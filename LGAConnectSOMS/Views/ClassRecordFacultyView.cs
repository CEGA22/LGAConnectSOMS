using LGAConnectSOMS.Properties;
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
    public partial class ClassRecordFacultyView : Form
    {
        public ClassRecordFacultyView()
        {
            InitializeComponent();
        }

        //Load
        private void ClassRecordFacultyView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            FirstGradingGradebook.Rows[0].Cells[0].Value = "Highest possible score";
            FirstGradingGradebook.Rows[0].Cells[10].ReadOnly = true;
            FirstGradingGradebook.Rows[0].Cells[12].Value = "50%";
            FirstGradingGradebook.Rows[0].Cells[24].Value = "50%";
            FirstGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
            FirstGradingGradebook.Rows[0].Cells[25].Value = "##";
            FirstGradingGradebook.Rows[0].Cells[26].Value = "##";
        }


        //NavigationToOtherForm

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeViewTeacher homeViewTeacher = new HomeViewTeacher();
            homeViewTeacher.Show();
            this.Hide();
        }




        //Buttons Forecolor and background Styles
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrowYellow;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrow;
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

        private void ClassRecordFacultyView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FirstGradingGradebook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in FirstGradingGradebook.Rows)
            {
                double WWTotal = 0;
                double WWPercentage = 0.5;
                double WWTotalPercentage = 0.0;

                double TPTotal = 0.0;
                double TPPercentage = 0.5;
                double TPTotalPercentage = 0.0;
                var highestpossiblescoreWW = FirstGradingGradebook.Rows[0].Cells[11].Value;
                var highestpossiblescoreTP = FirstGradingGradebook.Rows[0].Cells[23].Value;

                FirstGradingGradebook.Rows[1].Cells[0].Value = "Student's names";
                FirstGradingGradebook.Rows[0].Cells[0].Value = "Highest possible score";
                FirstGradingGradebook.Rows[0].Cells[10].ReadOnly = true;
                FirstGradingGradebook.Rows[0].Cells[12].Value = "50%";
                FirstGradingGradebook.Rows[0].Cells[24].Value = "50%";
                FirstGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
                FirstGradingGradebook.Rows[0].Cells[25].Value = "##";
                FirstGradingGradebook.Rows[0].Cells[26].Value = "##";

                //Written Works Total            
                WWTotal = (int)(Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW1"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW2"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW3"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW4"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW5"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW6"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW7"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW8"].Index].Value));


                if (Convert.ToDouble(highestpossiblescoreWW) != 0)
                {
                    WWTotalPercentage = (WWTotal / Convert.ToDouble(highestpossiblescoreWW) * 100);
                }

                else
                {
                }
                row.Cells[FirstGradingGradebook.Columns["WWTotal"].Index].Value = WWTotal;
                var roundoffWW = String.Format("{0:0.##}", Math.Round(WWTotalPercentage * WWPercentage, 2));
                row.Cells[FirstGradingGradebook.Columns["WWPercentage"].Index].Value = roundoffWW;


                //Task Performance Total

                TPTotal = (int)(Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP1"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP2"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP3"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP4"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP5"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP6"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP7"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP8"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TP9"].Index].Value));

                if (Convert.ToDouble(highestpossiblescoreTP) != 0)
                {
                    TPTotalPercentage = (TPTotal / Convert.ToDouble(highestpossiblescoreTP) * 100);
                }

                else
                {
                }
                row.Cells[FirstGradingGradebook.Columns["TPTotal"].Index].Value = TPTotal;
                var roundoffTP = String.Format("{0:0.##}", Math.Round(TPTotalPercentage * TPPercentage, 2));
                row.Cells[FirstGradingGradebook.Columns["TPPercentage"].Index].Value = roundoffTP;

                //Inital Grade

                row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value = Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WWPercentage"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["TPPercentage"].Index].Value);

                if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) != 0)
                {
                    if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 100)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 100;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 98.40 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 99.99)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 99.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 96.80 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 98.39)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 98.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 95.20 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 96.79)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 97.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 93.60 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 95.19)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 96.00;
                    }

                    else
                    {
                    }
                }
            }
        }
    }



}
