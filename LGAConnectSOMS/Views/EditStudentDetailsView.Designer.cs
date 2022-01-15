
namespace LGAConnectSOMS.Views
{
    partial class EditStudentDetailsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentDetailsView));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnDeleteStudentDetails = new System.Windows.Forms.Button();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSchoolYearStart = new System.Windows.Forms.Label();
            this.lblSchoolYearEnd = new System.Windows.Forms.Label();
            this.txtSchoolYearEnd = new System.Windows.Forms.TextBox();
            this.StudentProfilePicturebox = new System.Windows.Forms.PictureBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbSY = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStudentProfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParentsname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblShowHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentProfilePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(399, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(399, 143);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(233, 32);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.TabStop = false;
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(399, 251);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(233, 32);
            this.txtFirstname.TabIndex = 2;
            this.txtFirstname.TabStop = false;
            this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(399, 194);
            this.txtMiddlename.Multiline = true;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(233, 32);
            this.txtMiddlename.TabIndex = 3;
            this.txtMiddlename.TabStop = false;
            this.txtMiddlename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddlename_KeyPress);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(252, 148);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(127, 19);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Student Lastname: ";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(252, 260);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(127, 19);
            this.lblFirstname.TabIndex = 7;
            this.lblFirstname.Text = "Student Firstname: ";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.Location = new System.Drawing.Point(252, 203);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(147, 19);
            this.lblMiddlename.TabIndex = 8;
            this.lblMiddlename.Text = "Student Middlename: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(1067, 148);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 19);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender: ";
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(1067, 201);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(96, 19);
            this.lblGradeLevel.TabIndex = 10;
            this.lblGradeLevel.Text = "Grade Level: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student Details";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(10, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 3);
            this.panel1.TabIndex = 23;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(634, 526);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(302, 44);
            this.btnSaveChanges.TabIndex = 24;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cbGender.Location = new System.Drawing.Point(1192, 145);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(123, 27);
            this.cbGender.TabIndex = 25;
            this.cbGender.TabStop = false;
            this.cbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGender_KeyPress);
            // 
            // btnDeleteStudentDetails
            // 
            this.btnDeleteStudentDetails.BackColor = System.Drawing.Color.SeaShell;
            this.btnDeleteStudentDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudentDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudentDetails.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDeleteStudentDetails.Location = new System.Drawing.Point(634, 591);
            this.btnDeleteStudentDetails.Name = "btnDeleteStudentDetails";
            this.btnDeleteStudentDetails.Size = new System.Drawing.Size(302, 44);
            this.btnDeleteStudentDetails.TabIndex = 26;
            this.btnDeleteStudentDetails.Text = "Delete student details";
            this.btnDeleteStudentDetails.UseVisualStyleBackColor = false;
            this.btnDeleteStudentDetails.Visible = false;
            this.btnDeleteStudentDetails.Click += new System.EventHandler(this.btnDeleteStudentDetails_Click);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(1067, 264);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(61, 19);
            this.lblSection.TabIndex = 28;
            this.lblSection.Text = "Section: ";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(252, 329);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(119, 19);
            this.lblStudentNumber.TabIndex = 30;
            this.lblStudentNumber.Text = "Student Number: ";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.Location = new System.Drawing.Point(399, 316);
            this.txtStudentNumber.MaxLength = 10;
            this.txtStudentNumber.Multiline = true;
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(233, 32);
            this.txtStudentNumber.TabIndex = 29;
            this.txtStudentNumber.TabStop = false;
            this.txtStudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNumber_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(252, 389);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 19);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(399, 376);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 32);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblSchoolYearStart
            // 
            this.lblSchoolYearStart.AutoSize = true;
            this.lblSchoolYearStart.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolYearStart.Location = new System.Drawing.Point(1188, 330);
            this.lblSchoolYearStart.Name = "lblSchoolYearStart";
            this.lblSchoolYearStart.Size = new System.Drawing.Size(126, 19);
            this.lblSchoolYearStart.TabIndex = 34;
            this.lblSchoolYearStart.Text = "School Year Start: ";
            // 
            // lblSchoolYearEnd
            // 
            this.lblSchoolYearEnd.AutoSize = true;
            this.lblSchoolYearEnd.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolYearEnd.Location = new System.Drawing.Point(1334, 330);
            this.lblSchoolYearEnd.Name = "lblSchoolYearEnd";
            this.lblSchoolYearEnd.Size = new System.Drawing.Size(119, 19);
            this.lblSchoolYearEnd.TabIndex = 36;
            this.lblSchoolYearEnd.Text = "School Year End: ";
            // 
            // txtSchoolYearEnd
            // 
            this.txtSchoolYearEnd.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolYearEnd.Location = new System.Drawing.Point(1338, 367);
            this.txtSchoolYearEnd.Multiline = true;
            this.txtSchoolYearEnd.Name = "txtSchoolYearEnd";
            this.txtSchoolYearEnd.Size = new System.Drawing.Size(115, 26);
            this.txtSchoolYearEnd.TabIndex = 35;
            this.txtSchoolYearEnd.TabStop = false;
            this.txtSchoolYearEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchoolYearEnd_KeyPress);
            // 
            // StudentProfilePicturebox
            // 
            this.StudentProfilePicturebox.BackColor = System.Drawing.Color.DarkGray;
            this.StudentProfilePicturebox.Location = new System.Drawing.Point(23, 143);
            this.StudentProfilePicturebox.Name = "StudentProfilePicturebox";
            this.StudentProfilePicturebox.Size = new System.Drawing.Size(212, 191);
            this.StudentProfilePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentProfilePicturebox.TabIndex = 37;
            this.StudentProfilePicturebox.TabStop = false;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNumber.Location = new System.Drawing.Point(669, 437);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(115, 19);
            this.lblMobileNumber.TabIndex = 40;
            this.lblMobileNumber.Text = "Mobile Number: ";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.Location = new System.Drawing.Point(816, 428);
            this.txtMobileNumber.MaxLength = 11;
            this.txtMobileNumber.Multiline = true;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(233, 32);
            this.txtMobileNumber.TabIndex = 39;
            this.txtMobileNumber.TabStop = false;
            this.txtMobileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNumber_KeyPress);
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Location = new System.Drawing.Point(1192, 197);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(233, 27);
            this.cmbGradeLevel.TabIndex = 41;
            this.cmbGradeLevel.SelectedIndexChanged += new System.EventHandler(this.cmbGradeLevel_SelectedIndexChanged);
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(1192, 258);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(233, 27);
            this.cmbSection.TabIndex = 42;
            // 
            // cmbSY
            // 
            this.cmbSY.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSY.FormattingEnabled = true;
            this.cmbSY.Location = new System.Drawing.Point(1192, 367);
            this.cmbSY.Name = "cmbSY";
            this.cmbSY.Size = new System.Drawing.Size(122, 27);
            this.cmbSY.TabIndex = 43;
            this.cmbSY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSY_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1430, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 34);
            this.btnClose.TabIndex = 44;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnStudentProfile
            // 
            this.btnStudentProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStudentProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentProfile.FlatAppearance.BorderSize = 0;
            this.btnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentProfile.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentProfile.ForeColor = System.Drawing.Color.White;
            this.btnStudentProfile.Location = new System.Drawing.Point(29, 416);
            this.btnStudentProfile.Name = "btnStudentProfile";
            this.btnStudentProfile.Size = new System.Drawing.Size(144, 41);
            this.btnStudentProfile.TabIndex = 62;
            this.btnStudentProfile.Text = "Edit profile";
            this.btnStudentProfile.UseVisualStyleBackColor = false;
            this.btnStudentProfile.Click += new System.EventHandler(this.btnStudentProfile_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(25, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "File extension:  JPEG, PNG";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(27, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Maximum file size is 1MB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(816, 364);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 32);
            this.txtEmail.TabIndex = 71;
            this.txtEmail.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Birthday: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Parents name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 68;
            this.label7.Text = "Address:";
            // 
            // txtParentsname
            // 
            this.txtParentsname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentsname.Location = new System.Drawing.Point(816, 299);
            this.txtParentsname.Multiline = true;
            this.txtParentsname.Name = "txtParentsname";
            this.txtParentsname.Size = new System.Drawing.Size(233, 32);
            this.txtParentsname.TabIndex = 66;
            this.txtParentsname.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(816, 148);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 69);
            this.txtAddress.TabIndex = 65;
            this.txtAddress.TabStop = false;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(816, 246);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(200, 25);
            this.dtBirthday.TabIndex = 73;
            // 
            // lblShowHide
            // 
            this.lblShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowHide.AutoSize = true;
            this.lblShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowHide.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowHide.Location = new System.Drawing.Point(597, 382);
            this.lblShowHide.Name = "lblShowHide";
            this.lblShowHide.Size = new System.Drawing.Size(43, 19);
            this.lblShowHide.TabIndex = 74;
            this.lblShowHide.Text = "Show";
            this.lblShowHide.Click += new System.EventHandler(this.lblShowHide_Click);
            // 
            // EditStudentDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1466, 647);
            this.Controls.Add(this.lblShowHide);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtParentsname);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStudentProfile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbSY);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.cmbGradeLevel);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.StudentProfilePicturebox);
            this.Controls.Add(this.lblSchoolYearEnd);
            this.Controls.Add(this.txtSchoolYearEnd);
            this.Controls.Add(this.lblSchoolYearStart);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.btnDeleteStudentDetails);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGradeLevel);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudentDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditStudentDetailsView";
            this.Load += new System.EventHandler(this.EditStudentDetailsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentProfilePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveChanges;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtLastname;
        public System.Windows.Forms.TextBox txtFirstname;
        public System.Windows.Forms.TextBox txtMiddlename;
        public System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnDeleteStudentDetails;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblStudentNumber;
        public System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSchoolYearStart;
        private System.Windows.Forms.Label lblSchoolYearEnd;
        public System.Windows.Forms.TextBox txtSchoolYearEnd;
        private System.Windows.Forms.Label lblMobileNumber;
        public System.Windows.Forms.TextBox txtMobileNumber;
        public System.Windows.Forms.ComboBox cmbGradeLevel;
        public System.Windows.Forms.ComboBox cmbSection;
        public System.Windows.Forms.ComboBox cmbSY;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStudentProfile;
        public System.Windows.Forms.PictureBox StudentProfilePicturebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtParentsname;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label lblShowHide;
    }
}