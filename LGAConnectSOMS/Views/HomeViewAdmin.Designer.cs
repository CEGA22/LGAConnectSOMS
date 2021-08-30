
namespace LGAConnectSOMS
{
    partial class HomeViewAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeViewAdmin));
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.btnPaymentRecords = new System.Windows.Forms.Button();
            this.btnManageNews = new System.Windows.Forms.Button();
            this.btnClassSchedule = new System.Windows.Forms.Button();
            this.btnClassRecords = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.LGAConnectLogo = new System.Windows.Forms.PictureBox();
            this.DragWindowsPanel = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.NewsPanel = new System.Windows.Forms.Panel();
            this.lblArticelDescription = new System.Windows.Forms.Label();
            this.lblArticleTitle = new System.Windows.Forms.Label();
            this.NewsImage = new System.Windows.Forms.PictureBox();
            this.NewsPanelYellow = new System.Windows.Forms.Panel();
            this.lblvViewMoreNews = new System.Windows.Forms.Label();
            this.lblTitleNewsPanel = new System.Windows.Forms.Label();
            this.btnEnrolledStudents = new System.Windows.Forms.Button();
            this.btnFileRequest = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LGAConnectLogo)).BeginInit();
            this.DragWindowsPanel.SuspendLayout();
            this.NewsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsImage)).BeginInit();
            this.NewsPanelYellow.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.SideBarPanel.Controls.Add(this.btnPaymentRecords);
            this.SideBarPanel.Controls.Add(this.btnManageNews);
            this.SideBarPanel.Controls.Add(this.btnClassSchedule);
            this.SideBarPanel.Controls.Add(this.btnClassRecords);
            this.SideBarPanel.Controls.Add(this.btnHome);
            this.SideBarPanel.Controls.Add(this.LGAConnectLogo);
            this.SideBarPanel.Location = new System.Drawing.Point(-2, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(265, 700);
            this.SideBarPanel.TabIndex = 0;
            // 
            // btnPaymentRecords
            // 
            this.btnPaymentRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentRecords.FlatAppearance.BorderSize = 0;
            this.btnPaymentRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentRecords.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRecords.ForeColor = System.Drawing.Color.White;
            this.btnPaymentRecords.Image = global::LGAConnectSOMS.Properties.Resources.Payment_Records;
            this.btnPaymentRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentRecords.Location = new System.Drawing.Point(0, 478);
            this.btnPaymentRecords.Name = "btnPaymentRecords";
            this.btnPaymentRecords.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPaymentRecords.Size = new System.Drawing.Size(256, 51);
            this.btnPaymentRecords.TabIndex = 11;
            this.btnPaymentRecords.Text = "Payment Records";
            this.btnPaymentRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentRecords.UseVisualStyleBackColor = true;
            this.btnPaymentRecords.Click += new System.EventHandler(this.btnPaymentRecords_Click);
            this.btnPaymentRecords.MouseEnter += new System.EventHandler(this.btnPaymentRecords_MouseEnter);
            this.btnPaymentRecords.MouseLeave += new System.EventHandler(this.btnPaymentRecords_MouseLeave);
            // 
            // btnManageNews
            // 
            this.btnManageNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageNews.FlatAppearance.BorderSize = 0;
            this.btnManageNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageNews.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageNews.ForeColor = System.Drawing.Color.White;
            this.btnManageNews.Image = global::LGAConnectSOMS.Properties.Resources.envelope;
            this.btnManageNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageNews.Location = new System.Drawing.Point(0, 396);
            this.btnManageNews.Name = "btnManageNews";
            this.btnManageNews.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnManageNews.Size = new System.Drawing.Size(256, 66);
            this.btnManageNews.TabIndex = 10;
            this.btnManageNews.Text = "Manage News &&\r\nAnnouncements";
            this.btnManageNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageNews.UseVisualStyleBackColor = true;
            this.btnManageNews.Click += new System.EventHandler(this.btnManageNews_Click);
            this.btnManageNews.MouseEnter += new System.EventHandler(this.btnManageNews_MouseEnter);
            this.btnManageNews.MouseLeave += new System.EventHandler(this.btnManageNews_MouseLeave);
            // 
            // btnClassSchedule
            // 
            this.btnClassSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.btnClassSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassSchedule.FlatAppearance.BorderSize = 0;
            this.btnClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassSchedule.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassSchedule.ForeColor = System.Drawing.Color.White;
            this.btnClassSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnClassSchedule.Image")));
            this.btnClassSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassSchedule.Location = new System.Drawing.Point(0, 330);
            this.btnClassSchedule.Name = "btnClassSchedule";
            this.btnClassSchedule.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClassSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClassSchedule.Size = new System.Drawing.Size(256, 41);
            this.btnClassSchedule.TabIndex = 9;
            this.btnClassSchedule.Text = "Class Schedule";
            this.btnClassSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassSchedule.UseVisualStyleBackColor = false;
            this.btnClassSchedule.MouseEnter += new System.EventHandler(this.btnClassSchedule_MouseEnter);
            this.btnClassSchedule.MouseLeave += new System.EventHandler(this.btnClassSchedule_MouseLeave);
            // 
            // btnClassRecords
            // 
            this.btnClassRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassRecords.FlatAppearance.BorderSize = 0;
            this.btnClassRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassRecords.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassRecords.ForeColor = System.Drawing.Color.White;
            this.btnClassRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnClassRecords.Image")));
            this.btnClassRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassRecords.Location = new System.Drawing.Point(0, 268);
            this.btnClassRecords.Name = "btnClassRecords";
            this.btnClassRecords.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClassRecords.Size = new System.Drawing.Size(256, 41);
            this.btnClassRecords.TabIndex = 8;
            this.btnClassRecords.Text = "Class Records";
            this.btnClassRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassRecords.UseVisualStyleBackColor = true;
            this.btnClassRecords.Click += new System.EventHandler(this.btnClassRecords_Click);
            this.btnClassRecords.MouseEnter += new System.EventHandler(this.btnClassRecords_MouseEnter);
            this.btnClassRecords.MouseLeave += new System.EventHandler(this.btnClassRecords_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::LGAConnectSOMS.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 197);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(256, 41);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = " Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // LGAConnectLogo
            // 
            this.LGAConnectLogo.Image = global::LGAConnectSOMS.Properties.Resources.LGASCHOOLLOGO;
            this.LGAConnectLogo.Location = new System.Drawing.Point(75, 33);
            this.LGAConnectLogo.Name = "LGAConnectLogo";
            this.LGAConnectLogo.Size = new System.Drawing.Size(100, 100);
            this.LGAConnectLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LGAConnectLogo.TabIndex = 6;
            this.LGAConnectLogo.TabStop = false;
            // 
            // DragWindowsPanel
            // 
            this.DragWindowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragWindowsPanel.BackColor = System.Drawing.Color.Transparent;
            this.DragWindowsPanel.Controls.Add(this.btnMaximize);
            this.DragWindowsPanel.Controls.Add(this.btnMinimize);
            this.DragWindowsPanel.Controls.Add(this.btnClose);
            this.DragWindowsPanel.Location = new System.Drawing.Point(263, 0);
            this.DragWindowsPanel.Name = "DragWindowsPanel";
            this.DragWindowsPanel.Size = new System.Drawing.Size(1037, 29);
            this.DragWindowsPanel.TabIndex = 13;
            this.DragWindowsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseDown);
            this.DragWindowsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindowsPanel_MouseMove);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            this.btnMaximize.Location = new System.Drawing.Point(974, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 11;
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
            this.btnMinimize.Location = new System.Drawing.Point(944, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LGAConnectSOMS.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(1004, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewsPanel
            // 
            this.NewsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsPanel.BackColor = System.Drawing.Color.White;
            this.NewsPanel.Controls.Add(this.lblArticelDescription);
            this.NewsPanel.Controls.Add(this.lblArticleTitle);
            this.NewsPanel.Controls.Add(this.NewsImage);
            this.NewsPanel.Controls.Add(this.NewsPanelYellow);
            this.NewsPanel.Location = new System.Drawing.Point(269, 121);
            this.NewsPanel.Name = "NewsPanel";
            this.NewsPanel.Size = new System.Drawing.Size(782, 510);
            this.NewsPanel.TabIndex = 1;
            // 
            // lblArticelDescription
            // 
            this.lblArticelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArticelDescription.AutoSize = true;
            this.lblArticelDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblArticelDescription.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticelDescription.Location = new System.Drawing.Point(12, 401);
            this.lblArticelDescription.Name = "lblArticelDescription";
            this.lblArticelDescription.Size = new System.Drawing.Size(712, 76);
            this.lblArticelDescription.TabIndex = 5;
            this.lblArticelDescription.Text = resources.GetString("lblArticelDescription.Text");
            // 
            // lblArticleTitle
            // 
            this.lblArticleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArticleTitle.AutoSize = true;
            this.lblArticleTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblArticleTitle.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticleTitle.Location = new System.Drawing.Point(12, 357);
            this.lblArticleTitle.Name = "lblArticleTitle";
            this.lblArticleTitle.Size = new System.Drawing.Size(98, 24);
            this.lblArticleTitle.TabIndex = 4;
            this.lblArticleTitle.Text = "News Title";
            // 
            // NewsImage
            // 
            this.NewsImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsImage.Image = global::LGAConnectSOMS.Properties.Resources.LastOfUsPartIIEllieWallpaper;
            this.NewsImage.Location = new System.Drawing.Point(16, 50);
            this.NewsImage.Name = "NewsImage";
            this.NewsImage.Size = new System.Drawing.Size(747, 291);
            this.NewsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NewsImage.TabIndex = 3;
            this.NewsImage.TabStop = false;
            // 
            // NewsPanelYellow
            // 
            this.NewsPanelYellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsPanelYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(143)))));
            this.NewsPanelYellow.Controls.Add(this.lblvViewMoreNews);
            this.NewsPanelYellow.Controls.Add(this.lblTitleNewsPanel);
            this.NewsPanelYellow.Location = new System.Drawing.Point(0, 0);
            this.NewsPanelYellow.Name = "NewsPanelYellow";
            this.NewsPanelYellow.Size = new System.Drawing.Size(782, 33);
            this.NewsPanelYellow.TabIndex = 2;
            // 
            // lblvViewMoreNews
            // 
            this.lblvViewMoreNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblvViewMoreNews.AutoSize = true;
            this.lblvViewMoreNews.BackColor = System.Drawing.Color.Transparent;
            this.lblvViewMoreNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblvViewMoreNews.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvViewMoreNews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblvViewMoreNews.Location = new System.Drawing.Point(701, 6);
            this.lblvViewMoreNews.Name = "lblvViewMoreNews";
            this.lblvViewMoreNews.Size = new System.Drawing.Size(75, 17);
            this.lblvViewMoreNews.TabIndex = 7;
            this.lblvViewMoreNews.Text = "View More";
            // 
            // lblTitleNewsPanel
            // 
            this.lblTitleNewsPanel.AutoSize = true;
            this.lblTitleNewsPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleNewsPanel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNewsPanel.ForeColor = System.Drawing.Color.Black;
            this.lblTitleNewsPanel.Location = new System.Drawing.Point(9, 6);
            this.lblTitleNewsPanel.Name = "lblTitleNewsPanel";
            this.lblTitleNewsPanel.Size = new System.Drawing.Size(84, 19);
            this.lblTitleNewsPanel.TabIndex = 6;
            this.lblTitleNewsPanel.Text = "Latest News";
            // 
            // btnEnrolledStudents
            // 
            this.btnEnrolledStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnrolledStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.btnEnrolledStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrolledStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrolledStudents.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolledStudents.ForeColor = System.Drawing.Color.White;
            this.btnEnrolledStudents.Location = new System.Drawing.Point(1069, 121);
            this.btnEnrolledStudents.Name = "btnEnrolledStudents";
            this.btnEnrolledStudents.Size = new System.Drawing.Size(219, 188);
            this.btnEnrolledStudents.TabIndex = 2;
            this.btnEnrolledStudents.Text = "Enrolled Students\r\n\r\n\r\n                      ";
            this.btnEnrolledStudents.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEnrolledStudents.UseVisualStyleBackColor = false;
            // 
            // btnFileRequest
            // 
            this.btnFileRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnFileRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileRequest.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileRequest.ForeColor = System.Drawing.Color.White;
            this.btnFileRequest.Location = new System.Drawing.Point(1069, 326);
            this.btnFileRequest.Name = "btnFileRequest";
            this.btnFileRequest.Size = new System.Drawing.Size(219, 188);
            this.btnFileRequest.TabIndex = 3;
            this.btnFileRequest.Text = "File Request";
            this.btnFileRequest.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFileRequest.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.BackColor = System.Drawing.Color.Gray;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(1238, 55);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(50, 50);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountName.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.Color.Black;
            this.lblAccountName.Location = new System.Drawing.Point(1160, 55);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(72, 19);
            this.lblAccountName.TabIndex = 8;
            this.lblAccountName.Text = "Username";
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.Black;
            this.lblUserRole.Location = new System.Drawing.Point(1140, 86);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(92, 19);
            this.lblUserRole.TabIndex = 9;
            this.lblUserRole.Text = "Administrator";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(270, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 37);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Good Day, User";
            // 
            // HomeViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.DragWindowsPanel);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnFileRequest);
            this.Controls.Add(this.btnEnrolledStudents);
            this.Controls.Add(this.NewsPanel);
            this.Controls.Add(this.SideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeViewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeViewAdmin_FormClosing);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.SideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LGAConnectLogo)).EndInit();
            this.DragWindowsPanel.ResumeLayout(false);
            this.NewsPanel.ResumeLayout(false);
            this.NewsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsImage)).EndInit();
            this.NewsPanelYellow.ResumeLayout(false);
            this.NewsPanelYellow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel NewsPanel;
        private System.Windows.Forms.Label lblArticelDescription;
        private System.Windows.Forms.Label lblArticleTitle;
        private System.Windows.Forms.PictureBox NewsImage;
        private System.Windows.Forms.Panel NewsPanelYellow;
        private System.Windows.Forms.Button btnEnrolledStudents;
        private System.Windows.Forms.Button btnFileRequest;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblTitleNewsPanel;
        private System.Windows.Forms.Label lblvViewMoreNews;
        private System.Windows.Forms.PictureBox LGAConnectLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClassRecords;
        private System.Windows.Forms.Button btnClassSchedule;
        private System.Windows.Forms.Button btnManageNews;
        private System.Windows.Forms.Button btnPaymentRecords;
        public System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel DragWindowsPanel;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnMaximize;
    }
}

