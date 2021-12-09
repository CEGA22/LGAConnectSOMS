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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            GradeLevelRequestService gradeLevelRequestService = new GradeLevelRequestService();        
            var IsSuccess = await gradeLevelRequestService.CreateGradeLevelRequest(new GradeLevelRequest
            {
                GradeLevel = cmbGradelevel.Text
            });

            if (IsSuccess)
            {
                MessageBox.Show("New grade level Added");
            }

            else
            {
                MessageBox.Show("Added grade level failed");
            }
        }
    }
}
