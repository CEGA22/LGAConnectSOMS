using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
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
    public partial class ClassRecordAdminView : Form
    {
        List<Students> students = new List<Students>();
        List<GradeLevelModel> gradelevel = new List<GradeLevelModel>();
        List<GradeLevelModel> section = new List<GradeLevelModel>();
        public ClassRecordAdminView()
        {
            InitializeComponent();
        }

        //Load
        private void ClassRecordAdminView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            DisplayClassRecordData();
            ClassRecordDataGridView.CurrentCell = null;
                   
        }

        //NavigationToOtherForm

        private  void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var HVA = new HomeViewAdmin();
            HVA.Show();          
            this.Hide();
        }

        //Commands
        public void DisplayClassRecordData()
        {
            var db = new DataAccess();
            students = db.GetStudents();
            ClassRecordDataGridView.DataSource = students;                 
        }
        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            var db = new DataAccess();
            students = db.GetStudentsByLastname(txtSearchStudent.Text);
            ClassRecordDataGridView.DataSource = students;
            CBGradeLevel.SelectedIndex = -1;
            CBSection.SelectedIndex = -1;
            ClassRecordDataGridView.CurrentCell = null;
            if (string.IsNullOrWhiteSpace(txtSearchStudent.Text))
            {
                DisplayClassRecordData();
            }
        }
        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            var db = new DataAccess();
            db.AddStudent(txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtGender.Text, Convert.ToInt32(txtGradeLevel.Text));
        }

        private void CBGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBGradeLevel.SelectedIndex == -1)
            {
                DisplayClassRecordData();
            }
            else
            {
                var db = new DataAccess();
                var selectedgrade = CBGradeLevel.Text;
                students = db.FilterByGrade(selectedgrade.ToString());
                ClassRecordDataGridView.DataSource = students;
                CBSection.SelectedIndex = -1;
                ClassRecordDataGridView.CurrentCell = null;

            }     
        }

        private void CBGradeLevel_DropDown(object sender, EventArgs e)
        {
            var db = new DataAccess();
            gradelevel = db.GetStudentsByGradeLevel();
            CBGradeLevel.DataSource = gradelevel;
            CBGradeLevel.DisplayMember = "Grade_Level";
            CBGradeLevel.Text = "Grade Level";
            CBGradeLevel.SelectedIndex = -1;
            ClassRecordDataGridView.CurrentCell = null;
        }

        private void CBSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSection.SelectedIndex == -1)
            {
                DisplayClassRecordData();
            }
            else
            {
                var db = new DataAccess();
                var selectsection = CBSection.Text;
                students = db.FilterBySection(selectsection.ToString());
                ClassRecordDataGridView.DataSource = students;
                CBGradeLevel.SelectedIndex = -1;
                ClassRecordDataGridView.CurrentCell = null;

            }
        }

        private void CBSection_DropDown(object sender, EventArgs e)
        {
            var db = new DataAccess();
            section = db.GetStudentsBySection();
            CBSection.DataSource = section;
            CBSection.DisplayMember = "Section";
            CBSection.Text = "Grade Level";
            CBSection.SelectedIndex = -1;
            ClassRecordDataGridView.CurrentCell = null;
        }



        //Buttons Forecolor and background Styles

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.Back_Arrow_Yellow;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.Back_arrow;
        }

        //TitleBarFunction

        private void RestoreWindowPosition()
        {

            if (Settings.Default.HasSetDefault)
            {
                this.WindowState = Settings.Default.WindowState;
                this.Location = Settings.Default.Location;
                this.Size = Settings.Default.Size;

            }
        }

        private void ClassRecordAdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveWindowPosition();
        }

        private void SaveWindowPosition()
        {
            Settings.Default.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.Location = this.Location;
                Settings.Default.Size = this.Size;

            }
            else
            {
                Settings.Default.Location = this.RestoreBounds.Location;
                Settings.Default.Size = this.RestoreBounds.Size;
            }

            Settings.Default.HasSetDefault = true;

            Settings.Default.Save();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.NormalBlack;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        //DragWindows
        private Point _mouseLoc;
        private void DragWindowsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            _mouseLoc = e.Location;
        }

        private void DragWindowsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        public void MaximizeIcon()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.NormalBlack;
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            }
        }  
    }
}
