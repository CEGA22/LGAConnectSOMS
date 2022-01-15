using iTextSharp.text;
using iTextSharp.text.pdf;
using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private ClassSchedule _selectedSchedule;

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
            btnDeleteClassSchedule.Hide();
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
            ClassScheduleDataGridView.Columns[1].Visible = false;
            ClassScheduleDataGridView.Columns[2].Visible = false;
            ClassScheduleDataGridView.Columns[3].Visible = false;
            ClassScheduleDataGridView.Columns[10].Visible = false;
            ClassScheduleDataGridView.Columns[11].Visible = false;
            ClassScheduleDataGridView.AllowUserToAddRows = false;
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
                FreeSchedule.Font = new System.Drawing.Font("TW Cen MT", 24);
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
                    Subject.Font = new System.Drawing.Font("TW Cen MT", 16);
                    Teacher.Font = new System.Drawing.Font("TW Cen MT", 16);
                    StartTimeEndTime.Font = new System.Drawing.Font("TW Cen MT", 15);
                    WeekDay.AutoSize = true;
                    WeekDay.ForeColor = Color.White;
                    WeekDay.Text = classSchedule.WeekDay;
                    WeekDay.Font = new System.Drawing.Font("TW Cen MT", 14);
                    GradeLevelText.AutoSize = true;
                    GradeLevelText.ForeColor = Color.White;
                    GradeLevelText.Text = classSchedule.WeekDay;
                    GradeLevelText.Font = new System.Drawing.Font("TW Cen MT", 14);
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

            if (_selectedSchedule != null)
            {
                cmbGradeLevels.Text = $"{_selectedSchedule.GradeLevel} - {_selectedSchedule.SectionName}";
                //if (_sectionsHandled.Any(x => x.GradeLevel == _selectedSchedule.GradeLevel && x.SectionName == _selectedSchedule.SectionName))
                //{
                //    cmbGradeLevels.Text = $"{_selectedSchedule.GradeLevel} - {_selectedSchedule.SectionName}";
                //}
            }
        }

        public async Task LoadSubjects()
        {
            var result = (await _subjectsService.GetSubjectsHandled(_selectedFaculty.Id, _selectedGradeLevel.GradeLevelID)).OrderBy(x => x.SubjectName).ToList();

            cmbSubjects.ValueMember = "SubjectId";
            cmbSubjects.DisplayMember = "SubjectName";

            cmbSubjects.DataSource = result;

            if (_selectedSchedule != null)
            {
                cmbSubjects.Text = _selectedSchedule.Subject;
            }
        }

        private async void cmbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedGradeLevel = (SectionsHandled)cmbGradeLevels.SelectedItem;

            if (_selectedGradeLevel != null)
            {
                await LoadSubjects();
            }
        }

        public string weekday;
        public string weekdayverification;
        public bool IsSuccess;
        List<ClassSchedule> listofweekdays = new List<ClassSchedule>();
        List<ClassSchedule> verificationS = new List<ClassSchedule>();
        private async void btnAddClassSchedule_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (editclassschedule == 0)
            {
                if (!string.IsNullOrEmpty(cmbStartTime.Text) && !string.IsNullOrEmpty(cmbEndTime.Text) && !string.IsNullOrEmpty(cmbDays.Text))
                {
                    if (cmbDays.Text == "Custom" && string.IsNullOrEmpty(cmbCustomDays.Text))
                    {
                        MessageBox.Show("Please fill in all fields!", "Error", buttons, MessageBoxIcon.Information);
                        return;
                    }
                    if (cmbDays.Text == "Custom")
                    {
                        var verfification = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.GradeLevelSection.Equals(cmbGradeLevels.Text));

                        if (verfification.Any())
                        {
                            string message = "The schedule for this subject is already been scheduled.";
                            string title = "LGA Connect SOMS";
                            MessageBoxButtons buttonss = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show(message, title, buttonss, MessageBoxIcon.Error);
                            if (result == DialogResult.OK)
                            { }
                        }

                        else
                        {
                            var verfificationtime = schedule.Where(x => x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(cmbCustomDays.Text));
                            if (verfificationtime.Any())
                            {
                                string message = "Time scheduled already occupied. Please select other time schedule";
                                string title = "LGA Connect SOMS";
                                MessageBoxButtons buttonss = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show(message, title, buttonss, MessageBoxIcon.Error);
                                if (result == DialogResult.OK)
                                { }                               
                            }

                            else
                            {
                                CreateClassSchedule();
                            }
                        }
                    }

                    else
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (i == 0)
                            {
                                weekdayverification = "Monday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 1)
                            {
                                weekdayverification = "Tuesday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 2)
                            {
                                weekdayverification = "Wednesday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 3)
                            {
                                weekdayverification = "Thursday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 4)
                            {
                                weekdayverification = "Friday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }
                            else if (i == 5)
                            {
                                if (listofweekdays.Count == 5)
                                {
                                    string message = "The schedule for this subject is already been scheduled.";
                                    string title = "LGA Connect SOMS";
                                    MessageBoxButtons buttonss = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show(message, title, buttonss, MessageBoxIcon.Error);
                                    if (result == DialogResult.OK)
                                    { }                                    
                                }
                                else
                                {                                   
                                    var verfificationtime = schedule.Where(x => x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.GradeLevelSection.Equals(cmbGradeLevels.Text));
                                    if (verfificationtime.Any())
                                    {
                                        string message = "Time scheduled already occupied. Please select other time schedule";
                                        string title = "LGA Connect SOMS";
                                        MessageBoxButtons buttonss = MessageBoxButtons.OK;
                                        DialogResult result = MessageBox.Show(message, title, buttonss, MessageBoxIcon.Error);
                                        if (result == DialogResult.OK)
                                        { }                                      
                                    }
                                    else
                                    {
                                        CreateClassSchedule();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!", "Error", buttons, MessageBoxIcon.Information);
                }
            }

            else
            {
                if (!string.IsNullOrEmpty(cmbStartTime.Text) && !string.IsNullOrEmpty(cmbEndTime.Text) && !string.IsNullOrEmpty(cmbDays.Text))
                {
                    if (cmbDays.Text == "Custom" && string.IsNullOrEmpty(cmbCustomDays.Text))
                    {
                        MessageBox.Show("Please fill in all fields!", "Error", buttons, MessageBoxIcon.Information);
                        return;
                    }
                    if (cmbDays.Text == "Custom")
                    {
                        var verfification = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(cmbCustomDays.Text) && x.GradeLevelSection.Equals(cmbGradeLevels.Text));

                        if (verfification.Any())
                        {
                            MessageBox.Show("Already sched");
                        }

                        else
                        {
                            var verfificationtime = schedule.Where(x => x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(cmbCustomDays.Text) && x.GradeLevelSection.Equals(cmbGradeLevels.Text));
                            if (verfificationtime.Any())
                            {
                                MessageBox.Show("Time scheduled already occupied. Please select other time schedule");
                            }

                            else
                            {
                                UpdateClassSchedule();
                                editclassschedule = 0;
                                btnDeleteClassSchedule.Hide();
                            }
                        }
                    }

                    else
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (i == 0)
                            {
                                weekdayverification = "Monday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 1)
                            {
                                weekdayverification = "Tuesday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 2)
                            {
                                weekdayverification = "Wednesday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 3)
                            {
                                weekdayverification = "Thursday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }

                            else if (i == 4)
                            {
                                weekdayverification = "Friday";
                                verificationS = schedule.Where(x => x.FullName.Equals(cmbFaculty.Text) && x.Subject.Equals(cmbSubjects.Text) && x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text && x.WeekDay.Equals(weekdayverification)).ToList();
                                listofweekdays.AddRange(verificationS);
                            }
                            else if (i == 5)
                            {
                                if (listofweekdays.Count == 5)
                                {
                                    string message = "The schedule for this subject is already been scheduled.";
                                    string title = "LGA Connect SOMS";
                                    MessageBoxButtons buttonss = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show(message, title, buttonss, MessageBoxIcon.Error);
                                    if (result == DialogResult.OK)
                                    {

                                    }                                  
                                }
                                else
                                {                                  
                                    var verfificationtime = schedule.Where(x => x.StartTime == cmbStartTime.Text && x.EndTime == cmbEndTime.Text);
                                    if (verfificationtime.Any())
                                    {
                                        string message = "Time scheduled already occupied. Please select other time schedule";
                                        string title = "LGA Connect SOMS";
                                        MessageBoxButtons buttonsss = MessageBoxButtons.OK;
                                        DialogResult result = MessageBox.Show(message, title, buttonsss, MessageBoxIcon.Error);
                                        if (result == DialogResult.OK)
                                        {

                                        }                                   
                                    }
                                    else
                                    {
                                        UpdateClassSchedule();
                                        editclassschedule = 0;
                                        btnDeleteClassSchedule.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!", "Error", buttons, MessageBoxIcon.Information);
                }
            }
            
        }

        public async void CreateClassSchedule()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            var subjectid = _selectedSubjects.SubjectId;
            var teacherid = _selectedFaculty.Id;
            var gradeLevelId = _selectedGradeLevel.GradeLevelID;

            var starttime = Convert.ToDateTime(cmbStartTime.Text);
            var endtime = Convert.ToDateTime(cmbEndTime.Text);
            var startday = starttime.ToString("HH:mm:ss");
            var endday = endtime.ToString("HH:mm:ss");

            ClassScheduleService classScheduleService = new ClassScheduleService();

            if (cmbDays.Text == "Custom")
            {
                weekday = cmbCustomDays.Text;
                try
                {
                    IsSuccess = await classScheduleService.CreateClassScheduleRequest(new List<ClassScheduleRequest>
                    {
                        new ClassScheduleRequest
                        {
                            Subject = subjectid,
                            StartTime = TimeSpan.Parse(startday),
                            EndTime = TimeSpan.Parse(endday),
                            TeacherID = teacherid,
                            GradeLevel = gradeLevelId,
                            WeekDay = weekday
                        }
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                if (IsSuccess)
                {
                    _selectedSchedule = null;
                    string message = "Added new class schedule Successfully";
                    string title = "LGA Connect SOMS Class Schedule";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    tabControl1.SelectedIndex = 1;

                    await ClassSchedules(label1.Text);
                }

                else
                {
                    string message = "Added class schedule Unsucessfull";
                    string title = "Error";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }

            else
            {
                var itemsToSave = new List<ClassScheduleRequest>();

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

                    itemsToSave.Add(new ClassScheduleRequest
                    {
                        Subject = subjectid,
                        StartTime = TimeSpan.Parse(startday),
                        EndTime = TimeSpan.Parse(endday),
                        TeacherID = teacherid,
                        GradeLevel = gradeLevelId,
                        WeekDay = weekday
                    });
                }

                try
                {
                    IsSuccess = await classScheduleService.CreateClassScheduleRequest(itemsToSave);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                if (IsSuccess)
                {
                    _selectedSchedule = null;
                    string message = "Added new class schedule Successfully";
                    string title = "LGA Connect SOMS Class Schedule";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    tabControl1.SelectedIndex = 1;

                    await ClassSchedules(label1.Text);
                }

                else
                {
                    string message = "Added class schedule Unsucessfull";
                    string title = "Error";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
        }

        public async void UpdateClassSchedule()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            var subjectid = _selectedSubjects.SubjectId;
            var teacherid = _selectedFaculty.Id;
            var gradeLevelId = _selectedGradeLevel.GradeLevelID;

            var starttime = Convert.ToDateTime(cmbStartTime.Text);
            var endtime = Convert.ToDateTime(cmbEndTime.Text);
            var startday = starttime.ToString("HH:mm:ss");
            var endday = endtime.ToString("HH:mm:ss");

            ClassScheduleService classScheduleService = new ClassScheduleService();

            if (cmbDays.Text == "Custom")
            {
                weekday = cmbCustomDays.Text;
                try
                {
                    IsSuccess = await classScheduleService.UpdateClassScheduleRequest(new List<ClassScheduleRequest>
                    {
                        new ClassScheduleRequest
                        {
                            Subject = subjectid,
                            StartTime = TimeSpan.Parse(startday),
                            EndTime = TimeSpan.Parse(endday),
                            TeacherID = teacherid,
                            GradeLevel = gradeLevelId,
                            WeekDay = weekday
                        }
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                if (IsSuccess)
                {
                    _selectedSchedule = null;
                    string message = "Updated class schedule Successfully";
                    string title = "LGA Connect SOMS Class Schedule";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    tabControl1.SelectedIndex = 1;

                    await ClassSchedules(label1.Text);
                }

                else
                {
                    string message = "Update class schedule Unsucessfull";
                    string title = "Error";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }

            else
            {
                var itemsToSave = new List<ClassScheduleRequest>();

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

                    itemsToSave.Add(new ClassScheduleRequest
                    {
                        Subject = subjectid,
                        StartTime = TimeSpan.Parse(startday),
                        EndTime = TimeSpan.Parse(endday),
                        TeacherID = teacherid,
                        GradeLevel = gradeLevelId,
                        WeekDay = weekday
                    });
                }

                try
                {
                    IsSuccess = await classScheduleService.UpdateClassScheduleRequest(itemsToSave);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                if (IsSuccess)
                {
                    _selectedSchedule = null;
                    string message = "Updated class schedule Successfully";
                    string title = "LGA Connect SOMS Class Schedule";
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    tabControl1.SelectedIndex = 1;

                    await ClassSchedules(label1.Text);
                }

                else
                {
                    string message = "Update class schedule Unsucessfull";
                    string title = "Error";
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

            //var selectedFullnameTeacher = ClassScheduleDataGridView.CurrentRow.Cells[2].Value.ToString() + " " + ClassScheduleDataGridView.CurrentRow.Cells[1].Value.ToString();
            //var selectedFirstnameTeacher = ClassScheduleDataGridView.CurrentRow.Cells[2].Value.ToString();
            //var selectedLastnameTeacher = ClassScheduleDataGridView.CurrentRow.Cells[1].Value.ToString();
            //var selectedGradelevel = ClassScheduleDataGridView.CurrentRow.Cells[8].Value.ToString();
            ////var selectedSection = ClassScheduleDataGridView.CurrentRow.Cells[0].Value.ToString();          
            //var selectedsubject = ClassScheduleDataGridView.CurrentRow.Cells[5].Value.ToString();
            //var selectedStartTime = ClassScheduleDataGridView.CurrentRow.Cells[3].Value.ToString();
            //var selectedEndTime = ClassScheduleDataGridView.CurrentRow.Cells[4].Value.ToString();
            //var selecteddays = ClassScheduleDataGridView.CurrentRow.Cells[6].Value.ToString();

            ////var result = schedule.Where(x => x.Firstname.Equals(selectedFirstnameTeacher) && x.Lastname.Equals(selectedLastnameTeacher) && x.GradeLevel.Equals(selectedGradelevel) && x.Subject.Equals(selectedsubject) && x.StartTime.Equals(selectedStartTime) && x.EndTime.Equals(selectedEndTime) && x.WeekDay.Equals(selecteddays));

            //var result = schedule.Where(x => x.Firstname.Equals(selectedFirstnameTeacher) && x.Lastname.Equals(selectedLastnameTeacher) && x.GradeLevel.Equals(selectedGradelevel) && x.Subject.Equals(selectedsubject) && x.StartTime.Equals(selectedStartTime) && x.EndTime.Equals(selectedEndTime));

            //var count = result.Count();
            //EditClassScheduleView editClassScheduleView = new EditClassScheduleView();
            //if (count == 5)
            //{

            //    editClassScheduleView.cmbDays.Text = "Every weekday (Mon - Fri)";
            //    editClassScheduleView.txtFullname.Text = selectedFirstnameTeacher + " " + selectedLastnameTeacher;
            //    editClassScheduleView.txtGradeLevel.Text = selectedGradelevel;
            //    editClassScheduleView.txtSubject.Text = selectedsubject;
            //    editClassScheduleView.cmbStartTime.Text = selectedStartTime;
            //    editClassScheduleView.cmbEndTime.Text = selectedEndTime;
            //    editClassScheduleView.ShowDialog();
            //}

            //else
            //{
            //    editClassScheduleView.cmbDays.Text = selecteddays;
            //    editClassScheduleView.txtFullname.Text = selectedFirstnameTeacher + " " + selectedLastnameTeacher;
            //    editClassScheduleView.txtGradeLevel.Text = selectedGradelevel;
            //    editClassScheduleView.txtSubject.Text = selectedsubject;
            //    editClassScheduleView.cmbStartTime.Text = selectedStartTime;
            //    editClassScheduleView.cmbEndTime.Text = selectedEndTime;
            //    editClassScheduleView.ShowDialog();
            //}
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSubjects = (SubjectsHandled)cmbSubjects.SelectedItem;
        }

        private void ClassScheduleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnEditSchedule.Visible = ClassScheduleDataGridView.SelectedRows.Count > 0;
        }

        private void ClassScheduleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassScheduleDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditClassScheduleView editClassScheduleView = new EditClassScheduleView(_selectedSchedule);
            editClassScheduleView.ShowDialog();
        }

        public int editclassschedule = 0;
        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            editclassschedule = 1;
            btnDeleteClassSchedule.Show();
            if (ClassScheduleDataGridView.SelectedRows.Count > 0)
            {

                tabControl1.SelectedIndex = 2;

                foreach (DataGridViewRow row in ClassScheduleDataGridView.SelectedRows)
                {
                    _selectedSchedule = ClassScheduleDataGridView.Rows[row.Index].DataBoundItem as ClassSchedule;

                    if (_selectedSchedule.FullName != cmbFaculty.Text)
                    {
                        cmbFaculty.Text = _selectedSchedule.FullName;
                    }
                    else
                    {
                        cmbLastname_SelectedIndexChanged(this, null);
                    }

                    _selectedFaculty = new FacultyModel
                    {
                        Id = _selectedSchedule.SchoolID,
                        FullName = _selectedSchedule.FullName
                    };

                    cmbStartTime.Text = _selectedSchedule.StartTime;
                    cmbEndTime.Text = _selectedSchedule.EndTime;

                    var result = schedule.Where(x => x.FullName.Equals(_selectedSchedule.FullName) && x.GradeLevel.Equals(_selectedSchedule.GradeLevel) && x.Subject.Equals(_selectedSchedule.Subject) && x.StartTime.Equals(_selectedSchedule.StartTime) && x.EndTime.Equals(_selectedSchedule.EndTime));

                    cmbDays.Text = result.Count() == 5 ? "Every weekday (Mon - Fri)" : "Custom";
                    cmbCustomDays.Visible = result.Count() != 5;
                    cmbCustomDays.Text = _selectedSchedule.WeekDay;
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            var classSchedulelistWithoutid = schedule.Select(x => new { x.FullName, x.GradeLevelSection, x.SectionName, x.Subject, x.WeekDay, x.StartTime, x.EndTime }).ToList();

            DataGridView pdfclassschedule = new DataGridView();           
            pdfclassschedule.Hide();
            this.Controls.Add(pdfclassschedule);
            pdfclassschedule.DataSource = classSchedulelistWithoutid.ToList();
            if (pdfclassschedule.Rows.Count > 0)
            {    
                var datetime = DateTime.Now.ToString("yyyy");
                var schoolYearEnd = int.Parse(datetime) + 1;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Ladder of Gems Academy Class Schedule.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(pdfclassschedule.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.SpacingBefore = 30;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in pdfclassschedule.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in pdfclassschedule.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(Convert.ToString(cell.Value));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {

                                Document pdfDoc = new Document(PageSize.LEGAL_LANDSCAPE.Rotate());
                                PdfWriter.GetInstance(pdfDoc, stream);
                                Paragraph p = new Paragraph("Ladder of Gems Academy, Inc.");
                                Paragraph a = new Paragraph("Class Schedule");
                                Paragraph y1 = new Paragraph(datetime + " - " + schoolYearEnd);
                                p.Alignment = Element.ALIGN_CENTER;
                                a.Alignment = Element.ALIGN_CENTER;
                                y1.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Open();
                                pdfDoc.Add(p);
                                pdfDoc.Add(a);
                                pdfDoc.Add(y1);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            string Successmessage = "Class Schedule successfully save as pdf file";
                            string Successtitle = "LGA Connect SOMS Class Schedule";
                            MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                            DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                            if (Successresult == DialogResult.OK)
                            {  }                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export", "LGA Connect SOMS");
            }
        }

        private async void btnDeleteClassSchedule_Click(object sender, EventArgs e)
        {
            var subjectid = _selectedSubjects.SubjectId;
            var teacherid = _selectedFaculty.Id;
            var gradeLevelId = _selectedGradeLevel.GradeLevelID;

            try
            {               
                string message = "Are you sure you want to delete this schedule?";
                string title = "LGA Connect SOMS Student Account";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ClassScheduleService classScheduleService = new ClassScheduleService();
                    var IsSuccess = await classScheduleService.DeleteClassScheduleRequest(teacherid,subjectid,gradeLevelId);
                    if (IsSuccess)
                    {
                        MessageBox.Show("Delete class schedule Successfully");
                        btnDeleteClassSchedule.Hide();
                        tabControl1.SelectedIndex = 1;

                        await ClassSchedules(label1.Text);
                    }

                    else
                    {
                        MessageBox.Show("Delete class schedule Not Successfull");
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
    }
}
