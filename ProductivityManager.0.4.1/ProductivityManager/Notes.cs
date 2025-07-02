using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class Notes : Form
    {
        private string _connString = "Data Source=DESKTOP-VGTB6P9;Initial Catalog=Productivity;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int _selectedNoteId = -1;
        private int _currentUserId;

        public Notes(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
            this.Load += Notes_Load;
        }

       

        private void Notes_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void ClearDetails()
        {
            txtNoteTitle.Text = "";
            rtbNoteContent.Clear();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            lstNotes.ClearSelected();
            _selectedNoteId = -1;
            ClearDetails();
            txtNoteTitle.Focus();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            tstbSearch.Text = "";
            LoadNotes();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            LoadNotes(tstbSearch.Text);
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }

        private void LoadNotes(string searchTerm = null)
        {
            DataTable dt = new DataTable();
            string query;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {

                query = "SELECT ID, Title FROM dbo.Notes WHERE UserID = " + _currentUserId + " ORDER BY CreatedAt DESC";
            }
            else
            {

                query = "SELECT ID, Title FROM dbo.Notes WHERE UserID = " + _currentUserId + " AND (Title LIKE '%" + searchTerm + "%' OR Description LIKE '%" + searchTerm + "%') ORDER BY CreatedAt DESC";
            }

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                lstNotes.DataSource = dt;
                lstNotes.DisplayMember = "Title";
                lstNotes.ValueMember = "ID";
                lstNotes.ClearSelected();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notes: " + ex.Message);
            }
            finally
            {
                _selectedNoteId = -1;
                ClearDetails();
            }
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem == null)
            {
                ClearDetails();
                _selectedNoteId = -1;
                return;
            }

            DataRowView selectedRowView = (DataRowView)lstNotes.SelectedItem;
            _selectedNoteId = Convert.ToInt32(selectedRowView["ID"]);

            string query = "SELECT Title, Description FROM dbo.Notes WHERE ID = " + _selectedNoteId + " AND UserID = " + _currentUserId;

            DataTable noteDetailsTable = new DataTable();
            SqlConnection con = new SqlConnection(_connString);

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(noteDetailsTable);

                if (noteDetailsTable.Rows.Count > 0)
                {
                    DataRow row = noteDetailsTable.Rows[0];
                    txtNoteTitle.Text = row["Title"].ToString();
                    if (row["Description"] == DBNull.Value)
                    {
                        rtbNoteContent.Text = "";
                    }
                    else
                    {
                        rtbNoteContent.Text = row["Description"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading note details: " + ex.Message);
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string title = txtNoteTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            string description = rtbNoteContent.Text.Trim();

            string query;
            if (_selectedNoteId < 0)
            {

                query = "INSERT INTO dbo.Notes (Title, Description, CreatedAt, ModifiedAt, UserID) VALUES ('" + title + "', '" + description + "', GETDATE(), GETDATE(), " + _currentUserId + ")";
            }
            else
            {

                query = "UPDATE dbo.Notes SET Title = '" + title + "', Description = '" + description + "', ModifiedAt = GETDATE() WHERE ID = " + _selectedNoteId + " AND UserID = " + _currentUserId;
            }

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving note: " + ex.Message);
            }
            finally
            {
                con.Close();
                LoadNotes(tstbSearch.Text.Trim());
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (_selectedNoteId < 0)
            {
                MessageBox.Show("Select a note first.");
                return;
            }

            DialogResult result = MessageBox.Show("Delete this note?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                string query = "DELETE FROM dbo.Notes WHERE ID = " + _selectedNoteId + " AND UserID = " + _currentUserId;

                SqlConnection con = new SqlConnection(_connString);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting note: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadNotes(tstbSearch.Text.Trim());
                }
            }
        }
    }
}