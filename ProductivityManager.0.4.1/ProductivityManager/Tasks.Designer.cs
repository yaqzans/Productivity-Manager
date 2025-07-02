namespace ProductivityManager
{
    partial class Tasks
    {
        private System.ComponentModel.IContainer components = null;

        // ToolStrip & buttons
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbbtnnew;
        private System.Windows.Forms.ToolStripButton tsbbtnsave;
        private System.Windows.Forms.ToolStripButton tsbdelete;
        private System.Windows.Forms.ToolStripButton tsbrefresh;
        private System.Windows.Forms.ToolStripButton tsbtnback;

        // Left‐hand list
        private System.Windows.Forms.ListBox lstTasks;

        // Detail panel & layout
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        // Row 0: Title
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        // Row 1: Due Date
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        // Row 2: Category
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.ComboBox cmbLabel;
        // Row 3: Progress (numeric)
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.NumericUpDown numProgress;
        // Row 4: Progress (bar)
        private System.Windows.Forms.ProgressBar progressBar;
        // Row 5: Description
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        // Row 6: IsDone
        private System.Windows.Forms.CheckBox chkIsDone;
        // Row 7: Parent
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox cmbParent;
        // Row 8: Priority
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbbtnnew = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnsave = new System.Windows.Forms.ToolStripButton();
            this.tsbdelete = new System.Windows.Forms.ToolStripButton();
            this.tsbrefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnback = new System.Windows.Forms.ToolStripButton();
            this.tsbShowCompleted = new System.Windows.Forms.ToolStripButton();
            this.tsbPriority = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbhigh = new System.Windows.Forms.ToolStripMenuItem();
            this.tshmedium = new System.Windows.Forms.ToolStripMenuItem();
            this.tsblow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbcategory = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbhome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbwork = new System.Windows.Forms.ToolStripMenuItem();
            this.tsburgent = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblLabel = new System.Windows.Forms.Label();
            this.cmbLabel = new System.Windows.Forms.ComboBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.numProgress = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.chkIsDone = new System.Windows.Forms.CheckBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbtnnew,
            this.tsbbtnsave,
            this.tsbdelete,
            this.tsbrefresh,
            this.tsbtnback,
            this.tsbShowCompleted,
            this.tsbPriority,
            this.tsbcategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 2;
            // 
            // tsbbtnnew
            // 
            this.tsbbtnnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbbtnnew.Name = "tsbbtnnew";
            this.tsbbtnnew.Size = new System.Drawing.Size(51, 29);
            this.tsbbtnnew.Text = "New";
            this.tsbbtnnew.Click += new System.EventHandler(this.tsbbtnnew_Click);
            // 
            // tsbbtnsave
            // 
            this.tsbbtnsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbbtnsave.Name = "tsbbtnsave";
            this.tsbbtnsave.Size = new System.Drawing.Size(53, 29);
            this.tsbbtnsave.Text = "Save";
            this.tsbbtnsave.Click += new System.EventHandler(this.tsbbtnsave_Click);
            // 
            // tsbdelete
            // 
            this.tsbdelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbdelete.Name = "tsbdelete";
            this.tsbdelete.Size = new System.Drawing.Size(66, 29);
            this.tsbdelete.Text = "Delete";
            this.tsbdelete.Click += new System.EventHandler(this.tsbdelete_Click);
            // 
            // tsbrefresh
            // 
            this.tsbrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbrefresh.Name = "tsbrefresh";
            this.tsbrefresh.Size = new System.Drawing.Size(74, 29);
            this.tsbrefresh.Text = "Refresh";
            this.tsbrefresh.Click += new System.EventHandler(this.tsbrefresh_Click);
            // 
            // tsbtnback
            // 
            this.tsbtnback.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnback.Name = "tsbtnback";
            this.tsbtnback.Size = new System.Drawing.Size(52, 29);
            this.tsbtnback.Text = "Back";
            this.tsbtnback.Click += new System.EventHandler(this.tsbtnback_Click);
            // 
            // tsbShowCompleted
            // 
            this.tsbShowCompleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbShowCompleted.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowCompleted.Image")));
            this.tsbShowCompleted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowCompleted.Name = "tsbShowCompleted";
            this.tsbShowCompleted.Size = new System.Drawing.Size(109, 29);
            this.tsbShowCompleted.Text = "Completion";
            this.tsbShowCompleted.ToolTipText = "Completion";
            this.tsbShowCompleted.Click += new System.EventHandler(this.tsbShowCompleted_Click);
            // 
            // tsbPriority
            // 
            this.tsbPriority.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPriority.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbhigh,
            this.tshmedium,
            this.tsblow});
            this.tsbPriority.Image = ((System.Drawing.Image)(resources.GetObject("tsbPriority.Image")));
            this.tsbPriority.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPriority.Name = "tsbPriority";
            this.tsbPriority.Size = new System.Drawing.Size(86, 29);
            this.tsbPriority.Text = "Priority";
            // 
            // tsbhigh
            // 
            this.tsbhigh.Name = "tsbhigh";
            this.tsbhigh.Size = new System.Drawing.Size(180, 34);
            this.tsbhigh.Text = "High";
            this.tsbhigh.Click += new System.EventHandler(this.tsbhigh_Click);
            // 
            // tshmedium
            // 
            this.tshmedium.Name = "tshmedium";
            this.tshmedium.Size = new System.Drawing.Size(180, 34);
            this.tshmedium.Text = "Medium";
            this.tshmedium.Click += new System.EventHandler(this.tshmedium_Click);
            // 
            // tsblow
            // 
            this.tsblow.Name = "tsblow";
            this.tsblow.Size = new System.Drawing.Size(180, 34);
            this.tsblow.Text = "Low";
            this.tsblow.Click += new System.EventHandler(this.tsblow_Click);
            // 
            // tsbcategory
            // 
            this.tsbcategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbcategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbhome,
            this.tsbwork,
            this.tsburgent});
            this.tsbcategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbcategory.Image")));
            this.tsbcategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbcategory.Name = "tsbcategory";
            this.tsbcategory.Size = new System.Drawing.Size(102, 29);
            this.tsbcategory.Text = "Category";
            // 
            // tsbhome
            // 
            this.tsbhome.Name = "tsbhome";
            this.tsbhome.Size = new System.Drawing.Size(180, 34);
            this.tsbhome.Text = "Personal";
            this.tsbhome.Click += new System.EventHandler(this.tsbhome_Click);
            // 
            // tsbwork
            // 
            this.tsbwork.Name = "tsbwork";
            this.tsbwork.Size = new System.Drawing.Size(180, 34);
            this.tsbwork.Text = "Work";
            this.tsbwork.Click += new System.EventHandler(this.tsbwork_Click);
            // 
            // tsburgent
            // 
            this.tsburgent.Name = "tsburgent";
            this.tsburgent.Size = new System.Drawing.Size(180, 34);
            this.tsburgent.Text = "Urgent";
            this.tsburgent.Click += new System.EventHandler(this.tsburgent_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 20;
            this.lstTasks.Location = new System.Drawing.Point(0, 34);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(200, 401);
            this.lstTasks.TabIndex = 1;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.lstTasks_SelectedIndexChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.tableLayoutPanel1);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(200, 34);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(600, 401);
            this.panelDetails.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDueDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDueDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProgress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numProgress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkIsDone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblParent, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbParent, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblPriority, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbPriority, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 395);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(135, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(183, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(414, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(95, 50);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(82, 20);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDueDate.Location = new System.Drawing.Point(183, 43);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(414, 26);
            this.dtpDueDate.TabIndex = 3;
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(100, 90);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(77, 20);
            this.lblLabel.TabIndex = 4;
            this.lblLabel.Text = "Category:";
            // 
            // cmbLabel
            // 
            this.cmbLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLabel.Items.AddRange(new object[] {
            "Work",
            "Personal",
            "Urgent"});
            this.cmbLabel.Location = new System.Drawing.Point(183, 83);
            this.cmbLabel.Name = "cmbLabel";
            this.cmbLabel.Size = new System.Drawing.Size(414, 28);
            this.cmbLabel.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(101, 130);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(76, 20);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Progress:";
            // 
            // numProgress
            // 
            this.numProgress.DecimalPlaces = 2;
            this.numProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numProgress.Location = new System.Drawing.Point(183, 123);
            this.numProgress.Name = "numProgress";
            this.numProgress.Size = new System.Drawing.Size(414, 26);
            this.numProgress.TabIndex = 7;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(183, 163);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(414, 34);
            this.progressBar.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(84, 230);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Location = new System.Drawing.Point(183, 203);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(414, 74);
            this.rtbDescription.TabIndex = 10;
            this.rtbDescription.Text = "";
            // 
            // chkIsDone
            // 
            this.chkIsDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIsDone.AutoSize = true;
            this.chkIsDone.Location = new System.Drawing.Point(183, 288);
            this.chkIsDone.Name = "chkIsDone";
            this.chkIsDone.Size = new System.Drawing.Size(74, 24);
            this.chkIsDone.TabIndex = 11;
            this.chkIsDone.Text = "Done";
            // 
            // lblParent
            // 
            this.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(117, 329);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(60, 20);
            this.lblParent.TabIndex = 12;
            this.lblParent.Text = "Parent:";
            // 
            // cmbParent
            // 
            this.cmbParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbParent.Location = new System.Drawing.Point(183, 323);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(414, 28);
            this.cmbParent.TabIndex = 13;
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(117, 369);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(60, 20);
            this.lblPriority.TabIndex = 14;
            this.lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbPriority.Location = new System.Drawing.Point(183, 361);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(414, 28);
            this.cmbPriority.TabIndex = 15;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripButton tsbShowCompleted;
        private System.Windows.Forms.ToolStripDropDownButton tsbPriority;
        private System.Windows.Forms.ToolStripMenuItem tsbhigh;
        private System.Windows.Forms.ToolStripMenuItem tshmedium;
        private System.Windows.Forms.ToolStripMenuItem tsblow;
        private System.Windows.Forms.ToolStripDropDownButton tsbcategory;
        private System.Windows.Forms.ToolStripMenuItem tsbhome;
        private System.Windows.Forms.ToolStripMenuItem tsbwork;
        private System.Windows.Forms.ToolStripMenuItem tsburgent;
    }
}
