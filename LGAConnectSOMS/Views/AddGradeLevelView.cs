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
    public partial class AddGradeLevelView : Form
    {
        public AddGradeLevelView()
        {
            InitializeComponent();
        }

        private void AddGradeLevelView_Load(object sender, EventArgs e)
        {
            //LoadGradeLevel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public async void LoadData()
        //{
        //    await LoadGradeLevel();
        //}

        //IEnumerable<GradeLevel> gradeLevelList = new List<GradeLevel>();
        //private async Task LoadGradeLevel()
        //{
        //    GradeLevelService gradeLevelService = new GradeLevelService();
        //    gradeLevelList = await gradeLevelService.GetGradeLevel();
        //}

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {          
            //var result = gradeLevelList.Where(x => x.GradeLevels.Equals(cmbGradelevel.SelectedItem));

            //if (!result.Any())
            //{
            //    GradeLevelRequestService gradeLevelRequestService = new GradeLevelRequestService();
            //    var IsSuccess = await gradeLevelRequestService.CreateGradeLevelRequest(new GradeLevelRequest
            //    {
            //        GradeLevel = cmbGradelevel.Text
            //    });

            //    if (IsSuccess)
            //    {
            //        string message = "Added new grade level successfully";
            //        string title = "LGA Connect SOMS Grade Level";
            //        MessageBoxButtons buttons = MessageBoxButtons.OK;
            //        DialogResult results = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            //        if (results == DialogResult.OK)
            //        {
            //            this.Close();
            //        }                   
            //    }
            //    else
            //    {
            //        string message = "Added new grade level Unsuccessfull";
            //        string title = "LGA Connect SOMS Grade Level";
            //        MessageBoxButtons buttons = MessageBoxButtons.OK;
            //        DialogResult results = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            //        if (results == DialogResult.OK)
            //        {
            //            this.Close();
            //        }
            //    }
            // }
            //else
            //{
            //    MessageBox.Show("Added grade level already exist!");
            //}         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
