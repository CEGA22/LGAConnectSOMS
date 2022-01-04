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
    public partial class ForgotPasswordView : Form
    {
        public ForgotPasswordView()
        {
            InitializeComponent();          
        }

        private void ForgotPasswordView_Load(object sender, EventArgs e)
        {
            RestoreWindowPosition();
            MaximizeIcon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var login = new LoginPageView();
            login.Show();
            this.Hide();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrowYellow24;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrow24;
        }

        IEnumerable<SchoolAccount> studentAccounts = new List<SchoolAccount>();       
        private async void btnRetrieve_Click(object sender, EventArgs e)
        {                   
            var email = txtEmail.Text;
            SchoolAccountService schoolAccountService = new SchoolAccountService();
            var students = await schoolAccountService.GetSchoolAccountPassword(email);
            studentAccounts = students.ToList();
            if (studentAccounts.Any())
            {

                foreach (var password in studentAccounts)
                {
                    string Successmessage = "Your Password: " + password.password;
                    string Successtitle = "Retrieve password";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, buttons, MessageBoxIcon.Information);
                  if (Successresult == DialogResult.OK)
                  {
                        txtEmail.Text = "";           
                  }                                                                         
                }
            }

            else
            {
                string UnSuccessmessage = "Retrieve password unsuccessfull. Cannot find email address";
                string UnSuccesstitle = "Retrieve password Unsucessfull";             
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult Successresult = MessageBox.Show(UnSuccessmessage, UnSuccesstitle, buttons, MessageBoxIcon.Error);
                if (Successresult == DialogResult.OK)
                {
                    
                }
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

        private void ClassRecordAdminView_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
