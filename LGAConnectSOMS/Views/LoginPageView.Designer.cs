﻿
namespace LGAConnectSOMS.Views
{
    partial class LoginPageView
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLogInTitle = new System.Windows.Forms.Label();
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.LGAConnectSOMSLogo = new System.Windows.Forms.PictureBox();
            this.LoginPanel.SuspendLayout();
            this.DragWindowsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LGAConnectSOMSLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.lblPassword);
            this.LoginPanel.Controls.Add(this.txtAccountID);
            this.LoginPanel.Controls.Add(this.lblID);
            this.LoginPanel.Controls.Add(this.lblLogInTitle);
            this.LoginPanel.Location = new System.Drawing.Point(0, -1);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(591, 703);
            this.LoginPanel.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(348, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 43);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(42, 336);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(425, 43);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 294);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtAccountID
            // 
            this.txtAccountID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountID.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountID.Location = new System.Drawing.Point(39, 227);
            this.txtAccountID.Multiline = true;
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(425, 43);
            this.txtAccountID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(35, 185);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(227, 22);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Teacher ID / Administrator ID";
            // 
            // lblLogInTitle
            // 
            this.lblLogInTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLogInTitle.AutoSize = true;
            this.lblLogInTitle.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInTitle.Location = new System.Drawing.Point(35, 120);
            this.lblLogInTitle.Name = "lblLogInTitle";
            this.lblLogInTitle.Size = new System.Drawing.Size(93, 37);
            this.lblLogInTitle.TabIndex = 0;
            this.lblLogInTitle.Text = "Log in";
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.BackColor = System.Drawing.Color.Transparent;
            this.DragWindowsPanel.Controls.Add(this.btnMaximize);
            this.DragWindowsPanel.Controls.Add(this.btnMinimize);
            this.DragWindowsPanel.Controls.Add(this.btnClose);
            this.DragWindowsPanel.Location = new System.Drawing.Point(592, 0);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(709, 30);
            this.DragWindowsPanel.TabIndex = 16;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown_1);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(646, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 14;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LGAConnectSOMS.Properties.Resources.MinimizeBlack1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(616, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(676, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LGAConnectSOMSLogo
            // 
            this.LGAConnectSOMSLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LGAConnectSOMSLogo.Image = global::LGAConnectSOMS.Properties.Resources.LGA_Connect_SOMS;
            this.LGAConnectSOMSLogo.Location = new System.Drawing.Point(633, 66);
            this.LGAConnectSOMSLogo.Name = "LGAConnectSOMSLogo";
            this.LGAConnectSOMSLogo.Size = new System.Drawing.Size(600, 555);
            this.LGAConnectSOMSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LGAConnectSOMSLogo.TabIndex = 17;
            this.LGAConnectSOMSLogo.TabStop = false;
            // 
            // LoginPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.LGAConnectSOMSLogo);
            this.Controls.Add(this.DragWindowsPanel);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPageView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPageView_FormClosing);
            this.Load += new System.EventHandler(this.LoginPageView_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.DragWindowsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LGAConnectSOMSLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label lblLogInTitle;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.PictureBox LGAConnectSOMSLogo;
    }
}