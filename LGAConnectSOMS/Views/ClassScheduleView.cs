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
    public partial class ClassScheduleView : Form
    {

        private readonly SchoolAccountService _schoolAccountService;
        private readonly FacultyService _facultyService;
        private readonly SubjectsService _subjectsService;

        private IEnumerable<SchoolAccount> _facultyList = Enumerable.Empty<SchoolAccount>();
        IEnumerable<SchoolAccount> _schoolAccounts = Enumerable.Empty<SchoolAccount>();
        IEnumerable<SectionsHandled> _sectionsHandled = Enumerable.Empty<SectionsHandled>();

        private FacultyModel _selectedFaculty;
        private SectionsHandled _selectedGradeLevel;
        private SubjectsHandled _selectedSubjects;

        public ClassScheduleView()
        {
            InitializeComponent();

            _schoolAccountService = new SchoolAccountService();
            _facultyService = new FacultyService();
            _subjectsService = new SubjectsService();
        }

        //Load
        private void ClassScheduleView_Load(object sender, EventArgs e)
        {
            LoadData();
            this.RestoreWindowPosition();
            MaximizeIcon();
            ClassDaysPanel.Hide();
            string time = "7:00 pm";
            DateTime date = DateTime.Parse(time);
            DateTime dateTime = DateTime.Now;
            var day = date.ToString("HH:mm:ss");
            cmbCustomDays.Hide();
            lblRepeatEvery.Hide();
        }

        public async void LoadData()
        {
            DateTime todaysDate = DateTime.Now;
            var weekday = todaysDate.DayOfWeek.ToString();
            await ClassSchedules(weekday);
            await LoadFaculty();
            //await LoadSubjects();
            //await LoadGradeLevelSection();
        }

        //NavigationToOtherForm

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            HomeViewAdmin homeViewAdmin = new HomeViewAdmin();
            homeViewAdmin.Show();
            this.Hide();
        }

        //Commands

        public List<FacultySubjects> facultySubjects;
        public async Task SubjectsHandled(int ID)
        {
            FacultyService facultyService = new FacultyService();
            var result = await facultyService.GetFacultySubjects(ID);
            facultySubjects = result.ToList();
        }
        public List<ClassSchedule> schedulelist;
        public IEnumerable<ClassSchedule> schedule = new List<ClassSchedule>();

        public async Task ClassSchedules(string weekday)
        {
            var number = 1;
            ClassScheduleService classScheduleService = new ClassScheduleService();
            var schedules = await classScheduleService.GetClassScheduleDetails();
            schedule = await classScheduleService.GetClassScheduleDetails();
            schedulelist = schedules.ToList();
            ClassScheduleDataGridView.DataSource = schedulelist;
            ClassScheduleDataGridView.Columns[0].Visible = false;
            ClassScheduleDataGridView.Columns[7].Visible = false;
            if (weekday == "Entire Week")
            {
                schedulelist = schedules.ToList();
            }

            else
            {
                var filteredscheduledlist = schedulelist.Where(x => x.WeekDay == weekday);
                schedulelist = filteredscheduledlist.ToList();
            }

            if (!schedulelist.Any())
            {
                Label FreeSchedule = new Label();
                Panel FreeSchedulePanel = new Panel();
                PictureBox FreeSchedulePicture = new PictureBox();
                FreeSchedulePanel.Size = new System.Drawing.Size(736, 478);
                FreeSchedule.Text = "No Schedule For Today";
                FreeSchedule.AutoSize = true;
                FreeSchedule.Font = new Font("TW Cen MT", 24);
                FreeSchedulePicture.Image = LGAConnectSOMS.Properties.Resources.FreeSchedule;
                FreeSchedulePicture.SizeMode = PictureBoxSizeMode.Zoom;
                FreeSchedule.Location = new System.Drawing.Point(200, 200);
                FreeSchedulePicture.Location = new System.Drawing.Point(300, 120);
                FreeSchedule.ForeColor = Color.Black;
                ClassSchedulePanel.Controls.Add(FreeSchedulePanel);
                FreeSchedulePanel.Controls.Add(FreeSchedulePicture);
                FreeSchedulePanel.Controls.Add(FreeSchedule);
                label1.Text = weekday;
            }

            else
            {
                foreach (ClassSchedule classSchedule in schedulelist)
                {
                    Label Subject = new Label();
                    Label Teacher = new Label();
                    Label StartTimeEndTime = new Label();
                    Label WeekDay = new Label();
                    Label GradeLevelText = new Label();
                    Panel dynamicPanel = new Panel();
                    Panel LinePanel = new Panel();
                    LinePanel.Size = new Size(3, 50);
                    LinePanel.Location = new System.Drawing.Point(480, 20);
                    LinePanel.AutoSize = true;
                    LinePanel.BackColor = Color.White;
                    PictureBox pictureBox = new PictureBox();
                    Subject.Font = new Font("TW Cen MT", 16);
                    Teacher.Font = new Font("TW Cen MT", 16);
                    StartTimeEndTime.Font = new Font("TW Cen MT", 15);
                    WeekDay.AutoSize = true;
                    WeekDay.ForeColor = Color.White;
                    WeekDay.Text = classSchedule.WeekDay;
                    WeekDay.Font = new Font("TW Cen MT", 14);
                    GradeLevelText.AutoSize = true;
                    GradeLevelText.ForeColor = Color.White;
                    GradeLevelText.Text = classSchedule.WeekDay;
                    GradeLevelText.Font = new Font("TW Cen MT", 14);
                    GradeLevelText.Location = new System.Drawing.Point(95, 50);
                    WeekDay.Location = new System.Drawing.Point(500, 20);
                    StartTimeEndTime.AutoSize = true;
                    pictureBox.Image = Properties.Resources.Subject;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    Subject.Text = classSchedule.Subject;
                    Subject.ForeColor = ColorTranslator.FromHtml("#fff");
                    Teacher.Text = classSchedule.Firstname + " " + classSchedule.Lastname;
                    Teacher.ForeColor = Color.White;
                    StartTimeEndTime.Text = classSchedule.StartTime + " - " + classSchedule.EndTime;
                    GradeLevelText.Text = classSchedule.GradeLevel;
                    StartTimeEndTime.ForeColor = Color.White;
                    Subject.Location = new System.Drawing.Point(95, 20);
                    Teacher.Location = new System.Drawing.Point(95, 70);
                    Subject.AutoSize = true;
                    Teacher.AutoSize = true;
                    StartTimeEndTime.Location = new System.Drawing.Point(500, 45);
                    pictureBox.Location = new System.Drawing.Point(0, 15);
                    //dynamicPanel.Location = new System.Drawing.Point(500, 101);
                    dynamicPanel.Name = "Panel1";
                    dynamicPanel.Size = new System.Drawing.Size(700, 100);
                    dynamicPanel.BackColor = Color.LightBlue;
                    //Controls.Add(dynamicPanel);

                    dynamicPanel.Controls.Add(Subject);
                    dynamicPanel.Controls.Add(Teacher);
                    dynamicPanel.Controls.Add(StartTimeEndTime);
                    dynamicPanel.Controls.Add(pictureBox);
                    dynamicPanel.Controls.Add(LinePanel);
                    dynamicPanel.Controls.Add(WeekDay);
                    dynamicPanel.Controls.Add(GradeLevelText);
                    ClassSchedulePanel.Controls.Add(dynamicPanel);
                    dynamicPanel.Margin = new Padding(0, 0, 0, 10);

                    var rgb1 = 0;
                    var rgb2 = 0;
                    var rgb3 = 0;

                    if (number == 1)
                    {
                        rgb1 = 240;
                        rgb2 = 52;
                        rgb3 = 52;
                        number = number + 1;
                    }

                    else if (number == 2)
                    {
                        rgb1 = 250;
                        rgb2 = 190;
                        rgb3 = 88;
                        number = number + 1;
                    }

                    else if (number == 3)
                    {
                        rgb1 = 13;
                        rgb2 = 180;
                        rgb3 = 185;
                        number = number + 1;
                    }

                    else if (number == 4)
                    {
                        rgb1 = 142;
                        rgb2 = 68;
                        rgb3 = 173;
                        number = 1;
                    }

                    Color randomColor = Color.FromArgb(rgb1, rgb2, rgb3);
                    var Backcolor = randomColor;
                    dynamicPanel.BackColor = Backcolor;
                    label1.Text = weekday;
                }
            }
        }

        private async void lblMonday_Click(object sender, EventArgs e)
        {
            label1.Text = "Monday";
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblTuesday_Click(object sender, EventArgs e)
        {
            label1.Text = "Tuesday";
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblWednesday_Click(object sender, EventArgs e)
        {
            label1.Text = "Wednesday";
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblThursday_Click(object sender, EventArgs e)
        {
            label1.Text = "Thursday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblFriday_Click(object sender, EventArgs e)
        {
            label1.Text = "Friday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblSaturday_Click(object sender, EventArgs e)
        {
            label1.Text = "Saturday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblSunday_Click(object sender, EventArgs e)
        {
            label1.Text = "Sunday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private async void lblEntireWeek_Click(object sender, EventArgs e)
        {
            label1.Text = "Entire Week";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules(label1.Text);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            IsClassDaysVisible();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            IsClassDaysVisible();
        }

        private void ClassScheduleView_Click(object sender, EventArgs e)
        {
            IsClassDaysVisible();
        }

        public void IsClassDaysVisible()
        {
            if (ClassDaysPanel.Visible == false)
            {
                ClassDaysPanel.Show();
            }

            else if (ClassDaysPanel.Visible == true)
            {
                ClassDaysPanel.Hide();
            }
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

        private void ClassScheduleView_FormClosing(object sender, FormClosingEventArgs e)
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

        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        public async Task LoadGradeLevelSection()
        {
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await gradeLevelSectionService.GetGradeLevel();
            var gradelevelslist = gradeLevelSections.ToList();
        }

        IEnumerable<Subjects> subjects = new List<Subjects>();
        
        public async Task LoadFaculty()
        {
            _schoolAccounts = await _schoolAccountService.GetSchoolAccountOnly();
            _facultyList = _schoolAccounts.Where(x => x.isAdmin == 0).OrderBy(o => o.firstname);

            cmbFaculty.ValueMember = "Id";
            cmbFaculty.DisplayMember = "FullName";

            var facultyList = new List<FacultyModel>();

            foreach (var faculty in _facultyList)
            {
                facultyList.Add(new FacultyModel
                {
                    Id = faculty.id,
                    FullName = faculty.Fullname
                });
            }

            cmbFaculty.DataSource = facultyList;
        }

        private async Task LoadGradeLevels()
        {
            _sectionsHandled = await _facultyService.GetSectionsHandled(_selectedFaculty.Id);

            cmbGradeLevels.ValueMember = "GradeLevelID";
            cmbGradeLevels.DisplayMember = "DisplayText";

            cmbGradeLevels.DataSource = _sectionsHandled;
        }

        public async Task LoadSubjects()
        {
            var result = (await _subjectsService.GetSubjectsHandled(_selectedFaculty.Id, _selectedGradeLevel.GradeLevelID)).OrderBy(x => x.SubjectName).ToList();

            cmbSubjects.ValueMember = "SubjectId";
            cmbSubjects.DisplayMember = "SubjectName";

            cmbSubjects.DataSource = result;
        }

        private async void cmbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedGradeLevel = (SectionsHandled)cmbGradeLevels.SelectedItem;

            if(_selectedGradeLevel != null) 
            {
                await LoadSubjects();
            }
        }

        public string weekday;
        public bool IsSuccess;
        private async void btnAddClassSchedule_Click(object sender, EventArgs e)
        {
            //var selectedGradeLevel = (string)cmbGradeLevels.SelectedItem;
            //var selectedSection = cmbSections.SelectedItem;
            //var selectedteacher = (string)cmbFaculty.SelectedItem;
            //var selectedSubject = cmbSubjects.SelectedItem;
            //var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels.Equals(selectedGradeLevel) && x.SectionName.Equals(selectedSection)).GradeLevel;
            //var subjectid = subjects.First(x => x.SubjectName.Equals(selectedSubject) && x.GradeLevel == gradeLevelId).GradeLevel;
            //var teacherid = _schoolAccounts.First(x => x.Fullname == selectedteacher).id;

            var subjectid = _selectedSubjects.SubjectId;
            var teacherid = _selectedFaculty.Id;
            var gradeLevelId = _selectedGradeLevel.GradeLevelID;

            var starttime = Convert.ToDateTime(cmbStartTime.Text);
            var endtime = Convert.ToDateTime(cmbEndTime.Text);
            var startday = starttime.ToString("HH:mm:ss");
            var endday = endtime.ToString("HH:mm:ss");

            if (cmbDays.Text == "Custom")
            {
                weekday = cmbCustomDays.Text;
                try
                {
                    ClassScheduleService classScheduleService = new ClassScheduleService();
                    IsSuccess = await classScheduleService.CreateClassScheduleRequest(new ClassScheduleRequest
                    {
                        Subject = subjectid,
                        StartTime = TimeSpan.Parse(startday),
                        EndTime = TimeSpan.Parse(endday),
                        TeacherID = teacherid,
                        GradeLevel = gradeLevelId,
                        WeekDay = weekday
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                if (IsSuccess)
                {
                    string message = "Added new class schedule Successfully";
                    string title = "LGA Connect SOMS Class Schedule";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }

                else
                {
                    string message = "Added class schedule Unsucessfull";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }

            else
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (i == 0)
                    {
                        weekday = "Monday";
                    }
                    else if (i == 1)
                    {
                        weekday = "Tuesday";
                    }
                    else if (i == 2)
                    {
                        weekday = "Wednesday";
                    }
                    else if (i == 3)
                    {
                        weekday = "Thursday";
                    }
                    else if (i == 4)
                    {
                        weekday = "Friday";
                    }

                    try
                    {
                        ClassScheduleService classScheduleService = new ClassScheduleService();
                        IsSuccess = await classScheduleService.CreateClassScheduleRequest(new ClassScheduleRequest
                        {
                            Subject = subjectid,
                            StartTime = TimeSpan.Parse(startday),
                            EndTime = TimeSpan.Parse(endday),
                            TeacherID = teacherid,
                            GradeLevel = gradeLevelId,
                            WeekDay = weekday
                        });
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                }

                if (IsSuccess)
                {
                    string message = "Added new class schedule Successfully";
                    string title = "LGA Connect SOMS Class Schedule";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }

                else
                {
                    string message = "Added class schedule Unsucessfull";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDays.SelectedIndex == 1)
            {
                cmbCustomDays.Show();
                lblRepeatEvery.Show();
                cmbDays.Enabled = false;
                cmbCustomDays.SelectedIndex = -1;
            }
        }

        private async void cmbLastname_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFaculty = (FacultyModel)cmbFaculty.SelectedItem;

            if (_selectedFaculty != null)
            {
                await LoadGradeLevels();
            }

            //var selectedTeacher = cmbFaculty.Text;
            //var teacherid = _schoolAccounts.First(x => x.Fullname == selectedTeacher).id;
            //FacultyService facultyService = new FacultyService();
            //var result = await facultyService.GetFacultySubjects(teacherid);
            //facultySubjects = result.ToList();
            //var gradelevel = facultySubjects.Select(x => x.GradeLevel).Distinct();
            //cmbGradeLevels.DataSource = gradelevel.ToList();
            //var facultysectionsHandled = facultySubjects.Select(x => x.SectionName).Distinct();
            //cmbSections.DataSource = facultysectionsHandled.ToList();
            //var subjects = facultySubjects.Select(x => x.SubjectName).Distinct();
            //cmbSubjects.DataSource = subjects.ToList();
        }

        private void cmbCustomDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomDays.Text == "Cancel")
            {
                cmbDays.Enabled = true;
                cmbCustomDays.Hide();
                lblRepeatEvery.Hide();
                cmbDays.SelectedIndex = -1;
            }
        }

        private void ClassScheduleDataGridView_Click(object sender, EventArgs e)
        {
            var selectedFullnameTeacher = ClassScheduleDataGridView.CurrentRow.Cells[2].Value.ToString() + " " + ClassScheduleDataGridView.CurrentRow.Cells[1].Value.ToString();
            var selectedFirstnameTeacher = ClassScheduleDataGridView.CurrentRow.Cells[2].Value.ToString();
            var selectedLastnameTeacher = ClassScheduleDataGridView.CurrentRow.Cells[1].Value.ToString();
            var selectedGradelevel = ClassScheduleDataGridView.CurrentRow.Cells[8].Value.ToString();
            //var selectedSection = ClassScheduleDataGridView.CurrentRow.Cells[0].Value.ToString();          
            var selectedsubject = ClassScheduleDataGridView.CurrentRow.Cells[5].Value.ToString();
            var selectedStartTime = ClassScheduleDataGridView.CurrentRow.Cells[3].Value.ToString();
            var selectedEndTime = ClassScheduleDataGridView.CurrentRow.Cells[4].Value.ToString();
            var selecteddays = ClassScheduleDataGridView.CurrentRow.Cells[6].Value.ToString();

            //var result = schedule.Where(x => x.Firstname.Equals(selectedFirstnameTeacher) && x.Lastname.Equals(selectedLastnameTeacher) && x.GradeLevel.Equals(selectedGradelevel) && x.Subject.Equals(selectedsubject) && x.StartTime.Equals(selectedStartTime) && x.EndTime.Equals(selectedEndTime) && x.WeekDay.Equals(selecteddays));

            var result = schedule.Where(x => x.Firstname.Equals(selectedFirstnameTeacher) && x.Lastname.Equals(selectedLastnameTeacher) && x.GradeLevel.Equals(selectedGradelevel) && x.Subject.Equals(selectedsubject) && x.StartTime.Equals(selectedStartTime) && x.EndTime.Equals(selectedEndTime));

            var count = result.Count();
            EditClassScheduleView editClassScheduleView = new EditClassScheduleView();
            if (count == 5)
            {

                editClassScheduleView.cmbDays.Text = "Every weekday (Mon - Fri)";
                editClassScheduleView.txtFullname.Text = selectedFirstnameTeacher + " " + selectedLastnameTeacher;
                editClassScheduleView.txtGradeLevel.Text = selectedGradelevel;
                editClassScheduleView.txtSubject.Text = selectedsubject;
                editClassScheduleView.cmbStartTime.Text = selectedStartTime;
                editClassScheduleView.cmbEndTime.Text = selectedEndTime;
                editClassScheduleView.ShowDialog();
            }

            else
            {
                editClassScheduleView.cmbDays.Text = selecteddays;
                editClassScheduleView.txtFullname.Text = selectedFirstnameTeacher + " " + selectedLastnameTeacher;
                editClassScheduleView.txtGradeLevel.Text = selectedGradelevel;
                editClassScheduleView.txtSubject.Text = selectedsubject;
                editClassScheduleView.cmbStartTime.Text = selectedStartTime;
                editClassScheduleView.cmbEndTime.Text = selectedEndTime;
                editClassScheduleView.ShowDialog();
            }
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSubjects = (SubjectsHandled)cmbSubjects.SelectedItem;
        }
    }
}
