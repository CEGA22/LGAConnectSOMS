
namespace LGAConnectSOMS.Views
{
    partial class AddGradeLevelSectionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGradeLevelSectionView));
            this.lblClassRecordAdminTitle = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cmbGradelevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HighestPossiblescorePictureBox = new System.Windows.Forms.PictureBox();
            this.txtSchoolYearEnd = new System.Windows.Forms.TextBox();
            this.CYStart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HighestPossiblescorePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassRecordAdminTitle
            // 
            this.lblClassRecordAdminTitle.AutoSize = true;
            this.lblClassRecordAdminTitle.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRecordAdminTitle.Location = new System.Drawing.Point(12, 21);
            this.lblClassRecordAdminTitle.Name = "lblClassRecordAdminTitle";
            this.lblClassRecordAdminTitle.Size = new System.Drawing.Size(324, 28);
            this.lblClassRecordAdminTitle.TabIndex = 46;
            this.lblClassRecordAdminTitle.Text = "Grade Level and Section Details";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(445, 286);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(102, 41);
            this.btnAddStudent.TabIndex = 51;
            this.btnAddStudent.Text = "Save ";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // cmbGradelevel
            // 
            this.cmbGradelevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradelevel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradelevel.FormattingEnabled = true;
            this.cmbGradelevel.Items.AddRange(new object[] {
            "Kinder",
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "Grade 11",
            "Grade 12"});
            this.cmbGradelevel.Location = new System.Drawing.Point(226, 122);
            this.cmbGradelevel.Name = "cmbGradelevel";
            this.cmbGradelevel.Size = new System.Drawing.Size(203, 30);
            this.cmbGradelevel.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Grade Level:";
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(103, 174);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(114, 22);
            this.lblLastname.TabIndex = 52;
            this.lblLastname.Text = "Section name:";
            // 
            // txtSectionName
            // 
            this.txtSectionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSectionName.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSectionName.Location = new System.Drawing.Point(227, 170);
            this.txtSectionName.Multiline = true;
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(233, 32);
            this.txtSectionName.TabIndex = 53;
            this.txtSectionName.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 60;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HighestPossiblescorePictureBox
            // 
            this.HighestPossiblescorePictureBox.Image = global::LGAConnectSOMS.Properties.Resources.LastOfUsPartIIEllieWallpaper;
            this.HighestPossiblescorePictureBox.Location = new System.Drawing.Point(12, 264);
            this.HighestPossiblescorePictureBox.Name = "HighestPossiblescorePictureBox";
            this.HighestPossiblescorePictureBox.Size = new System.Drawing.Size(108, 63);
            this.HighestPossiblescorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HighestPossiblescorePictureBox.TabIndex = 61;
            this.HighestPossiblescorePictureBox.TabStop = false;
            this.HighestPossiblescorePictureBox.Visible = false;
            // 
            // txtSchoolYearEnd
            // 
            this.txtSchoolYearEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSchoolYearEnd.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolYearEnd.Location = new System.Drawing.Point(141, 297);
            this.txtSchoolYearEnd.Multiline = true;
            this.txtSchoolYearEnd.Name = "txtSchoolYearEnd";
            this.txtSchoolYearEnd.Size = new System.Drawing.Size(115, 27);
            this.txtSchoolYearEnd.TabIndex = 62;
            this.txtSchoolYearEnd.TabStop = false;
            this.txtSchoolYearEnd.Visible = false;
            // 
            // CYStart
            // 
            this.CYStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CYStart.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CYStart.Location = new System.Drawing.Point(141, 264);
            this.CYStart.Multiline = true;
            this.CYStart.Name = "CYStart";
            this.CYStart.Size = new System.Drawing.Size(115, 27);
            this.CYStart.TabIndex = 63;
            this.CYStart.TabStop = false;
            this.CYStart.Visible = false;
            // 
            // AddGradeLevelSectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(559, 339);
            this.Controls.Add(this.CYStart);
            this.Controls.Add(this.txtSchoolYearEnd);
            this.Controls.Add(this.HighestPossiblescorePictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cmbGradelevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClassRecordAdminTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGradeLevelSectionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddGradeLevelSectionView";
            this.Load += new System.EventHandler(this.AddGradeLevelSectionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HighestPossiblescorePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClassRecordAdminTitle;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.ComboBox cmbGradelevel;
        public System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox HighestPossiblescorePictureBox;
        public System.Windows.Forms.TextBox txtSchoolYearEnd;
        public System.Windows.Forms.TextBox CYStart;
    }
}