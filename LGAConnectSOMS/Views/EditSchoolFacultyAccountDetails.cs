﻿using LGAConnectSOMS.Models;
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
                    MessageBox.Show("You have updated Administrator Details");
                }

                else
                {
                    MessageBox.Show("Update Administrator Details Not Successfull");
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
                        MessageBox.Show("Delete Faculty Account Successfully");
                        clearEditData();
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
    }
}
