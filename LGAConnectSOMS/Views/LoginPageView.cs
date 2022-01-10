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
    public partial class LoginPageView : Form
    {       
        public LoginPageView()
        {
            InitializeComponent();           
        }

        private void LoginPageView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            txtPasswordSize();
            panel1.Hide();
        }

        //NavigationToOtherForm

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            panel1.Show();
            LoginService loginService = new LoginService();
            var result = await loginService.AccountLogin(new LoginRequest
            {
                Username = txtAccountID.Text,
                Password = txtPassword.Text
            });
            
            if (result.IsSuccess)
            {
               
                await Task.Delay(1000);
                if (result.IsAdmin == 1)
                {

                    //save to persitence data                    
                    SavePersistentData(result.ID, result.Firstname, result.Lastname, result.Fullname, result.IsAdmin, result.TeacherProfile);
                    this.SaveWindowPosition();
                    HomeViewAdmin homeViewAdmin = new HomeViewAdmin();                  
                    homeViewAdmin.Show();
                    this.Hide();
                    panel1.Hide();

                }

                else
                {
                    //save to persitence data
                    SavePersistentData(result.ID, result.Firstname, result.Lastname, result.Fullname, result.IsAdmin, result.TeacherProfile);
                    this.SaveWindowPosition();
                    HomeViewTeacher homeViewTeacher = new HomeViewTeacher();
                    panel1.Hide();
                    homeViewTeacher.Show();
                    this.Hide();
                }
            }
            else
            {
                panel1.Hide();
                string message = "Incorrect password or ID";
                string title = "Login failed";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        public void SavePersistentData(int ID, string firstname, string lastname, string fullname, int isAdmin, byte[] TeacherProfile)
        {
            string teacherprofile = System.Convert.ToBase64String(TeacherProfile);
            Settings.Default.ID = ID;
            Settings.Default.Firstname = firstname;
            Settings.Default.Lastname = lastname;
            Settings.Default.Fullname = fullname;
            Settings.Default.IsAdmin = isAdmin;
            Settings.Default.TeacherProfile =  teacherprofile;
        }
        //private async Task<StudentAccount> GetStudentAccountById(int id)
        //{
        //    StudentService studentservice = new StudentService();
        //    var result = await studentservice.GetStudentAccountById(id);
        //    return result;
        //}

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

        private void LoginPageView_FormClosing(object sender, FormClosingEventArgs e)
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
        private void DragWindowsPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
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

        private void lblShowHide_Click(object sender, EventArgs e)
        {  
                if (lblShowHide.Text == "Show")
                {
                    lblShowHide.Text = "Hide";
                    txtPassword.UseSystemPasswordChar = true;
                }

                else
                {
                    txtPassword.UseSystemPasswordChar = false;
                    lblShowHide.Text = "Show";
                }
  
        }

        public void txtPasswordSize()
        {
            txtPassword.Size = new System.Drawing.Size(422, 43);
            lblShowHide.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == string.Empty)
            {
                txtPasswordSize();
            }

            else
            {
                txtPassword.Size = new System.Drawing.Size(365, 43);
                lblShowHide.Show();
              
            }
            
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(240, 52, 52);
            btnClose.Image = LGAConnectSOMS.Properties.Resources.close_button;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.Image = LGAConnectSOMS.Properties.Resources.CloseBlack;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            ForgotPasswordView forgotPasswordView = new ForgotPasswordView();
            forgotPasswordView.Show();
            this.Hide();
        }
    }
}
