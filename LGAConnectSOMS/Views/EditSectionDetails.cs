using LGAConnectSOMS.Models;
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
    public partial class EditSectionDetails : Form
    {
        
        public EditSectionDetails()
        {
            InitializeComponent();
        }

        private void EditSectionDetails_Load(object sender, EventArgs e)
        {
            LoadData();                      
        }
     
        public async void LoadData()
        {
            await LoadGradeLevels();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        private async Task LoadGradeLevels()
        {
            btnAddStudent.Enabled = false;
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());
            var gradelevelslist = gradeLevelSections.Select(x => x.GradeLevels).Distinct().ToList();
            btnAddStudent.Enabled = true;
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            var selectedGradeLevel = cmbGradelevel.Text;
            var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels == selectedGradeLevel).Id;
            try
            {
                GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
                var IsSucess = await gradeLevelSectionService.UpdateGradeLevelSectionRequest(new GradeLevelSection
                {
                    Id = int.Parse(txtID.Text),
                    GradeLevel = gradeLevelId,
                    SectionName = txtSectionName.Text
                });

                if (IsSucess)
                {
                    string message = "Update Section Details Successfully";
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
                    string message = "Update Section Details Unsuccessful";
                    string title = "LGA Connect SOMS Section";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult results = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (results == DialogResult.OK)
                    {
                        this.Hide();
                    }                   
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnCancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txtID.Text);
                string message = "Are you sure you want to delete this section?";
                string title = "LGA Connect SOMS Section";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
                    var IsSuccess = await gradeLevelSectionService.DeleteSection(ID);
                    if (IsSuccess)
                    {
                        string Successmessage = "Delete section successfully";
                        string Successtitle = "LGA Connect SOMS Section";
                        MessageBoxButtons Successbuttons = MessageBoxButtons.OK;
                        DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                        if (Successresult == DialogResult.OK)
                        {
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delete section Unsuccessful");
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
