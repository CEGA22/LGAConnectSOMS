
namespace LGAConnectSOMS.Views
{
    partial class SectionsManagementView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFacultyAdmin = new System.Windows.Forms.Label();
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.dtSectionsHandledPreview = new System.Windows.Forms.DataGridView();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveGraceSection = new System.Windows.Forms.Button();
            this.btnAddGradeSection = new System.Windows.Forms.Button();
            this.dtGradeSection = new System.Windows.Forms.DataGridView();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFacultyLoading = new System.Windows.Forms.Label();
            this.lblGradeLevelLoading = new System.Windows.Forms.Label();
            this.lblPreviewLoading = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDisplayResult = new System.Windows.Forms.Label();
            this.tmrSaveResult = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.DragWindowsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSectionsHandledPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGradeSection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(10, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 38;
            // 
            // lblFacultyAdmin
            // 
            this.lblFacultyAdmin.AutoSize = true;
            this.lblFacultyAdmin.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyAdmin.Location = new System.Drawing.Point(71, 31);
            this.lblFacultyAdmin.Name = "lblFacultyAdmin";
            this.lblFacultyAdmin.Size = new System.Drawing.Size(269, 34);
            this.lblFacultyAdmin.TabIndex = 37;
            this.lblFacultyAdmin.Text = "Sections Management";
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
            this.DragWindowsPanel.TabIndex = 40;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // dtSectionsHandledPreview
            // 
            this.dtSectionsHandledPreview.AllowUserToAddRows = false;
            this.dtSectionsHandledPreview.AllowUserToDeleteRows = false;
            this.dtSectionsHandledPreview.AllowUserToResizeColumns = false;
            this.dtSectionsHandledPreview.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.dtSectionsHandledPreview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtSectionsHandledPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSectionsHandledPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSectionsHandledPreview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtSectionsHandledPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSectionsHandledPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtSectionsHandledPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSectionsHandledPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Faculty,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtSectionsHandledPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSectionsHandledPreview.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtSectionsHandledPreview.Enabled = false;
            this.dtSectionsHandledPreview.EnableHeadersVisualStyles = false;
            this.dtSectionsHandledPreview.Location = new System.Drawing.Point(583, 181);
            this.dtSectionsHandledPreview.Name = "dtSectionsHandledPreview";
            this.dtSectionsHandledPreview.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSectionsHandledPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtSectionsHandledPreview.RowHeadersVisible = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSectionsHandledPreview.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtSectionsHandledPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSectionsHandledPreview.Size = new System.Drawing.Size(681, 449);
            this.dtSectionsHandledPreview.TabIndex = 81;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Section";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(579, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "3. Save";
            // 
            // btnRemoveGraceSection
            // 
            this.btnRemoveGraceSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveGraceSection.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveGraceSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveGraceSection.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRemoveGraceSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveGraceSection.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGraceSection.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGraceSection.Location = new System.Drawing.Point(1065, 636);
            this.btnRemoveGraceSection.Name = "btnRemoveGraceSection";
            this.btnRemoveGraceSection.Size = new System.Drawing.Size(96, 29);
            this.btnRemoveGraceSection.TabIndex = 79;
            this.btnRemoveGraceSection.Text = "Remove";
            this.btnRemoveGraceSection.UseVisualStyleBackColor = false;
            this.btnRemoveGraceSection.Visible = false;
            this.btnRemoveGraceSection.Click += new System.EventHandler(this.btnRemoveGraceSection_Click);
            // 
            // btnAddGradeSection
            // 
            this.btnAddGradeSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGradeSection.BackColor = System.Drawing.Color.Teal;
            this.btnAddGradeSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGradeSection.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAddGradeSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGradeSection.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGradeSection.ForeColor = System.Drawing.Color.White;
            this.btnAddGradeSection.Location = new System.Drawing.Point(354, 636);
            this.btnAddGradeSection.Name = "btnAddGradeSection";
            this.btnAddGradeSection.Size = new System.Drawing.Size(96, 29);
            this.btnAddGradeSection.TabIndex = 78;
            this.btnAddGradeSection.Text = "Select";
            this.btnAddGradeSection.UseVisualStyleBackColor = false;
            this.btnAddGradeSection.Visible = false;
            this.btnAddGradeSection.Click += new System.EventHandler(this.btnAddGradeSection_Click);
            // 
            // dtGradeSection
            // 
            this.dtGradeSection.AllowUserToAddRows = false;
            this.dtGradeSection.AllowUserToDeleteRows = false;
            this.dtGradeSection.AllowUserToResizeColumns = false;
            this.dtGradeSection.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.dtGradeSection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtGradeSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGradeSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGradeSection.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGradeSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGradeSection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtGradeSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGradeSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grade,
            this.Section});
            this.dtGradeSection.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGradeSection.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtGradeSection.Enabled = false;
            this.dtGradeSection.EnableHeadersVisualStyles = false;
            this.dtGradeSection.Location = new System.Drawing.Point(41, 288);
            this.dtGradeSection.Name = "dtGradeSection";
            this.dtGradeSection.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGradeSection.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtGradeSection.RowHeadersVisible = false;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGradeSection.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dtGradeSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGradeSection.Size = new System.Drawing.Size(409, 342);
            this.dtGradeSection.TabIndex = 77;
            this.dtGradeSection.SelectionChanged += new System.EventHandler(this.dtGradeSection_SelectionChanged);
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "2. Select Grade Level(s)";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFaculty.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbFaculty.Location = new System.Drawing.Point(41, 181);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(409, 30);
            this.cmbFaculty.TabIndex = 75;
            this.cmbFaculty.TabStop = false;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "1. Select Faculty";
            // 
            // lblFacultyLoading
            // 
            this.lblFacultyLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFacultyLoading.AutoSize = true;
            this.lblFacultyLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyLoading.Location = new System.Drawing.Point(37, 214);
            this.lblFacultyLoading.Name = "lblFacultyLoading";
            this.lblFacultyLoading.Size = new System.Drawing.Size(152, 19);
            this.lblFacultyLoading.TabIndex = 82;
            this.lblFacultyLoading.Text = "Loading.. Please wait..";
            // 
            // lblGradeLevelLoading
            // 
            this.lblGradeLevelLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGradeLevelLoading.AutoSize = true;
            this.lblGradeLevelLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevelLoading.Location = new System.Drawing.Point(37, 633);
            this.lblGradeLevelLoading.Name = "lblGradeLevelLoading";
            this.lblGradeLevelLoading.Size = new System.Drawing.Size(152, 19);
            this.lblGradeLevelLoading.TabIndex = 83;
            this.lblGradeLevelLoading.Text = "Loading.. Please wait..";
            // 
            // lblPreviewLoading
            // 
            this.lblPreviewLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPreviewLoading.AutoSize = true;
            this.lblPreviewLoading.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewLoading.Location = new System.Drawing.Point(579, 633);
            this.lblPreviewLoading.Name = "lblPreviewLoading";
            this.lblPreviewLoading.Size = new System.Drawing.Size(152, 19);
            this.lblPreviewLoading.TabIndex = 84;
            this.lblPreviewLoading.Text = "Loading.. Please wait..";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1167, 636);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 29);
            this.btnSubmit.TabIndex = 85;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDisplayResult
            // 
            this.lblDisplayResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplayResult.AutoSize = true;
            this.lblDisplayResult.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayResult.Location = new System.Drawing.Point(579, 633);
            this.lblDisplayResult.Name = "lblDisplayResult";
            this.lblDisplayResult.Size = new System.Drawing.Size(126, 19);
            this.lblDisplayResult.TabIndex = 86;
            this.lblDisplayResult.Text = "Successfully saved!";
            this.lblDisplayResult.Visible = false;
            // 
            // tmrSaveResult
            // 
            this.tmrSaveResult.Interval = 3000;
            this.tmrSaveResult.Tick += new System.EventHandler(this.tmrSaveResult_Tick);
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
            this.btnBack.TabIndex = 39;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
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
            // SectionsManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.lblDisplayResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPreviewLoading);
            this.Controls.Add(this.lblGradeLevelLoading);
            this.Controls.Add(this.lblFacultyLoading);
            this.Controls.Add(this.dtSectionsHandledPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveGraceSection);
            this.Controls.Add(this.btnAddGradeSection);
            this.Controls.Add(this.dtGradeSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFacultyAdmin);
            this.Controls.Add(this.DragWindowsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SectionsManagementView";
            this.Text = "SectionsManagementView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SectionsManagementView_FormClosing);
            this.Load += new System.EventHandler(this.SectionsManagementView_Load);
            this.DragWindowsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSectionsHandledPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGradeSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFacultyAdmin;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dtSectionsHandledPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveGraceSection;
        private System.Windows.Forms.Button btnAddGradeSection;
        public System.Windows.Forms.DataGridView dtGradeSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFacultyLoading;
        private System.Windows.Forms.Label lblGradeLevelLoading;
        private System.Windows.Forms.Label lblPreviewLoading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDisplayResult;
        private System.Windows.Forms.Timer tmrSaveResult;
    }
}