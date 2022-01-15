
namespace LGAConnectSOMS.Views
{
    partial class AddNewsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewsView));
            this.BtnUpdatePhoto = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ContentPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.lblClassRecordAdminTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.NewsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PanelLoadingPublishNews = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).BeginInit();
            this.PanelLoadingPublishNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUpdatePhoto
            // 
            this.BtnUpdatePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUpdatePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.BtnUpdatePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdatePhoto.FlatAppearance.BorderSize = 0;
            this.BtnUpdatePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdatePhoto.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdatePhoto.ForeColor = System.Drawing.Color.White;
            this.BtnUpdatePhoto.Location = new System.Drawing.Point(1161, 188);
            this.BtnUpdatePhoto.Name = "BtnUpdatePhoto";
            this.BtnUpdatePhoto.Size = new System.Drawing.Size(122, 34);
            this.BtnUpdatePhoto.TabIndex = 93;
            this.BtnUpdatePhoto.Text = "Upload Photo";
            this.BtnUpdatePhoto.UseVisualStyleBackColor = false;
            this.BtnUpdatePhoto.Click += new System.EventHandler(this.BtnUpdatePhoto_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(1161, 654);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(122, 34);
            this.BtnSave.TabIndex = 92;
            this.BtnSave.Text = "Publish";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ContentPhotoPictureBox
            // 
            this.ContentPhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContentPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContentPhotoPictureBox.Location = new System.Drawing.Point(676, 228);
            this.ContentPhotoPictureBox.Name = "ContentPhotoPictureBox";
            this.ContentPhotoPictureBox.Size = new System.Drawing.Size(608, 420);
            this.ContentPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContentPhotoPictureBox.TabIndex = 90;
            this.ContentPhotoPictureBox.TabStop = false;
            // 
            // rtContent
            // 
            this.rtContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtContent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtContent.Location = new System.Drawing.Point(13, 228);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(643, 420);
            this.rtContent.TabIndex = 89;
            this.rtContent.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "Date:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitle.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(53, 142);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(258, 30);
            this.txtTitle.TabIndex = 84;
            this.txtTitle.TabStop = false;
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(9, 146);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(38, 19);
            this.lblSearchStudent.TabIndex = 83;
            this.lblSearchStudent.Text = "Title:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(8, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 77;
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.Location = new System.Drawing.Point(266, 2);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(890, 31);
            this.DragWindowsPanel.TabIndex = 82;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // lblClassRecordAdminTitle
            // 
            this.lblClassRecordAdminTitle.AutoSize = true;
            this.lblClassRecordAdminTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRecordAdminTitle.Location = new System.Drawing.Point(57, 29);
            this.lblClassRecordAdminTitle.Name = "lblClassRecordAdminTitle";
            this.lblClassRecordAdminTitle.Size = new System.Drawing.Size(363, 31);
            this.lblClassRecordAdminTitle.TabIndex = 76;
            this.lblClassRecordAdminTitle.Text = "Publish News and Announcement";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LGAConnectSOMS.Properties.Resources.MinimizeBlack1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1213, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 81;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(1243, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 80;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1273, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 79;
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
            this.btnBack.Location = new System.Drawing.Point(13, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 78;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // NewsDateTimePicker
            // 
            this.NewsDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewsDateTimePicker.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewsDateTimePicker.Location = new System.Drawing.Point(381, 143);
            this.NewsDateTimePicker.Name = "NewsDateTimePicker";
            this.NewsDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.NewsDateTimePicker.TabIndex = 94;
            // 
            // PanelLoadingPublishNews
            // 
            this.PanelLoadingPublishNews.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelLoadingPublishNews.BackColor = System.Drawing.Color.White;
            this.PanelLoadingPublishNews.Controls.Add(this.label1);
            this.PanelLoadingPublishNews.Location = new System.Drawing.Point(461, 300);
            this.PanelLoadingPublishNews.Name = "PanelLoadingPublishNews";
            this.PanelLoadingPublishNews.Size = new System.Drawing.Size(378, 100);
            this.PanelLoadingPublishNews.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "please wait this may take a few minutes";
            // 
            // AddNewsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PanelLoadingPublishNews);
            this.Controls.Add(this.NewsDateTimePicker);
            this.Controls.Add(this.BtnUpdatePhoto);
            this.Controls.Add(this.BtnSave);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewsView";
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).EndInit();
            this.PanelLoadingPublishNews.ResumeLayout(false);
            this.PanelLoadingPublishNews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdatePhoto;
        private System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.PictureBox ContentPhotoPictureBox;
        public System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Label lblClassRecordAdminTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker NewsDateTimePicker;
        private System.Windows.Forms.Panel PanelLoadingPublishNews;
        private System.Windows.Forms.Label label1;
    }
}