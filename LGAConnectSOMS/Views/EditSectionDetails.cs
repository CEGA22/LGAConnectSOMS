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
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());
            var gradelevelslist = gradeLevelSections.Select(x => x.GradeLevels).Distinct().ToList();           
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
                    MessageBox.Show("Update Section Details Successfully");
                }

                else
                {
                    MessageBox.Show("Added Details Not Successfull");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        
    }
}
