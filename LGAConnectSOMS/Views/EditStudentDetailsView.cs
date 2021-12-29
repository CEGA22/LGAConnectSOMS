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
    public partial class EditStudentDetailsView : Form
    {
        
        public EditStudentDetailsView()
        {
            InitializeComponent();            
        }

        //Load
        private void EditStudentDetailsView_Load(object sender, EventArgs e)
        {          
            LoadData();            
        }

        public async void LoadData()
        {
            await LoadGradeLevels();
            LoadYear();
        }

        private void LoadYear()
        {
            var datetime = DateTime.Now.ToString("yyyy");
            for (int year = 2015; year <= DateTime.UtcNow.Year; ++year)
            {
                cmbSY.Items.Add(year);
            }
        }

        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        private async Task LoadGradeLevels()
        {
            var currentGradeLevel = cmbGradeLevel.Text;
            var currentSection = cmbSection.Text;          
            
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());
            var gradelevelslist = gradeLevelSections.Select(x => x.GradeLevels).Distinct();
            cmbGradeLevel.DataSource = gradelevelslist.ToList();
            cmbGradeLevel.Text = currentGradeLevel;
            cmbSection.Text = currentSection;
        }

        //NavigationToOtherForm

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Buttons Forecolor and background Styles

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

        //TitleBarFunction
        //
        private void btnClose_Click_1(object sender, EventArgs e)
        {           
            this.Hide();
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public const int Form_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= Form_DropShadow;
                return cp;
            }
        }

        private void btnStudentProfile_Click(object sender, EventArgs e)
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
                    // display image in picture box
                    StudentProfilePicturebox.SizeMode = PictureBoxSizeMode.Zoom;
                    StudentProfilePicturebox.Image = new Bitmap(open.FileName);
                    var image = StudentProfilePicturebox.Image;
                    ImageToByteArray(image);
                    // image file path  
                }
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
            var image = StudentProfilePicturebox.Image;
            var selectedGradeLevel = cmbGradeLevel.SelectedItem;
            var selectedSection = cmbSection.SelectedItem;
            var dateonly = dtBirthday.Value.ToShortDateString();

            if (txtLastname.Text == "" || txtMiddlename.Text == "" || txtFirstname.Text == "" || txtStudentNumber.Text == "" || txtPassword.Text == "" || txtMobileNumber.Text == "" || cbGender.Text == "" || cmbGradeLevel.Text == "" || cmbSection.Text == "" || cmbSY.Text == "" || StudentProfilePicturebox.Image == null)
            {
                string message = "Please Fill in All Fields!";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {

                }
            }

            else
            {
                var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels.Equals(selectedGradeLevel) && x.SectionName.Equals(selectedSection)).Id;
                try
                {
                    StudentRequestService studentRequestService = new StudentRequestService();
                    var IsSucess = await studentRequestService.UpdateStudentRequest(new StudentRequest
                    {
                        ID = id,
                        Lastname = txtLastname.Text,
                        Middlename = txtMiddlename.Text,
                        Firstname = txtFirstname.Text,                        
                        Address = txtAddress.Text,
                        Birthday = Convert.ToDateTime(dateonly),
                        ParentsName = txtParentsname.Text,
                        StudentNumber = txtStudentNumber.Text,
                        Password = txtPassword.Text,
                        mobileNumber = txtMobileNumber.Text,
                        Email = txtEmail.Text,
                        Gender = cbGender.Text,
                        GradeLevelid = gradeLevelId,
                        StudentProfile = ImageToByteArray(image),                        
                        SchoolYearStart = int.Parse(cmbSY.Text),
                        SchoolYearEnd = int.Parse(txtSchoolYearEnd.Text)
                    });

                    if (IsSucess)
                    {
                        MessageBox.Show("Update Student information Successfully");
                    }

                    else
                    {
                        MessageBox.Show("Update Student information Not Successfull");
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }        
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {               
           var selectedGradeLevel = cmbGradeLevel.SelectedItem;
           var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel)).Select(x => x.SectionName);
           cmbSection.DataSource = gradelevelslist.ToList();         
        }
       
        private void txtSchoolYearEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private async void btnDeleteStudentDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txtID.Text);
                string message = "Are you sure you want to delete this student account?";
                string title = "LGA Connect SOMS Student Account";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    StudentRequestService studentRequestService = new StudentRequestService();
                    var IsSuccess = await studentRequestService.DeleteStudentRequest(ID);
                    if (IsSuccess)
                    {
                        MessageBox.Show("Delete student account Successfully");
                        NewsAndAnnouncementsView newsAndAnnouncements = new NewsAndAnnouncementsView();
                        newsAndAnnouncements.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Delete student account Not Successfull");
                    }
                }
                else if (result == DialogResult.No)
                {

                }
            }
            catch (Exception x)
            {

            }
        }
    }
}
