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
        }

    
        IEnumerable<GradeLevel> gradeLevels = new List<GradeLevel>();
        private async Task DisplayGradeLevels()
        {       
            GradeLevelService gradeLevelService = new GradeLevelService();
            gradeLevels = await Task.Run(() => gradeLevelService.GetGradeLevel());
            var gradelevelslist = gradeLevels.Select(x => x.GradeLevels).ToList();
            cmbGradelevel.DataSource = gradelevelslist.ToList();
        }

        private void AddGradeLevelSectionView_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            var selectedGradeLevel = cmbGradelevel.SelectedItem;
            var gradelevelid = gradeLevels.First(x => x.GradeLevels.Equals(selectedGradeLevel)).ID;

            try
            {
                GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
                var IsSucess = await gradeLevelSectionService.CreateGradeLevelSectionRequest(new GradeLevelSection
                {
                    GradeLevel = gradelevelid,
                    SectionName = txtSectionName.Text
                });

                if (IsSucess)
                {
                    MessageBox.Show("Added new Section Successfully");
                }

                else
                {
                    MessageBox.Show("Added new Section Not Successfull");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
