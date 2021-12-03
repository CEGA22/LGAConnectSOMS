using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class AboutPageView : Form
    {
        public AboutPageView()
        {
            InitializeComponent();

            
        }

        private async void AboutPageView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            await AboutDisplay();
        }

        public List<About> aboutlist;      
        public async Task AboutDisplay()
        {
            AboutServices aboutservices = new AboutServices();
            var aboutitems = await aboutservices.GetClassAboutDetails();
            aboutlist = aboutitems.ToList();
            foreach (About about in aboutlist)
            {
                Label SchoolInfo = new Label();
                Label Mission = new Label();
                Label Vision = new Label();
                Label AppInfo = new Label();
                Label schoolinfotitle = new Label();
                Label Missiontitle = new Label();
                Label VisionTitle = new Label();
                Label AppinfoTitle = new Label();
                Panel line = new Panel();
                Panel MissionLine = new Panel();
                Panel VisionLine = new Panel();
                Panel AppInfoLine = new Panel();
                Panel frame = new Panel();
                Panel MissionFrame = new Panel();
                Panel VisionFrame = new Panel();
                Panel AppInfoFrame = new Panel();
                MissionFrame.Size = new Size(1271, 500);
                MissionFrame.BackColor = Color.White;
                VisionFrame.Size = new Size(1271, 300);
                VisionFrame.BackColor = Color.White;
                AppInfoFrame.Size = new Size(1271, 300);
                AppInfoFrame.BackColor = Color.White;
                frame.Name = "Panel1";
                frame.Size = new System.Drawing.Size(1271, 150);
                frame.BackColor = Color.White;
                line.Size = new Size(1000, 3);
                line.BackColor = Color.FromArgb(255, 246, 143);
                line.Location = new System.Drawing.Point(25, 50);

                MissionLine.Size = new Size(1000, 3);
                MissionLine.BackColor = Color.FromArgb(255, 246, 143);
                MissionLine.Location = new System.Drawing.Point(25, 50);

                VisionLine.Size = new Size(1000, 3);
                VisionLine.BackColor = Color.FromArgb(255, 246, 143);
                VisionLine.Location = new System.Drawing.Point(25, 50);

                AppInfoLine.Size = new Size(1000, 3);
                AppInfoLine.BackColor = Color.FromArgb(255, 246, 143);
                AppInfoLine.Location = new System.Drawing.Point(25, 50);

                frame.BackColor = Color.White;

                schoolinfotitle.Font = new Font("TW Cen MT", 20);
                schoolinfotitle.Text = "About Ladder of Gems Academy";
                schoolinfotitle.ForeColor = ColorTranslator.FromHtml("#000");
                schoolinfotitle.Location = new System.Drawing.Point(25, 10);
                schoolinfotitle.AutoSize = true;

                Missiontitle.Font = new Font("TW Cen MT", 20);
                Missiontitle.Text = "Mission";
                Missiontitle.ForeColor = ColorTranslator.FromHtml("#000");
                Missiontitle.Location = new System.Drawing.Point(25, 10);
                Missiontitle.AutoSize = true;

                VisionTitle.Font = new Font("TW Cen MT", 20);
                VisionTitle.Text = "Vision";
                VisionTitle.ForeColor = ColorTranslator.FromHtml("#000");
                VisionTitle.Location = new System.Drawing.Point(25, 10);
                VisionTitle.AutoSize = true;

                AppinfoTitle.Font = new Font("TW Cen MT", 20);
                AppinfoTitle.Text = "LGA Connect School Operations Management System";
                AppinfoTitle.ForeColor = ColorTranslator.FromHtml("#000");
                AppinfoTitle.Location = new System.Drawing.Point(25, 10);
                AppinfoTitle.AutoSize = true;

                SchoolInfo.Font = new Font("TW Cen MT", 16);
                SchoolInfo.Text = about.SchoolInfo;
                SchoolInfo.ForeColor = ColorTranslator.FromHtml("#000");
                Mission.Font = new Font("TW Cen MT", 16);
                Mission.Text = about.Mission;
                Mission.ForeColor = ColorTranslator.FromHtml("#000");

                Vision.Font = new Font("TW Cen MT", 16);
                Vision.Text = about.Vision;
                Vision.ForeColor = ColorTranslator.FromHtml("#000");

                AppInfo.Font = new Font("TW Cen MT", 16);
                AppInfo.Text = about.AppInfoSOMS;
                AppInfo.ForeColor = ColorTranslator.FromHtml("#000");

                SchoolInfo.Location = new System.Drawing.Point(25, 80);
                SchoolInfo.AutoSize = true;

                Mission.Location = new System.Drawing.Point(25, 90);
                Mission.AutoSize = true;

                Vision.Location = new System.Drawing.Point(25, 90);
                Vision.AutoSize = true;

                AppInfo.Location = new System.Drawing.Point(25, 90);
                AppInfo.AutoSize = true;

                frame.Controls.Add(schoolinfotitle);
                frame.Controls.Add(line);
                frame.Controls.Add(SchoolInfo);
                MissionFrame.Controls.Add(Mission);
                MissionFrame.Controls.Add(Missiontitle);
                MissionFrame.Controls.Add(MissionLine);
                VisionFrame.Controls.Add(Vision);
                VisionFrame.Controls.Add(VisionTitle);
                VisionFrame.Controls.Add(VisionLine);
                AppInfoFrame.Controls.Add(AppinfoTitle);
                AppInfoFrame.Controls.Add(AppInfoLine);
                AppInfoFrame.Controls.Add(AppInfo);
                AboutPanel.Controls.Add(frame);
                AboutPanel.Controls.Add(MissionFrame);
                AboutPanel.Controls.Add(VisionFrame);
                AboutPanel.Controls.Add(AppInfoFrame);
                frame.Margin = new Padding(0, 0, 0, 20);
                MissionFrame.Margin = new Padding(0, 0, 0, 20);
                VisionFrame.Margin = new Padding(0, 0, 0, 20);
                AppInfoFrame.Margin = new Padding(0, 0, 0, 20);


            }



        }

        //TitleBarFunction

        private void RestoreWindowPosition()
        {

            if (Settings.Default.HasSetDefault)
            {
                this.WindowState = Settings.Default.WindowState;
                this.Location = Settings.Default.Location;
                this.Size = Settings.Default.Size;

            }
        }

        private void AboutPageView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveWindowPosition();
        }

        private void SaveWindowPosition()
        {
            Settings.Default.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.Location = this.Location;
                Settings.Default.Size = this.Size;

            }
            else
            {
                Settings.Default.Location = this.RestoreBounds.Location;
                Settings.Default.Size = this.RestoreBounds.Size;
            }

            Settings.Default.HasSetDefault = true;

            Settings.Default.Save();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.NormalBlack;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //DragWindows
        private Point _mouseLoc;

        private void DragWindowsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            _mouseLoc = e.Location;
        }

        private void DragWindowsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        public void MaximizeIcon()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.NormalBlack;
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            }
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrowYellow24;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrow24;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            HomeViewAdmin homeViewAdmin = new HomeViewAdmin();
            homeViewAdmin.Show();
            this.Hide();
        }
    }
}
