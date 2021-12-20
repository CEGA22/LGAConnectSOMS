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
        
        public ClassScheduleView()
        {
            InitializeComponent();
        }

        //Load
        private async void ClassScheduleView_Load(object sender, EventArgs e)
        {
            LoadData();
            this.RestoreWindowPosition();
            MaximizeIcon();
            ClassDaysPanel.Hide();
            
            //string time = "7:00 pm";
            //DateTime date = DateTime.Parse(time);
            //var day = date.ToString("HH:mm:ss");          
        }


        public async void LoadData()
        {
            await LoadFaculty();
            await ClassSchedules();
            await LoadSubjects();
            await LoadGradeLevelSection();
            
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
        public List<ClassSchedule> schedulelist;
        public async Task ClassSchedules()
        {
            var number = 1;
            ClassScheduleService classScheduleService = new ClassScheduleService();
            var schedules = await classScheduleService.GetClassScheduleDetails();
            schedulelist = schedules.ToList();
            ClassScheduleDataGridView.DataSource = schedulelist;
            ClassScheduleDataGridView.Columns[0].Visible = false;
            ClassScheduleDataGridView.Columns[7].Visible = false;          
            var count = schedulelist.Count();
            if (count == 0)
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
                FreeSchedule.ForeColor = Color.White;
                ClassSchedulePanel.Controls.Add(FreeSchedulePanel);
                FreeSchedulePanel.Controls.Add(FreeSchedulePicture);
                FreeSchedulePanel.Controls.Add(FreeSchedule);
            }

            else
            {
                foreach (ClassSchedule classSchedule in schedulelist)
                {
                    Label Subject = new Label();
                    Label Teacher = new Label();
                    Label StartTimeEndTime = new Label();
                    Label WeekDay = new Label();
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
                    WeekDay.Location = new System.Drawing.Point(500, 20);
                    StartTimeEndTime.AutoSize = true;                   
                    pictureBox.Image = Properties.Resources.Subject;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    Subject.Text = classSchedule.Subject;
                    Subject.ForeColor = ColorTranslator.FromHtml("#fff");
                    Teacher.Text = classSchedule.Firstname + " " + classSchedule.Lastname;
                    Teacher.ForeColor = Color.White;
                    StartTimeEndTime.Text = classSchedule.StartTime + " - " + classSchedule.EndTime;
                    StartTimeEndTime.ForeColor = Color.White;
                    Subject.Location = new System.Drawing.Point(85, 20);
                    Teacher.Location = new System.Drawing.Point(85, 50);
                    Subject.AutoSize = true;
                    Teacher.AutoSize = true;
                    StartTimeEndTime.Location = new System.Drawing.Point(500, 45);
                    pictureBox.Location = new System.Drawing.Point(0, 15);
                    //dynamicPanel.Location = new System.Drawing.Point(500, 101);
                    dynamicPanel.Name = "Panel1";
                    dynamicPanel.Size = new System.Drawing.Size(700, 94);
                    dynamicPanel.BackColor = Color.LightBlue;
                    //Controls.Add(dynamicPanel);

                    dynamicPanel.Controls.Add(Subject);
                    dynamicPanel.Controls.Add(Teacher);
                    dynamicPanel.Controls.Add(StartTimeEndTime);
                    dynamicPanel.Controls.Add(pictureBox);
                    dynamicPanel.Controls.Add(LinePanel);
                    dynamicPanel.Controls.Add(WeekDay);
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
                }
            }
            
        }

        public async Task WeekDaySelection(string selectedweekday)
        {
           
            var number = 1;
            ClassScheduleService classScheduleService = new ClassScheduleService();
            var weekdayselection = await classScheduleService.GetClassScheduleByWeekDayDetails(selectedweekday);
            schedulelist = weekdayselection.ToList();
            var count = schedulelist.Count();
            if (count == 0)
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
                FreeSchedule.ForeColor = Color.White;
                ClassSchedulePanel.Controls.Add(FreeSchedulePanel);
                FreeSchedulePanel.Controls.Add(FreeSchedulePicture);
                FreeSchedulePanel.Controls.Add(FreeSchedule);
            }

            else
            {
                foreach (ClassSchedule classSchedule in schedulelist)
                {
                    Label Subject = new Label();
                    Label Teacher = new Label();
                    Label StartTimeEndTime = new Label();
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
                    StartTimeEndTime.AutoSize = true;
                    //Panel linebox = new Panel();
                    pictureBox.Image = Properties.Resources.Subject;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    Subject.Text = classSchedule.Subject;
                    Subject.ForeColor = ColorTranslator.FromHtml("#fff");
                    Teacher.Text = classSchedule.Firstname + " " + classSchedule.Lastname;
                    Teacher.ForeColor = Color.White;
                    StartTimeEndTime.Text = classSchedule.StartTime + " - " + classSchedule.EndTime;
                    StartTimeEndTime.ForeColor = Color.White;
                    Subject.Location = new System.Drawing.Point(85, 20);
                    Teacher.Location = new System.Drawing.Point(85, 50);
                    Subject.AutoSize = true;
                    Teacher.AutoSize = true;
                    StartTimeEndTime.Location = new System.Drawing.Point(500, 35);
                    pictureBox.Location = new System.Drawing.Point(0, 15);
                    dynamicPanel.Location = new System.Drawing.Point(500, 101);
                    dynamicPanel.Size = new System.Drawing.Size(700, 94);
                    dynamicPanel.BackColor = Color.LightBlue;
                    Controls.Add(dynamicPanel);
                    dynamicPanel.Controls.Add(Subject);
                    dynamicPanel.Controls.Add(Teacher);
                    dynamicPanel.Controls.Add(StartTimeEndTime);
                    dynamicPanel.Controls.Add(pictureBox);
                    dynamicPanel.Controls.Add(LinePanel);
                    ClassSchedulePanel.Controls.Add(dynamicPanel);


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
                }
            }

                                 
        }

        private async void lblMonday_Click(object sender, EventArgs e)
        {
            label1.Text = "Monday";
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);
        }

        private async void lblTuesday_Click(object sender, EventArgs e)
        {
            label1.Text = "Tuesday";
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);
            
        }

        private async void lblWednesday_Click(object sender, EventArgs e)
        {
            label1.Text = "Wednesday";
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);          
        }

        private async void lblThursday_Click(object sender, EventArgs e)
        {
            label1.Text = "Thursday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);
        }

        private async void lblFriday_Click(object sender, EventArgs e)
        {
            label1.Text = "Friday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);
        }

        private async void lblSaturday_Click(object sender, EventArgs e)
        {
            label1.Text = "Saturday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);
        }

        private async void lblSunday_Click(object sender, EventArgs e)
        {
            label1.Text = "Sunday";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await WeekDaySelection(label1.Text);
        }

        private async void lblEntireWeek_Click(object sender, EventArgs e)
        {
            label1.Text = "Entire Week";
            ClassDaysPanel.Hide();
            ClassDaysPanel.Hide();
            ClassSchedulePanel.Controls.Clear();
            await ClassSchedules();
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
            gradeLevelSections = await Task.Run(() => gradeLevelSectionService.GetGradeLevel());
            var gradelevelslist = gradeLevelSections.Select(x => x.GradeLevels).Distinct().ToList();
            cmbGradeLevels.DataSource = gradelevelslist.ToList();
        }

        IEnumerable<Subjects> subjects = new List<Subjects>();
        public async Task LoadSubjects()
        {
            SubjectsService subjectsService = new SubjectsService();
            subjects = await Task.Run(() => subjectsService.GetSubjects());           
        }

        IEnumerable<SchoolAccount> schoolAccounts = new List<SchoolAccount>();
        public async Task LoadFaculty()
        {
            SchoolAccountService schoolAccountService = new SchoolAccountService();
            schoolAccounts = await Task.Run(() => schoolAccountService.GetSchoolAccountDetails());
            var facultylist = schoolAccounts.Where(x => x.isAdmin == 0).Select(x => x.Fullname);
            cmbLastname.DataSource = facultylist.ToList();
        }

        private void cmbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGradeLevel = cmbGradeLevels.SelectedItem;
            var selectedSection = cmbSections.SelectedItem;
            
            var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel)).Select(x => x.SectionName);
            
            cmbSections.DataSource = gradelevelslist.ToList();
           

            var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels == selectedGradeLevel).Id;
            var subjectslist = subjects.Where(x => x.GradeLevel == gradeLevelId).Select(x => x.SubjectName);
            cmbSubjects.DataSource = subjectslist.ToList();
        }

        private void btnAddClassSchedule_Click(object sender, EventArgs e)
        {
            var selectedGradeLevel = (string)cmbGradeLevels.SelectedItem;
            var selectedSection = cmbSections.SelectedItem;
            var selectedteacher = (string)cmbLastname.SelectedItem;
            var selectedSubject = cmbSubjects.SelectedItem;
            var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels == selectedGradeLevel && x.SectionName == selectedSection).Id;
            var subjectid = subjects.First(x => x.SubjectName == selectedSubject).ID;
            var teacherid = schoolAccounts.First(x => x.Fullname == selectedteacher).id;
                 
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDays.SelectedIndex == 1)
            {
                MessageBox.Show("Custom");
            }
        }
    }
}
