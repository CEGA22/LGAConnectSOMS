using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class ClassRecordAdminView : Form
    {   
        public ClassRecordAdminView()
        {
            InitializeComponent();      
        }

        //Load
        private void ClassRecordAdminView_Load(object sender, EventArgs e)
        {
            LoadData();           
            this.RestoreWindowPosition();
            MaximizeIcon();
        }

        private readonly Random _random = new Random();
        List<int> studentnumberlist = new List<int>();       
        StringBuilder concatenatedString = new StringBuilder();
        public async Task RandomStudentNumber()
        {         
            var result = verification();
            var students = studentAccounts.ToList();
            var results = studentAccounts.Where(x => x.StudentNumber.ToString().Contains(result)).ToList();
            if (!results.Any())
            {
                txtStudentNumber.Text = result;
            }

            else
            {
                studentnumberlist.Clear();
                concatenatedString.Clear();
                RandomStudentNumber();
            }
        }

        public string verification()
        {
            var num1 = 0;
            var num2 = 0;
            studentnumberlist.Add(num1);
            studentnumberlist.Add(num2);
            for (int i = 1; i <= 8; i++)
            {
                int num = _random.Next(10);
                var studentnumber = num;
                studentnumberlist.Add(studentnumber);
            }

            foreach (int password in studentnumberlist)
            {
                concatenatedString.Append(password);
            }

            return concatenatedString.ToString();
        }

        private async void LoadData()
        {
            
            btnAddGradeLevel.Hide();
            LoadYear();
            int yearcount = cmbSYStart.Items.Count;
            cmbSYStart.SelectedIndex = yearcount - 1;
            //GenerateStudentNumberandPassword();
            await DisplayGradeLevels();            
            await DisplayGradeLevelSections();
            await LoadSubjects();
            await LoadGradeLevels();
            await DisplayClassRecordData();
            await RandomStudentNumber();
            CBGradeLevel.SelectedIndex = -1;
            CBSection.SelectedIndex = -1;
            //await CreateHighestPossibleScore();                   
            lblloading.Hide();
            lblloadingGradeLevel.Hide();
            lblLoadingGradeLevelSection.Hide();
            CBGradeLevel.SelectedIndex = -1;
            CBSection.SelectedIndex = -1;
            GradeLevelDataGridView.CurrentCell = null;
            GradeLevelSectionDataGridView.CurrentCell = null;          
        }

        //Generate studentnumber and password
        public void GenerateStudentNumberandPassword()
        {           
            var monthanddate = dtBirthday.Value.ToString("dd-MM");
            string newmonthanddate;
            string oldmonthanddate = monthanddate;
            newmonthanddate = oldmonthanddate.Replace("-", "");
            var year = DateTime.Now.ToString("yyyy");
            var studentNumber = "00" + newmonthanddate + year;            
            //txtStudentNumber.Text = studentNumber;           
        }
      
        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        private async Task LoadGradeLevels()
        {
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());
            var gradelevelslist = gradeLevelSections.Select(x => x.GradeLevels).Distinct().ToList();
            gradelevelslist.Insert(0, "All Grade Level");
            cmbGradeLevels.DataSource = gradelevelslist.ToList();
            CBGradeLevel.DataSource = gradelevelslist.ToList();
            var addgradelevelslist = gradeLevelSections.Select(x => x.GradeLevels).Distinct().ToList();
            cmbGradeLevels.DataSource = addgradelevelslist.ToList();
            cmbGradeLevels.SelectedIndex = -1;           
            //CBGradeLevel.SelectedIndex = 0;
            //CBSection.SelectedIndex = 0;
        }

        public async Task CreateHighestPossibleScore()
        {
            var sections = gradeLevelSections.Count();
            MessageBox.Show(sections.ToString());
            for(int section = 0; section < sections; section++)
            {
                
            }
        }

        private async Task DisplayGradeLevelSections()
        {
            lblLoadingGradeLevelSection.Show();
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());
            var gradelevelslist = gradeLevelSections;
            GradeLevelSectionDataGridView.DataSource = gradelevelslist.ToList();
            GradeLevelSectionDataGridView.Columns[0].Visible = false;
            GradeLevelSectionDataGridView.Columns[1].Visible = false;
            GradeLevelSectionDataGridView.Columns[4].Visible = false;
            GradeLevelSectionDataGridView.Columns[5].Visible = false;
            GradeLevelSectionDataGridView.Columns[6].Visible = false;
            GradeLevelSectionDataGridView.Columns[7].Visible = false;
            GradeLevelSectionDataGridView.Columns[8].Visible = false;
            GradeLevelSectionDataGridView.Columns[9].Visible = false;
            GradeLevelSectionDataGridView.Columns[10].Visible = false;
            GradeLevelSectionDataGridView.Columns[11].Visible = false;
            GradeLevelSectionDataGridView.Columns[12].Visible = false;
            GradeLevelSectionDataGridView.Columns[13].Visible = false;
            GradeLevelSectionDataGridView.Columns[14].Visible = false;
            GradeLevelSectionDataGridView.Columns[15].Visible = false;
            GradeLevelSectionDataGridView.Columns[16].Visible = false;
            GradeLevelSectionDataGridView.Columns[17].Visible = false;
            GradeLevelSectionDataGridView.Columns[18].Visible = false;
            GradeLevelSectionDataGridView.Columns[19].Visible = false;
            GradeLevelSectionDataGridView.Columns[20].Visible = false;
            lblLoadingGradeLevelSection.Hide();
            GradeLevelSectionDataGridView.CurrentCell = null;
        }

        IEnumerable<GradeLevel> gradeLevels = new List<GradeLevel>();
        private async Task DisplayGradeLevels()
        {
            lblloadingGradeLevel.Show();
            GradeLevelService gradeLevelService = new GradeLevelService();
            gradeLevels = await Task.Run(() => gradeLevelService.GetGradeLevel());
            var gradelevelslist = gradeLevels;
            GradeLevelDataGridView.DataSource = gradelevelslist.ToList();
            this.GradeLevelDataGridView.Columns[0].Visible = false;
            GradeLevelDataGridView.CurrentCell = null;
            lblloadingGradeLevel.Hide();
            
        }
        private void LoadYear()
        {
            var datetime = DateTime.Now.ToString("yyyy");
            for (int year = 2015; year <= DateTime.UtcNow.Year; ++year)
            {
                cmbSYStart.Items.Add(year);
            }
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
        public IEnumerable<StudentAccount> studentAccounts = new List<StudentAccount>();
        public async Task DisplayClassRecordData()
        {
            lblloading.Show();
            txtSearchStudent.Enabled = false;
            CBGradeLevel.Enabled = false;
            CBSection.Enabled = false;
            StudentService studentService = new StudentService();
            var students = await Task.Run(() => studentService.GetStudentAccount());
            studentAccounts = students.ToList();
            var year = studentAccounts.Select(x => x.SchoolYearStart).Distinct();
            cmbschoolYear.DataSource = year.ToList();
            ClassRecordDataGridView.DataSource = studentAccounts;
            
            lblloading.Hide();
            txtSearchStudent.Enabled = true;
            CBGradeLevel.Enabled = true;
            CBSection.Enabled = true;
            ClassRecordDataGridView.CurrentCell = null;
            this.ClassRecordDataGridView.Columns[0].Visible = false;
            this.ClassRecordDataGridView.Columns[14].Visible = false;
            this.ClassRecordDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassRecordDataGridView.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchStudent.Text))
            {
                ClassRecordDataGridView.DataSource = studentAccounts.ToList();
            }           
        }

        IEnumerable<Subjects> subjects = new List<Subjects>();
        public async Task LoadSubjects()
        {
            SubjectsService subjectsService = new SubjectsService();
            subjects = await Task.Run(() => subjectsService.GetSubjects());
        }

        public bool IsSucess;
        private async void btnAddStudent_Click_1(object sender, EventArgs e)
        {                   
             if (txtLastname.Text == "")
             {
                    string message = "Please enter lastname";
                    string title = "LGA Connect SOMS";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK){ }
             }

            else if (txtStudentNumber.Text == "")
            {
                string message = "Please wait to generate student number";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtFirstname.Text == "")
            {
                string message = "Please enter firstname";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtPassword.Text == "")
                {
                string message = "Please enter password";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
                }
          
              else if (cmbSYStart.Text == "")
              {
                string message = "Please enter School year start";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
              }

            else if (txtAddress.Text == "")
            {
                string message = "Please enter address";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (cbGender.Text == "")
            {
                string message = "Please select gender";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (cmbGradeLevels.Text == "")
            {
                string message = "Please select Student Grade Level";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtMobileNumber.Text == "")
            {
                string message = "Please enter mobile number";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtMobileNumber.Text.Length != 11)
            {
                string message = "Please enter valid mobile number";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtAddress.Text =="")
            {
                string message = "Please enter address";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtEmail.Text == "")
            {
                string message = "Please enter email address";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (txtParentsname.Text == "")
            {
                string message = "Please enter Guardian name";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if (StudentProfilePictureBox.Image == null)
            {
                StudentProfilePictureBox.Image = LGAConnectSOMS.Properties.Resources.DefaultUserProfile;
                await AddStudent();
            }

            else
            {
                await AddStudent();   
            }
        }

        public async Task AddStudent()
        {
            var selectedGradeLevel = (string)cmbGradeLevels.SelectedItem;
            var selectedSection = (string)cmbSections.SelectedItem;
            var image = StudentProfilePictureBox.Image;
            var dateonly = dtBirthday.Value.ToShortDateString();
            var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels == selectedGradeLevel && x.SectionName == selectedSection).Id;
            try
            {
                StudentRequestService studentRequestService = new StudentRequestService();
                IsSucess = await studentRequestService.CreateStudentRequest(new StudentRequest
                {
                    Lastname = txtLastname.Text,
                    Middlename = txtMiddlename.Text,
                    Firstname = txtFirstname.Text,
                    Address = txtAddress.Text,
                    Birthday = Convert.ToDateTime(dateonly),
                    ParentsName = txtParentsname.Text,
                    StudentNumber = txtStudentNumber.Text,
                    Password = txtPassword.Text,
                    mobileNumber = txtMobileNumber.Text,
                    Email = txtEmail.Text,
                    Gender = cbGender.Text,
                    StudentProfile = ImageToByteArray(image),
                    GradeLevelid = gradeLevelId,
                    SchoolYearStart = int.Parse(cmbSYStart.Text),
                    SchoolYearEnd = int.Parse(txtSchoolYearEnd.Text),
                    //SubjectsName = subjectid
                });
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            if (IsSucess)
            {
                string Successmessage = "Added new Student Successfully";
                string Successtitle = "LGA Connect SOMS Student Records";
                MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                if (Successresult == DialogResult.OK)
                {
                    ClearData();
                }
            }

            else
            {
                MessageBox.Show("Added new Student Not Successfull");
            }
        }

        public void ClearData()
        {
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            txtFirstname.Text = "";
            txtStudentNumber.Text = "";
            txtPassword.Text = "";
            txtMobileNumber.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtParentsname.Text = "";
            txtSchoolYearEnd.Text = "";
            cmbGradeLevels.SelectedIndex = -1;
            cbGender.Text = "";
            cmbGradeLevels.Text = "";
            cmbSections.Text = "";
            cmbSYStart.Text = "";
            StudentProfilePictureBox.Image = null;
        }

        private void CBGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CBGradeLevel.SelectedIndex;

            if (selectedIndex > -1)
            {
                var selectedGradeLevel = (string)CBGradeLevel.SelectedItem;

                var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel)).Select(x => x.SectionName);

                CBSection.DataSource = gradelevelslist.ToList();
                var selectedSection = (string)CBSection.SelectedItem;

                //if (studentAccounts.Any())
                //{
                //    var filteredlist = studentAccounts.Where(item => item.Grade_Level.ToString() == selectedGradeLevel && item.SectionName.ToString() == selectedSection).ToList();
                //    ClassRecordDataGridView.DataSource = selectedIndex != 0 ? filteredlist : studentAccounts;
                //}
            }
        }
      
        private void cmbSYStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = (int)cmbSYStart.SelectedItem + 1;
            txtSchoolYearEnd.Text = selectedYear.ToString();
        }

        private void cmbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGradeLevel = cmbGradeLevels.SelectedItem;
            var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel)).Select(x => x.SectionName);
            cmbSections.DataSource = gradelevelslist.ToList();
        }

        private void ClassRecordDataGridView_Click(object sender, EventArgs e)
        {
            var ESDV = new EditStudentDetailsView();
            ESDV.txtID.Text = ClassRecordDataGridView.CurrentRow.Cells[0].Value.ToString();
            ESDV.txtLastname.Text = ClassRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
            ESDV.txtMiddlename.Text = ClassRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
            ESDV.txtFirstname.Text = ClassRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
            ESDV.cbGender.Text = ClassRecordDataGridView.CurrentRow.Cells[11].Value.ToString();
            ESDV.cmbGradeLevel.Text = ClassRecordDataGridView.CurrentRow.Cells[12].Value.ToString();
            ESDV.cmbSection.Text = ClassRecordDataGridView.CurrentRow.Cells[13].Value.ToString();
            ESDV.txtStudentNumber.Text = ClassRecordDataGridView.CurrentRow.Cells[7].Value.ToString();
            ESDV.txtPassword.Text = ClassRecordDataGridView.CurrentRow.Cells[8].Value.ToString();
            byte[] image = (byte[])ClassRecordDataGridView.CurrentRow.Cells[14].Value;
            MemoryStream ms = new MemoryStream(image);
            ESDV.StudentProfilePicturebox.Image = Image.FromStream(ms);
            ESDV.txtMobileNumber.Text = ClassRecordDataGridView.CurrentRow.Cells[9].Value.ToString();
            ESDV.cmbSY.Text = ClassRecordDataGridView.CurrentRow.Cells[15].Value.ToString();
            ESDV.txtSchoolYearEnd.Text = ClassRecordDataGridView.CurrentRow.Cells[16].Value.ToString();
            ESDV.txtAddress.Text = ClassRecordDataGridView.CurrentRow.Cells[4].Value.ToString();
            ESDV.dtBirthday.Text = ClassRecordDataGridView.CurrentRow.Cells[5].Value.ToString();
            ESDV.txtParentsname.Text = ClassRecordDataGridView.CurrentRow.Cells[6].Value.ToString();
            ESDV.txtEmail.Text = ClassRecordDataGridView.CurrentRow.Cells[10].Value.ToString();           
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

        private void btnUploadStudentProfile_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
               
                    FileStream fs = File.OpenRead(open.FileName);
                    if (fs.Length > 1000000)
                    {
                        MessageBox.Show("Maximum file size is 1MB");
                        return;
                    }

                    else
                    {
                        StudentProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        StudentProfilePictureBox.Image = new Bitmap(open.FileName);
                        var image = StudentProfilePictureBox.Image;
                        ImageToByteArray(image);
                    }
                    // display image in picture box

                    // image file path                          
                }
            }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }

        private void btnAddGradeLevel_Click(object sender, EventArgs e)
        {
            AddGradeLevelView addGradeLevelView = new AddGradeLevelView();
            addGradeLevelView.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //var selectedGradeLevel = (string)cmbGradeLevels.SelectedItem;
            //var selectedSection = cmbSections.SelectedItem;
            //var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel)).Select(x => x.SectionName);
            //var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels == selectedGradeLevel).Id;
            //var subjectslist = subjects.Where(x => x.GradeLevel == gradeLevelId).Select(x => x.SubjectName);                     
            //foreach(var subjecttosave in subjectslist)
            //{
                
            //}
        }

        private async void btnAddGradeSection_Click(object sender, EventArgs e)
        {
            AddGradeLevelSectionView addGradeLevelSectionView = new AddGradeLevelSectionView();
            addGradeLevelSectionView.ShowDialog();
        }
      
        private void GradeLevelSectionDataGridView_Click(object sender, EventArgs e)
        {
            EditSectionDetails editSectionDetails = new EditSectionDetails();          
            editSectionDetails.txtID.Text = GradeLevelSectionDataGridView.CurrentRow.Cells[0].Value.ToString();
            editSectionDetails.cmbGradelevel.Text = GradeLevelSectionDataGridView.CurrentRow.Cells[2].Value.ToString();
            editSectionDetails.txtSectionName.Text = GradeLevelSectionDataGridView.CurrentRow.Cells[3].Value.ToString();
            //cmbGradeLevels.SelectedIndex = -1;
            editSectionDetails.ShowDialog();
        }
       
        private void txtLastname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void dtBirthday_ValueChanged(object sender, EventArgs e)
        {
            var monthanddate = dtBirthday.Value.ToString("dd-MM");
            string newmonthanddate;
            string oldmonthanddate = monthanddate;
            newmonthanddate = oldmonthanddate.Replace("-", "");
            var year = DateTime.Now.ToString("yyyy");
            var studentNumber = "00" + newmonthanddate + year;
            //txtStudentNumber.Text = studentNumber;
            var lastname = txtLastname.Text;
            txtPassword.Text = lastname + newmonthanddate + year;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtLastname.Text))
            {
                var lastname = txtLastname.Text;
                var monthanddate = dtBirthday.Value.ToString("dd-MM");
                var year = DateTime.Now.ToString("yyyy");
                string newmonthanddate;
                string oldmonthanddate = monthanddate;
                newmonthanddate = oldmonthanddate.Replace("-", "");
                txtPassword.Text = lastname + newmonthanddate + year;
            }

            else
            {
                txtPassword.Text = "";
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSearchStudent.Text == "")
            {
                MessageBox.Show("Please enter student lastname!");
            }

            else if (CBGradeLevel.Text == "")
            {
                MessageBox.Show("Please select grade level!");
            }
            
            else
            {
                var lastname = txtSearchStudent.Text;
                var gradelevel = CBGradeLevel.SelectedItem;
                var section = CBSection.SelectedItem;
                var Schoolyear = cmbschoolYear.SelectedItem;
                if (gradelevel.Equals("All Grade Level"))
                {
                    var result = studentAccounts.Where(x => x.Lastname.ToString().Equals(lastname) && x.SchoolYearStart.Equals(Schoolyear)).ToList();
                    ClassRecordDataGridView.DataSource = result;
                    ClassRecordDataGridView.CurrentCell = null;
                }
                else
                {
                    var result = studentAccounts.Where(x => x.Lastname.ToString().Equals(lastname) && x.Grade_Level.Equals(gradelevel) && x.SectionName.Equals(section)).ToList();
                    ClassRecordDataGridView.DataSource = result;
                    ClassRecordDataGridView.CurrentCell = null;
                }
            }
        }      
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblSearchStudent.Show();
                lblGradeLevel.Show();
                lblSection.Show();
                btnSearch.Show();
                txtSearchStudent.Show();
                CBGradeLevel.Show();
                CBSection.Show();
            }

            else if (tabControl1.SelectedIndex == 1)
            {
                lblSearchStudent.Hide();
                lblGradeLevel.Hide();
                lblSection.Hide();
                btnSearch.Hide();
                txtSearchStudent.Hide();
                CBGradeLevel.Hide();
                CBSection.Hide();
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                lblSearchStudent.Hide();
                lblGradeLevel.Hide();
                lblSection.Hide();
                btnSearch.Hide();
                txtSearchStudent.Hide();
                CBGradeLevel.Hide();
                CBSection.Hide();
            }

            else if (tabControl1.SelectedIndex == 3)
            {
                lblSearchStudent.Hide();
                lblGradeLevel.Hide();
                lblSection.Hide();
                btnSearch.Hide();
                txtSearchStudent.Hide();
                CBGradeLevel.Hide();
                CBSection.Hide();
            }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            ClassRecordDataGridView.DataSource = null;
            await DisplayClassRecordData();
        }
    }
    }
