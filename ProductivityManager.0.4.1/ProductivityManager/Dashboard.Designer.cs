namespace ProductivityManager
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.grpRecent = new System.Windows.Forms.GroupBox();
            this.lstActivity = new System.Windows.Forms.ListBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpRecent.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecent
            // 
            this.grpRecent.Controls.Add(this.lstActivity);
            this.grpRecent.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpRecent.Location = new System.Drawing.Point(342, 0);
            this.grpRecent.Name = "grpRecent";
            this.grpRecent.Size = new System.Drawing.Size(200, 330);
            this.grpRecent.TabIndex = 1;
            this.grpRecent.TabStop = false;
            this.grpRecent.Text = "Recent Sessions";
            // 
            // lstActivity
            // 
            this.lstActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstActivity.ItemHeight = 20;
            this.lstActivity.Location = new System.Drawing.Point(3, 22);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.Size = new System.Drawing.Size(194, 305);
            this.lstActivity.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.Controls.Add(this.pictureBox1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(342, 330);
            this.contentPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // navPanel
            // 
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.btnTasks);
            this.navPanel.Controls.Add(this.btnNotes);
            this.navPanel.Controls.Add(this.btnTimer);
            this.navPanel.Controls.Add(this.btnexit);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Padding = new System.Windows.Forms.Padding(5);
            this.navPanel.Size = new System.Drawing.Size(120, 330);
            this.navPanel.TabIndex = 0;
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(8, 8);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(100, 50);
            this.btnTasks.TabIndex = 0;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.Click += new System.EventHandler(this.btntasks_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(8, 64);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(100, 50);
            this.btnNotes.TabIndex = 1;
            this.btnNotes.Text = "Notes";
            this.btnNotes.Click += new System.EventHandler(this.btnnotes_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(8, 120);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(100, 50);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "Timer";
            this.btnTimer.Click += new System.EventHandler(this.btntimer_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(8, 176);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 50);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(0, 60);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.navPanel);
            this.splitMain.Panel1MinSize = 120;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.contentPanel);
            this.splitMain.Panel2.Controls.Add(this.grpRecent);
            this.splitMain.Size = new System.Drawing.Size(666, 330);
            this.splitMain.SplitterDistance = 120;
            this.splitMain.TabIndex = 0;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGreeting.Location = new System.Drawing.Point(8, 8);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(111, 38);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, !";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblDay);
            this.panelHeader.Controls.Add(this.lblGreeting);
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(666, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDay.Location = new System.Drawing.Point(465, 8);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(188, 38);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(1060, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(666, 390);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.grpRecent.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecent;
        private System.Windows.Forms.ListBox lstActivity;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel navPanel;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnexit;
    }
}
