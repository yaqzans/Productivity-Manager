using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class Dashboard : Form
    {
        private string _connString = "Data Source=DESKTOP-VGTB6P9;Initial Catalog=Productivity;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private string _userName;
        private int _currentUserId;

        public Dashboard(string userName, int userId)
        {
            InitializeComponent();
            _userName = userName;
            _currentUserId = userId;
        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello, " + _userName.Trim() + "!";
            lblDay.Text = "Date: " + DateTime.Now.ToString("dd MMMM,yyyy");

            LoadRecentActivity();
        }

        private void LoadRecentActivity()
        {
            DataTable sessionsTable = new DataTable();

            string query = "SELECT TOP 5 CONCAT(FORMAT(StartAt, 'dd/MM HH:mm'), ' (', DurationMin, 'm)') AS Description FROM dbo.Sessions WHERE UserID = " + _currentUserId + " ORDER BY ID DESC";

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(sessionsTable);

                lstActivity.DisplayMember = "Description";
                lstActivity.DataSource = sessionsTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load recent activity. Error: " + ex.Message);
            }
        }

        private void btntasks_Click(object sender, EventArgs e)
        {

            new Tasks(_currentUserId).Show(this);
            this.Hide();
        }

        private void btnnotes_Click(object sender, EventArgs e)
        {

            new Notes(_currentUserId).Show(this);
            this.Hide();
        }

        private void btntimer_Click(object sender, EventArgs e)
        {

            new Timer(_currentUserId).Show(this);
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}