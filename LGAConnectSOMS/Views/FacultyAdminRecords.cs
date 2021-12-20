using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            
            lblLoading.Hide();
            this.RestoreWindowPosition();
            MaximizeIcon();
            LoadData();           
        }

        private async void LoadData()
        {          
            lblLoading.Show();                           
            await DisplayFacultyRecordData();
            await DisplayAdminRecordData();                        
            lblLoading.Hide();          
        }
        public async Task DisplayAdminRecordData()
        {            
            var AdminList = schoolAccounts.Where(x => x.isAdmin == 1).ToList();           
            AdminDataGridView.DataSource = AdminList;
            AdminDataGridView.CurrentCell = null;
            this.AdminDataGridView.Columns[6].Visible = false;           
        }
        public async Task DisplayFacultyRecordData()
        {
            SchoolAccountService schoolAccountService = new SchoolAccountService();
            schoolAccounts = await Task.Run(() => schoolAccountService.GetSchoolAccountDetails());
            var facultylist = schoolAccounts.Where(x => x.isAdmin == 0).ToList();
            FacultyDataGridView.DataSource = facultylist;
            FacultyDataGridView.CurrentCell = null;
            this.FacultyDataGridView.Columns[6].Visible = false;           
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 0)
            //{
            //   DisplayFacultyRecordData();  
            //}

            //else if (tabControl1.SelectedIndex == 1)
            //{
            //    DisplayAdminRecordData();
            //}
        }

        private void btnUploadAdminProfile_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(open.FileName);
                if (fs.Length > 1000000)
                {
                    MessageBox.Show("Maximum file size is 1MB");
                    return;
                }
                else
                {
                    AdminPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    AdminPictureBox.Image = new Bitmap(open.FileName);
                    var image = AdminPictureBox.Image;
                    ImageToByteArray(image);
                }
                // display image in picture box
                
                // image file path                          
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private async void btnAddAdministrator_Click(object sender, EventArgs e)
        {            
            var image = AdminPictureBox.Image;
            try
            {
                SchoolAccountRequestService schoolAccountRequestService = new SchoolAccountRequestService();
                var IsSuccess = await schoolAccountRequestService.CreateSchoolAccountRequest(new SchoolAccountRequest
                {
                    LastName = txtLastname.Text,
                    Middlename = txtMiddlename.Text,
                    Firstname = txtFirstname.Text,
                    SchoolNumber = txtTeacherNumber.Text,
                    Password = txtPassword.Text,
                    TeacherProfile = ImageToByteArray(image),
                    MobileNumber = txtMobileNumber.Text,
                    Gender = cbGender.Text,
                    IsAdmin = 1,
                    IsFaculty = 0
                });

                if (IsSuccess)
                {
                    string message = "Added new Administrator Successfully";
                    string title = "New Administrator account created";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }

                else
                {                    
                    string message = "Added new Administrator Unsucessfull";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);                 
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void AdminDataGridView_Click(object sender, EventArgs e)
        {
            EditSchoolAccountDetails editSchoolAccountDetails = new EditSchoolAccountDetails();
            editSchoolAccountDetails.txtID.Text = AdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            editSchoolAccountDetails.txtLastname.Text = AdminDataGridView.CurrentRow.Cells[1].Value.ToString();
            editSchoolAccountDetails.txtMiddlename.Text = AdminDataGridView.CurrentRow.Cells[2].Value.ToString();
            editSchoolAccountDetails.txtFirstname.Text = AdminDataGridView.CurrentRow.Cells[3].Value.ToString();
            editSchoolAccountDetails.txtTeacherNumber.Text = AdminDataGridView.CurrentRow.Cells[4].Value.ToString();
            editSchoolAccountDetails.txtPassword.Text = AdminDataGridView.CurrentRow.Cells[5].Value.ToString();
            byte[] image = (byte[])AdminDataGridView.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(image);
            editSchoolAccountDetails.AdminPicturebox.Image = Image.FromStream(ms);
            editSchoolAccountDetails.txtMobileNumber.Text = AdminDataGridView.CurrentRow.Cells[7].Value.ToString();
            editSchoolAccountDetails.cbGender.Text = AdminDataGridView.CurrentRow.Cells[8].Value.ToString();
            editSchoolAccountDetails.ShowDialog();
        }
      
        private void txtAdminLastname_TextChanged(object sender, EventArgs e)
        {
            var lastname = txtAdminLastname.Text;
            var listbyLastname = schoolAccounts.Where(x => x.lastName.ToString().ToLower().Contains(lastname) && x.isAdmin == 1).ToList();
            AdminDataGridView.DataSource = listbyLastname;          
            AdminDataGridView.CurrentCell = null;           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var lastname = txtSearchFaculty.Text;
            var listbyLastname = schoolAccounts.Where(x => x.lastName.ToString().ToLower().Contains(lastname) && x.isAdmin == 0).ToList();
            FacultyDataGridView.DataSource = listbyLastname;
            FacultyDataGridView.CurrentCell = null;
        }

        private void FacultyDataGridView_Click(object sender, EventArgs e)
        {
            EditSchoolFacultyAccountDetails editSchoolFacultyAccountDetails = new EditSchoolFacultyAccountDetails();
            editSchoolFacultyAccountDetails.txtID.Text = FacultyDataGridView.CurrentRow.Cells[0].Value.ToString();
            editSchoolFacultyAccountDetails.txtLastname.Text = FacultyDataGridView.CurrentRow.Cells[1].Value.ToString();
            editSchoolFacultyAccountDetails.txtMiddlename.Text = FacultyDataGridView.CurrentRow.Cells[2].Value.ToString();
            editSchoolFacultyAccountDetails.txtFirstname.Text = FacultyDataGridView.CurrentRow.Cells[3].Value.ToString();
            editSchoolFacultyAccountDetails.txtTeacherNumber.Text = FacultyDataGridView.CurrentRow.Cells[4].Value.ToString();
            editSchoolFacultyAccountDetails.txtPassword.Text = FacultyDataGridView.CurrentRow.Cells[5].Value.ToString();
            byte[] image = (byte[])FacultyDataGridView.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(image);           
            editSchoolFacultyAccountDetails.FacultyPicturebox.Image = Image.FromStream(ms);
            editSchoolFacultyAccountDetails.txtMobileNumber.Text = FacultyDataGridView.CurrentRow.Cells[7].Value.ToString();
            editSchoolFacultyAccountDetails.cbGender.Text = FacultyDataGridView.CurrentRow.Cells[8].Value.ToString();
            editSchoolFacultyAccountDetails.ShowDialog();
        }
    }
}
