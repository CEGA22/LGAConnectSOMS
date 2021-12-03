using LGAConnectSOMS.Properties;
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
    public partial class HomeViewTeacher : Form
    {
        public HomeViewTeacher()
        {
            InitializeComponent();
        }

        private void HomeViewTeacher_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            Menu.Hide();
            lblAccountName.Text = Settings.Default.Fullname;
            lblTitle.Text = "Good Day, " + Settings.Default.Firstname;
        }


        //NavigationToOtherForm
        private void btnClassRecords_Click(object sender, EventArgs e)
        {
            ClassRecordFacultyView classRecordFacultyView = new ClassRecordFacultyView();
            classRecordFacultyView.Show();
            this.Hide();
        }

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            ClassScheduleFacultyView classScheduleFacultyView = new ClassScheduleFacultyView();
            classScheduleFacultyView.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SaveWindowPosition();
            Settings.Default.ID = 0;
            Settings.Default.Firstname = null;
            Settings.Default.Lastname = null;
            Settings.Default.Fullname = null;
            LoginPageView loginPageView = new LoginPageView();
            loginPageView.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            IsMenuVisible();
        }

        public void IsMenuVisible()
        {
            if (Menu.Visible == false)
            {
                Menu.Show();
            }

            else if (panel1.Visible == true)
            {
                Menu.Hide();
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

        

        private void HomeViewTeacher_FormClosing(object sender, FormClosingEventArgs e)
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




        //DragWIindows

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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            AboutPageView aboutPageView = new AboutPageView();
            aboutPageView.Show();
            this.Hide();
        }
    }
}
