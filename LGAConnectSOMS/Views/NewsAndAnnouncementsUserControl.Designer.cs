
namespace LGAConnectSOMS.Views
{
    partial class NewsAndAnnouncementsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Button();
            this.ContentPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSeeMore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 220);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // lblContent
            // 
            this.lblContent.AutoEllipsis = true;
            this.lblContent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(16, 258);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(253, 82);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(244, 211);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "label2";
            this.lblID.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoEllipsis = true;
            this.lblDate.FlatAppearance.BorderSize = 0;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Image = global::LGAConnectSOMS.Properties.Resources.Date;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(3, 402);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 23);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "button1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.UseVisualStyleBackColor = true;
            // 
            // ContentPhotoPictureBox
            // 
            this.ContentPhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContentPhotoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ContentPhotoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ContentPhotoPictureBox.Name = "ContentPhotoPictureBox";
            this.ContentPhotoPictureBox.Size = new System.Drawing.Size(284, 204);
            this.ContentPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContentPhotoPictureBox.TabIndex = 0;
            this.ContentPhotoPictureBox.TabStop = false;
            // 
            // lblSeeMore
            // 
            this.lblSeeMore.AutoSize = true;
            this.lblSeeMore.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.lblSeeMore.Location = new System.Drawing.Point(211, 406);
            this.lblSeeMore.Name = "lblSeeMore";
            this.lblSeeMore.Size = new System.Drawing.Size(69, 19);
            this.lblSeeMore.TabIndex = 16;
            this.lblSeeMore.Text = "See more";
            this.lblSeeMore.Click += new System.EventHandler(this.lblSeeMore_Click);
            // 
            // NewsAndAnnouncementsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblSeeMore);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ContentPhotoPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NewsAndAnnouncementsUserControl";
            this.Size = new System.Drawing.Size(284, 431);
            this.MouseEnter += new System.EventHandler(this.NewsAndAnnouncementsUserControl_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.ContentPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ContentPhotoPictureBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button lblDate;
        public System.Windows.Forms.Label lblSeeMore;
    }
}
