using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class login : Form
    {
        private string _connString = "Data Source=DESKTOP-VGTB6P9;Initial Catalog=Productivity;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }

            SqlConnection con = new SqlConnection(_connString);
            try
            {

                string query = "SELECT ID, name FROM userInfo WHERE name = '" + email + "' AND pass = '" + password + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable loginTable = new DataTable();

                con.Open();
                adapter.Fill(loginTable);

                if (loginTable.Rows.Count > 0)
                {
                    DataRow row = loginTable.Rows[0];
                    int userId = Convert.ToInt32(row["ID"]);
                    string userName = row["name"].ToString();

                    OpenDashboard(userName, userId);
                }
                else
                {
                    MessageBox.Show("Invalid name or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) AS UserCount FROM userInfo WHERE email = '" + email + "'";
                SqlDataAdapter checkAdapter = new SqlDataAdapter(checkQuery, con);
                DataTable checkTable = new DataTable();
                checkAdapter.Fill(checkTable);

                int count = 0;
                if (checkTable.Rows.Count > 0)
                {
                    count = Convert.ToInt32(checkTable.Rows[0]["UserCount"]);
                }

                if (count > 0)
                {
                    MessageBox.Show("Email is already registered.");
                    return;
                }

                string insertQuery = "INSERT INTO userInfo (name, email, pass) VALUES ('" + name + "', '" + email + "', '" + password + "')";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                int rows = insertCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Signup successful! You can now log in.");
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Signup failed. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Signup failed: " + ex.Message);
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

        }

        private void OpenDashboard(string userName, int userId)
        {
            Dashboard dashboard = new Dashboard(userName, userId);
            dashboard.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}