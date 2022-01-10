
namespace LGAConnectSOMS.Views
{
    partial class EditClassScheduleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClassScheduleView));
            this.lblClassScheduleDetailsTitle = new System.Windows.Forms.Label();
            this.btnAddClassSchedule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGradeLevel = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.cmbCustomDays = new System.Windows.Forms.ComboBox();
            this.lblRepeatEvery = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtGradeLevel = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClassScheduleDetailsTitle
            // 
            this.lblClassScheduleDetailsTitle.AutoSize = true;
            this.lblClassScheduleDetailsTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassScheduleDetailsTitle.Location = new System.Drawing.Point(12, 18);
            this.lblClassScheduleDetailsTitle.Name = "lblClassScheduleDetailsTitle";
            this.lblClassScheduleDetailsTitle.Size = new System.Drawing.Size(253, 31);
            this.lblClassScheduleDetailsTitle.TabIndex = 1;
            this.lblClassScheduleDetailsTitle.Text = "Class Schedule Details";
            // 
            // btnAddClassSchedule
            // 
            this.btnAddClassSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddClassSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.btnAddClassSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClassSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClassSchedule.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClassSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnAddClassSchedule.Location = new System.Drawing.Point(653, 501);
            this.btnAddClassSchedule.Name = "btnAddClassSchedule";
            this.btnAddClassSchedule.Size = new System.Drawing.Size(136, 41);
            this.btnAddClassSchedule.TabIndex = 12;
            this.btnAddClassSchedule.Text = "Save";
            this.btnAddClassSchedule.UseVisualStyleBackColor = false;
            this.btnAddClassSchedule.Click += new System.EventHandler(this.btnAddClassSchedule_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Subject: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Days:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Time: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Section: ";
            // 
            // labelGradeLevel
            // 
            this.labelGradeLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGradeLevel.AutoSize = true;
            this.labelGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeLevel.Location = new System.Drawing.Point(207, 165);
            this.labelGradeLevel.Name = "labelGradeLevel";
            this.labelGradeLevel.Size = new System.Drawing.Size(96, 19);
            this.labelGradeLevel.TabIndex = 60;
            this.labelGradeLevel.Text = "Grade Level: ";
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(207, 103);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(63, 19);
            this.lblLastname.TabIndex = 59;
            this.lblLastname.Text = "Teacher:";
            // 
            // cmbCustomDays
            // 
            this.cmbCustomDays.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cmbCustomDays.Location = new System.Drawing.Point(316, 445);
            this.cmbCustomDays.Name = "cmbCustomDays";
            this.cmbCustomDays.Size = new System.Drawing.Size(216, 27);
            this.cmbCustomDays.TabIndex = 67;
            this.cmbCustomDays.TabStop = false;
            this.cmbCustomDays.SelectedIndexChanged += new System.EventHandler(this.cmbCustomDays_SelectedIndexChanged);
            this.cmbCustomDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomDays_KeyPress);
            // 
            // lblRepeatEvery
            // 
            this.lblRepeatEvery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRepeatEvery.AutoSize = true;
            this.lblRepeatEvery.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatEvery.Location = new System.Drawing.Point(207, 453);
            this.lblRepeatEvery.Name = "lblRepeatEvery";
            this.lblRepeatEvery.Size = new System.Drawing.Size(103, 19);
            this.lblRepeatEvery.TabIndex = 66;
            this.lblRepeatEvery.Text = "Repeat every: ";
            // 
            // cmbDays
            // 
            this.cmbDays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDays.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "Every Weekday (Mon - Fri)",
            "Custom"});
            this.cmbDays.Location = new System.Drawing.Point(313, 383);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(194, 27);
            this.cmbDays.TabIndex = 65;
            this.cmbDays.TabStop = false;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            this.cmbDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDays_KeyPress);
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFullname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(313, 100);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(233, 32);
            this.txtFullname.TabIndex = 68;
            this.txtFullname.TabStop = false;
            // 
            // txtGradeLevel
            // 
            this.txtGradeLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGradeLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeLevel.Location = new System.Drawing.Point(313, 162);
            this.txtGradeLevel.Multiline = true;
            this.txtGradeLevel.Name = "txtGradeLevel";
            this.txtGradeLevel.ReadOnly = true;
            this.txtGradeLevel.Size = new System.Drawing.Size(233, 32);
            this.txtGradeLevel.TabIndex = 69;
            this.txtGradeLevel.TabStop = false;
            // 
            // txtSection
            // 
            this.txtSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSection.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(313, 214);
            this.txtSection.Multiline = true;
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(233, 32);
            this.txtSection.TabIndex = 70;
            this.txtSection.TabStop = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubject.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(313, 273);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(233, 32);
            this.txtSubject.TabIndex = 71;
            this.txtSubject.TabStop = false;
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cmbEndTime.Location = new System.Drawing.Point(469, 329);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(113, 27);
            this.cmbEndTime.TabIndex = 73;
            this.cmbEndTime.TabStop = false;
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cmbStartTime.Location = new System.Drawing.Point(313, 329);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(113, 27);
            this.cmbStartTime.TabIndex = 72;
            this.cmbStartTime.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(513, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "Delete";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(765, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 34);
            this.btnClose.TabIndex = 75;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EditClassScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbEndTime);
            this.Controls.Add(this.cmbStartTime);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.txtGradeLevel);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.cmbCustomDays);
            this.Controls.Add(this.lblRepeatEvery);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGradeLevel);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.btnAddClassSchedule);
            this.Controls.Add(this.lblClassScheduleDetailsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditClassScheduleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClassScheduleView";
            this.Load += new System.EventHandler(this.EditClassScheduleView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassScheduleDetailsTitle;
        private System.Windows.Forms.Button btnAddClassSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGradeLevel;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.ComboBox cmbCustomDays;
        private System.Windows.Forms.Label lblRepeatEvery;
        public System.Windows.Forms.ComboBox cmbDays;
        public System.Windows.Forms.ComboBox cmbEndTime;
        public System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtFullname;
        public System.Windows.Forms.TextBox txtGradeLevel;
        public System.Windows.Forms.TextBox txtSection;
        public System.Windows.Forms.TextBox txtSubject;
    }
}