using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class Tasks : Form
    {
        private string _connString = "Data Source=DESKTOP-VGTB6P9;Initial Catalog=Productivity;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int _selectedTaskId = -1;
        private int _currentUserId;

        public Tasks(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
            this.Load += Tasks_Load;
        }

        

        private void Tasks_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void ClearDetails()
        {
            txtTitle.Text = "";
            dtpDueDate.Value = DateTime.Today;
            cmbLabel.SelectedIndex = -1;
            numProgress.Value = 0;
            progressBar.Value = 0;
            rtbDescription.Clear();
            chkIsDone.Checked = false;

            if (cmbParent.Items.Count > 0) cmbParent.SelectedIndex = 0;
            if (cmbPriority.Items.Count > 0) cmbPriority.SelectedIndex = 0;
        }

        private void tsbbtnnew_Click(object sender, EventArgs e)
        {
            lstTasks.ClearSelected();
            _selectedTaskId = -1;
            ClearDetails();
        }

        private void tsbtnback_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }

        private void tsbrefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void tsbShowCompleted_Click(object sender, EventArgs e)
        {

            FilterTasks("IsDone = 1");
        }
        private void tsbhigh_Click(object sender, EventArgs e)
        {

            FilterTasks("Priority = 3");
        }
        private void tshmedium_Click(object sender, EventArgs e)
        {

            FilterTasks("Priority = 2");
        }
        private void tsblow_Click(object sender, EventArgs e)
        {

            FilterTasks("Priority = 1");
        }
        private void tsbhome_Click(object sender, EventArgs e)
        {

            FilterTasks("CATEGORY = 'Personal'");
        }
        private void tsbwork_Click(object sender, EventArgs e)
        {

            FilterTasks("CATEGORY = 'Work'");
        }
        private void tsburgent_Click(object sender, EventArgs e)
        {

            FilterTasks("CATEGORY = 'Urgent'");
        }

        private void LoadTasks()
        {
            DataTable tasksTable = new DataTable();

            string query = "SELECT ID, TITLE FROM themain WHERE UserID = " + _currentUserId + " ORDER BY TITLE";
            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(tasksTable);

                lstTasks.DataSource = tasksTable;
                lstTasks.DisplayMember = "TITLE";
                lstTasks.ValueMember = "ID";
                lstTasks.ClearSelected();

                PopulateParentTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
            finally
            {
                con.Close();
                _selectedTaskId = -1;
                ClearDetails();
            }
        }

        private void PopulateParentTasks()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();

                string query = "SELECT ID, TITLE FROM themain WHERE UserID = " + _currentUserId;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);

                DataRow noneRow = dt.NewRow();
                noneRow["ID"] = DBNull.Value;
                noneRow["TITLE"] = "(None)";
                dt.Rows.InsertAt(noneRow, 0);

                cmbParent.DisplayMember = "TITLE";
                cmbParent.ValueMember = "ID";
                cmbParent.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null) return;

            DataRowView selectedRow = (DataRowView)lstTasks.SelectedItem;
            _selectedTaskId = Convert.ToInt32(selectedRow["ID"]);

            string query = "SELECT TITLE, DUEDATE, CATEGORY, PROGRESS, DESCRIPTION, IsDone, ParentID, Priority FROM themain WHERE ID = " + _selectedTaskId + " AND UserID = " + _currentUserId;

            DataTable taskTable = new DataTable();

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(taskTable);

                if (taskTable.Rows.Count > 0)
                {
                    DataRow row = taskTable.Rows[0];

                    txtTitle.Text = row["TITLE"].ToString();
                    dtpDueDate.Value = (DateTime)row["DUEDATE"];
                    cmbLabel.Text = row["CATEGORY"].ToString();
                    numProgress.Value = (decimal)row["PROGRESS"];

                    if (row["DESCRIPTION"] == DBNull.Value)
                    {
                        rtbDescription.Text = "";
                    }
                    else
                    {
                        rtbDescription.Text = row["DESCRIPTION"].ToString();
                    }

                    chkIsDone.Checked = (bool)row["IsDone"];

                    if (row["ParentID"] == DBNull.Value)
                    {
                        cmbParent.SelectedValue = DBNull.Value;
                    }
                    else
                    {
                        cmbParent.SelectedValue = (int)row["ParentID"];
                    }

                    cmbPriority.SelectedIndex = (int)row["Priority"] - 1;
                    progressBar.Value = Convert.ToInt32(numProgress.Value);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting task details: " + ex.Message);
            }
        }

        private void tsbbtnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            string title = txtTitle.Text.Trim();
            DateTime due = dtpDueDate.Value;
            string cat = cmbLabel.Text;
            decimal prog = numProgress.Value;
            string desc = rtbDescription.Text;
            int pri = cmbPriority.SelectedIndex + 1;

            int done;
            if (chkIsDone.Checked == true)
            {
                done = 1;
            }
            else
            {
                done = 0;
            }

            string pidString;
            if (cmbParent.SelectedValue == null || cmbParent.SelectedValue == DBNull.Value)
            {
                pidString = "NULL";
            }
            else
            {
                pidString = cmbParent.SelectedValue.ToString();
            }

            string query;
            if (_selectedTaskId < 0)
            {

                query = "INSERT INTO themain (TITLE, DUEDATE, CATEGORY, PROGRESS, DESCRIPTION, IsDone, ParentID, Priority, UserID) VALUES ('" + title + "', '" + due.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + cat + "', " + prog + ", '" + desc + "', " + done + ", " + pidString + ", " + pri + ", " + _currentUserId + ")";
            }
            else
            {

                query = "UPDATE themain SET TITLE='" + title + "', DUEDATE='" + due.ToString("yyyy-MM-dd HH:mm:ss") + "', CATEGORY='" + cat + "', PROGRESS=" + prog + ", DESCRIPTION='" + desc + "', IsDone=" + done + ", ParentID=" + pidString + ", Priority=" + pri + " WHERE ID=" + _selectedTaskId + " AND UserID = " + _currentUserId;
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
                MessageBox.Show("Error saving task: " + ex.Message);
            }
            finally
            {
                con.Close();
                LoadTasks();
            }
        }

        private void tsbdelete_Click(object sender, EventArgs e)
        {
            if (_selectedTaskId < 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }
            DialogResult result = MessageBox.Show("Delete this task?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                string query = "DELETE FROM themain WHERE ID = " + _selectedTaskId + " AND UserID = " + _currentUserId;
                SqlConnection con = new SqlConnection(_connString);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting task: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadTasks();
                }
            }
        }

        private void FilterTasks(string clause)
        {
            DataTable dt = new DataTable();

            string query = $"SELECT ID, TITLE FROM themain WHERE {clause} AND UserID = " + _currentUserId + " ORDER BY TITLE";
            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                lstTasks.DataSource = dt;
                lstTasks.DisplayMember = "TITLE";
                lstTasks.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering tasks: " + ex.Message);
            }
            finally
            {
                con.Close();
                _selectedTaskId = -1;
                ClearDetails();
            }
        }
    }
}