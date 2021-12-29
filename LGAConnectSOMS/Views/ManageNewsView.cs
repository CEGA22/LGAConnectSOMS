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
    public partial class ManageNewsView : Form
    {
        public ManageNewsView()
        {
            InitializeComponent();            
        }

        private void ManageNewsView_Load(object sender, EventArgs e)
        {
            LoadData();
            this.RestoreWindowPosition();
            MaximizeIcon();
            
        }

        public async void LoadData()
        {
            await LoadNewsAndAnnouncements();
            await GenerateDynamicUserControl();
        }

        //Load
        IEnumerable<NewsAndAnnouncements> newsandannouncements = new List<NewsAndAnnouncements>();
        int newsCount = 0;
        public async Task LoadNewsAndAnnouncements()
        {
            NewsAndAnnouncementsService newsAndAnnouncementsService = new NewsAndAnnouncementsService();
            newsandannouncements = await Task.Run(() => newsAndAnnouncementsService.GetNewsAndAnnouncements());
            var newsandannouncementsOrder = newsandannouncements.OrderByDescending(x => x.DateCreated);
            newsCount = newsandannouncementsOrder.Count();
        }

        private async Task GenerateDynamicUserControl()
        {
            await LoadNewsAndAnnouncements();
            flowLayoutNewsAndAnnouncements.Controls.Clear();
            NewsAndAnnouncementsUserControl[] newsAndAnnouncementsUserControls = new NewsAndAnnouncementsUserControl[newsCount];

            for (int i = 0; i < 1; i++)
            {
                foreach (NewsAndAnnouncements a in newsandannouncements)
                {                    
                    newsAndAnnouncementsUserControls[i] = new NewsAndAnnouncementsUserControl();                   
                    string contentPhoto = Convert.ToBase64String(a.ContentPhoto); 
                    byte[] convertprofile = System.Convert.FromBase64String(contentPhoto);
                    var imageMemoryStream = new MemoryStream(convertprofile);
                    Image imgFromStream = Image.FromStream(imageMemoryStream);
                    newsAndAnnouncementsUserControls[i].ID = a.ID;
                    newsAndAnnouncementsUserControls[i].Title = a.Title;
                    newsAndAnnouncementsUserControls[i].Content = a.Content;
                    newsAndAnnouncementsUserControls[i].ContentPhoto = imgFromStream;
                    //newsAndAnnouncementsUserControls[i].Author = a.AuthorsName;
                    newsAndAnnouncementsUserControls[i].Date = a.DateCreated;
                    flowLayoutNewsAndAnnouncements.Controls.Add(newsAndAnnouncementsUserControls[i]);
                    newsAndAnnouncementsUserControls[i].Click += new System.EventHandler(this.UserControl_Click);                   
                }
            }
        }
       
        void UserControl_Click(object sender, EventArgs e)
        {
            if(Settings.Default.IsAdmin == 1)
            {
                NewsAndAnnouncementsUserControl obj = (NewsAndAnnouncementsUserControl)sender;
                NewsAndAnnouncementsView newsAndAnnouncementsView = new NewsAndAnnouncementsView();
                newsAndAnnouncementsView.lblID.Text = obj.ID.ToString();
                newsAndAnnouncementsView.lblTitle.Text = obj.Title;
                newsAndAnnouncementsView.lblContent.Text = obj.Content;
                newsAndAnnouncementsView.ContentPhotoPictureBox.Image = obj.ContentPhoto;
                //newsAndAnnouncementsView.btnAuthor.Text = obj.Author;
                newsAndAnnouncementsView.btnDate.Text = obj.Date.ToShortDateString();
                newsAndAnnouncementsView.Show();
            }

            else if(Settings.Default.IsAdmin == 0)
            {
                NewsAndAnnouncementsUserControl obj = (NewsAndAnnouncementsUserControl)sender;
                NewsAndAnnouncementsView newsAndAnnouncementsView = new NewsAndAnnouncementsView();
                newsAndAnnouncementsView.lblID.Text = obj.ID.ToString();
                newsAndAnnouncementsView.lblTitle.Text = obj.Title;
                newsAndAnnouncementsView.lblContent.Text = obj.Content;
                newsAndAnnouncementsView.ContentPhotoPictureBox.Image = obj.ContentPhoto;
                //newsAndAnnouncementsView.btnAuthor.Text = obj.Author;
                newsAndAnnouncementsView.btnDate.Text = obj.Date.ToShortDateString();
                newsAndAnnouncementsView.BtnEditNews.Hide();               
                newsAndAnnouncementsView.Show();
               
            }           
            this.Hide();
        }

        //NavigationToOtherForm       
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if(Settings.Default.IsAdmin == 1)
            {
                this.SaveWindowPosition();
                var HVM = new HomeViewAdmin();
                HVM.Show();              
                this.Hide();
            }

            else if(Settings.Default.IsAdmin == 0)
            {
                this.SaveWindowPosition();
                HomeViewTeacher homeViewTeacher = new HomeViewTeacher();
                homeViewTeacher.Show();
                this.Hide();
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

        private void ManageNewsView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            AddNewsView addNewsView = new AddNewsView();
            addNewsView.Show();
            this.Hide();
        }
    }
}
