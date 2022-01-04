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
    public partial class EditAddNewsView : Form
    {
        public EditAddNewsView()
        {
            InitializeComponent();
            this.RestoreWindowPosition();
            MaximizeIcon();
            CalendarEditingControl();
        }

        //NavigationToOtherForm       
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            NewsAndAnnouncementsView newsAndAnnouncementsView = new NewsAndAnnouncementsView();
            newsAndAnnouncementsView.lblID.Text = txtID.Text;
            newsAndAnnouncementsView.lblTitle.Text = txtTitle.Text;
            newsAndAnnouncementsView.lblContent.Text = rtContent.Text;
            newsAndAnnouncementsView.ContentPhotoPictureBox.Image = ContentPhotoPictureBox.Image;
            //newsAndAnnouncementsView.btnAuthor.Text = txtAuthorsName.Text;
            newsAndAnnouncementsView.btnDate.Text = NewsDateTimePicker.Text;
            newsAndAnnouncementsView.Show();
            this.Hide();
        }

        public void CalendarEditingControl()
        {
            DateTime dt1;
            NewsDateTimePicker.MinDate = dt1 = new DateTime(2015, 01, 1);
            NewsDateTimePicker.MaxDate = DateTime.Now.AddYears(1);
            NewsDateTimePicker.Format = DateTimePickerFormat.Short;
            NewsDateTimePicker.Value.ToString("dd-MM-yyyy");
            var monthanddate = NewsDateTimePicker.Value.ToString("dd-MM");
            var datetime = DateTime.Now;
            var date = datetime.Date;
            string newmonthanddate;
            string oldmonthanddate = monthanddate;
            newmonthanddate = oldmonthanddate.Replace("-", "");
            var studentNumber = "00" + newmonthanddate + "2021";

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

        private void BtnUpdatePhoto_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                ContentPhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                ContentPhotoPictureBox.Image = new Bitmap(open.FileName);
                var image = ContentPhotoPictureBox.Image;
                ImageToByteArray(image);
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

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var dateonly = NewsDateTimePicker.Value.ToShortDateString();
            if (txtTitle.Text == "" || NewsDateTimePicker.Text == "" || rtContent.Text == "" || ContentPhotoPictureBox.Image == null)
            {
                string message = "Please Fill in All Fields!";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {

                }
            }

            else
            {
               
                try
                {
                    var id = int.Parse(txtID.Text);
                    var image = ContentPhotoPictureBox.Image;
                    NewsAndAnnouncementsService newsAndAnnouncementsService = new NewsAndAnnouncementsService();
                    var IsSucess = await newsAndAnnouncementsService.UpdateNewsAndAnnouncement(new NewsAndAnnouncements
                    {
                        ID = id,
                        Title = txtTitle.Text,
                        //AuthorsName = txtAuthorsName.Text,
                        DateCreated = Convert.ToDateTime(dateonly),
                        ContentPhoto = ImageToByteArray(image),
                        Content = rtContent.Text,
                                              
                    }); ;

                    if (IsSucess)
                    {
                        MessageBox.Show("Updated Successfully");
                    }

                    else
                    {
                        MessageBox.Show("Update Not Successfull");
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txtID.Text);
                string message = "Are you sure you want to delete this article?";
                string title = "LGA Connect SOMS News and Announcements";
                string Successmessage = "Delete article successfully";
                string Successtitle = "LGA Connect SOMS News and Announcements";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxButtons Successbuttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    NewsAndAnnouncementsService newsAndAnnouncementsService = new NewsAndAnnouncementsService();
                    var IsSuccess = await newsAndAnnouncementsService.DeleteNewsAndAnnouncement(ID);
                    if (IsSuccess)
                    {
                        DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                        if (Successresult == DialogResult.OK)
                        {                           
                            ManageNewsView manageNewsView = new ManageNewsView();
                            manageNewsView.Show();
                            this.Hide();
                        }                                                                      
                    }
                    else
                    {
                        MessageBox.Show("Delete article Not Successfull");
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
