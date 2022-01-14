
namespace LGAConnectSOMS.Views
{
    partial class SubjectsManagementView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsManagementView));
            this.lblDisplayResult = new System.Windows.Forms.Label();
            this.btnRemoveSubjectsHandled = new System.Windows.Forms.Button();
            this.dtSubjectsHandled = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSubjectsHandledLoading = new System.Windows.Forms.Label();
            this.lblFacultyLoading = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.lblSubjectsLoading = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtSubjects = new System.Windows.Forms.DataGridView();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGradeLevelLoading = new System.Windows.Forms.Label();
            this.lblFacultyAdmin = new System.Windows.Forms.Label();
            this.btnSelectSubject = new System.Windows.Forms.Button();
            this.tmrSaveResult = new System.Windows.Forms.Timer(this.components);
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnHandledDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtSubjectsHandled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSubjects)).BeginInit();
            this.DragWindowsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnHandledDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplayResult
            // 
            this.lblDisplayResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplayResult.AutoSize = true;
            this.lblDisplayResult.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayResult.Location = new System.Drawing.Point(822, 635);
            this.lblDisplayResult.Name = "lblDisplayResult";
            this.lblDisplayResult.Size = new System.Drawing.Size(126, 19);
            this.lblDisplayResult.TabIndex = 174;
            this.lblDisplayResult.Text = "Successfully saved!";
            this.lblDisplayResult.Visible = false;
            // 
            // btnRemoveSubjectsHandled
            // 
            this.btnRemoveSubjectsHandled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveSubjectsHandled.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveSubjectsHandled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSubjectsHandled.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRemoveSubjectsHandled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSubjectsHandled.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSubjectsHandled.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSubjectsHandled.Location = new System.Drawing.Point(989, 630);
            this.btnRemoveSubjectsHandled.Name = "btnRemoveSubjectsHandled";
            this.btnRemoveSubjectsHandled.Size = new System.Drawing.Size(96, 29);
            this.btnRemoveSubjectsHandled.TabIndex = 172;
            this.btnRemoveSubjectsHandled.Text = "Remove";
            this.btnRemoveSubjectsHandled.UseVisualStyleBackColor = false;
            this.btnRemoveSubjectsHandled.Visible = false;
            this.btnRemoveSubjectsHandled.Click += new System.EventHandler(this.btnRemoveGraceSection_Click);
            // 
            // dtSubjectsHandled
            // 
            this.dtSubjectsHandled.AllowUserToAddRows = false;
            this.dtSubjectsHandled.AllowUserToDeleteRows = false;
            this.dtSubjectsHandled.AllowUserToOrderColumns = true;
            this.dtSubjectsHandled.AllowUserToResizeColumns = false;
            this.dtSubjectsHandled.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.dtSubjectsHandled.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtSubjectsHandled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtSubjectsHandled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSubjectsHandled.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtSubjectsHandled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSubjectsHandled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtSubjectsHandled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSubjectsHandled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dtSubjectsHandled.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSubjectsHandled.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtSubjectsHandled.EnableHeadersVisualStyles = false;
            this.dtSubjectsHandled.Location = new System.Drawing.Point(826, 179);
            this.dtSubjectsHandled.Name = "dtSubjectsHandled";
            this.dtSubjectsHandled.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSubjectsHandled.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtSubjectsHandled.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSubjectsHandled.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtSubjectsHandled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSubjectsHandled.Size = new System.Drawing.Size(360, 445);
            this.dtSubjectsHandled.TabIndex = 169;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(825, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 171;
            this.label2.Text = "Subjects Handled";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1091, 630);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 29);
            this.btnSubmit.TabIndex = 173;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSubjectsHandledLoading
            // 
            this.lblSubjectsHandledLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubjectsHandledLoading.AutoSize = true;
            this.lblSubjectsHandledLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectsHandledLoading.Location = new System.Drawing.Point(822, 634);
            this.lblSubjectsHandledLoading.Name = "lblSubjectsHandledLoading";
            this.lblSubjectsHandledLoading.Size = new System.Drawing.Size(152, 19);
            this.lblSubjectsHandledLoading.TabIndex = 170;
            this.lblSubjectsHandledLoading.Text = "Loading.. Please wait..";
            // 
            // lblFacultyLoading
            // 
            this.lblFacultyLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFacultyLoading.AutoSize = true;
            this.lblFacultyLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyLoading.Location = new System.Drawing.Point(111, 212);
            this.lblFacultyLoading.Name = "lblFacultyLoading";
            this.lblFacultyLoading.Size = new System.Drawing.Size(152, 19);
            this.lblFacultyLoading.TabIndex = 162;
            this.lblFacultyLoading.Text = "Loading.. Please wait..";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFaculty.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbFaculty.Location = new System.Drawing.Point(115, 179);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(300, 30);
            this.cmbFaculty.TabIndex = 160;
            this.cmbFaculty.TabStop = false;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // lblSubjectsLoading
            // 
            this.lblSubjectsLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubjectsLoading.AutoSize = true;
            this.lblSubjectsLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectsLoading.Location = new System.Drawing.Point(466, 635);
            this.lblSubjectsLoading.Name = "lblSubjectsLoading";
            this.lblSubjectsLoading.Size = new System.Drawing.Size(152, 19);
            this.lblSubjectsLoading.TabIndex = 168;
            this.lblSubjectsLoading.Text = "Loading.. Please wait..";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 166;
            this.label5.Text = "Available Subjects";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 164;
            this.label1.Text = "Grade Level";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 159;
            this.label4.Text = "Faculty";
            // 
            // dtSubjects
            // 
            this.dtSubjects.AllowUserToAddRows = false;
            this.dtSubjects.AllowUserToDeleteRows = false;
            this.dtSubjects.AllowUserToOrderColumns = true;
            this.dtSubjects.AllowUserToResizeColumns = false;
            this.dtSubjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.dtSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtSubjects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSubjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject});
            this.dtSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSubjects.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtSubjects.EnableHeadersVisualStyles = false;
            this.dtSubjects.Location = new System.Drawing.Point(470, 179);
            this.dtSubjects.Name = "dtSubjects";
            this.dtSubjects.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtSubjects.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSubjects.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSubjects.Size = new System.Drawing.Size(300, 445);
            this.dtSubjects.TabIndex = 167;
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGradeLevel.Location = new System.Drawing.Point(115, 286);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(300, 30);
            this.cmbGradeLevel.TabIndex = 165;
            this.cmbGradeLevel.TabStop = false;
            this.cmbGradeLevel.SelectedIndexChanged += new System.EventHandler(this.cmbGradeLevel_SelectedIndexChanged);
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
            this.btnBack.Location = new System.Drawing.Point(21, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 157;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lblGradeLevelLoading
            // 
            this.lblGradeLevelLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGradeLevelLoading.AutoSize = true;
            this.lblGradeLevelLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevelLoading.Location = new System.Drawing.Point(111, 319);
            this.lblGradeLevelLoading.Name = "lblGradeLevelLoading";
            this.lblGradeLevelLoading.Size = new System.Drawing.Size(152, 19);
            this.lblGradeLevelLoading.TabIndex = 163;
            this.lblGradeLevelLoading.Text = "Loading.. Please wait..";
            // 
            // lblFacultyAdmin
            // 
            this.lblFacultyAdmin.AutoSize = true;
            this.lblFacultyAdmin.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyAdmin.Location = new System.Drawing.Point(71, 31);
            this.lblFacultyAdmin.Name = "lblFacultyAdmin";
            this.lblFacultyAdmin.Size = new System.Drawing.Size(270, 34);
            this.lblFacultyAdmin.TabIndex = 155;
            this.lblFacultyAdmin.Text = "Subjects Management";
            // 
            // btnSelectSubject
            // 
            this.btnSelectSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectSubject.BackColor = System.Drawing.Color.Teal;
            this.btnSelectSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSubject.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelectSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSubject.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSubject.ForeColor = System.Drawing.Color.White;
            this.btnSelectSubject.Location = new System.Drawing.Point(674, 630);
            this.btnSelectSubject.Name = "btnSelectSubject";
            this.btnSelectSubject.Size = new System.Drawing.Size(96, 29);
            this.btnSelectSubject.TabIndex = 161;
            this.btnSelectSubject.Text = "Select";
            this.btnSelectSubject.UseVisualStyleBackColor = false;
            this.btnSelectSubject.Visible = false;
            this.btnSelectSubject.Click += new System.EventHandler(this.btnSelectSubject_Click);
            // 
            // tmrSaveResult
            // 
            this.tmrSaveResult.Interval = 3000;
            this.tmrSaveResult.Tick += new System.EventHandler(this.tmrSaveResult_Tick);
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.Controls.Add(this.btnMinimize);
            this.DragWindowsPanel.Controls.Add(this.btnMaximize);
            this.DragWindowsPanel.Controls.Add(this.btnClose);
            this.DragWindowsPanel.Location = new System.Drawing.Point(0, 7);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(1302, 37);
            this.DragWindowsPanel.TabIndex = 175;
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
            this.btnMinimize.Location = new System.Drawing.Point(1209, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(1239, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 21;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1269, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(10, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 176;
            // 
            // UnHandledDataGridView
            // 
            this.UnHandledDataGridView.AllowUserToAddRows = false;
            this.UnHandledDataGridView.AllowUserToResizeColumns = false;
            this.UnHandledDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.UnHandledDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.UnHandledDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnHandledDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UnHandledDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UnHandledDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnHandledDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.UnHandledDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnHandledDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnHandledDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.UnHandledDataGridView.EnableHeadersVisualStyles = false;
            this.UnHandledDataGridView.Location = new System.Drawing.Point(115, 365);
            this.UnHandledDataGridView.MultiSelect = false;
            this.UnHandledDataGridView.Name = "UnHandledDataGridView";
            this.UnHandledDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnHandledDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.UnHandledDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnHandledDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.UnHandledDataGridView.Size = new System.Drawing.Size(300, 294);
            this.UnHandledDataGridView.TabIndex = 177;
            // 
            // SubjectsManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.UnHandledDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDisplayResult);
            this.Controls.Add(this.btnRemoveSubjectsHandled);
            this.Controls.Add(this.dtSubjectsHandled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSubjectsHandledLoading);
            this.Controls.Add(this.lblFacultyLoading);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.lblSubjectsLoading);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtSubjects);
            this.Controls.Add(this.cmbGradeLevel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGradeLevelLoading);
            this.Controls.Add(this.lblFacultyAdmin);
            this.Controls.Add(this.btnSelectSubject);
            this.Controls.Add(this.DragWindowsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubjectsManagementView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubjectsManagementView";
            this.Load += new System.EventHandler(this.SubjectsManagementView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSubjectsHandled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSubjects)).EndInit();
            this.DragWindowsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnHandledDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayResult;
        private System.Windows.Forms.Button btnRemoveSubjectsHandled;
        public System.Windows.Forms.DataGridView dtSubjectsHandled;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubjectsHandledLoading;
        private System.Windows.Forms.Label lblFacultyLoading;
        public System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label lblSubjectsLoading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dtSubjects;
        public System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGradeLevelLoading;
        private System.Windows.Forms.Label lblFacultyAdmin;
        private System.Windows.Forms.Button btnSelectSubject;
        private System.Windows.Forms.Timer tmrSaveResult;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView UnHandledDataGridView;
    }
}