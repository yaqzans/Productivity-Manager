using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class Timer : Form
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private string _connString = "Data Source=DESKTOP-VGTB6P9;Initial Catalog=Productivity;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int _currentUserId;

        public Timer(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
            this.Load += Timer_Load;
        }

        

        private void Timer_Load(object sender, EventArgs e)
        {
            LoadSessions();
            ResetButtons();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int hoursToSet = (int)nudHours.Value;
            int minutesToSet = (int)nudMinutes.Value;

            if (hoursToSet == 0 && minutesToSet == 0)
            {
                MessageBox.Show("Please set a duration first.");
                return;
            }

            _startTime = DateTime.Now;
            _endTime = _startTime.AddHours(hoursToSet).AddMinutes(minutesToSet);

            TimeSpan remainingTime = _endTime - DateTime.Now;
            lblCountdown.Text = FormatTime(remainingTime);

            countdownTimer.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            RecordSession();
            LoadSessions();
            ResetButtons();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            var remainingTime = _endTime - DateTime.Now;

            if (remainingTime <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                lblCountdown.Text = "00:00:00";
                MessageBox.Show("Time is up!");
                RecordSession();
                LoadSessions();
                ResetButtons();
            }
            else
            {
                lblCountdown.Text = FormatTime(remainingTime);
            }
        }

        private void ResetButtons()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private string FormatTime(TimeSpan timeSpan)
        {
            string formattedHours = ((int)timeSpan.TotalHours).ToString("D2");
            string formattedMinutes = timeSpan.Minutes.ToString("D2");
            string formattedSeconds = timeSpan.Seconds.ToString("D2");

            return formattedHours + ":" + formattedMinutes + ":" + formattedSeconds;
        }

        private void RecordSession()
        {
            var durationMinutes = (int)Math.Round((DateTime.Now - _startTime).TotalMinutes);

            if (durationMinutes < 1)
            {
                return;
            }

            string query = "INSERT INTO dbo.Sessions (StartAt, EndAt, DurationMin, UserID) VALUES ('" + _startTime.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + durationMinutes + "', " + _currentUserId + ")";

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to record the session. Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void LoadSessions()
        {
            lstSessions.Items.Clear();

            string query = "SELECT TOP 20 StartAt, EndAt, DurationMin FROM dbo.Sessions WHERE UserID = " + _currentUserId + " ORDER BY ID DESC";

            SqlConnection con = new SqlConnection(_connString);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable sessionsTable = new DataTable();

                con.Open();
                adapter.Fill(sessionsTable);

                foreach (DataRow row in sessionsTable.Rows)
                {
                    DateTime sessionStartTime = (DateTime)row["StartAt"];
                    DateTime sessionEndTime = (DateTime)row["EndAt"];
                    int sessionMinutes = (int)row["DurationMin"];

                    string displayString = sessionStartTime.ToString("dd/MM HH:mm") + " → " +
                                           sessionEndTime.ToString("HH:mm") + "  (" +
                                           sessionMinutes.ToString() + " min)";

                    lstSessions.Items.Add(displayString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load sessions. Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}