
namespace LGAConnectSOMS.Views
{
    partial class ClassScheduleCustomView
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
            this.lblClassScheduleTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomDays = new System.Windows.Forms.ComboBox();
            this.btnAddClassSchedule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClassScheduleTitle
            // 
            this.lblClassScheduleTitle.AutoSize = true;
            this.lblClassScheduleTitle.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassScheduleTitle.Location = new System.Drawing.Point(22, 23);
            this.lblClassScheduleTitle.Name = "lblClassScheduleTitle";
            this.lblClassScheduleTitle.Size = new System.Drawing.Size(188, 28);
            this.lblClassScheduleTitle.TabIndex = 11;
            this.lblClassScheduleTitle.Text = "Custom recurrence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Repeat every: ";
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
            "Sunday"});
            this.cmbCustomDays.Location = new System.Drawing.Point(207, 146);
            this.cmbCustomDays.Name = "cmbCustomDays";
            this.cmbCustomDays.Size = new System.Drawing.Size(216, 27);
            this.cmbCustomDays.TabIndex = 56;
            this.cmbCustomDays.TabStop = false;
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
            this.btnAddClassSchedule.Location = new System.Drawing.Point(434, 286);
            this.btnAddClassSchedule.Name = "btnAddClassSchedule";
            this.btnAddClassSchedule.Size = new System.Drawing.Size(102, 41);
            this.btnAddClassSchedule.TabIndex = 57;
            this.btnAddClassSchedule.Text = "Save";
            this.btnAddClassSchedule.UseVisualStyleBackColor = false;
            this.btnAddClassSchedule.Click += new System.EventHandler(this.btnAddClassSchedule_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(321, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 41);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 59;
            // 
            // ClassScheduleCustomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(559, 339);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddClassSchedule);
            this.Controls.Add(this.cmbCustomDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClassScheduleTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassScheduleCustomView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClassScheduleCustomView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassScheduleTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCustomDays;
        private System.Windows.Forms.Button btnAddClassSchedule;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox textBox1;
    }
}