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
    public partial class NewsAndAnnouncementsUserControl : UserControl
    {
        public NewsAndAnnouncementsUserControl()
        {
            InitializeComponent();
            ContentPhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AddEvent();
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; lblID.Text = value.ToString(); }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }
        }

        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; lblContent.Text = value; }
        }

        //private string author;

        //public string Author
        //{
        //    get { return author; }
        //    set { author = value; lblAuthorname.Text = value; }
        //}

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; lblDate.Text = value.ToShortDateString(); }
        }

              
        private Image contentPhoto;
        public Image ContentPhoto
        {
            get { return contentPhoto; }
            set { contentPhoto = value; ContentPhotoPictureBox.Image = value; }
        }

        private void lblSeeMore_Click(object sender, EventArgs e)
        {

        }

        private void NewsAndAnnouncementsUserControl_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void AddEvent()
        {
            lblSeeMore.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
        }
    }
}
