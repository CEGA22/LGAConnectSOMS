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

                //FirstGradingGradebook.Rows[1].Cells[0].Value = "Student's names";
                //FirstGradingGradebook.Rows[0].Cells[0].Value = "Highest possible score";                
                FirstGradingGradebook.Rows[0].Cells[12].Value = "50%";
                FirstGradingGradebook.Rows[0].Cells[24].Value = "50%";
                FirstGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
                FirstGradingGradebook.Rows[0].Cells[25].Value = "##";
                FirstGradingGradebook.Rows[0].Cells[26].Value = "##";

                var verificationww = FirstGradingGradebook.Rows[0].Cells[1].Value;
                var wwgrade = row.Cells[FirstGradingGradebook.Columns["WW"].Index].Value;

                var verificationww1 = FirstGradingGradebook.Rows[0].Cells[2].Value;
                var wwgrade1 = row.Cells[FirstGradingGradebook.Columns["WW1"].Index].Value;

                var verificationww2 = FirstGradingGradebook.Rows[0].Cells[3].Value;
                var wwgrade2 = row.Cells[FirstGradingGradebook.Columns["WW2"].Index].Value;

                var verificationww3 = FirstGradingGradebook.Rows[0].Cells[4].Value;
                var wwgrade3 = row.Cells[FirstGradingGradebook.Columns["WW3"].Index].Value;

                var verificationww4 = FirstGradingGradebook.Rows[0].Cells[5].Value;
                var wwgrade4 = row.Cells[FirstGradingGradebook.Columns["WW4"].Index].Value;

                var verificationww5 = FirstGradingGradebook.Rows[0].Cells[6].Value;
                var wwgrade5 = row.Cells[FirstGradingGradebook.Columns["WW5"].Index].Value;

                var verificationww6 = FirstGradingGradebook.Rows[0].Cells[7].Value;
                var wwgrade6 = row.Cells[FirstGradingGradebook.Columns["WW6"].Index].Value;

                var verificationww7 = FirstGradingGradebook.Rows[0].Cells[8].Value;
                var wwgrade7 = row.Cells[FirstGradingGradebook.Columns["WW7"].Index].Value;

                var verificationww8 = FirstGradingGradebook.Rows[0].Cells[9].Value;
                var wwgrade8 = row.Cells[FirstGradingGradebook.Columns["WW8"].Index].Value;

                var verificationww9 = FirstGradingGradebook.Rows[0].Cells[10].Value;
                var wwgrade9 = row.Cells[FirstGradingGradebook.Columns["WW9"].Index].Value;
                if (Convert.ToDouble(wwgrade) > Convert.ToDouble(verificationww))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;

                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {                      
                    }              
                }
                else { }

                if (Convert.ToDouble(wwgrade1) > Convert.ToDouble(verificationww1))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW1"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade2) > Convert.ToDouble(verificationww2))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW2"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade3) > Convert.ToDouble(verificationww3))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW3"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade4) > Convert.ToDouble(verificationww4))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW4"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade5) > Convert.ToDouble(verificationww5))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW5"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade6) > Convert.ToDouble(verificationww6))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW6"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade7) > Convert.ToDouble(verificationww7))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW7"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade8) > Convert.ToDouble(verificationww8))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW8"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(wwgrade9) > Convert.ToDouble(verificationww9))
                {
                    row.Cells[FirstGradingGradebook.Columns["WW9"].Index].Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                //Written Works Total            
                WWTotal = (int)(Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW1"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW2"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW3"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW4"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW5"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW6"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW7"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW8"].Index].Value) + Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["WW9"].Index].Value));


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

                var verificationTP = FirstGradingGradebook.Rows[0].Cells[13].Value;
                var tpgrade = row.Cells[FirstGradingGradebook.Columns["TP"].Index].Value;

                var verificationTP1 = FirstGradingGradebook.Rows[0].Cells[14].Value;
                var tpgrade1 = row.Cells[FirstGradingGradebook.Columns["TP1"].Index].Value;

                var verificationTP2 = FirstGradingGradebook.Rows[0].Cells[15].Value;
                var tpgrade2 = row.Cells[FirstGradingGradebook.Columns["TP2"].Index].Value;

                var verificationTP3 = FirstGradingGradebook.Rows[0].Cells[16].Value;
                var tpgrade3 = row.Cells[FirstGradingGradebook.Columns["TP3"].Index].Value;

                var verificationTP4 = FirstGradingGradebook.Rows[0].Cells[17].Value;
                var tpgrade4 = row.Cells[FirstGradingGradebook.Columns["TP4"].Index].Value;

                var verificationTP5 = FirstGradingGradebook.Rows[0].Cells[18].Value;
                var tpgrade5 = row.Cells[FirstGradingGradebook.Columns["TP5"].Index].Value;

                var verificationTP6 = FirstGradingGradebook.Rows[0].Cells[19].Value;
                var tpgrade6 = row.Cells[FirstGradingGradebook.Columns["TP6"].Index].Value;

                var verificationTP7 = FirstGradingGradebook.Rows[0].Cells[20].Value;
                var tpgrade7 = row.Cells[FirstGradingGradebook.Columns["TP7"].Index].Value;

                var verificationTP8 = FirstGradingGradebook.Rows[0].Cells[21].Value;
                var tpgrade8 = row.Cells[FirstGradingGradebook.Columns["TP8"].Index].Value;

                var verificationTP9 = FirstGradingGradebook.Rows[0].Cells[22].Value;
                var tpgrade9 = row.Cells[FirstGradingGradebook.Columns["TP9"].Index].Value;

                if (Convert.ToDouble(tpgrade) > Convert.ToDouble(verificationTP))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade1) > Convert.ToDouble(verificationTP1))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade2) > Convert.ToDouble(verificationTP2))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade3) > Convert.ToDouble(verificationTP3))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade4) > Convert.ToDouble(verificationTP4))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade5) > Convert.ToDouble(verificationTP5))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade6) > Convert.ToDouble(verificationTP6))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade7) > Convert.ToDouble(verificationTP7))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade8) > Convert.ToDouble(verificationTP8))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

                if (Convert.ToDouble(tpgrade9) > Convert.ToDouble(verificationTP9))
                {
                    FirstGradingGradebook.CurrentCell.Value = 0;
                    string message = "Invalid input grade";
                    string title = "Error Grade";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                    }
                }
                else { }

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

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 92.00 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 93.59)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 95.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 90.40 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 91.99)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 94.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 88.80 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 90.39)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 93.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 87.20 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 88.79)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 92.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 85.60 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 87.19)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 91.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 84.00 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 85.59)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 90.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 82.40 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 83.99)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 89.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 80.80 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 82.39)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 88.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 79.20 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 80.79)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 86.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 77.60 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 79.19)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 85.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 74.40 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 75.99)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 84.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 72.80 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 74.39)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 83.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 71.20 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 72.79)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 82.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 69.60 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 71.19)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 81.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 68.00 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 69.59)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 80.00;
                    }

                    else 
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 75.00;
                    }


                }
            }
        }

        private void FirstGradingGradebook_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow number, backspace and dot
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;

            }
            //allow only one dot
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;

            }
        }

        private void FirstGradingGradebook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(FirstGradingGradebook_KeyPress);
            if (FirstGradingGradebook.CurrentCell.ColumnIndex == 1 || FirstGradingGradebook.CurrentCell.ColumnIndex == 2 || FirstGradingGradebook.CurrentCell.ColumnIndex == 3 || FirstGradingGradebook.CurrentCell.ColumnIndex == 4 || FirstGradingGradebook.CurrentCell.ColumnIndex == 5 || FirstGradingGradebook.CurrentCell.ColumnIndex == 6 || FirstGradingGradebook.CurrentCell.ColumnIndex == 7 || FirstGradingGradebook.CurrentCell.ColumnIndex == 8 || FirstGradingGradebook.CurrentCell.ColumnIndex == 3 || FirstGradingGradebook.CurrentCell.ColumnIndex == 9 || FirstGradingGradebook.CurrentCell.ColumnIndex == 12 || FirstGradingGradebook.CurrentCell.ColumnIndex == 13 || FirstGradingGradebook.CurrentCell.ColumnIndex == 14 || FirstGradingGradebook.CurrentCell.ColumnIndex == 15 || FirstGradingGradebook.CurrentCell.ColumnIndex == 16 || FirstGradingGradebook.CurrentCell.ColumnIndex == 17 || FirstGradingGradebook.CurrentCell.ColumnIndex == 18 || FirstGradingGradebook.CurrentCell.ColumnIndex == 19 || FirstGradingGradebook.CurrentCell.ColumnIndex == 20 || FirstGradingGradebook.CurrentCell.ColumnIndex == 21) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(FirstGradingGradebook_KeyPress);
                }
            }
        }
    }



}
