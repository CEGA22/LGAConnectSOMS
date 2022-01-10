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
    public partial class HomeViewTeacher : Form
    {
        public HomeViewTeacher()
        {
            InitializeComponent();
        }

        private void HomeViewTeacher_Load(object sender, EventArgs e)
        {
            LoadData();
            var profile = Settings.Default.TeacherProfile;
            byte[] convertprofile = System.Convert.FromBase64String(profile);
            var imageMemoryStream = new MemoryStream(convertprofile);
            Image imgFromStream = Image.FromStream(imageMemoryStream);
            pictureBox2.Image = imgFromStream;
            this.RestoreWindowPosition();
            MaximizeIcon();
            Menu.Hide();
            lblAccountName.Text = Settings.Default.Fullname;
            lblTitle.Text = "Good Day, " + Settings.Default.Firstname;
        }

        public async void LoadData()
        {
            await SectionsHandled();
            await ClassSchedulesFaculty();
            await LoadNewsAndAnnouncements();
        }


        public async Task SectionsHandled()
        {
            var ID = Settings.Default.ID;
            var sections = await SectionsHandledService.GetSectionsHandled(ID);
            var count = sections.ToList();
            lblSectionsHandled.Text = count.Count.ToString();
        }

        public List<ClassSchedule> schedulelist;
        public async Task ClassSchedulesFaculty()
        {
            var number = 1;
            var ID = Settings.Default.ID;
            DateTime todaysDate = DateTime.Now;
            var weekday = todaysDate.DayOfWeek.ToString();
            ClassScheduleService classScheduleService = new ClassScheduleService();
            var schedules = await Task.Run(() => classScheduleService.GetClassScheduleFacultyDetails(ID));
            schedulelist = schedules.ToList();
            var result = schedulelist.Where(x => x.WeekDay == weekday);
            schedulelist = result.ToList();
            if (!schedulelist.Any())
            {
                Label FreeSchedule = new Label();
                Panel FreeSchedulePanel = new Panel();
                PictureBox FreeSchedulePicture = new PictureBox();
                FreeSchedulePanel.Size = new System.Drawing.Size(720, 478);
                FreeSchedule.Text = "No Schedule For Today";
                FreeSchedule.AutoSize = true;
                FreeSchedule.Font = new Font("TW Cen MT", 24);
                FreeSchedulePicture.Image = LGAConnectSOMS.Properties.Resources.FreeSchedule;
                FreeSchedulePicture.SizeMode = PictureBoxSizeMode.Zoom;
                FreeSchedule.Location = new System.Drawing.Point(200, 100);
                FreeSchedulePicture.Location = new System.Drawing.Point(300, 50);
                FreeSchedule.ForeColor = Color.Black;
                flowLayoutPanel1.Controls.Add(FreeSchedulePanel);
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
                    //dynamicPanel.Location = new System.Drawing.Point(700, 101);
                    dynamicPanel.Size = new System.Drawing.Size(700, 94);                    
                    dynamicPanel.BackColor = Color.LightBlue;
                    Controls.Add(dynamicPanel);
                    dynamicPanel.Controls.Add(Subject);
                    dynamicPanel.Controls.Add(Teacher);
                    dynamicPanel.Controls.Add(StartTimeEndTime);
                    dynamicPanel.Controls.Add(pictureBox);
                    dynamicPanel.Controls.Add(LinePanel);
                    flowLayoutPanel1.Controls.Add(dynamicPanel);


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

        IEnumerable<NewsAndAnnouncements> newsandannouncements = new List<NewsAndAnnouncements>();
        public async Task LoadNewsAndAnnouncements()
        {
            lblLoading.Show();
            NewsAndAnnouncementsService newsAndAnnouncementsService = new NewsAndAnnouncementsService();
            newsandannouncements = await Task.Run(() => newsAndAnnouncementsService.GetNewsAndAnnouncements());
            var newsandannouncementsOrder = newsandannouncements.OrderByDescending(x => x.DateCreated);
            var latestnews = newsandannouncementsOrder.FirstOrDefault();
            lblArticleTitle.Text = latestnews.Title;
            lblArticelDescription.Text = latestnews.Content;
            byte[] image = (byte[])latestnews.ContentPhoto;
            MemoryStream ms = new MemoryStream(image);
            NewsImage.Image = Image.FromStream(ms);
            lblLoading.Hide();
        }

        //NavigationToOtherForm
        private void btnClassRecords_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            ClassRecordFacultyView classRecordFacultyView = new ClassRecordFacultyView();
            classRecordFacultyView.Show();
            this.Hide();
        }

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            ClassScheduleFacultyView classScheduleFacultyView = new ClassScheduleFacultyView();
            classScheduleFacultyView.Show();
            this.Hide();
        }

        private void btnManageNews_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            ManageNewsView manageNewsView = new ManageNewsView();
            manageNewsView.BtnAddNews.Hide();
            manageNewsView.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SaveWindowPosition();
            Settings.Default.ID = 0;
            Settings.Default.Firstname = null;
            Settings.Default.Lastname = null;
            Settings.Default.Fullname = null;
            LoginPageView loginPageView = new LoginPageView();
            loginPageView.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            IsMenuVisible();
        }

        public void IsMenuVisible()
        {
            if (Menu.Visible == false)
            {
                Menu.Show();
            }

            else if (panel1.Visible == true)
            {
                Menu.Hide();
            }
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
      
        private void HomeViewTeacher_FormClosing(object sender, FormClosingEventArgs e)
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

        //DragWIindows

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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            AboutPageView aboutPageView = new AboutPageView();
            aboutPageView.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IsMenuVisible();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            SaveWindowPosition();
            AccountSettingsView accountSettingsView = new AccountSettingsView();
            accountSettingsView.Show();
            this.Hide();
        }

        private void lblViewAllSched_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            ClassScheduleFacultyView classScheduleFacultyView = new ClassScheduleFacultyView();
            classScheduleFacultyView.Show();
            this.Hide();
        }

        private void lblvViewMoreNews_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            ManageNewsView manageNewsView = new ManageNewsView();
            manageNewsView.BtnAddNews.Hide();
            manageNewsView.Show();
            this.Hide();
        }

        private void btnFileRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
