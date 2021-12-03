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
        

        public ClassRecordAdminView()
        {
            InitializeComponent();

            //gradeLevelSections.Add(new GradeLevelSection
            //{
            //    Id = 1,
            //    GradeLevel = 1,
            //    SectionName = "Amber"
            //});

            //gradeLevelSections.Add(new GradeLevelSection
            //{
            //    Id = 2,
            //    GradeLevel = 2,
            //    SectionName = "Amethyst"
            //});

            //gradeLevelSections.Add(new GradeLevelSection
            //{
            //    Id = 10,
            //    GradeLevel = 10,
            //    SectionName = "Citrine"
            //});

            //gradeLevelSections.Add(new GradeLevelSection
            //{
            //    Id = 12,
            //    GradeLevel = 10,
            //    SectionName = "Blue Sapphire"
            //});            
        }
            
        //Load
        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        private async Task LoadGradeLevels()
        {
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await gradeLevelSectionService.GetGradeLevel();
            var gradelevelslist = gradeLevelSections.Select(x => x.GradeLevel).Distinct();
            cmbGradeLevels.DataSource = gradelevelslist.ToList();
        }
        private void LoadYear()
        {
            var datetime = DateTime.Now.ToString("yyyy");
            for (int year = 2015; year <= DateTime.UtcNow.Year; ++year)
            {
                cmbSYStart.Items.Add(year);
            }
        }

        private async Task LoadData()
        {
            await DisplayClassRecordData();          
            await LoadGradeLevels();
            LoadYear();           
        }
        private void ClassRecordAdminView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            LoadData();           
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

        private async void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            //var db = new DataAccess();
            //db.AddStudent(txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtGender.Text, Convert.ToInt32(txtGradeLevel.Text));
            var selectedGradeLevel = (int)cmbGradeLevels.SelectedItem;
            var selectedSection = (string)cmbSections.SelectedItem;

            var gradeLevelId = gradeLevelSections.First(x => x.GradeLevel == selectedGradeLevel && x.SectionName == selectedSection).Id;

            try
            {
                StudentRequestService studentRequestService = new StudentRequestService();
                var IsSucess = await studentRequestService.CreateStudentRequest(new StudentRequest
                {
                    Lastname = txtLastname.Text,
                    Middlename = txtMiddlename.Text,
                    Firstname = txtFirstname.Text,
                    StudentNumber = txtStudentNumber.Text,
                    Password = txtPassword.Text,
                    MobileNumber = Convert.ToInt64(txtMobileNumber.Text),
                    Gender = cbGender.Text,
                    GradeLevelId = gradeLevelId,
                    SchoolYearStart = int.Parse(cmbSYStart.Text),
                    SchoolYearEnd = int.Parse(txtSchoolYearEnd.Text)
                });

                if (IsSucess)
                {
                    MessageBox.Show("Added new Student Successfully");
                }

                else
                {
                    MessageBox.Show("Added new Student Not Successfull");                   
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
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

        private void cmbSYStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = (int)cmbSYStart.SelectedItem + 1;
            txtSchoolYearEnd.Text = selectedYear.ToString();
        }

        private void cmbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGradeLevel = (int)cmbGradeLevels.SelectedItem;
            var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevel == selectedGradeLevel).Select(x => x.SectionName);
            cmbSections.DataSource = gradelevelslist.ToList();
        }

        private void ClassRecordDataGridView_Click(object sender, EventArgs e)
        {
            var ESDV = new EditStudentDetailsView();
            ESDV.txtID.Text = ClassRecordDataGridView.CurrentRow.Cells[0].Value.ToString();
            ESDV.txtLastname.Text = ClassRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
            ESDV.txtMiddlename.Text = ClassRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
            ESDV.txtFirstname.Text = ClassRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
            ESDV.cbGender.Text = ClassRecordDataGridView.CurrentRow.Cells[4].Value.ToString();          
            ESDV.cmbGradeLevel.Text = ClassRecordDataGridView.CurrentRow.Cells[5].Value.ToString();
            ESDV.cmbSection.Text = ClassRecordDataGridView.CurrentRow.Cells[6].Value.ToString();
            ESDV.txtStudentNumber.Text = ClassRecordDataGridView.CurrentRow.Cells[7].Value.ToString();
            ESDV.txtPassword.Text = ClassRecordDataGridView.CurrentRow.Cells[8].Value.ToString();           
            ESDV.txtMobileNumber.Text = ClassRecordDataGridView.CurrentRow.Cells[9].Value.ToString();                                        
            ESDV.cmbSY.Text = ClassRecordDataGridView.CurrentRow.Cells[10].Value.ToString();
            ESDV.txtSchoolYearEnd.Text = ClassRecordDataGridView.CurrentRow.Cells[11].Value.ToString();
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

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbGradeLevels_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSections_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSchoolYearEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSYStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
