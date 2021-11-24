
namespace LGAConnectSOMS.Views
{
    partial class ClassRecordFacultyView
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClassRecordAdminTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FirstGradingGradebook = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CBSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.CBGradeLevel = new System.Windows.Forms.ComboBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WW9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WWTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WWPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterlyGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DragWindowsPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstGradingGradebook)).BeginInit();
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
            this.DragWindowsPanel.Controls.Add(this.lblClassRecordAdminTitle);
            this.DragWindowsPanel.Location = new System.Drawing.Point(1, 1);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(1301, 105);
            this.DragWindowsPanel.TabIndex = 27;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LGAConnectSOMS.Properties.Resources.MinimizeBlack1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1208, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(1238, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
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
            this.btnClose.Location = new System.Drawing.Point(1268, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
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
            // lblClassRecordAdminTitle
            // 
            this.lblClassRecordAdminTitle.AutoSize = true;
            this.lblClassRecordAdminTitle.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRecordAdminTitle.Location = new System.Drawing.Point(75, 25);
            this.lblClassRecordAdminTitle.Name = "lblClassRecordAdminTitle";
            this.lblClassRecordAdminTitle.Size = new System.Drawing.Size(175, 34);
            this.lblClassRecordAdminTitle.TabIndex = 10;
            this.lblClassRecordAdminTitle.Text = "Class Records";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 502);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.FirstGradingGradebook);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1268, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First Grading";
            // 
            // FirstGradingGradebook
            // 
            this.FirstGradingGradebook.AllowUserToResizeColumns = false;
            this.FirstGradingGradebook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.FirstGradingGradebook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FirstGradingGradebook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstGradingGradebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FirstGradingGradebook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FirstGradingGradebook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstGradingGradebook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FirstGradingGradebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstGradingGradebook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.WW,
            this.WW1,
            this.WW2,
            this.WW3,
            this.WW4,
            this.WW5,
            this.WW6,
            this.WW7,
            this.WW8,
            this.WW9,
            this.WWTotal,
            this.WWPercentage,
            this.TP,
            this.TP1,
            this.TP2,
            this.TP3,
            this.TP4,
            this.TP5,
            this.TP6,
            this.TP7,
            this.TP8,
            this.TP9,
            this.TPTotal,
            this.TPPercentage,
            this.InitialGrade,
            this.QuarterlyGrade});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstGradingGradebook.DefaultCellStyle = dataGridViewCellStyle3;
            this.FirstGradingGradebook.EnableHeadersVisualStyles = false;
            this.FirstGradingGradebook.Location = new System.Drawing.Point(0, 0);
            this.FirstGradingGradebook.Name = "FirstGradingGradebook";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstGradingGradebook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FirstGradingGradebook.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstGradingGradebook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FirstGradingGradebook.Size = new System.Drawing.Size(1268, 474);
            this.FirstGradingGradebook.TabIndex = 26;
            this.FirstGradingGradebook.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.FirstGradingGradebook_CellEndEdit);
            this.FirstGradingGradebook.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.FirstGradingGradebook_EditingControlShowing);
            this.FirstGradingGradebook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstGradingGradebook_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1268, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Second Grading";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1268, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Third Grading";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1268, 470);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fourth Grading";
            // 
            // CBSection
            // 
            this.CBSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBSection.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSection.FormattingEnabled = true;
            this.CBSection.ItemHeight = 22;
            this.CBSection.Location = new System.Drawing.Point(399, 134);
            this.CBSection.Name = "CBSection";
            this.CBSection.Size = new System.Drawing.Size(218, 30);
            this.CBSection.TabIndex = 40;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(338, 137);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(61, 19);
            this.lblSection.TabIndex = 39;
            this.lblSection.Text = "Section: ";
            // 
            // CBGradeLevel
            // 
            this.CBGradeLevel.DropDownHeight = 200;
            this.CBGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGradeLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGradeLevel.ForeColor = System.Drawing.Color.Black;
            this.CBGradeLevel.FormattingEnabled = true;
            this.CBGradeLevel.IntegralHeight = false;
            this.CBGradeLevel.ItemHeight = 22;
            this.CBGradeLevel.Location = new System.Drawing.Point(114, 134);
            this.CBGradeLevel.Name = "CBGradeLevel";
            this.CBGradeLevel.Size = new System.Drawing.Size(218, 30);
            this.CBGradeLevel.TabIndex = 38;
            this.CBGradeLevel.TabStop = false;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(18, 137);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(96, 19);
            this.lblGradeLevel.TabIndex = 37;
            this.lblGradeLevel.Text = "Grade Level: ";
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentName.HeaderText = "Learner\'s Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 133;
            // 
            // WW
            // 
            this.WW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW.HeaderText = "WW #1";
            this.WW.Name = "WW";
            this.WW.ToolTipText = "Written Work 1";
            this.WW.Width = 90;
            // 
            // WW1
            // 
            this.WW1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW1.HeaderText = "WW #2";
            this.WW1.Name = "WW1";
            this.WW1.ToolTipText = "Written Work 2";
            this.WW1.Width = 90;
            // 
            // WW2
            // 
            this.WW2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW2.HeaderText = "WW #3";
            this.WW2.Name = "WW2";
            this.WW2.ToolTipText = "Written Work 3";
            this.WW2.Width = 90;
            // 
            // WW3
            // 
            this.WW3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW3.HeaderText = "WW #4";
            this.WW3.Name = "WW3";
            this.WW3.ToolTipText = "Written Work 4";
            this.WW3.Width = 90;
            // 
            // WW4
            // 
            this.WW4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW4.HeaderText = "WW #5";
            this.WW4.Name = "WW4";
            this.WW4.ToolTipText = "Written Work 5";
            this.WW4.Width = 90;
            // 
            // WW5
            // 
            this.WW5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW5.HeaderText = "WW #6";
            this.WW5.Name = "WW5";
            this.WW5.ToolTipText = "Written Work 6";
            this.WW5.Width = 90;
            // 
            // WW6
            // 
            this.WW6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW6.HeaderText = "WW  #7";
            this.WW6.Name = "WW6";
            this.WW6.ToolTipText = "Written Work 7";
            this.WW6.Width = 94;
            // 
            // WW7
            // 
            this.WW7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW7.HeaderText = "WW #8";
            this.WW7.Name = "WW7";
            this.WW7.ToolTipText = "Written Work 8";
            this.WW7.Width = 90;
            // 
            // WW8
            // 
            this.WW8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW8.HeaderText = "WW #9";
            this.WW8.Name = "WW8";
            this.WW8.ToolTipText = "Written Work 9";
            this.WW8.Width = 90;
            // 
            // WW9
            // 
            this.WW9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WW9.HeaderText = "WW #10";
            this.WW9.Name = "WW9";
            this.WW9.ToolTipText = "Written Work 10";
            this.WW9.Width = 99;
            // 
            // WWTotal
            // 
            this.WWTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WWTotal.HeaderText = "Total";
            this.WWTotal.Name = "WWTotal";
            this.WWTotal.Width = 65;
            // 
            // WWPercentage
            // 
            this.WWPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WWPercentage.HeaderText = "WS";
            this.WWPercentage.Name = "WWPercentage";
            this.WWPercentage.ToolTipText = "Written Work Percentage";
            this.WWPercentage.Width = 58;
            // 
            // TP
            // 
            this.TP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP.HeaderText = "TP #1";
            this.TP.Name = "TP";
            this.TP.ToolTipText = "Task Performance 1";
            this.TP.Width = 73;
            // 
            // TP1
            // 
            this.TP1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP1.HeaderText = "TP #2";
            this.TP1.Name = "TP1";
            this.TP1.ToolTipText = "Task Performance 2";
            this.TP1.Width = 73;
            // 
            // TP2
            // 
            this.TP2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP2.HeaderText = "TP #3";
            this.TP2.Name = "TP2";
            this.TP2.ToolTipText = "Task Performance 3";
            this.TP2.Width = 73;
            // 
            // TP3
            // 
            this.TP3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP3.HeaderText = "TP #4";
            this.TP3.Name = "TP3";
            this.TP3.ToolTipText = "Task Performance 4";
            this.TP3.Width = 73;
            // 
            // TP4
            // 
            this.TP4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP4.HeaderText = "TP #5";
            this.TP4.Name = "TP4";
            this.TP4.ToolTipText = "Task Performance 5";
            this.TP4.Width = 73;
            // 
            // TP5
            // 
            this.TP5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP5.HeaderText = "TP #6";
            this.TP5.Name = "TP5";
            this.TP5.ToolTipText = "Task Performance 6";
            this.TP5.Width = 73;
            // 
            // TP6
            // 
            this.TP6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP6.HeaderText = "TP #7";
            this.TP6.Name = "TP6";
            this.TP6.ToolTipText = "Task Performance 7";
            this.TP6.Width = 73;
            // 
            // TP7
            // 
            this.TP7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP7.HeaderText = "TP #8";
            this.TP7.Name = "TP7";
            this.TP7.ToolTipText = "Task Performance 8";
            this.TP7.Width = 73;
            // 
            // TP8
            // 
            this.TP8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP8.HeaderText = "TP #9";
            this.TP8.Name = "TP8";
            this.TP8.ToolTipText = "Task Performance 9";
            this.TP8.Width = 73;
            // 
            // TP9
            // 
            this.TP9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TP9.HeaderText = "TP #10";
            this.TP9.Name = "TP9";
            this.TP9.ToolTipText = "Task Performance 10";
            this.TP9.Width = 82;
            // 
            // TPTotal
            // 
            this.TPTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TPTotal.HeaderText = "Total";
            this.TPTotal.Name = "TPTotal";
            this.TPTotal.ToolTipText = "Task Performance Percentage";
            this.TPTotal.Width = 65;
            // 
            // TPPercentage
            // 
            this.TPPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TPPercentage.HeaderText = "TS";
            this.TPPercentage.Name = "TPPercentage";
            this.TPPercentage.Width = 49;
            // 
            // InitialGrade
            // 
            this.InitialGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InitialGrade.HeaderText = "Initial Grade";
            this.InitialGrade.Name = "InitialGrade";
            this.InitialGrade.Width = 114;
            // 
            // QuarterlyGrade
            // 
            this.QuarterlyGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QuarterlyGrade.HeaderText = "Quarterly Grade";
            this.QuarterlyGrade.Name = "QuarterlyGrade";
            this.QuarterlyGrade.Width = 130;
            // 
            // ClassRecordFacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.CBSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.CBGradeLevel);
            this.Controls.Add(this.lblGradeLevel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DragWindowsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassRecordFacultyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassRecordFacultyView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassRecordFacultyView_FormClosing);
            this.Load += new System.EventHandler(this.ClassRecordFacultyView_Load);
            this.DragWindowsPanel.ResumeLayout(false);
            this.DragWindowsPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstGradingGradebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClassRecordAdminTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView FirstGradingGradebook;
        private System.Windows.Forms.ComboBox CBSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox CBGradeLevel;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW3;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW4;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW5;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW6;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW7;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW8;
        private System.Windows.Forms.DataGridViewTextBoxColumn WW9;
        private System.Windows.Forms.DataGridViewTextBoxColumn WWTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn WWPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterlyGrade;
    }
}