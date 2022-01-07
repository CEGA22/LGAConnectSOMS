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
            txtAdminLastname.Enabled = false;
            txtSearchFaculty.Enabled = false;
            await DisplayFacultyRecordData();
            await DisplayAdminRecordData();
            RandomAdminNumber();
            RandomFacultyNumber();
            lblLoading.Hide();          
        }

        private readonly Random _random = new Random();
        List<int> AdminnumberList = new List<int>();
        StringBuilder concatenatedString = new StringBuilder();
        public void RandomAdminNumber()
        {
            var result = verification();
            var students = schoolAccounts.ToList();
            var results = schoolAccounts.Where(x => x.schoolNumber.ToString().Contains(result)).ToList();
            if (!results.Any())
            {
                txtTeacherNumber.Text = result;
            }

            else
            {
                AdminnumberList.Clear();
                concatenatedString.Clear();
                RandomAdminNumber();
            }
        }

        public string verification()
        {
            var num1 = 0;
            var num2 = 0;
            AdminnumberList.Add(num1);
            AdminnumberList.Add(num2);
            for (int i = 1; i <= 8; i++)
            {
                int num = _random.Next(10);
                var studentnumber = num;
                AdminnumberList.Add(studentnumber);
            }

            foreach (int password in AdminnumberList)
            {
                concatenatedString.Append(password);
            }

            return concatenatedString.ToString();
        }


        private readonly Random _randomFaculty = new Random();
        List<int> FacultynumberList = new List<int>();
        StringBuilder concatenatedStringFaculty = new StringBuilder();
        public void RandomFacultyNumber()
        {
            var result = verificationFaculty();
            var students = schoolAccounts.ToList();
            var results = schoolAccounts.Where(x => x.schoolNumber.ToString().Contains(result)).ToList();
            if (!results.Any())
            {
                txtFacultyTeacherNumber.Text = result;
            }

            else
            {
                FacultynumberList.Clear();
                concatenatedString.Clear();
                RandomFacultyNumber();
            }
        }

        public string verificationFaculty()
        {
            var num1 = 0;
            var num2 = 0;
            FacultynumberList.Add(num1);
            FacultynumberList.Add(num2);
            for (int i = 1; i <= 8; i++)
            {
                int num = _randomFaculty.Next(10);
                var studentnumber = num;
                FacultynumberList.Add(studentnumber);
            }

            foreach (int password in FacultynumberList)
            {
                concatenatedStringFaculty.Append(password);
            }

            return concatenatedStringFaculty.ToString();
        }

        public async Task DisplayAdminRecordData()
        {
            lblloadingadmin.Show();
            var AdminList = schoolAccounts.Where(x => x.isAdmin == 1).ToList();           
            AdminDataGridView.DataSource = AdminList;
            lblloadingadmin.Hide();
            txtAdminLastname.Enabled = true;
            AdminDataGridView.CurrentCell = null;
            this.AdminDataGridView.Columns[6].Visible = false;           
        }
        public async Task DisplayFacultyRecordData()
        {
            lblLoading.Show();
            SchoolAccountService schoolAccountService = new SchoolAccountService();
            schoolAccounts = await Task.Run(() => schoolAccountService.GetSchoolAccountDetails());
            var facultylist = schoolAccounts.Where(x => x.isAdmin == 0).ToList();
            FacultyDataGridView.DataSource = facultylist;
            lblLoading.Hide();
            txtSearchFaculty.Enabled = true;
            FacultyDataGridView.CurrentCell = null;
            this.FacultyDataGridView.Columns[0].Visible = false;
            this.FacultyDataGridView.Columns[6].Visible = false;
            this.FacultyDataGridView.Columns[9].Visible = false;
            this.FacultyDataGridView.Columns[13].Visible = false;
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

        private void btnUploadFacultyProfile_Click(object sender, EventArgs e)
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
                    FacultyPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    FacultyPictureBox.Image = new Bitmap(open.FileName);
                    var image = FacultyPictureBox.Image;
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
            var dateonly = dtAdminBirthday.Value.ToShortDateString();
            if (txtLastname.Text == "" || txtMiddlename.Text == "" || txtFirstname.Text == "" || txtTeacherNumber.Text == "" || txtPassword.Text == "" || txtMobileNumber.Text == "" || cbGender.Text == "" || txtAdminAddress.Text == "" || txtAdminEmail.Text == "" || AdminPictureBox.Image == null)
            {
                string message = "Please Fill in All Fields!";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }
            else
            {
                try
                {
                    SchoolAccountRequestService schoolAccountRequestService = new SchoolAccountRequestService();
                    var IsSuccess = await schoolAccountRequestService.CreateSchoolAccountRequest(new SchoolAccountRequest
                    {
                        LastName = txtLastname.Text,
                        Middlename = txtMiddlename.Text,
                        Firstname = txtFirstname.Text,
                        Birthday = Convert.ToDateTime(dateonly),
                        Address = txtAdminAddress.Text,
                        Email = txtAdminEmail.Text,
                        SchoolNumber = txtTeacherNumber.Text,
                        Password = txtPassword.Text,
                        MobileNumber = txtMobileNumber.Text,                      
                        Gender = cbGender.Text,
                        IsAdmin = 1,
                        IsFaculty = 0,
                        TeacherProfile = ImageToByteArray(image),
                    });

                    if (IsSuccess)
                    {
                        string message = "Added new Administrator Successfully";
                        string title = "New Administrator account created";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                        txtLastname.Text = "";
                        txtMiddlename.Text = "";
                        txtFirstname.Text = "";
                        txtTeacherNumber.Text = "";
                        txtPassword.Text = "";
                        txtMobileNumber.Text = "";
                        cbGender.Text = "";
                        txtAdminAddress.Text = "";
                        txtAdminEmail.Text = "";
                        AdminPictureBox.Image = null;
                    }

                    else
                    {
                        string message = "Added new Administrator Unsucessful";
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
            editSchoolAccountDetails.dtBirthday.Text = AdminDataGridView.CurrentRow.Cells[10].Value.ToString();
            editSchoolAccountDetails.txtAddress.Text = AdminDataGridView.CurrentRow.Cells[11].Value.ToString();
            editSchoolAccountDetails.txtEmail.Text = AdminDataGridView.CurrentRow.Cells[12].Value.ToString();
            editSchoolAccountDetails.ShowDialog();
        }
      
        private void txtAdminLastname_TextChanged(object sender, EventArgs e)
        {
            var lastname = txtAdminLastname.Text;
            var listbyLastname = schoolAccounts.Where(x => x.lastName.ToString().Contains(lastname) && x.isAdmin == 1).ToList();
            AdminDataGridView.DataSource = listbyLastname;          
            AdminDataGridView.CurrentCell = null;           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var lastname = txtSearchFaculty.Text;
            var listbyLastname = schoolAccounts.Where(x => x.lastName.ToString().Contains(lastname) && x.isAdmin == 0).ToList();
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
                editSchoolFacultyAccountDetails.dtBirthday.Text = FacultyDataGridView.CurrentRow.Cells[10].Value.ToString();
                editSchoolFacultyAccountDetails.txtAddress.Text = FacultyDataGridView.CurrentRow.Cells[11].Value.ToString();
                editSchoolFacultyAccountDetails.txtEmail.Text = FacultyDataGridView.CurrentRow.Cells[12].Value.ToString();
                editSchoolFacultyAccountDetails.ShowDialog();                     
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var image = FacultyPictureBox.Image;
            var dateonly = dtBirthday.Value.ToShortDateString();
            if (txtFacultyLastname.Text == "" || txtFacultyMiddlename.Text == "" || txtFacultyFirstname.Text == "" || txtFacultyTeacherNumber.Text == "" || txtFacultyPassword.Text == "" || txtFacultyMobileNumber.Text == "" || cbFacultyGender.Text == "" || txtFacultyAddress.Text == "" || txtFacultyEmail.Text == "" || FacultyPictureBox.Image == null)
            {
                string message = "Please Fill in All Fields!";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else
            {
                try
                {
                    SchoolAccountRequestService schoolAccountRequestService = new SchoolAccountRequestService();
                    var IsSuccess = await schoolAccountRequestService.CreateSchoolAccountRequest(new SchoolAccountRequest
                    {
                        LastName = txtFacultyLastname.Text,
                        Middlename = txtFacultyMiddlename.Text,
                        Firstname = txtFacultyFirstname.Text,
                        Birthday = Convert.ToDateTime(dateonly),
                        Address = txtFacultyAddress.Text,
                        Email = txtFacultyEmail.Text,
                        SchoolNumber = txtFacultyTeacherNumber.Text,
                        Password = txtFacultyPassword.Text,
                        MobileNumber = txtFacultyMobileNumber.Text,                        
                        Gender = cbFacultyGender.Text,                       
                        IsAdmin = 0,
                        IsFaculty = 1,
                        TeacherProfile = ImageToByteArray(image),
                    });

                    if (IsSuccess)
                    {
                        string message = "Added new Faculty Successfully";
                        string title = "New Faculty account created";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                        txtFacultyLastname.Text = "";
                        txtFacultyMiddlename.Text = "";
                        txtFacultyFirstname.Text = "";
                        txtFacultyTeacherNumber.Text = "";
                        txtFacultyPassword.Text = "";
                        txtFacultyMobileNumber.Text = "";
                        cbFacultyGender.Text = "";
                        txtFacultyAddress.Text = "";
                        txtFacultyEmail.Text = "";
                        FacultyPictureBox.Image = null;
                    }

                    else
                    {
                        string message = "Added new Faculty Unsucessful";
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
              
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTeacherNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
     
        private void txtFacultyLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFacultyMiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFacultyFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFacultyTeacherNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //    e.Handled = true;
        }

        

        private void cbFacultyGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtFacultyMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            FacultyDataGridView.DataSource = null;
            await DisplayFacultyRecordData();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            AdminDataGridView.DataSource = null;
            await DisplayAdminRecordData();
        }
    }
}
