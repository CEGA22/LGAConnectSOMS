using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using Newtonsoft.Json;
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
        //List<StudentAccount> students = new List<StudentAccount>();
        //List<GradeLevelModel> gradelevel = new List<GradeLevelModel>();
        //List<GradeLevelModel> section = new List<GradeLevelModel>();
        public ClassRecordAdminView()
        {
            InitializeComponent();          
            
        }

        //Load
        private async void ClassRecordAdminView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            await DisplayClassRecordData();
            ClassRecordDataGridView.CurrentCell = null; 
        }

        //NavigationToOtherForm

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var HVA = new HomeViewAdmin();
            HVA.Show();   
            this.Hide();
        }

        //Commands
        public async Task DisplayClassRecordData()
        {           
            StudentService studentService = new StudentService();
            var students = await studentService.GetStudentAccount();
            var studentsList = students.ToList();

            studentsList.Insert(0, new StudentAccount
            {
                
            });

            

            ClassRecordDataGridView.DataSource =  students;
            ClassRecordDataGridView.CurrentCell = null;
        }
        private async void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {                      
            if (!string.IsNullOrWhiteSpace(txtSearchStudent.Text))
            {
                StudentService studentService = new StudentService();
                var students = studentService.GetStudentAccountById(txtSearchStudent.Text);
                ClassRecordDataGridView.DataSource = await students;
                CBGradeLevel.SelectedIndex = -1;
                CBSection.SelectedIndex = -1;
                ClassRecordDataGridView.CurrentCell = null;               
            }

            else
            {
                await DisplayClassRecordData();
            }
        }
        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            //var db = new DataAccess();
            //db.AddStudent(txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtGender.Text, Convert.ToInt32(txtGradeLevel.Text));
        }
        

        private async void CBGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBGradeLevel.SelectedIndex == -1)
            {
                await DisplayClassRecordData();              
            }
            else
            {              
                var selectedgrade = CBGradeLevel.Text;              
                StudentService studentService = new StudentService();
                var students = studentService.GetStudentAccountByGradeLevel(selectedgrade.ToString());
                ClassRecordDataGridView.DataSource = await students;
                CBSection.SelectedIndex = -1;
                ClassRecordDataGridView.CurrentCell = null;
            }
        }

        private async void CBGradeLevel_DropDown(object sender, EventArgs e)
        {
            //var db = new DataAccess();
            //gradelevel = db.GetStudentsByGradeLevel();
            //CBGradeLevel.DataSource = gradelevel;           
             StudentService studentService = new StudentService();
             var students = studentService.GetStudentByGradeLevelFilter();
             CBGradeLevel.DataSource = await students;
             CBGradeLevel.DisplayMember = "Grade_Level";
            CBGradeLevel.Text = "Grade Level";
            CBGradeLevel.SelectedIndex = -1;
             ClassRecordDataGridView.CurrentCell = null;                    
        }

        private async void CBSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSection.SelectedIndex == -1)
            {
                await DisplayClassRecordData();
            }
            else
            {
                //var db = new DataAccess();
                //var selectsection = CBSection.Text;
                //students = db.FilterBySection(selectsection.ToString());
                var selectedsection = CBSection.Text;
                StudentService studentService = new StudentService();
                var students = studentService.GetStudentAccountBySection(selectedsection.ToString());
                ClassRecordDataGridView.DataSource = await students;            
                CBGradeLevel.SelectedIndex = -1;
                ClassRecordDataGridView.CurrentCell = null;

            }
        }

        private async void CBSection_DropDown(object sender, EventArgs e)
        {
            //var db = new DataAccess();
            //section = db.GetStudentsBySection();
            //CBSection.DataSource = section;
            StudentService studentService = new StudentService();
            var students = studentService.GetStudentBySectionFilter();
            CBSection.DataSource = await students;
            CBSection.DisplayMember = "SectionName";
            CBSection.Text = "Section Name";
            CBSection.SelectedIndex = -1;
            ClassRecordDataGridView.CurrentCell = null;
        }

        private void ClassRecordDataGridView_Click(object sender, EventArgs e)
        {
            var ESDV = new EditStudentDetailsView();
            ESDV.txtID.Text = ClassRecordDataGridView.CurrentRow.Cells[0].Value.ToString();
            ESDV.txtLastname.Text = ClassRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
            ESDV.txtFirstname.Text = ClassRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
            ESDV.txtMiddlename.Text = ClassRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
            ESDV.cbGender.Text = ClassRecordDataGridView.CurrentRow.Cells[4].Value.ToString();
            ESDV.txtGradeLevel.Text = ClassRecordDataGridView.CurrentRow.Cells[5].Value.ToString();
            ESDV.txtSection.Text = ClassRecordDataGridView.CurrentRow.Cells[6].Value.ToString();
            ESDV.txtStudentNumber.Text = ClassRecordDataGridView.CurrentRow.Cells[7].Value.ToString();
            ESDV.txtPassword.Text = ClassRecordDataGridView.CurrentRow.Cells[8].Value.ToString();
            ESDV.txtSchoolYearStart.Text = ClassRecordDataGridView.CurrentRow.Cells[9].Value.ToString();
            ESDV.txtSchoolYearEnd.Text = ClassRecordDataGridView.CurrentRow.Cells[10].Value.ToString();
            ESDV.ShowDialog();
        }



        //Buttons Forecolor and background Styles

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrowYellow24;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrow24;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
