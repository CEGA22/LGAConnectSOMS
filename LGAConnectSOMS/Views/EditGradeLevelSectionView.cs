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
    public partial class EditGradeLevelSectionView : Form
    {
        public EditGradeLevelSectionView()
        {
            InitializeComponent();
        }

        private async void btnCancel_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
