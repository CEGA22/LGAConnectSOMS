using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Views;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS
{
    public partial class HomeViewAdmin : Form
    {
        public HomeViewAdmin()
        {
            InitializeComponent();
        }

        //Load
        private void HomeView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            
        }


        //NavigationToOtherForm

        private void btnClassRecords_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var CRAV = new ClassRecordAdminView();
            CRAV.Show();
            Task.Delay(5000);
            this.Hide();
        }

        private void btnManageNews_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var MNV = new ManageNewsView();
            MNV.Show();
            Task.Delay(5000);
            this.Hide();

        }

        private void btnPaymentRecords_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var PRV = new PaymentRecordsView();
            PRV.Show();
            this.Hide();
        }

        //Buttons Forecolor and background Styles
        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.FromArgb(255, 246, 143);           
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.White;
        }

        private void btnClassRecords_MouseEnter(object sender, EventArgs e)
        {
            btnClassRecords.ForeColor = Color.FromArgb(255, 246, 143);
        }

        private void btnClassRecords_MouseLeave(object sender, EventArgs e)
        {
            btnClassRecords.ForeColor = Color.White;
        }

        private void btnClassSchedule_MouseEnter(object sender, EventArgs e)
        {
            btnClassSchedule.ForeColor = Color.FromArgb(255, 246, 143);
        }

        private void btnClassSchedule_MouseLeave(object sender, EventArgs e)
        {
            btnClassSchedule.ForeColor = Color.White;
        }

        private void btnManageNews_MouseEnter(object sender, EventArgs e)
        {
            btnManageNews.ForeColor = Color.FromArgb(255, 246, 143);
        }

        private void btnManageNews_MouseLeave(object sender, EventArgs e)
        {
            btnManageNews.ForeColor = Color.White;
        }

        private void btnPaymentRecords_MouseEnter(object sender, EventArgs e)
        {
            btnPaymentRecords.ForeColor = Color.FromArgb(255, 246, 143);
        }

        private void btnPaymentRecords_MouseLeave(object sender, EventArgs e)
        {
            btnPaymentRecords.ForeColor = Color.White;
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

        private void HomeViewAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

            else if(this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            }
        }      
    }
}
