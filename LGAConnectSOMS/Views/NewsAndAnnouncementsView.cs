using LGAConnectSOMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class NewsAndAnnouncementsView : Form
    {
        public NewsAndAnnouncementsView()
        {
            InitializeComponent();
        }

        //Load
        private void NewsAndAnnouncementsView_Load(object sender, EventArgs e)
        {
            //LoadData();
            this.RestoreWindowPosition();
            MaximizeIcon();          
        }
      
        //NavigationToOtherForm       
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if(Settings.Default.IsAdmin == 1)
            {
                this.SaveWindowPosition();
                var LatestNewsList = new ManageNewsView();
                LatestNewsList.Show();
                this.Hide();
            }

            else if(Settings.Default.IsAdmin == 0)
            {
                this.SaveWindowPosition();
                var LatestNewsList = new ManageNewsView();
                LatestNewsList.BtnAddNews.Hide();
                LatestNewsList.Show();
                this.Hide();
            }
            
        }

        //Buttons Forecolor and background Styles

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrowYellow24;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrow24;
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

        private void ManageNewsView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnEditNews_Click(object sender, EventArgs e)
        {
            EditAddNewsView editAddNewsView = new EditAddNewsView();
            editAddNewsView.txtID.Text = lblID.Text;
            editAddNewsView.txtTitle.Text = lblTitle.Text;
            editAddNewsView.rtContent.Text = lblContent.Text;
            editAddNewsView.ContentPhotoPictureBox.Image = ContentPhotoPictureBox.Image;
            //editAddNewsView.txtAuthorsName.Text = btnAuthor.Text;
            editAddNewsView.NewsDateTimePicker.Text = btnDate.Text;
            editAddNewsView.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
