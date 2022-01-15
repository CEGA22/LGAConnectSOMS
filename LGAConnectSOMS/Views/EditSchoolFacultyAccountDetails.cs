using LGAConnectSOMS.Models;
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
    public partial class EditSchoolFacultyAccountDetails : Form
    {
        public EditSchoolFacultyAccountDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                FacultyPicturebox.SizeMode = PictureBoxSizeMode.Zoom;
                FacultyPicturebox.Image = new Bitmap(open.FileName);
                var image = FacultyPicturebox.Image;
                ImageToByteArray(image);
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

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text);
            var image = FacultyPicturebox.Image;
            var dateonly = dtBirthday.Value.ToShortDateString();
            try
            {
                SchoolAccountRequestService schoolAccountRequestService = new SchoolAccountRequestService();
                var IsSuccess = await schoolAccountRequestService.UpdateSchoolAccountRequest(new SchoolAccountRequest
                {
                    id = id,
                    LastName = txtLastname.Text,
                    Middlename = txtMiddlename.Text,
                    Firstname = txtFirstname.Text,
                    SchoolNumber = txtTeacherNumber.Text,
                    Password = txtPassword.Text,
                    TeacherProfile = ImageToByteArray(image),
                    MobileNumber = txtMobileNumber.Text,
                    Birthday = Convert.ToDateTime(dateonly),
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Gender = cbGender.Text,
                    IsAdmin = 0
                }); ;

                if (IsSuccess)
                {
                    string Successmessage = "You have updated Faculty Details";
                    string Successtitle = "LGA Connect SOMS Faculty records";
                    MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                    DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                    if (Successresult == DialogResult.OK)
                    {
                        this.Hide();
                    }                    
                }

                else
                {
                    MessageBox.Show("Update Faculty Details Unsuccessful");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnDeleteFacultyDetails_Click(object sender, EventArgs e)
        {
            string message = "Are you sure do you want to delete this account?";
            string title = "Delete Faculty Account";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var id = int.Parse(txtID.Text);
                    SchoolAccountRequestService schoolAccountRequestService = new SchoolAccountRequestService();
                    var IsSuccess = await schoolAccountRequestService.DeleteSchoolAccountRequest(id);

                    if (IsSuccess)
                    {
                        string Deletemessage = "Delete Faculty record Successfully";
                        string Deletetitle = "LGA Connect SOMS";
                        MessageBoxButtons Deletebuttons = MessageBoxButtons.OK;
                        MessageBox.Show(Deletemessage, Deletetitle, Deletebuttons, MessageBoxIcon.Information);                     
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Delete Faculty Account Not Successfull");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else { }
        }

        public void clearEditData()
        {
            txtID.Text = "";
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            txtFirstname.Text = "";
            txtTeacherNumber.Text = "";
            txtPassword.Text = "";
            txtMobileNumber.Text = "";
            cbGender.Text = "";
            FacultyPicturebox.Image = null;
        }

        public void txtPasswordSize()
        {
            txtPassword.Size = new System.Drawing.Size(193, 32);
            lblShowHide.Show();
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Size = new System.Drawing.Size(233, 32);
                lblShowHide.Hide();
            }

            else
            {
                txtPassword.Size = new System.Drawing.Size(192, 32);
                lblShowHide.Show();
            }
        }

        private void EditSchoolFacultyAccountDetails_Load(object sender, EventArgs e)
        {
            txtPasswordSize();
        }
    }
}
