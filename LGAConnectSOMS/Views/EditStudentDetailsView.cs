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
    public partial class EditStudentDetailsView : Form
    {
        public EditStudentDetailsView()
        {
            InitializeComponent();
        }


        //Buttons Forecolor and background Styles


        //TitleBarFunction
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStudentDetailsView_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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
    }
}
