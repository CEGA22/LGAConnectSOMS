
namespace LGAConnectSOMS.Views
{
    partial class NewsAndAnnouncementsView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContentPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.BtnEditNews = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 50;
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.Location = new System.Drawing.Point(266, 2);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(890, 31);
            this.DragWindowsPanel.TabIndex = 55;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // lblClassRecordAdminTitle
            // 
            this.lblClassRecordAdminTitle.AutoSize = true;
            this.lblClassRecordAdminTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRecordAdminTitle.Location = new System.Drawing.Point(57, 34);
            this.lblClassRecordAdminTitle.Name = "lblClassRecordAdminTitle";
            this.lblClassRecordAdminTitle.Size = new System.Drawing.Size(336, 31);
            this.lblClassRecordAdminTitle.TabIndex = 49;
            this.lblClassRecordAdminTitle.Text = "Latest News && Announcements";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // btnDate
            // 
            this.btnDate.AutoSize = true;
            this.btnDate.FlatAppearance.BorderSize = 0;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.Image = global::LGAConnectSOMS.Properties.Resources.Date;
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.Location = new System.Drawing.Point(18, 46);
            this.btnDate.MaximumSize = new System.Drawing.Size(200, 0);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(105, 25);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "button2";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(1188, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 22);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(22, 422);
            this.lblContent.MaximumSize = new System.Drawing.Size(1276, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(58, 22);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lblContent);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.btnDate);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.ContentPhotoPictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 527);
            this.panel2.TabIndex = 56;
            // 
            // ContentPhotoPictureBox
            // 
            this.ContentPhotoPictureBox.Location = new System.Drawing.Point(18, 77);
            this.ContentPhotoPictureBox.Name = "ContentPhotoPictureBox";
            this.ContentPhotoPictureBox.Size = new System.Drawing.Size(1228, 305);
            this.ContentPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContentPhotoPictureBox.TabIndex = 1;
            this.ContentPhotoPictureBox.TabStop = false;
            // 
            // BtnEditNews
            // 
            this.BtnEditNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditNews.FlatAppearance.BorderSize = 0;
            this.BtnEditNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditNews.Image = global::LGAConnectSOMS.Properties.Resources.editNewsAnnouncement;
            this.BtnEditNews.Location = new System.Drawing.Point(1238, 107);
            this.BtnEditNews.Name = "BtnEditNews";
            this.BtnEditNews.Size = new System.Drawing.Size(42, 40);
            this.BtnEditNews.TabIndex = 57;
            this.BtnEditNews.UseVisualStyleBackColor = true;
            this.BtnEditNews.Click += new System.EventHandler(this.BtnEditNews_Click);
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
            this.btnMinimize.TabIndex = 54;
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
            this.btnMaximize.TabIndex = 53;
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
            this.btnClose.TabIndex = 52;
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
            this.btnBack.Location = new System.Drawing.Point(13, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 51;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // NewsAndAnnouncementsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.BtnEditNews);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragWindowsPanel);
            this.Controls.Add(this.lblClassRecordAdminTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsAndAnnouncementsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewsAndAnnouncementsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageNewsView_FormClosing);
            this.Load += new System.EventHandler(this.NewsAndAnnouncementsView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Label lblClassRecordAdminTitle;
        public System.Windows.Forms.PictureBox ContentPhotoPictureBox;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnDate;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BtnEditNews;
    }
}