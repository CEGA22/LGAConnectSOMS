
namespace LGAConnectSOMS.Views
{
    partial class ClassScheduleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClassScheduleTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ClassDaysPanel = new System.Windows.Forms.Panel();
            this.lblEntireWeek = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClassSchedulePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ClassScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbCustomDays = new System.Windows.Forms.ComboBox();
            this.lblRepeatEvery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.cmbLastname = new System.Windows.Forms.ComboBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.cmbGradeLevels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddClassSchedule = new System.Windows.Forms.Button();
            this.labelGradeLevel = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblClassScheduleDetailsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.DragWindowsPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ClassDaysPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassScheduleDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.Controls.Add(this.btnMinimize);
            this.DragWindowsPanel.Controls.Add(this.btnMaximize);
            this.DragWindowsPanel.Controls.Add(this.btnClose);
            this.DragWindowsPanel.Controls.Add(this.btnBack);
            this.DragWindowsPanel.Controls.Add(this.panel1);
            this.DragWindowsPanel.Controls.Add(this.lblClassScheduleTitle);
            this.DragWindowsPanel.Location = new System.Drawing.Point(1, 1);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(1301, 105);
            this.DragWindowsPanel.TabIndex = 27;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(13, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 12;
            // 
            // lblClassScheduleTitle
            // 
            this.lblClassScheduleTitle.AutoSize = true;
            this.lblClassScheduleTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassScheduleTitle.Location = new System.Drawing.Point(69, 27);
            this.lblClassScheduleTitle.Name = "lblClassScheduleTitle";
            this.lblClassScheduleTitle.Size = new System.Drawing.Size(173, 31);
            this.lblClassScheduleTitle.TabIndex = 10;
            this.lblClassScheduleTitle.Text = "Class Schedule";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 543);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.ClassDaysPanel);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.ClassSchedulePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1268, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class Schedule";
            // 
            // ClassDaysPanel
            // 
            this.ClassDaysPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClassDaysPanel.BackColor = System.Drawing.Color.White;
            this.ClassDaysPanel.Controls.Add(this.lblEntireWeek);
            this.ClassDaysPanel.Controls.Add(this.lblSunday);
            this.ClassDaysPanel.Controls.Add(this.lblSaturday);
            this.ClassDaysPanel.Controls.Add(this.lblFriday);
            this.ClassDaysPanel.Controls.Add(this.lblThursday);
            this.ClassDaysPanel.Controls.Add(this.lblWednesday);
            this.ClassDaysPanel.Controls.Add(this.lblTuesday);
            this.ClassDaysPanel.Controls.Add(this.lblMonday);
            this.ClassDaysPanel.Controls.Add(this.Title);
            this.ClassDaysPanel.Location = new System.Drawing.Point(293, 59);
            this.ClassDaysPanel.Name = "ClassDaysPanel";
            this.ClassDaysPanel.Size = new System.Drawing.Size(710, 407);
            this.ClassDaysPanel.TabIndex = 30;
            // 
            // lblEntireWeek
            // 
            this.lblEntireWeek.AutoSize = true;
            this.lblEntireWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntireWeek.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntireWeek.Location = new System.Drawing.Point(13, 328);
            this.lblEntireWeek.Name = "lblEntireWeek";
            this.lblEntireWeek.Size = new System.Drawing.Size(103, 22);
            this.lblEntireWeek.TabIndex = 8;
            this.lblEntireWeek.Text = "Entire Week";
            this.lblEntireWeek.Click += new System.EventHandler(this.lblEntireWeek_Click);
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSunday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(13, 286);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(66, 22);
            this.lblSunday.TabIndex = 7;
            this.lblSunday.Text = "Sunday";
            this.lblSunday.Click += new System.EventHandler(this.lblSunday_Click);
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaturday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(13, 248);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(79, 22);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday";
            this.lblSaturday.Click += new System.EventHandler(this.lblSaturday_Click);
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFriday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(13, 210);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(58, 22);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday";
            this.lblFriday.Click += new System.EventHandler(this.lblFriday_Click);
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThursday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(13, 173);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(76, 22);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Thursday";
            this.lblThursday.Click += new System.EventHandler(this.lblThursday_Click);
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWednesday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(13, 133);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(103, 22);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday";
            this.lblWednesday.Click += new System.EventHandler(this.lblWednesday_Click);
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTuesday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(13, 92);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(72, 22);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday";
            this.lblTuesday.Click += new System.EventHandler(this.lblTuesday_Click);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(13, 53);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(73, 22);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday";
            this.lblMonday.Click += new System.EventHandler(this.lblMonday_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Title.Location = new System.Drawing.Point(13, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Class Days";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(293, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 38);
            this.panel2.TabIndex = 32;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // ClassSchedulePanel
            // 
            this.ClassSchedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClassSchedulePanel.AutoScroll = true;
            this.ClassSchedulePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassSchedulePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ClassSchedulePanel.Location = new System.Drawing.Point(293, 76);
            this.ClassSchedulePanel.Name = "ClassSchedulePanel";
            this.ClassSchedulePanel.Size = new System.Drawing.Size(736, 433);
            this.ClassSchedulePanel.TabIndex = 31;
            this.ClassSchedulePanel.WrapContents = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ClassScheduleDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1268, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List of Class Schedule";
            // 
            // ClassScheduleDataGridView
            // 
            this.ClassScheduleDataGridView.AllowUserToResizeColumns = false;
            this.ClassScheduleDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClassScheduleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassScheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassScheduleDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ClassScheduleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassScheduleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassScheduleDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassScheduleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassScheduleDataGridView.EnableHeadersVisualStyles = false;
            this.ClassScheduleDataGridView.Location = new System.Drawing.Point(-1, 69);
            this.ClassScheduleDataGridView.Name = "ClassScheduleDataGridView";
            this.ClassScheduleDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassScheduleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassScheduleDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassScheduleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClassScheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassScheduleDataGridView.Size = new System.Drawing.Size(1271, 446);
            this.ClassScheduleDataGridView.TabIndex = 27;
            this.ClassScheduleDataGridView.Click += new System.EventHandler(this.ClassScheduleDataGridView_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.cmbCustomDays);
            this.tabPage2.Controls.Add(this.lblRepeatEvery);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbSubjects);
            this.tabPage2.Controls.Add(this.cmbLastname);
            this.tabPage2.Controls.Add(this.cmbDays);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbEndTime);
            this.tabPage2.Controls.Add(this.cmbStartTime);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbSections);
            this.tabPage2.Controls.Add(this.cmbGradeLevels);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnAddClassSchedule);
            this.tabPage2.Controls.Add(this.labelGradeLevel);
            this.tabPage2.Controls.Add(this.lblLastname);
            this.tabPage2.Controls.Add(this.lblClassScheduleDetailsTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1268, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Schedule";
            // 
            // cmbCustomDays
            // 
            this.cmbCustomDays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCustomDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomDays.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomDays.FormattingEnabled = true;
            this.cmbCustomDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            "Cancel"});
            this.cmbCustomDays.Location = new System.Drawing.Point(836, 354);
            this.cmbCustomDays.Name = "cmbCustomDays";
            this.cmbCustomDays.Size = new System.Drawing.Size(216, 27);
            this.cmbCustomDays.TabIndex = 61;
            this.cmbCustomDays.TabStop = false;
            this.cmbCustomDays.SelectedIndexChanged += new System.EventHandler(this.cmbCustomDays_SelectedIndexChanged);
            // 
            // lblRepeatEvery
            // 
            this.lblRepeatEvery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRepeatEvery.AutoSize = true;
            this.lblRepeatEvery.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatEvery.Location = new System.Drawing.Point(722, 357);
            this.lblRepeatEvery.Name = "lblRepeatEvery";
            this.lblRepeatEvery.Size = new System.Drawing.Size(103, 19);
            this.lblRepeatEvery.TabIndex = 60;
            this.lblRepeatEvery.Text = "Repeat every: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Subject: ";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(508, 234);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(233, 27);
            this.cmbSubjects.TabIndex = 57;
            this.cmbSubjects.TabStop = false;
            // 
            // cmbLastname
            // 
            this.cmbLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLastname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLastname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLastname.FormattingEnabled = true;
            this.cmbLastname.Location = new System.Drawing.Point(508, 69);
            this.cmbLastname.Name = "cmbLastname";
            this.cmbLastname.Size = new System.Drawing.Size(233, 27);
            this.cmbLastname.TabIndex = 56;
            this.cmbLastname.TabStop = false;
            this.cmbLastname.SelectedIndexChanged += new System.EventHandler(this.cmbLastname_SelectedIndexChanged);
            // 
            // cmbDays
            // 
            this.cmbDays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDays.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "Every Weekday (Mon - Fri)",
            "Custom"});
            this.cmbDays.Location = new System.Drawing.Point(508, 354);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(194, 27);
            this.cmbDays.TabIndex = 55;
            this.cmbDays.TabStop = false;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Days:";
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndTime.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Items.AddRange(new object[] {
            "6:00 am",
            "6:30 am",
            "7:00 am",
            "7:30 am",
            "8:00 am",
            "8:30 am",
            "9:00 am",
            "9:30 am",
            "10:00 am",
            "10:30 am",
            "11:00 am",
            "11:30 am",
            "12:00 pm",
            "12:30pm",
            "1:00 pm",
            "1:30 pm",
            "2:00 pm",
            "2:30 pm",
            "3:00 pm",
            "3:00 pm",
            "4:00 pm",
            "4:30 pm",
            "5:00 pm",
            "5:30 pm",
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm",
            "8:00 pm",
            "8:30 pm",
            "9:00 pm",
            "9:30 pm",
            "10:00 pm",
            "10:30 pm",
            "11:00 pm",
            "11:30 pm"});
            this.cmbEndTime.Location = new System.Drawing.Point(664, 295);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(113, 27);
            this.cmbEndTime.TabIndex = 53;
            this.cmbEndTime.TabStop = false;
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartTime.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Items.AddRange(new object[] {
            "6:00 am",
            "6:30 am",
            "7:00 am",
            "7:30 am",
            "8:00 am",
            "8:30 am",
            "9:00 am",
            "9:30 am",
            "10:00 am",
            "10:30 am",
            "11:00 am",
            "11:30 am",
            "12:00 pm",
            "12:30pm",
            "1:00 pm",
            "1:30 pm",
            "2:00 pm",
            "2:30 pm",
            "3:00 pm",
            "3:00 pm",
            "4:00 pm",
            "4:30 pm",
            "5:00 pm",
            "5:30 pm",
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm",
            "8:00 pm",
            "8:30 pm",
            "9:00 pm",
            "9:30 pm",
            "10:00 pm",
            "10:30 pm",
            "11:00 pm",
            "11:30 pm"});
            this.cmbStartTime.Location = new System.Drawing.Point(508, 295);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(113, 27);
            this.cmbStartTime.TabIndex = 52;
            this.cmbStartTime.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Time: ";
            // 
            // cmbSections
            // 
            this.cmbSections.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSections.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(508, 177);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(233, 27);
            this.cmbSections.TabIndex = 47;
            this.cmbSections.TabStop = false;
            // 
            // cmbGradeLevels
            // 
            this.cmbGradeLevels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbGradeLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevels.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevels.FormattingEnabled = true;
            this.cmbGradeLevels.Location = new System.Drawing.Point(508, 123);
            this.cmbGradeLevels.Name = "cmbGradeLevels";
            this.cmbGradeLevels.Size = new System.Drawing.Size(233, 27);
            this.cmbGradeLevels.TabIndex = 46;
            this.cmbGradeLevels.TabStop = false;
            this.cmbGradeLevels.SelectedIndexChanged += new System.EventHandler(this.cmbGradeLevels_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Section: ";
            // 
            // btnAddClassSchedule
            // 
            this.btnAddClassSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddClassSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.btnAddClassSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClassSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClassSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnAddClassSchedule.Location = new System.Drawing.Point(508, 418);
            this.btnAddClassSchedule.Name = "btnAddClassSchedule";
            this.btnAddClassSchedule.Size = new System.Drawing.Size(269, 41);
            this.btnAddClassSchedule.TabIndex = 11;
            this.btnAddClassSchedule.Text = "Save";
            this.btnAddClassSchedule.UseVisualStyleBackColor = false;
            this.btnAddClassSchedule.Click += new System.EventHandler(this.btnAddClassSchedule_Click);
            // 
            // labelGradeLevel
            // 
            this.labelGradeLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGradeLevel.AutoSize = true;
            this.labelGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeLevel.Location = new System.Drawing.Point(322, 131);
            this.labelGradeLevel.Name = "labelGradeLevel";
            this.labelGradeLevel.Size = new System.Drawing.Size(96, 19);
            this.labelGradeLevel.TabIndex = 5;
            this.labelGradeLevel.Text = "Grade Level: ";
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(322, 69);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(63, 19);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Teacher:";
            // 
            // lblClassScheduleDetailsTitle
            // 
            this.lblClassScheduleDetailsTitle.AutoSize = true;
            this.lblClassScheduleDetailsTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassScheduleDetailsTitle.Location = new System.Drawing.Point(21, 14);
            this.lblClassScheduleDetailsTitle.Name = "lblClassScheduleDetailsTitle";
            this.lblClassScheduleDetailsTitle.Size = new System.Drawing.Size(253, 31);
            this.lblClassScheduleDetailsTitle.TabIndex = 0;
            this.lblClassScheduleDetailsTitle.Text = "Class Schedule Details";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::LGAConnectSOMS.Properties.Resources.dropdown16;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(325, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entire Week";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LGAConnectSOMS.Properties.Resources.MinimizeBlack1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1208, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 34);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(1238, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 34);
            this.btnMaximize.TabIndex = 21;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1268, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 34);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::LGAConnectSOMS.Properties.Resources.BackArrow24;
            this.btnBack.Location = new System.Drawing.Point(25, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // ClassScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DragWindowsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassScheduleView";
            this.Text = "ClassScheduleView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassScheduleView_FormClosing);
            this.Load += new System.EventHandler(this.ClassScheduleView_Load);
            this.Click += new System.EventHandler(this.ClassScheduleView_Click);
            this.DragWindowsPanel.ResumeLayout(false);
            this.DragWindowsPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ClassDaysPanel.ResumeLayout(false);
            this.ClassDaysPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassScheduleDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClassScheduleTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel ClassDaysPanel;
        private System.Windows.Forms.Label lblEntireWeek;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ClassSchedulePanel;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ComboBox cmbSections;
        public System.Windows.Forms.ComboBox cmbGradeLevels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddClassSchedule;
        private System.Windows.Forms.Label labelGradeLevel;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblClassScheduleDetailsTitle;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView ClassScheduleDataGridView;
        public System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbEndTime;
        public System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbSubjects;
        public System.Windows.Forms.ComboBox cmbLastname;
        public System.Windows.Forms.ComboBox cmbCustomDays;
        private System.Windows.Forms.Label lblRepeatEvery;
    }
}