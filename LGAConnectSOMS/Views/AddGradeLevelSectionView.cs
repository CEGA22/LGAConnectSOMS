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
    public partial class AddGradeLevelSectionView : Form
    {
        public AddGradeLevelSectionView()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            await DisplayGradeLevels();
            await DisplayGradeLevelSections();       
        }
      
        IEnumerable<GradeLevel> gradeLevels = new List<GradeLevel>();
        private async Task DisplayGradeLevels()
        {
            cmbGradelevel.Enabled = false;
            GradeLevelService gradeLevelService = new GradeLevelService();
            gradeLevels = await Task.Run(() => gradeLevelService.GetGradeLevel());
            var gradelevelslist = gradeLevels.Select(x => x.GradeLevels).ToList();
            cmbGradelevel.DataSource = gradelevelslist.ToList();
            cmbGradelevel.Enabled = true;
        }

        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        private async Task DisplayGradeLevelSections()
        {           
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());                
        }

        private void AddGradeLevelSectionView_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int year = int.Parse(dateTime.ToString("yyyy"));
            var years = (int)year + 1;
            CYStart.Text = year.ToString();
            txtSchoolYearEnd.Text = years.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            var selectedGradeLevel = cmbGradelevel.SelectedItem;
            var gradelevelid = gradeLevels.First(x => x.GradeLevels.Equals(selectedGradeLevel)).ID;
            var result = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel) && x.SectionName.Equals(txtSectionName.Text));
          
            var selectedSection = (string)txtSectionName.Text;
            var image = HighestPossiblescorePictureBox.Image;        
            DateTime dateTime = DateTime.Now;
            var dateonly = dateTime.ToShortDateString();

            if (!result.Any())
            {
                try
                {
                    GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
                    var IsSucess = await gradeLevelSectionService.CreateGradeLevelSectionRequest(new GradeLevelSection
                    {
                        GradeLevel = gradelevelid,
                        SectionName = txtSectionName.Text
                    });
                   
                    try
                    {
                        await DisplayGradeLevelSections();
                        var selectedGradeLevelInsert = cmbGradelevel.SelectedItem;
                        var gradelevelidInsert = gradeLevelSections.First(x => x.GradeLevels.Equals(selectedGradeLevelInsert) && x.SectionName.Equals(txtSectionName.Text)).Id;                       
                        StudentRequestService studentRequestService = new StudentRequestService();
                        IsSucess = await studentRequestService.CreateStudentRequest(new StudentRequest
                        {
                            Lastname = "Highest possible score",
                            Middlename = "H",
                            Firstname = "(HPS)",
                            Address = "ASASAS",
                            Birthday = Convert.ToDateTime(dateonly),
                            ParentsName = "SASA",
                            StudentNumber = "0000000000",
                            Password = "HPS123",
                            mobileNumber = "01234567891",
                            Email = "SASASA",
                            Gender = "MALE",
                            GradeLevelid = gradelevelidInsert,
                            StudentProfile = ImageToByteArray(image),
                            SchoolYearStart = int.Parse(CYStart.Text),
                            SchoolYearEnd = int.Parse(txtSchoolYearEnd.Text),
                            //SubjectsName = subjectid
                        });
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }

                    if (IsSucess)
                    {
                        string message = "Added new Section Successfully";
                        string title = "LGA Connect SOMS Section";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult results = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                        if (results == DialogResult.OK)
                        {
                            this.Hide();
                        }                                             
                    }

                    else
                    {
                        string message = "Added new Section Unsuccessful";
                        string title = "LGA Connect SOMS Section";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult results = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                        if (results == DialogResult.OK)
                        {                           
                        }                       
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                string message = "Grade level and section name already exist!";
                string title = "LGA Connect SOMS Section";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult results = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (results == DialogResult.OK)
                {                  
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        
    }


}
