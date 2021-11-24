
namespace LGAConnectSOMS.Views
{
    partial class ClassScheduleView
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
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClassScheduleTitle = new System.Windows.Forms.Label();
            this.ClassSchedulePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassDaysPanel = new System.Windows.Forms.Panel();
            this.lblEntireWeek = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.DragWindowsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ClassDaysPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.Controls.Add(this.btnMinimize);
            this.DragWindowsPanel.Controls.Add(this.btnMaximize);
            this.DragWindowsPanel.Controls.Add(this.btnClose);
            this.DragWindowsPanel.Controls.Add(this.btnBack);
            this.DragWindowsPanel.Controls.Add(this.panel1);
            this.DragWindowsPanel.Controls.Add(this.lblClassScheduleTitle);
            this.DragWindowsPanel.Location = new System.Drawing.Point(1, 1);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(1301, 105);
            this.DragWindowsPanel.TabIndex = 27;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LGAConnectSOMS.Properties.Resources.MinimizeBlack1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1208, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 34);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(1238, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 34);
            this.btnMaximize.TabIndex = 21;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1268, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 34);
            this.btnClose.TabIndex = 20;
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
            this.btnBack.Location = new System.Drawing.Point(25, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(13, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 3);
            this.panel1.TabIndex = 12;
            // 
            // lblClassScheduleTitle
            // 
            this.lblClassScheduleTitle.AutoSize = true;
            this.lblClassScheduleTitle.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassScheduleTitle.Location = new System.Drawing.Point(69, 27);
            this.lblClassScheduleTitle.Name = "lblClassScheduleTitle";
            this.lblClassScheduleTitle.Size = new System.Drawing.Size(173, 31);
            this.lblClassScheduleTitle.TabIndex = 10;
            this.lblClassScheduleTitle.Text = "Class Schedule";
            // 
            // ClassSchedulePanel
            // 
            this.ClassSchedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClassSchedulePanel.AutoScroll = true;
            this.ClassSchedulePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassSchedulePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ClassSchedulePanel.Location = new System.Drawing.Point(295, 210);
            this.ClassSchedulePanel.Name = "ClassSchedulePanel";
            this.ClassSchedulePanel.Size = new System.Drawing.Size(736, 478);
            this.ClassSchedulePanel.TabIndex = 28;
            this.ClassSchedulePanel.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(295, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 38);
            this.panel2.TabIndex = 29;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::LGAConnectSOMS.Properties.Resources.dropdown16;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(325, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entire Week";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClassDaysPanel
            // 
            this.ClassDaysPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClassDaysPanel.BackColor = System.Drawing.Color.White;
            this.ClassDaysPanel.Controls.Add(this.lblEntireWeek);
            this.ClassDaysPanel.Controls.Add(this.lblSunday);
            this.ClassDaysPanel.Controls.Add(this.lblSaturday);
            this.ClassDaysPanel.Controls.Add(this.lblFriday);
            this.ClassDaysPanel.Controls.Add(this.lblThursday);
            this.ClassDaysPanel.Controls.Add(this.lblWednesday);
            this.ClassDaysPanel.Controls.Add(this.lblTuesday);
            this.ClassDaysPanel.Controls.Add(this.lblMonday);
            this.ClassDaysPanel.Controls.Add(this.Title);
            this.ClassDaysPanel.Location = new System.Drawing.Point(295, 193);
            this.ClassDaysPanel.Name = "ClassDaysPanel";
            this.ClassDaysPanel.Size = new System.Drawing.Size(710, 407);
            this.ClassDaysPanel.TabIndex = 0;
            // 
            // lblEntireWeek
            // 
            this.lblEntireWeek.AutoSize = true;
            this.lblEntireWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntireWeek.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntireWeek.Location = new System.Drawing.Point(13, 328);
            this.lblEntireWeek.Name = "lblEntireWeek";
            this.lblEntireWeek.Size = new System.Drawing.Size(103, 22);
            this.lblEntireWeek.TabIndex = 8;
            this.lblEntireWeek.Text = "Entire Week";
            this.lblEntireWeek.Click += new System.EventHandler(this.lblEntireWeek_Click);
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSunday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(13, 286);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(66, 22);
            this.lblSunday.TabIndex = 7;
            this.lblSunday.Text = "Sunday";
            this.lblSunday.Click += new System.EventHandler(this.lblSunday_Click);
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaturday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(13, 248);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(79, 22);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday";
            this.lblSaturday.Click += new System.EventHandler(this.lblSaturday_Click);
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFriday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(13, 210);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(58, 22);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday";
            this.lblFriday.Click += new System.EventHandler(this.lblFriday_Click);
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThursday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(13, 173);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(76, 22);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Thursday";
            this.lblThursday.Click += new System.EventHandler(this.lblThursday_Click);
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWednesday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(13, 133);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(103, 22);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday";
            this.lblWednesday.Click += new System.EventHandler(this.lblWednesday_Click);
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTuesday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(13, 92);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(72, 22);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday";
            this.lblTuesday.Click += new System.EventHandler(this.lblTuesday_Click);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonday.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(13, 53);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(73, 22);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday";
            this.lblMonday.Click += new System.EventHandler(this.lblMonday_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Title.Location = new System.Drawing.Point(13, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Class Days";
            // 
            // ClassScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.ClassDaysPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClassSchedulePanel);
            this.Controls.Add(this.DragWindowsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassScheduleView";
            this.Text = "ClassScheduleView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassScheduleView_FormClosing);
            this.Load += new System.EventHandler(this.ClassScheduleView_Load);
            this.Click += new System.EventHandler(this.ClassScheduleView_Click);
            this.DragWindowsPanel.ResumeLayout(false);
            this.DragWindowsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ClassDaysPanel.ResumeLayout(false);
            this.ClassDaysPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClassScheduleTitle;
        private System.Windows.Forms.FlowLayoutPanel ClassSchedulePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ClassDaysPanel;
        private System.Windows.Forms.Label lblEntireWeek;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label Title;
    }
}