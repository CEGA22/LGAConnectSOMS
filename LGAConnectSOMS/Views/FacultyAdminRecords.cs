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
    public partial class FacultyAdminRecords : Form
    {
        IEnumerable<SchoolAccount> schoolAccounts = new List<SchoolAccount>();
        public FacultyAdminRecords()
        {
            InitializeComponent();
        }

        //Load
        private void FacultyAdminRecords_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();        
            MaximizeIcon();
            DisplayFacultyRecordData();
            DisplayAdminRecordData();
        }

        public async Task DisplayAdminRecordData()
        {         
            var AdminList = schoolAccounts.Where(x => x.isAdmin == 1).ToList();
            AdminDataGridView.DataSource = AdminList;
            AdminDataGridView.CurrentCell = null;
        }
        public async Task DisplayFacultyRecordData()
        {
            SchoolAccountService schoolAccountService = new SchoolAccountService();
            schoolAccounts = await schoolAccountService.GetSchoolAccountDetails();
            var facultylist = schoolAccounts.Where(x => x.isAdmin == 0).ToList();
            FacultyDataGridView.DataSource = facultylist;
            FacultyDataGridView.CurrentCell = null;
        }

        //NavigateToOtherForms
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var HVA = new HomeViewAdmin();
            HVA.Show();
            this.Hide();
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

        private void FacultyAdminRecords_FormClosing(object sender, FormClosingEventArgs e)
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

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                await DisplayFacultyRecordData();
            }

            else if(tabControl1.SelectedIndex == 1)
            {
                await DisplayAdminRecordData();
               
            }
        }

        private async void txtAdminLastname_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtAdminLastname.Text))
            {
                var lastname = txtAdminLastname.Text;
                var AdminLastname = schoolAccounts.Where(x => x.lastName.Contains(lastname)).Any();
                AdminDataGridView.DataSource = AdminLastname;
                AdminDataGridView.CurrentCell = null;
            }

            else
            {
                await DisplayAdminRecordData();
            }
        }
    }
}
