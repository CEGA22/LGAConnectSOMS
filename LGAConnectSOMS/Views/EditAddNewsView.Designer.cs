
namespace LGAConnectSOMS.Views
{
    partial class EditAddNewsView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.lblClassRecordAdminTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.ContentPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdatePhoto = new System.Windows.Forms.Button();
            this.NewsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 59;
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.Location = new System.Drawing.Point(266, 2);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(890, 31);
            this.DragWindowsPanel.TabIndex = 64;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // lblClassRecordAdminTitle
            // 
            this.lblClassRecordAdminTitle.AutoSize = true;
            this.lblClassRecordAdminTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRecordAdminTitle.Location = new System.Drawing.Point(57, 37);
            this.lblClassRecordAdminTitle.Name = "lblClassRecordAdminTitle";
            this.lblClassRecordAdminTitle.Size = new System.Drawing.Size(363, 31);
            this.lblClassRecordAdminTitle.TabIndex = 58;
            this.lblClassRecordAdminTitle.Text = "Publish News and Announcement";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LGAConnectSOMS.Properties.Resources.MinimizeBlack1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1212, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 63;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(1242, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 62;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1272, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 61;
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
            this.btnBack.Location = new System.Drawing.Point(13, 35);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 60;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitle.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(57, 136);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(258, 28);
            this.txtTitle.TabIndex = 66;
            this.txtTitle.TabStop = false;
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(13, 140);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(38, 19);
            this.lblSearchStudent.TabIndex = 65;
            this.lblSearchStudent.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Date:";
            // 
            // rtContent
            // 
            this.rtContent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtContent.Location = new System.Drawing.Point(17, 223);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(643, 420);
            this.rtContent.TabIndex = 71;
            this.rtContent.Text = "";
            // 
            // ContentPhotoPictureBox
            // 
            this.ContentPhotoPictureBox.Location = new System.Drawing.Point(680, 223);
            this.ContentPhotoPictureBox.Name = "ContentPhotoPictureBox";
            this.ContentPhotoPictureBox.Size = new System.Drawing.Size(608, 420);
            this.ContentPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContentPhotoPictureBox.TabIndex = 72;
            this.ContentPhotoPictureBox.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtID.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(1202, 137);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 32);
            this.txtID.TabIndex = 73;
            this.txtID.TabStop = false;
            this.txtID.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(1165, 654);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(122, 34);
            this.BtnSave.TabIndex = 74;
            this.BtnSave.Text = "Save changes";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdatePhoto
            // 
            this.BtnUpdatePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.BtnUpdatePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdatePhoto.FlatAppearance.BorderSize = 0;
            this.BtnUpdatePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdatePhoto.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdatePhoto.ForeColor = System.Drawing.Color.White;
            this.BtnUpdatePhoto.Location = new System.Drawing.Point(1165, 183);
            this.BtnUpdatePhoto.Name = "BtnUpdatePhoto";
            this.BtnUpdatePhoto.Size = new System.Drawing.Size(122, 34);
            this.BtnUpdatePhoto.TabIndex = 75;
            this.BtnUpdatePhoto.Text = "Update Photo";
            this.BtnUpdatePhoto.UseVisualStyleBackColor = false;
            this.BtnUpdatePhoto.Click += new System.EventHandler(this.BtnUpdatePhoto_Click);
            // 
            // NewsDateTimePicker
            // 
            this.NewsDateTimePicker.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewsDateTimePicker.Location = new System.Drawing.Point(390, 136);
            this.NewsDateTimePicker.Name = "NewsDateTimePicker";
            this.NewsDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.NewsDateTimePicker.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1024, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 96;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAddNewsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewsDateTimePicker);
            this.Controls.Add(this.BtnUpdatePhoto);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ContentPhotoPictureBox);
            this.Controls.Add(this.rtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSearchStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragWindowsPanel);
            this.Controls.Add(this.lblClassRecordAdminTitle);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAddNewsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAddNewsView";
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Label lblClassRecordAdminTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.RichTextBox rtContent;
        public System.Windows.Forms.PictureBox ContentPhotoPictureBox;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdatePhoto;
        public System.Windows.Forms.DateTimePicker NewsDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}