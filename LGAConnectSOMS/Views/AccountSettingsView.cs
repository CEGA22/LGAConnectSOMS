using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class AccountSettingsView : Form
    {
        public AccountSettingsView()
        {
            InitializeComponent();
        }


        //Load
        private void AccountSettingsView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            var profile = Settings.Default.TeacherProfile;
            byte[] convertprofile = System.Convert.FromBase64String(profile);
            var imageMemoryStream = new MemoryStream(convertprofile);
            Image imgFromStream = Image.FromStream(imageMemoryStream);
            AccountProfilePictureBox.Image = imgFromStream;
            lblAccountName.Text = Settings.Default.Fullname;
        }

        //NavigateToOtherForm
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Settings.Default.IsAdmin == 1)
            {
                this.SaveWindowPosition();
                var HVA = new HomeViewAdmin();
                HVA.Show();
                this.Hide();
            }

            else if(Settings.Default.IsAdmin == 0)
            {
                this.SaveWindowPosition();
                HomeViewTeacher homeViewTeacher = new HomeViewTeacher();
                homeViewTeacher.Show();
                this.Hide();
            }           
        }

        //TitleBarFunction
        private void RestoreWindowPosition()
        {

            try
            {
                if (Settings.Default.HasSetDefault)
                {
                    this.WindowState = Settings.Default.WindowState;
                    this.Location = Settings.Default.Location;
                    this.Size = Settings.Default.Size;


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void AccountSettingsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.SaveWindowPosition();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveWindowPosition()
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {

                throw;
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
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;

                }
                _mouseLoc = e.Location;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DragWindowsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int dx = e.Location.X - _mouseLoc.X;
                    int dy = e.Location.Y - _mouseLoc.Y;
                    this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MaximizeIcon()
        {

            try
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
            catch (Exception)
            {

                throw;
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

        private async void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var ID = Settings.Default.ID;
            if(string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("Please enter your current password", "LGA Connect SOMS");
            }

            else if(string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter your new password", "LGA Connect SOMS");
            }

            else if(string.IsNullOrWhiteSpace(txtRetypeNewPassword.Text))
            {
                MessageBox.Show("Please Re-type your new password", "LGA Connect SOMS");
            }

            else
            {
                try
                {
                    if (txtNewPassword.Text == txtRetypeNewPassword.Text)
                    {
                        SchoolAccountRequestService schoolAccountRequestService = new SchoolAccountRequestService();
                        var IsSucess = await schoolAccountRequestService.UpdateSchoolAccountPassword(new SchoolAccountRequest
                        {
                            id = ID,
                            Password = txtNewPassword.Text
                        });

                        if (IsSucess)
                        {
                            MessageBox.Show("Updated Successfully", "LGA Connect SOMS");
                        }
                        else
                        {
                            MessageBox.Show("Error. Please Try Again", "LGA Connect SOMS");
                        }
                    }

                    else
                    {
                        MessageBox.Show("You must enter the same password twice in order to confirm it", "LGA Connect SOMS");
                    }
                }
                catch (Exception x)
                {                   
                }
            }
        }
    }
}
