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
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace LGAConnectSOMS.Views
{
    public partial class ClassRecordFacultyView : Form
    {
        bool IsFirstLoad = true;
        public double firstgrading = 0.0;
        public double secondgrading = 0.0;
        public double thirdgrading = 0.0;
        public double fourthgrading = 0.0;
        List<ClassRecords> FirstGradingList = new List<ClassRecords>();
        List<ClassRecords> SecondGradingList = new List<ClassRecords>();
        List<ClassRecords> ThirdGradingList = new List<ClassRecords>();
        List<ClassRecords> FourthGradingList = new List<ClassRecords>();

        private string _selectedSection;

        public void IsMenuVisible()
        {
            if (panel2.Visible == false)
            {
                panel2.Show();
            }

            else if (panel2.Visible == true)
            {
                panel2.Hide();
            }
        }

        IEnumerable<FinalGrade> finalGrades = Enumerable.Empty<FinalGrade>();
        public ClassRecordFacultyView()
        {
            InitializeComponent();
        }

        //Load
        private void ClassRecordFacultyView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();
            LoadData();
        }

        public async void LoadData()
        {
            panel2.Hide();
            lblLoadingGrades.Visible = true;
            btnExport.Hide();
            //this.Cursor = Cursors.WaitCursor;           
            PanelLoadingSaveGradesFirst.Hide();
           
            await LoadFacultySubjects();
            await LoadSubjects();
            GradeLvelDropDown();          
            await ClassRecords();           
            await DataGridFlickerFix();
            await FinalGradeRecords();
            btnExport.Show();
            lblLoadingGrades.Visible = false;
            //this.Cursor = Cursors.Default;        
            //SetupDataGrid();
        }

        private async Task DataGridFlickerFix()
        {
            FirstGradingGradebook.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(FirstGradingGradebook, true, null);
            SecondGradingGradebook.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(SecondGradingGradebook, true, null);
            ThirdGradingGradebook.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(ThirdGradingGradebook, true, null);
            FourthGradingGradebook.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(FourthGradingGradebook, true, null);
        }

        private void SetupDataGrid()
        {
            FirstGradingGradebook.Rows[0].Cells[0].ReadOnly = true;
            //FirstGradingGradebook.Columns["SaveasDraft"].Visible = false;
            FirstGradingGradebook.Rows[0].Cells[12].Value = 50;
            FirstGradingGradebook.Rows[0].Cells[24].Value = 50;
            FirstGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
            //FirstGradingGradebook.Rows[0].Cells[25].Value = "##";
            //FirstGradingGradebook.Rows[0].Cells[26].Value = "##";

            SecondGradingGradebook.Rows[0].Cells[0].ReadOnly = true;
            //SecondGradingGradebook.Columns["SaveasDraft"].Visible = false;
            SecondGradingGradebook.Rows[0].Cells[12].Value = 50;
            SecondGradingGradebook.Rows[0].Cells[24].Value = 50;
            SecondGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
            //SecondGradingGradebook.Rows[0].Cells[25].Value = "##";
            //SecondGradingGradebook.Rows[0].Cells[26].Value = "##";

            ThirdGradingGradebook.Rows[0].Cells[0].ReadOnly = true;
            // ThirdGradingGradebook.Columns["SaveAsDraft"].Visible = false;
            ThirdGradingGradebook.Rows[0].Cells[12].Value = 50;
            ThirdGradingGradebook.Rows[0].Cells[24].Value = 50;
            ThirdGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
            //ThirdGradingGradebook.Rows[0].Cells[25].Value = "##";
            //ThirdGradingGradebook.Rows[0].Cells[26].Value = "##";

            FourthGradingGradebook.Rows[0].Cells[0].ReadOnly = true;
            //FourthGradingGradebook.Columns["SaveAsDraft"].Visible = false;
            //FourthGradingGradebook.Rows[0].Cells[12].Value = 50;
            //FourthGradingGradebook.Rows[0].Cells[24].Value = 50;
            FourthGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
            //FourthGradingGradebook.Rows[0].Cells[25].Value = "##";
            //FourthGradingGradebook.Rows[0].Cells[26].Value = "##";
        }

        //NavigationToOtherForm
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            HomeViewTeacher homeViewTeacher = new HomeViewTeacher();
            homeViewTeacher.Show();
            this.Hide();
        }

        //Commands
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
                //FirstGradingGradebook.Rows[0].Cells[12].Value = 50;
                //FirstGradingGradebook.Rows[0].Cells[24].Value = 50;
                FirstGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
                //FirstGradingGradebook.Rows[0].Cells[25].Value = "##";
                //FirstGradingGradebook.Rows[0].Cells[26].Value = "##";

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

                    else if (Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 65.00 || Convert.ToDouble(row.Cells[FirstGradingGradebook.Columns["InitialGrade"].Index].Value) >= 67.00)
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 75.00;
                    }

                    else
                    {
                        row.Cells[FirstGradingGradebook.Columns["QuarterlyGrade"].Index].Value = 0;
                    }
                }
            }
        }
        private void SecondGradingGradebook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in SecondGradingGradebook.Rows)
            {
                double WWTotal = 0;
                double WWPercentage = 0.5;
                double WWTotalPercentage = 0.0;

                double TPTotal = 0.0;
                double TPPercentage = 0.5;
                double TPTotalPercentage = 0.0;
                var highestpossiblescoreWW = SecondGradingGradebook.Rows[0].Cells[11].Value;
                var highestpossiblescoreTP = SecondGradingGradebook.Rows[0].Cells[23].Value;

                //FirstGradingGradebook.Rows[1].Cells[0].Value = "Student's names";
                //FirstGradingGradebook.Rows[0].Cells[0].Value = "Highest possible score";               
                //SecondGradingGradebook.Rows[0].Cells[12].Value = 50;
                //SecondGradingGradebook.Rows[0].Cells[24].Value = 50;
                SecondGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
                //SecondGradingGradebook.Rows[0].Cells[25].Value = "##";
                //SecondGradingGradebook.Rows[0].Cells[26].Value = "##";

                var verificationww = SecondGradingGradebook.Rows[0].Cells[1].Value;
                var wwgrade = row.Cells[SecondGradingGradebook.Columns["SecondWW"].Index].Value;

                var verificationww1 = SecondGradingGradebook.Rows[0].Cells[2].Value;
                var wwgrade1 = row.Cells[SecondGradingGradebook.Columns["SecondWW1"].Index].Value;

                var verificationww2 = SecondGradingGradebook.Rows[0].Cells[3].Value;
                var wwgrade2 = row.Cells[SecondGradingGradebook.Columns["SecondWW2"].Index].Value;

                var verificationww3 = SecondGradingGradebook.Rows[0].Cells[4].Value;
                var wwgrade3 = row.Cells[SecondGradingGradebook.Columns["SecondWW3"].Index].Value;

                var verificationww4 = SecondGradingGradebook.Rows[0].Cells[5].Value;
                var wwgrade4 = row.Cells[SecondGradingGradebook.Columns["SecondWW4"].Index].Value;

                var verificationww5 = SecondGradingGradebook.Rows[0].Cells[6].Value;
                var wwgrade5 = row.Cells[SecondGradingGradebook.Columns["SecondWW5"].Index].Value;

                var verificationww6 = SecondGradingGradebook.Rows[0].Cells[7].Value;
                var wwgrade6 = row.Cells[SecondGradingGradebook.Columns["SecondWW6"].Index].Value;

                var verificationww7 = SecondGradingGradebook.Rows[0].Cells[8].Value;
                var wwgrade7 = row.Cells[SecondGradingGradebook.Columns["SecondWW7"].Index].Value;

                var verificationww8 = SecondGradingGradebook.Rows[0].Cells[9].Value;
                var wwgrade8 = row.Cells[SecondGradingGradebook.Columns["SecondWW8"].Index].Value;

                var verificationww9 = SecondGradingGradebook.Rows[0].Cells[10].Value;
                var wwgrade9 = row.Cells[SecondGradingGradebook.Columns["SecondWW9"].Index].Value;
                if (Convert.ToDouble(wwgrade) > Convert.ToDouble(verificationww))
                {
                    SecondGradingGradebook.CurrentCell.Value = 0;

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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW1"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW2"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW3"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW4"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW5"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW6"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW7"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW8"].Index].Value = 0;
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
                    row.Cells[SecondGradingGradebook.Columns["SecondWW9"].Index].Value = 0;
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
                WWTotal = (int)(Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW1"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW2"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW3"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW4"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW5"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW6"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW7"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW8"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWW9"].Index].Value));


                if (Convert.ToDouble(highestpossiblescoreWW) != 0)
                {
                    WWTotalPercentage = (WWTotal / Convert.ToDouble(highestpossiblescoreWW) * 100);
                }

                else
                {
                }
                row.Cells[SecondGradingGradebook.Columns["SecondWWTotal"].Index].Value = WWTotal;
                var roundoffWW = String.Format("{0:0.##}", Math.Round(WWTotalPercentage * WWPercentage, 2));
                row.Cells[SecondGradingGradebook.Columns["SecondWWPercentage"].Index].Value = roundoffWW;

                var verificationTP = SecondGradingGradebook.Rows[0].Cells[13].Value;
                var tpgrade = row.Cells[SecondGradingGradebook.Columns["SecondTP"].Index].Value;

                var verificationTP1 = SecondGradingGradebook.Rows[0].Cells[14].Value;
                var tpgrade1 = row.Cells[SecondGradingGradebook.Columns["SecondTP1"].Index].Value;

                var verificationTP2 = SecondGradingGradebook.Rows[0].Cells[15].Value;
                var tpgrade2 = row.Cells[SecondGradingGradebook.Columns["SecondTP2"].Index].Value;

                var verificationTP3 = SecondGradingGradebook.Rows[0].Cells[16].Value;
                var tpgrade3 = row.Cells[SecondGradingGradebook.Columns["SecondTP3"].Index].Value;

                var verificationTP4 = SecondGradingGradebook.Rows[0].Cells[17].Value;
                var tpgrade4 = row.Cells[SecondGradingGradebook.Columns["SecondTP4"].Index].Value;

                var verificationTP5 = SecondGradingGradebook.Rows[0].Cells[18].Value;
                var tpgrade5 = row.Cells[SecondGradingGradebook.Columns["SecondTP5"].Index].Value;

                var verificationTP6 = SecondGradingGradebook.Rows[0].Cells[19].Value;
                var tpgrade6 = row.Cells[SecondGradingGradebook.Columns["SecondTP6"].Index].Value;

                var verificationTP7 = SecondGradingGradebook.Rows[0].Cells[20].Value;
                var tpgrade7 = row.Cells[SecondGradingGradebook.Columns["SecondTP7"].Index].Value;

                var verificationTP8 = SecondGradingGradebook.Rows[0].Cells[21].Value;
                var tpgrade8 = row.Cells[SecondGradingGradebook.Columns["SecondTP8"].Index].Value;

                var verificationTP9 = SecondGradingGradebook.Rows[0].Cells[22].Value;
                var tpgrade9 = row.Cells[SecondGradingGradebook.Columns["SecondTP9"].Index].Value;

                if (Convert.ToDouble(tpgrade) > Convert.ToDouble(verificationTP))
                {
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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
                    SecondGradingGradebook.CurrentCell.Value = 0;
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

                TPTotal = (int)(Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP1"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP2"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP3"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP4"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP5"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP6"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP7"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP8"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTP9"].Index].Value));

                if (Convert.ToDouble(highestpossiblescoreTP) != 0)
                {
                    TPTotalPercentage = (TPTotal / Convert.ToDouble(highestpossiblescoreTP) * 100);
                }

                else
                {
                }
                row.Cells[SecondGradingGradebook.Columns["SecondTPTotal"].Index].Value = TPTotal;
                var roundoffTP = String.Format("{0:0.##}", Math.Round(TPTotalPercentage * TPPercentage, 2));
                row.Cells[SecondGradingGradebook.Columns["SecondTPPercentage"].Index].Value = roundoffTP;

                //Inital Grade

                row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value = Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondWWPercentage"].Index].Value) + Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondTPPercentage"].Index].Value);

                if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) != 0)
                {
                    if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 100)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 100;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 98.40 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 99.99)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 99.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 96.80 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 98.39)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 98.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 95.20 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 96.79)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 97.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 93.60 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 95.19)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 96.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 92.00 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 93.59)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 95.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 90.40 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 91.99)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 94.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 88.80 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 90.39)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 93.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 87.20 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 88.79)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 92.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 85.60 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 87.19)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 91.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 84.00 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 85.59)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 90.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 82.40 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 83.99)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 89.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 80.80 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 82.39)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 88.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 79.20 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 80.79)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 86.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 77.60 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 79.19)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 85.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 74.40 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 75.99)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 84.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 72.80 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 74.39)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 83.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 71.20 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 72.79)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 82.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 69.60 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 71.19)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 81.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 68.00 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 69.59)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 80.00;
                    }

                    else if (Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 65.00 || Convert.ToDouble(row.Cells[SecondGradingGradebook.Columns["SecondInitialGrade"].Index].Value) >= 67.00)
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 75.00;
                    }

                    else
                    {
                        row.Cells[SecondGradingGradebook.Columns["SecondQuarterlyGrade"].Index].Value = 0;
                    }
                }
            }
        }
        private void ThirdGradingGradebook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ThirdGradingGradebook.Rows)
            {
                double WWTotal = 0;
                double WWPercentage = 0.5;
                double WWTotalPercentage = 0.0;

                double TPTotal = 0.0;
                double TPPercentage = 0.5;
                double TPTotalPercentage = 0.0;
                var highestpossiblescoreWW = ThirdGradingGradebook.Rows[0].Cells[11].Value;
                var highestpossiblescoreTP = ThirdGradingGradebook.Rows[0].Cells[23].Value;

                //FirstGradingGradebook.Rows[1].Cells[0].Value = "Student's names";
                //FirstGradingGradebook.Rows[0].Cells[0].Value = "Highest possible score";               
                //ThirdGradingGradebook.Rows[0].Cells[12].Value = 50;
                //ThirdGradingGradebook.Rows[0].Cells[24].Value = 50;
                ThirdGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
                //ThirdGradingGradebook.Rows[0].Cells[25].Value = "##";
                //ThirdGradingGradebook.Rows[0].Cells[26].Value = "##";

                var verificationww = ThirdGradingGradebook.Rows[0].Cells[1].Value;
                var wwgrade = row.Cells[ThirdGradingGradebook.Columns["ThirdWW"].Index].Value;

                var verificationww1 = ThirdGradingGradebook.Rows[0].Cells[2].Value;
                var wwgrade1 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW1"].Index].Value;

                var verificationww2 = ThirdGradingGradebook.Rows[0].Cells[3].Value;
                var wwgrade2 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW2"].Index].Value;

                var verificationww3 = ThirdGradingGradebook.Rows[0].Cells[4].Value;
                var wwgrade3 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW3"].Index].Value;

                var verificationww4 = ThirdGradingGradebook.Rows[0].Cells[5].Value;
                var wwgrade4 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW4"].Index].Value;

                var verificationww5 = ThirdGradingGradebook.Rows[0].Cells[6].Value;
                var wwgrade5 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW5"].Index].Value;

                var verificationww6 = ThirdGradingGradebook.Rows[0].Cells[7].Value;
                var wwgrade6 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW6"].Index].Value;

                var verificationww7 = ThirdGradingGradebook.Rows[0].Cells[8].Value;
                var wwgrade7 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW7"].Index].Value;

                var verificationww8 = ThirdGradingGradebook.Rows[0].Cells[9].Value;
                var wwgrade8 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW8"].Index].Value;

                var verificationww9 = ThirdGradingGradebook.Rows[0].Cells[10].Value;
                var wwgrade9 = row.Cells[ThirdGradingGradebook.Columns["ThirdWW9"].Index].Value;
                if (Convert.ToDouble(wwgrade) > Convert.ToDouble(verificationww))
                {
                    ThirdGradingGradebook.CurrentCell.Value = 0;

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
                    row.Cells[SecondGradingGradebook.Columns["ThirdWW1"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW2"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW3"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW4"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW5"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW6"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW7"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW8"].Index].Value = 0;
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
                    row.Cells[ThirdGradingGradebook.Columns["ThirdWW9"].Index].Value = 0;
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
                WWTotal = (int)(Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW1"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW2"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW3"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW4"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW5"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW6"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW7"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW8"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWW9"].Index].Value));


                if (Convert.ToDouble(highestpossiblescoreWW) != 0)
                {
                    WWTotalPercentage = (WWTotal / Convert.ToDouble(highestpossiblescoreWW) * 100);
                }

                else
                {
                }
                row.Cells[ThirdGradingGradebook.Columns["ThirdWWTotal"].Index].Value = WWTotal;
                var roundoffWW = String.Format("{0:0.##}", Math.Round(WWTotalPercentage * WWPercentage, 2));
                row.Cells[ThirdGradingGradebook.Columns["ThirdWWPercentage"].Index].Value = roundoffWW;

                var verificationTP = ThirdGradingGradebook.Rows[0].Cells[13].Value;
                var tpgrade = row.Cells[ThirdGradingGradebook.Columns["ThirdTP"].Index].Value;

                var verificationTP1 = ThirdGradingGradebook.Rows[0].Cells[14].Value;
                var tpgrade1 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP1"].Index].Value;

                var verificationTP2 = ThirdGradingGradebook.Rows[0].Cells[15].Value;
                var tpgrade2 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP2"].Index].Value;

                var verificationTP3 = ThirdGradingGradebook.Rows[0].Cells[16].Value;
                var tpgrade3 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP3"].Index].Value;

                var verificationTP4 = ThirdGradingGradebook.Rows[0].Cells[17].Value;
                var tpgrade4 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP4"].Index].Value;

                var verificationTP5 = ThirdGradingGradebook.Rows[0].Cells[18].Value;
                var tpgrade5 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP5"].Index].Value;

                var verificationTP6 = ThirdGradingGradebook.Rows[0].Cells[19].Value;
                var tpgrade6 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP6"].Index].Value;

                var verificationTP7 = ThirdGradingGradebook.Rows[0].Cells[20].Value;
                var tpgrade7 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP7"].Index].Value;

                var verificationTP8 = ThirdGradingGradebook.Rows[0].Cells[21].Value;
                var tpgrade8 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP8"].Index].Value;

                var verificationTP9 = ThirdGradingGradebook.Rows[0].Cells[22].Value;
                var tpgrade9 = row.Cells[ThirdGradingGradebook.Columns["ThirdTP9"].Index].Value;

                if (Convert.ToDouble(tpgrade) > Convert.ToDouble(verificationTP))
                {
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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
                    ThirdGradingGradebook.CurrentCell.Value = 0;
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

                TPTotal = (int)(Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP1"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP2"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP3"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP4"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP5"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP6"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP7"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP8"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTP9"].Index].Value));

                if (Convert.ToDouble(highestpossiblescoreTP) != 0)
                {
                    TPTotalPercentage = (TPTotal / Convert.ToDouble(highestpossiblescoreTP) * 100);
                }

                else
                {
                }
                row.Cells[ThirdGradingGradebook.Columns["ThirdTPTotal"].Index].Value = TPTotal;
                var roundoffTP = String.Format("{0:0.##}", Math.Round(TPTotalPercentage * TPPercentage, 2));
                row.Cells[ThirdGradingGradebook.Columns["ThirdTPPercentage"].Index].Value = roundoffTP;

                //Inital Grade

                row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value = Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdWWPercentage"].Index].Value) + Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdTPPercentage"].Index].Value);

                if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) != 0)
                {
                    if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 100)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 100;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 98.40 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 99.99)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 99.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 96.80 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 98.39)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 98.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 95.20 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 96.79)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 97.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 93.60 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 95.19)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 96.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 92.00 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 93.59)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 95.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 90.40 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 91.99)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 94.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 88.80 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 90.39)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 93.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 87.20 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 88.79)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 92.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 85.60 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 87.19)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 91.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 84.00 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 85.59)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 90.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 82.40 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 83.99)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 89.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 80.80 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 82.39)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 88.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 79.20 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 80.79)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 86.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 77.60 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 79.19)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 85.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 74.40 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 75.99)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 84.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 72.80 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 74.39)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 83.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 71.20 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 72.79)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 82.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 69.60 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 71.19)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 81.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 68.00 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 69.59)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 80.00;
                    }

                    else if (Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 65.00 || Convert.ToDouble(row.Cells[ThirdGradingGradebook.Columns["ThirdInitialGrade"].Index].Value) >= 67.00)
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 75.00;
                    }

                    else
                    {
                        row.Cells[ThirdGradingGradebook.Columns["ThirdQuarterlyGrade"].Index].Value = 0;
                    }
                }
            }
        }
        private void FourthGradingGradebook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in FourthGradingGradebook.Rows)
            {
                double WWTotal = 0;
                double WWPercentage = 0.5;
                double WWTotalPercentage = 0.0;

                double TPTotal = 0.0;
                double TPPercentage = 0.5;
                double TPTotalPercentage = 0.0;
                var highestpossiblescoreWW = FourthGradingGradebook.Rows[0].Cells[11].Value;
                var highestpossiblescoreTP = FourthGradingGradebook.Rows[0].Cells[23].Value;

                //FirstGradingGradebook.Rows[1].Cells[0].Value = "Student's names";
                //FirstGradingGradebook.Rows[0].Cells[0].Value = "Highest possible score";               
                //FourthGradingGradebook.Rows[0].Cells[12].Value = 50;
                //FourthGradingGradebook.Rows[0].Cells[24].Value = 50;
                FourthGradingGradebook.Rows[0].Cells[11].ReadOnly = true;
                //FourthGradingGradebook.Rows[0].Cells[25].Value = "##";
                //FourthGradingGradebook.Rows[0].Cells[26].Value = "##";

                var verificationww = FourthGradingGradebook.Rows[0].Cells[1].Value;
                var wwgrade = row.Cells[FourthGradingGradebook.Columns["FourthWW"].Index].Value;

                var verificationww1 = FourthGradingGradebook.Rows[0].Cells[2].Value;
                var wwgrade1 = row.Cells[FourthGradingGradebook.Columns["FourthWW1"].Index].Value;

                var verificationww2 = FourthGradingGradebook.Rows[0].Cells[3].Value;
                var wwgrade2 = row.Cells[FourthGradingGradebook.Columns["FourthWW2"].Index].Value;

                var verificationww3 = FourthGradingGradebook.Rows[0].Cells[4].Value;
                var wwgrade3 = row.Cells[FourthGradingGradebook.Columns["FourthWW3"].Index].Value;

                var verificationww4 = FourthGradingGradebook.Rows[0].Cells[5].Value;
                var wwgrade4 = row.Cells[FourthGradingGradebook.Columns["FourthWW4"].Index].Value;

                var verificationww5 = FourthGradingGradebook.Rows[0].Cells[6].Value;
                var wwgrade5 = row.Cells[FourthGradingGradebook.Columns["FourthWW5"].Index].Value;

                var verificationww6 = FourthGradingGradebook.Rows[0].Cells[7].Value;
                var wwgrade6 = row.Cells[FourthGradingGradebook.Columns["FourthWW6"].Index].Value;

                var verificationww7 = FourthGradingGradebook.Rows[0].Cells[8].Value;
                var wwgrade7 = row.Cells[FourthGradingGradebook.Columns["FourthWW7"].Index].Value;

                var verificationww8 = FourthGradingGradebook.Rows[0].Cells[9].Value;
                var wwgrade8 = row.Cells[FourthGradingGradebook.Columns["FourthWW8"].Index].Value;

                var verificationww9 = FourthGradingGradebook.Rows[0].Cells[10].Value;
                var wwgrade9 = row.Cells[FourthGradingGradebook.Columns["FourthWW9"].Index].Value;
                if (Convert.ToDouble(wwgrade) > Convert.ToDouble(verificationww))
                {
                    FourthGradingGradebook.CurrentCell.Value = 0;

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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW1"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW2"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW3"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW4"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW5"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW6"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW7"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW8"].Index].Value = 0;
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
                    row.Cells[FourthGradingGradebook.Columns["FourthWW9"].Index].Value = 0;
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
                WWTotal = (int)(Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW1"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW2"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW3"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW4"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW5"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW6"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW7"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW8"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWW9"].Index].Value));


                if (Convert.ToDouble(highestpossiblescoreWW) != 0)
                {
                    WWTotalPercentage = (WWTotal / Convert.ToDouble(highestpossiblescoreWW) * 100);
                }

                else
                {
                }
                row.Cells[FourthGradingGradebook.Columns["FourthWWTotal"].Index].Value = WWTotal;
                var roundoffWW = String.Format("{0:0.##}", Math.Round(WWTotalPercentage * WWPercentage, 2));
                row.Cells[FourthGradingGradebook.Columns["FourthWWPercentage"].Index].Value = roundoffWW;

                var verificationTP = FourthGradingGradebook.Rows[0].Cells[13].Value;
                var tpgrade = row.Cells[FourthGradingGradebook.Columns["FourthTP"].Index].Value;

                var verificationTP1 = FourthGradingGradebook.Rows[0].Cells[14].Value;
                var tpgrade1 = row.Cells[FourthGradingGradebook.Columns["FourthTP1"].Index].Value;

                var verificationTP2 = FourthGradingGradebook.Rows[0].Cells[15].Value;
                var tpgrade2 = row.Cells[FourthGradingGradebook.Columns["FourthTP2"].Index].Value;

                var verificationTP3 = FourthGradingGradebook.Rows[0].Cells[16].Value;
                var tpgrade3 = row.Cells[FourthGradingGradebook.Columns["FourthTP3"].Index].Value;

                var verificationTP4 = FourthGradingGradebook.Rows[0].Cells[17].Value;
                var tpgrade4 = row.Cells[FourthGradingGradebook.Columns["FourthTP4"].Index].Value;

                var verificationTP5 = FourthGradingGradebook.Rows[0].Cells[18].Value;
                var tpgrade5 = row.Cells[FourthGradingGradebook.Columns["FourthTP5"].Index].Value;

                var verificationTP6 = FourthGradingGradebook.Rows[0].Cells[19].Value;
                var tpgrade6 = row.Cells[FourthGradingGradebook.Columns["FourthTP6"].Index].Value;

                var verificationTP7 = FourthGradingGradebook.Rows[0].Cells[20].Value;
                var tpgrade7 = row.Cells[FourthGradingGradebook.Columns["FourthTP7"].Index].Value;

                var verificationTP8 = FourthGradingGradebook.Rows[0].Cells[21].Value;
                var tpgrade8 = row.Cells[FourthGradingGradebook.Columns["FourthTP8"].Index].Value;

                var verificationTP9 = FourthGradingGradebook.Rows[0].Cells[22].Value;
                var tpgrade9 = row.Cells[FourthGradingGradebook.Columns["FourthTP9"].Index].Value;

                if (Convert.ToDouble(tpgrade) > Convert.ToDouble(verificationTP))
                {
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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
                    FourthGradingGradebook.CurrentCell.Value = 0;
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

                TPTotal = (int)(Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP1"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP2"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP3"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP4"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP5"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP6"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP7"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP8"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTP9"].Index].Value));

                if (Convert.ToDouble(highestpossiblescoreTP) != 0)
                {
                    TPTotalPercentage = (TPTotal / Convert.ToDouble(highestpossiblescoreTP) * 100);
                }

                else
                {
                }
                row.Cells[FourthGradingGradebook.Columns["FourthTPTotal"].Index].Value = TPTotal;
                var roundoffTP = String.Format("{0:0.##}", Math.Round(TPTotalPercentage * TPPercentage, 2));
                row.Cells[FourthGradingGradebook.Columns["FourthTPPercentage"].Index].Value = roundoffTP;

                //Inital Grade

                row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value = Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthWWPercentage"].Index].Value) + Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthTPPercentage"].Index].Value);

                if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) != 0)
                {
                    if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 100)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 100;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 98.40 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 99.99)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 99.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 96.80 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 98.39)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 98.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 95.20 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 96.79)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 97.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 93.60 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 95.19)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 96.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 92.00 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 93.59)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 95.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 90.40 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 91.99)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 94.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 88.80 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 90.39)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 93.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 87.20 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 88.79)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 92.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 85.60 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 87.19)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 91.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 84.00 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 85.59)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 90.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 82.40 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 83.99)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 89.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 80.80 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 82.39)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 88.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 79.20 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 80.79)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 86.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 77.60 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 79.19)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 85.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 74.40 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 75.99)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 84.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 72.80 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 74.39)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 83.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 71.20 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 72.79)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 82.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 69.60 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 71.19)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 81.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 68.00 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 69.59)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 80.00;
                    }

                    else if (Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 65.00 || Convert.ToDouble(row.Cells[FourthGradingGradebook.Columns["FourthInitialGrade"].Index].Value) >= 67.00)
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 75.00;
                    }

                    else
                    {
                        row.Cells[FourthGradingGradebook.Columns["FourthQuarterlyGrade"].Index].Value = 0.0;
                    }
                }
            }
        }

        private List<FacultySubjects> FacultySubjects = new List<FacultySubjects>();
        public async Task LoadFacultySubjects()
        {
            var ID = Settings.Default.ID;
            FacultyService facultySubjectsService = new FacultyService();
            var facultySubjectList = await facultySubjectsService.GetFacultySubjects(ID);
            FacultySubjects = facultySubjectList.ToList();
        }

        IEnumerable<FinalGrade> finalGradesfiltered = new List<FinalGrade>();
        public async Task FinalGradeRecords()
        {           
            var ID = Settings.Default.ID;
            FinalGradeService finalGradeService = new FinalGradeService();
            finalGrades = await finalGradeService.GetFinalGrade(ID);

            var subjectsList = finalGrades.Where(x => x.SectionName == _selectedSection).Select(x => x.SubjectName).Distinct().ToList();
            var studentsList = finalGrades.Where(x => x.SectionName == _selectedSection).Select(x => x.StudentName).Distinct();

            FinalGradeDataGridView.AutoGenerateColumns = false;
            FinalGradeDataGridView.Columns.Clear();
            FinalGradeDataGridView.Columns.Add("Fullname", "Fullname");

            FinalGradeDataGridView.Rows.Clear();

            foreach (var subject in subjectsList)
            {
                var subjectId = subject;
                //var subjectId = Regex.Replace(subject, @"\s+", "");
                FinalGradeDataGridView.Columns.Add(subjectId, subject);
            }

            FinalGradeDataGridView.Columns.Add("Average", "Average");

            var studentCtr = 0;

            foreach (var student in studentsList.OrderBy(o => o))
            {
                DataGridViewRow row = (DataGridViewRow)FinalGradeDataGridView.Rows[studentCtr].Clone();
                row.Cells[0].Value = student;

                var subjectCtr = subjectsList.Count();

                for (var x = 0; x < subjectCtr; x++)
                {
                    row.Cells[x + 1].Value = finalGrades.FirstOrDefault(o => o.SubjectName.ToLowerInvariant() == subjectsList[x].ToLowerInvariant() && o.StudentName.ToLowerInvariant() == student.ToLowerInvariant()).finalGrade;
                }

                row.Cells[subjectCtr + 1].Value = finalGrades.FirstOrDefault(o => o.StudentName.ToLowerInvariant() == student.ToLowerInvariant()).Average;

                FinalGradeDataGridView.Rows.Add(row);
                studentCtr++;
            }

            FinalGradeDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        int globalgradingperiod;
        IEnumerable<ClassRecords> recordslist = new List<ClassRecords>();
        public async Task ClassRecords()
        {
            //int gradingperiod = 0
            var ID = Settings.Default.ID;
            ClassRecordsService classRecordsService = new ClassRecordsService();
            var records = await classRecordsService.GetClassRecrodsDetails(ID);
            recordslist = records.ToList();
            var schoolyear = recordslist.Select(x => x.SchoolYearStart).Distinct();
            CBSY.DataSource = schoolyear.ToList();
            //globalgradingperiod = gradingperiod;

            var selectedGradeLevel = CBGradeLevel.SelectedItem;
            var selectedSection = CBSection.SelectedItem;
            var selectedSubject = CBSubject.SelectedItem;
            var selectedSchoolYear = CBSY.SelectedItem;
            var selectedSubjectID = FacultySubjects.First(x => x.SubjectName.Equals(selectedSubject) && x.GradeLevel.Equals(selectedGradeLevel)).SubjectID;
            var selectedGradingPeriod = tabcontrol.SelectedIndex;

            //if (selectedGradingPeriod == 0)
            //{
               // globalgradingperiod = gradingperiod;
                FirstGradingGradebook.AutoGenerateColumns = false;

                FirstGradingList = recordslist.Where(x => x.GradingPeriod == 1 && x.SubjectName == selectedSubjectID && x.SectionName.Equals((string)selectedSection) && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            //FirstGradingList = recordslist.Where(x => x.GradingPeriod == gradingperiod + 1 && x.SubjectName == selectedSubjectID && x.SectionName.Equals((string)selectedSection) && x.Grade_Level.Equals(selectedGradeLevel)).ToList();



            FirstGradingGradebook.DataSource = FirstGradingList;        
                //CBSubject_SelectedIndexChanged(null, null);

                if (FirstGradingList.Any())
                    FirstGradingGradebook.BeginEdit(true);
                //FirstGradingGradebook.ClearSelection();

             //  }

                //else if (selectedGradingPeriod == 1)
                //{
                    //globalgradingperiod = gradingperiod + 1;
                SecondGradingGradebook.AutoGenerateColumns = false;
                //CBSubject_SelectedIndexChanged(null, null);
                SecondGradingList = recordslist.Where(x => x.GradingPeriod == 2 && x.SubjectName == selectedSubjectID && x.SectionName == (string)selectedSection && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            //SecondGradingList = recordslist.Where(x => x.GradingPeriod == gradingperiod + 1 && x.SubjectName == selectedSubjectID && x.SectionName == (string)selectedSection && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            SecondGradingGradebook.DataSource = SecondGradingList;
                this.SecondGradingGradebook.Columns[28].Visible = false;
                this.SecondGradingGradebook.Columns[30].Visible = false;


                //if (SecondGradingList.Any())

                //    SecondGradingGradebook.BeginEdit(true);
                //SecondGradingGradebook.ClearSelection();
               // }

            //else if (selectedGradingPeriod == 2)
            //{
                //globalgradingperiod = gradingperiod;
                ThirdGradingGradebook.AutoGenerateColumns = false;
                ThirdGradingList = recordslist.Where(x => x.GradingPeriod == 3 && x.SubjectName == selectedSubjectID && x.SectionName == (string)selectedSection && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            //ThirdGradingList = recordslist.Where(x => x.GradingPeriod == gradingperiod + 1 && x.SubjectName == selectedSubjectID && x.SectionName == (string)selectedSection && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            ThirdGradingGradebook.DataSource = ThirdGradingList;
                this.ThirdGradingGradebook.Columns[28].Visible = false;
                this.ThirdGradingGradebook.Columns[30].Visible = false;

                //CBSubject_SelectedIndexChanged(null, null);

                //if (ThirdGradingList.Any())
                //    ThirdGradingGradebook.BeginEdit(true);

                //ThirdGradingGradebook.ClearSelection();

           // }

            //else if (selectedGradingPeriod == 3)
            //{
                //globalgradingperiod = gradingperiod;

                FourthGradingGradebook.AutoGenerateColumns = false;

                FourthGradingList = recordslist.Where(x => x.GradingPeriod == 4 && x.SubjectName == selectedSubjectID && x.SectionName == (string)selectedSection && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            //FourthGradingList = recordslist.Where(x => x.GradingPeriod == gradingperiod + 1 && x.SubjectName == selectedSubjectID && x.SectionName == (string)selectedSection && x.Grade_Level.Equals(selectedGradeLevel)).ToList();

            FourthGradingGradebook.DataSource = FourthGradingList;
                this.FourthGradingGradebook.Columns[28].Visible = false;
                this.FourthGradingGradebook.Columns[30].Visible = false;
                //CBSubject_SelectedIndexChanged(null, null);

                //if (FourthGradingList.Any())
                //    FourthGradingGradebook.BeginEdit(true);

                FourthGradingGradebook.ClearSelection();
           // }

            //FirstGradingGradebook.Columns[0].DataPropertyName = "ID";
            FirstGradingGradebook.Columns[0].DataPropertyName = "Fullname";
            FirstGradingGradebook.Columns[1].DataPropertyName = "WrittenWork1";
            FirstGradingGradebook.Columns[2].DataPropertyName = "WrittenWork2";
            FirstGradingGradebook.Columns[3].DataPropertyName = "WrittenWork3";
            FirstGradingGradebook.Columns[4].DataPropertyName = "WrittenWork4";
            FirstGradingGradebook.Columns[5].DataPropertyName = "WrittenWork5";
            FirstGradingGradebook.Columns[6].DataPropertyName = "WrittenWork6";
            FirstGradingGradebook.Columns[7].DataPropertyName = "WrittenWork7";
            FirstGradingGradebook.Columns[8].DataPropertyName = "WrittenWork8";
            FirstGradingGradebook.Columns[9].DataPropertyName = "WrittenWork9";
            FirstGradingGradebook.Columns[10].DataPropertyName = "WrittenWork10";
            FirstGradingGradebook.Columns[11].DataPropertyName = "WrittenWorkTotal";
            FirstGradingGradebook.Columns[12].DataPropertyName = "WrittenWorkPercentage";
            FirstGradingGradebook.Columns[13].DataPropertyName = "TaskPerformance1";
            FirstGradingGradebook.Columns[14].DataPropertyName = "TaskPerformance2";
            FirstGradingGradebook.Columns[15].DataPropertyName = "TaskPerformance3";
            FirstGradingGradebook.Columns[16].DataPropertyName = "TaskPerformance4";
            FirstGradingGradebook.Columns[17].DataPropertyName = "TaskPerformance5";
            FirstGradingGradebook.Columns[18].DataPropertyName = "TaskPerformance6";
            FirstGradingGradebook.Columns[19].DataPropertyName = "TaskPerformance7";
            FirstGradingGradebook.Columns[20].DataPropertyName = "TaskPerformance8";
            FirstGradingGradebook.Columns[21].DataPropertyName = "TaskPerformance9";
            FirstGradingGradebook.Columns[22].DataPropertyName = "TaskPerformance10";
            FirstGradingGradebook.Columns[23].DataPropertyName = "TaskPerformanceTotal";
            FirstGradingGradebook.Columns[24].DataPropertyName = "TaskPerformancePercentage";
            FirstGradingGradebook.Columns[25].DataPropertyName = "InitialGrade";
            FirstGradingGradebook.Columns[26].DataPropertyName = "QuarterlyGrade";
            FirstGradingGradebook.Columns[27].DataPropertyName = "SchoolYearStart";
            FirstGradingGradebook.Columns[28].DataPropertyName = "Grade_Level";
            FirstGradingGradebook.Columns[29].DataPropertyName = "SubjectName";
            FirstGradingGradebook.Columns[30].DataPropertyName = "SectionName";
            FirstGradingGradebook.Columns[31].DataPropertyName = "SaveasDraft";
            FirstGradingGradebook.Columns[32].DataPropertyName = "SaveDraft";
            FirstGradingGradebook.Columns[33].DataPropertyName = "GradingPeriod";
            this.FirstGradingGradebook.Columns[27].Visible = false;
            this.FirstGradingGradebook.Columns[28].Visible = false;
            this.FirstGradingGradebook.Columns[29].Visible = false;
            this.FirstGradingGradebook.Columns[30].Visible = false;
            this.FirstGradingGradebook.Columns[31].Visible = false;

            SecondGradingGradebook.Columns[0].DataPropertyName = "Fullname";
            SecondGradingGradebook.Columns[1].DataPropertyName = "WrittenWork1";
            SecondGradingGradebook.Columns[2].DataPropertyName = "WrittenWork2";
            SecondGradingGradebook.Columns[3].DataPropertyName = "WrittenWork3";
            SecondGradingGradebook.Columns[4].DataPropertyName = "WrittenWork4";
            SecondGradingGradebook.Columns[5].DataPropertyName = "WrittenWork5";
            SecondGradingGradebook.Columns[6].DataPropertyName = "WrittenWork6";
            SecondGradingGradebook.Columns[7].DataPropertyName = "WrittenWork7";
            SecondGradingGradebook.Columns[8].DataPropertyName = "WrittenWork8";
            SecondGradingGradebook.Columns[9].DataPropertyName = "WrittenWork9";
            SecondGradingGradebook.Columns[10].DataPropertyName = "WrittenWork10";
            SecondGradingGradebook.Columns[11].DataPropertyName = "WrittenWorkTotal";
            SecondGradingGradebook.Columns[12].DataPropertyName = "WrittenWorkPercentage";
            SecondGradingGradebook.Columns[13].DataPropertyName = "TaskPerformance1";
            SecondGradingGradebook.Columns[14].DataPropertyName = "TaskPerformance2";
            SecondGradingGradebook.Columns[15].DataPropertyName = "TaskPerformance3";
            SecondGradingGradebook.Columns[16].DataPropertyName = "TaskPerformance4";
            SecondGradingGradebook.Columns[17].DataPropertyName = "TaskPerformance5";
            SecondGradingGradebook.Columns[18].DataPropertyName = "TaskPerformance6";
            SecondGradingGradebook.Columns[19].DataPropertyName = "TaskPerformance7";
            SecondGradingGradebook.Columns[20].DataPropertyName = "TaskPerformance8";
            SecondGradingGradebook.Columns[21].DataPropertyName = "TaskPerformance9";
            SecondGradingGradebook.Columns[22].DataPropertyName = "TaskPerformance10";
            SecondGradingGradebook.Columns[23].DataPropertyName = "TaskPerformanceTotal";
            SecondGradingGradebook.Columns[24].DataPropertyName = "TaskPerformancePercentage";
            SecondGradingGradebook.Columns[25].DataPropertyName = "InitialGrade";
            SecondGradingGradebook.Columns[26].DataPropertyName = "QuarterlyGrade";
            SecondGradingGradebook.Columns[27].DataPropertyName = "SchoolYearStart";
            SecondGradingGradebook.Columns[28].DataPropertyName = "Grade_Level";
            SecondGradingGradebook.Columns[29].DataPropertyName = "SubjectName";
            SecondGradingGradebook.Columns[30].DataPropertyName = "SectionName";
            SecondGradingGradebook.Columns[31].DataPropertyName = "SaveasDraft";
            SecondGradingGradebook.Columns[32].DataPropertyName = "SaveDraft";
            SecondGradingGradebook.Columns[33].DataPropertyName = "GradingPeriod";
            this.SecondGradingGradebook.Columns[27].Visible = false;
            this.SecondGradingGradebook.Columns[28].Visible = false;
            this.SecondGradingGradebook.Columns[29].Visible = false;
            this.SecondGradingGradebook.Columns[30].Visible = false;
            this.SecondGradingGradebook.Columns[31].Visible = false;

            ThirdGradingGradebook.Columns[0].DataPropertyName = "Fullname";
            ThirdGradingGradebook.Columns[1].DataPropertyName = "WrittenWork1";
            ThirdGradingGradebook.Columns[2].DataPropertyName = "WrittenWork2";
            ThirdGradingGradebook.Columns[3].DataPropertyName = "WrittenWork3";
            ThirdGradingGradebook.Columns[4].DataPropertyName = "WrittenWork4";
            ThirdGradingGradebook.Columns[5].DataPropertyName = "WrittenWork5";
            ThirdGradingGradebook.Columns[6].DataPropertyName = "WrittenWork6";
            ThirdGradingGradebook.Columns[7].DataPropertyName = "WrittenWork7";
            ThirdGradingGradebook.Columns[8].DataPropertyName = "WrittenWork8";
            ThirdGradingGradebook.Columns[9].DataPropertyName = "WrittenWork9";
            ThirdGradingGradebook.Columns[10].DataPropertyName = "WrittenWork10";
            ThirdGradingGradebook.Columns[11].DataPropertyName = "WrittenWorkTotal";
            ThirdGradingGradebook.Columns[12].DataPropertyName = "WrittenWorkPercentage";
            ThirdGradingGradebook.Columns[13].DataPropertyName = "TaskPerformance1";
            ThirdGradingGradebook.Columns[14].DataPropertyName = "TaskPerformance2";
            ThirdGradingGradebook.Columns[15].DataPropertyName = "TaskPerformance3";
            ThirdGradingGradebook.Columns[16].DataPropertyName = "TaskPerformance4";
            ThirdGradingGradebook.Columns[17].DataPropertyName = "TaskPerformance5";
            ThirdGradingGradebook.Columns[18].DataPropertyName = "TaskPerformance6";
            ThirdGradingGradebook.Columns[19].DataPropertyName = "TaskPerformance7";
            ThirdGradingGradebook.Columns[20].DataPropertyName = "TaskPerformance8";
            ThirdGradingGradebook.Columns[21].DataPropertyName = "TaskPerformance9";
            ThirdGradingGradebook.Columns[22].DataPropertyName = "TaskPerformance10";
            ThirdGradingGradebook.Columns[23].DataPropertyName = "TaskPerformanceTotal";
            ThirdGradingGradebook.Columns[24].DataPropertyName = "TaskPerformancePercentage";
            ThirdGradingGradebook.Columns[25].DataPropertyName = "InitialGrade";
            ThirdGradingGradebook.Columns[26].DataPropertyName = "QuarterlyGrade";
            ThirdGradingGradebook.Columns[27].DataPropertyName = "SchoolYearStart";
            ThirdGradingGradebook.Columns[28].DataPropertyName = "Grade_Level";
            ThirdGradingGradebook.Columns[29].DataPropertyName = "SubjectName";
            ThirdGradingGradebook.Columns[30].DataPropertyName = "SectionName";
            ThirdGradingGradebook.Columns[31].DataPropertyName = "SaveasDraft";
            ThirdGradingGradebook.Columns[32].DataPropertyName = "SaveDraft";
            ThirdGradingGradebook.Columns[33].DataPropertyName = "GradingPeriod";
            this.ThirdGradingGradebook.Columns[27].Visible = false;
            this.ThirdGradingGradebook.Columns[28].Visible = false;
            this.ThirdGradingGradebook.Columns[29].Visible = false;
            this.ThirdGradingGradebook.Columns[30].Visible = false;
            this.ThirdGradingGradebook.Columns[31].Visible = false;

            FourthGradingGradebook.Columns[0].DataPropertyName = "Fullname";
            FourthGradingGradebook.Columns[1].DataPropertyName = "WrittenWork1";
            FourthGradingGradebook.Columns[2].DataPropertyName = "WrittenWork2";
            FourthGradingGradebook.Columns[3].DataPropertyName = "WrittenWork3";
            FourthGradingGradebook.Columns[4].DataPropertyName = "WrittenWork4";
            FourthGradingGradebook.Columns[5].DataPropertyName = "WrittenWork5";
            FourthGradingGradebook.Columns[6].DataPropertyName = "WrittenWork6";
            FourthGradingGradebook.Columns[7].DataPropertyName = "WrittenWork7";
            FourthGradingGradebook.Columns[8].DataPropertyName = "WrittenWork8";
            FourthGradingGradebook.Columns[9].DataPropertyName = "WrittenWork9";
            FourthGradingGradebook.Columns[10].DataPropertyName = "WrittenWork10";
            FourthGradingGradebook.Columns[11].DataPropertyName = "WrittenWorkTotal";
            FourthGradingGradebook.Columns[12].DataPropertyName = "WrittenWorkPercentage";
            FourthGradingGradebook.Columns[13].DataPropertyName = "TaskPerformance1";
            FourthGradingGradebook.Columns[14].DataPropertyName = "TaskPerformance2";
            FourthGradingGradebook.Columns[15].DataPropertyName = "TaskPerformance3";
            FourthGradingGradebook.Columns[16].DataPropertyName = "TaskPerformance4";
            FourthGradingGradebook.Columns[17].DataPropertyName = "TaskPerformance5";
            FourthGradingGradebook.Columns[18].DataPropertyName = "TaskPerformance6";
            FourthGradingGradebook.Columns[19].DataPropertyName = "TaskPerformance7";
            FourthGradingGradebook.Columns[20].DataPropertyName = "TaskPerformance8";
            FourthGradingGradebook.Columns[21].DataPropertyName = "TaskPerformance9";
            FourthGradingGradebook.Columns[22].DataPropertyName = "TaskPerformance10";
            FourthGradingGradebook.Columns[23].DataPropertyName = "TaskPerformanceTotal";
            FourthGradingGradebook.Columns[24].DataPropertyName = "TaskPerformancePercentage";
            FourthGradingGradebook.Columns[25].DataPropertyName = "InitialGrade";
            FourthGradingGradebook.Columns[26].DataPropertyName = "QuarterlyGrade";
            FourthGradingGradebook.Columns[27].DataPropertyName = "SchoolYearStart";
            FourthGradingGradebook.Columns[28].DataPropertyName = "Grade_Level";
            FourthGradingGradebook.Columns[29].DataPropertyName = "SubjectName";
            FourthGradingGradebook.Columns[30].DataPropertyName = "SectionName";
            FourthGradingGradebook.Columns[31].DataPropertyName = "SaveasDraft";
            FourthGradingGradebook.Columns[32].DataPropertyName = "SaveDraft";
            FourthGradingGradebook.Columns[33].DataPropertyName = "GradingPeriod";
            this.FourthGradingGradebook.Columns[27].Visible = false;
            this.FourthGradingGradebook.Columns[28].Visible = false;
            this.FourthGradingGradebook.Columns[29].Visible = false;
            this.FourthGradingGradebook.Columns[30].Visible = false;
            this.FourthGradingGradebook.Columns[31].Visible = false;

            if (FirstGradingList.Any())
                FirstGradingGradebook_CellEndEdit(null, null);

            if (SecondGradingList.Any())
                SecondGradingGradebook_CellEndEdit(null, null);

            if (ThirdGradingList.Any())
                ThirdGradingGradebook_CellEndEdit(null, null);

            if (FourthGradingList.Any())
                FourthGradingGradebook_CellEndEdit(null, null);

            if (finalGrades.Any())
                FinalGradeDataGridView_CellEndEdit(null, null);


            IsFirstLoad = false;
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
            if (FirstGradingGradebook.CurrentCell.ColumnIndex == 1 || FirstGradingGradebook.CurrentCell.ColumnIndex == 2 || FirstGradingGradebook.CurrentCell.ColumnIndex == 3 || FirstGradingGradebook.CurrentCell.ColumnIndex == 4 || FirstGradingGradebook.CurrentCell.ColumnIndex == 5 || FirstGradingGradebook.CurrentCell.ColumnIndex == 6 || FirstGradingGradebook.CurrentCell.ColumnIndex == 7 || FirstGradingGradebook.CurrentCell.ColumnIndex == 8 || FirstGradingGradebook.CurrentCell.ColumnIndex == 3 || FirstGradingGradebook.CurrentCell.ColumnIndex == 9 || FirstGradingGradebook.CurrentCell.ColumnIndex == 10 || FirstGradingGradebook.CurrentCell.ColumnIndex == 12 || FirstGradingGradebook.CurrentCell.ColumnIndex == 13 || FirstGradingGradebook.CurrentCell.ColumnIndex == 14 || FirstGradingGradebook.CurrentCell.ColumnIndex == 15 || FirstGradingGradebook.CurrentCell.ColumnIndex == 16 || FirstGradingGradebook.CurrentCell.ColumnIndex == 17 || FirstGradingGradebook.CurrentCell.ColumnIndex == 18 || FirstGradingGradebook.CurrentCell.ColumnIndex == 19 || FirstGradingGradebook.CurrentCell.ColumnIndex == 20 || FirstGradingGradebook.CurrentCell.ColumnIndex == 21 || FirstGradingGradebook.CurrentCell.ColumnIndex == 22) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(FirstGradingGradebook_KeyPress);
                }
            }
        }

        private async void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSubjects.Visible = tabcontrol.SelectedIndex != 4;
            
            if (tabcontrol.SelectedIndex == 4)
            {
                //CBGradeLevel.Hide();
                //CBSection.Hide();
                ////CBSubject.Hide();
                //CBSY.Hide();
                //lblGradeLevel.Hide();
                //lblSection.Hide();
                //lblSubject.Hide();
                //lblSY.Hide();
                ComputeFinalGrade();
            }
            else
            {
                //await ClassRecords(tabcontrol.SelectedIndex);
            }

            //else
            //{
            //    //CBGradeLevel.Show();
            //    //CBSection.Show();
            //    //CBSubject.Show();
            //    //CBSY.Show();
            //    //lblGradeLevel.Show();
            //    //lblSection.Show();
            //    //lblSubject.Show();
            //    //lblSY.Show();
            //}
        }

        private async Task SubjectDropDown()
        {
            var ID = Settings.Default.ID;
            //ClassRecordsService classRecordsService = new ClassRecordsService();
            //var records = await classRecordsService.GetClassRecrodsDetails(ID);
            //var recordslist = records.ToList();
            //var gradingperiodlist = recordslist.ToList();
            //var Distinctgradingperiod = recordslist.Select(x => x.SubjectName).Distinct().ToList();
            //Distinctgradingperiod.Insert(0, "All Subjects");

            //ClassRecordsService classRecordsService = new ClassRecordsService();
            //var records = await classRecordsService.GetFacultySubjects(ID, cm);

            var subjects = FacultySubjects.Select(x => x.SubjectName).ToList();

            CBSubject.DataSource = subjects;
            //CBGradeLevel.DisplayMember = "GradingPeriod";
            CBSubject.SelectedIndex = 0;
        }

        private void GradeLvelDropDown()
        {
            var Distinctgradingperiod = FacultySubjects.Select(x => x.GradeLevel).Distinct().ToList();
            CBGradeLevel.DataSource = Distinctgradingperiod;
            CBGradeLevel.SelectedIndex = 0;

            //var ID = Settings.Default.ID;
            //ClassRecordsService classRecordsService = new ClassRecordsService();
            //var records = await classRecordsService.GetClassRecrodsDetails(ID);
            //var recordslist = records.ToList();
            //var gradingperiodlist = recordslist.ToList();
            //var Distinctgradingperiod = recordslist.Select(x => x.Grade_Level.ToString()).Distinct().ToList();
            //Distinctgradingperiod.Insert(0, "All Grade Level");
            //CBGradeLevel.DisplayMember = "GradingPeriod";
        }

        private async void CBSY_DropDown(object sender, EventArgs e)
        {
            var ID = Settings.Default.ID;
            ClassRecordsService classRecordsService = new ClassRecordsService();
            var records = await classRecordsService.GetClassRecrodsDetails(ID);
            var recordslist = records.ToList();
            var gradingperiodlist = recordslist.ToList();
            var Distinctgradingperiod = recordslist.Select(x => x.SchoolYearStart).Distinct().ToList();
            CBSY.DataSource = Distinctgradingperiod;
            //CBGradeLevel.DisplayMember = "GradingPeriod";
            CBSY.SelectedIndex = -1;
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

        private void SecondGradingGradebook_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SecondGradingGradebook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(SecondGradingGradebook_KeyPress);
            if (SecondGradingGradebook.CurrentCell.ColumnIndex == 1 || SecondGradingGradebook.CurrentCell.ColumnIndex == 2 || SecondGradingGradebook.CurrentCell.ColumnIndex == 3 || SecondGradingGradebook.CurrentCell.ColumnIndex == 4 || SecondGradingGradebook.CurrentCell.ColumnIndex == 5 || SecondGradingGradebook.CurrentCell.ColumnIndex == 6 || SecondGradingGradebook.CurrentCell.ColumnIndex == 7 || SecondGradingGradebook.CurrentCell.ColumnIndex == 8 || SecondGradingGradebook.CurrentCell.ColumnIndex == 3 || SecondGradingGradebook.CurrentCell.ColumnIndex == 9 || SecondGradingGradebook.CurrentCell.ColumnIndex == 10 || SecondGradingGradebook.CurrentCell.ColumnIndex == 12 || SecondGradingGradebook.CurrentCell.ColumnIndex == 13 || SecondGradingGradebook.CurrentCell.ColumnIndex == 14 || SecondGradingGradebook.CurrentCell.ColumnIndex == 15 || SecondGradingGradebook.CurrentCell.ColumnIndex == 16 || SecondGradingGradebook.CurrentCell.ColumnIndex == 17 || SecondGradingGradebook.CurrentCell.ColumnIndex == 18 || SecondGradingGradebook.CurrentCell.ColumnIndex == 19 || SecondGradingGradebook.CurrentCell.ColumnIndex == 20 || SecondGradingGradebook.CurrentCell.ColumnIndex == 21 || SecondGradingGradebook.CurrentCell.ColumnIndex == 22) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(SecondGradingGradebook_KeyPress);
                }
            }
        }

        private void ThirdGradingGradebook_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ThirdGradingGradebook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ThirdGradingGradebook_KeyPress);
            if (ThirdGradingGradebook.CurrentCell.ColumnIndex == 1 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 2 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 3 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 4 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 5 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 6 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 7 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 8 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 3 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 9 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 10 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 12 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 13 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 14 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 15 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 16 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 17 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 18 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 19 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 20 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 21 || ThirdGradingGradebook.CurrentCell.ColumnIndex == 22) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ThirdGradingGradebook_KeyPress);
                }
            }
        }

        private void FourthGradingGradebook_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FourthGradingGradebook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(FourthGradingGradebook_KeyPress);
            if (FourthGradingGradebook.CurrentCell.ColumnIndex == 1 || FourthGradingGradebook.CurrentCell.ColumnIndex == 2 || FourthGradingGradebook.CurrentCell.ColumnIndex == 3 || FourthGradingGradebook.CurrentCell.ColumnIndex == 4 || FourthGradingGradebook.CurrentCell.ColumnIndex == 5 || FourthGradingGradebook.CurrentCell.ColumnIndex == 6 || FourthGradingGradebook.CurrentCell.ColumnIndex == 7 || FourthGradingGradebook.CurrentCell.ColumnIndex == 8 || FourthGradingGradebook.CurrentCell.ColumnIndex == 3 || FourthGradingGradebook.CurrentCell.ColumnIndex == 9 || FourthGradingGradebook.CurrentCell.ColumnIndex == 10 || FourthGradingGradebook.CurrentCell.ColumnIndex == 12 || FourthGradingGradebook.CurrentCell.ColumnIndex == 13 || FourthGradingGradebook.CurrentCell.ColumnIndex == 14 || FourthGradingGradebook.CurrentCell.ColumnIndex == 15 || FourthGradingGradebook.CurrentCell.ColumnIndex == 16 || FourthGradingGradebook.CurrentCell.ColumnIndex == 17 || FourthGradingGradebook.CurrentCell.ColumnIndex == 18 || FourthGradingGradebook.CurrentCell.ColumnIndex == 19 || FourthGradingGradebook.CurrentCell.ColumnIndex == 20 || FourthGradingGradebook.CurrentCell.ColumnIndex == 21 || FourthGradingGradebook.CurrentCell.ColumnIndex == 22) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(FourthGradingGradebook_KeyPress);
                }
            }
        }

        private async void CBSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSubject.SelectedIndex > -1)
            {
                await ClassRecords();
                //await ClassRecords(//tabcontrol.SelectedIndex);
            }
            //int selectedIndex = CBSubject.SelectedIndex;

            //if(selectedIndex > -1)
            //{
            //    var selectedSubject = (string)CBSubject.SelectedItem;

            //    if (FirstGradingList.Any() || SecondGradingList.Any() || ThirdGradingList.Any() || FourthGradingList.Any())
            //    {
            //        var filteredlist = FirstGradingList.Where(item => item.SubjectName == selectedSubject).ToList();                                                       
            //        //filteredlist.Insert(0, new ClassRecords
            //        //{
            //        //    Lastname = "Score",
            //        //    Firstname = "Highest Possible",
            //        //    GradingPeriod = 1
            //        //});
            //        FirstGradingGradebook.AutoGenerateColumns = false;
            //        //FirstGradingGradebook.DataSource = selectedIndex != -1 ? filteredlist : FirstGradingList;
            //        FirstGradingGradebook.DataSource = filteredlist;
            //        FirstGradingGradebook.BeginEdit(true);
            //        FirstGradingGradebook.ClearSelection();

            //        SecondGradingGradebook.AutoGenerateColumns = false;
            //        var SecondGradingfilteredlist = SecondGradingList.Where(item => item.SubjectName == selectedSubject).ToList();
            //        SecondGradingGradebook.DataSource = selectedIndex != 0 ? SecondGradingfilteredlist : SecondGradingList;
            //        SecondGradingGradebook.BeginEdit(true);
            //        SecondGradingGradebook.ClearSelection();

            //        ThirdGradingGradebook.AutoGenerateColumns = false;
            //        var ThirdGradingfilteredlist = ThirdGradingList.Where(item => item.SubjectName == selectedSubject).ToList();
            //        ThirdGradingGradebook.DataSource = selectedIndex != 0 ? ThirdGradingfilteredlist : ThirdGradingList;
            //        ThirdGradingGradebook.BeginEdit(true);
            //        ThirdGradingGradebook.ClearSelection();

            //        FourthGradingGradebook.AutoGenerateColumns = false;
            //        var FourthGradingfilteredlist = FourthGradingList.Where(item => item.SubjectName == selectedSubject).ToList();
            //        FourthGradingGradebook.DataSource = selectedIndex != 0 ? FourthGradingfilteredlist : FourthGradingList;
            //        FourthGradingGradebook.BeginEdit(true);
            //        FourthGradingGradebook.ClearSelection();
            //    }           
            //}         
        }

        private async void CBGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CBGradeLevel.SelectedIndex;

            var selectedGradeLevel = CBGradeLevel.SelectedItem;
            var sectionlist = FacultySubjects.Where(x => x.GradeLevel.Equals(selectedGradeLevel)).Select(x => x.SectionName).Distinct();
            CBSection.DataSource = sectionlist.ToList();

            if (CBGradeLevel.SelectedIndex > -1)
            {
                await ClassRecords();
            }

            //var selectedGradeLevel = cmbGradeLevels.SelectedItem;
            //var gradelevelslist = gradeLevelSections.Where(x => x.GradeLevels.Equals(selectedGradeLevel)).Select(x => x.SectionName);

            //if (selectedIndex > -1)
            //{
            //    var selectedGradeLevel = (string)CBGradeLevel.SelectedItem;

            //    if (FirstGradingList.Any())
            //    {
            //        var filteredlist = FirstGradingList.Where(item => item.Grade_Level.ToString() == selectedGradeLevel).ToList();

            //        //filteredlist.Insert(0, new ClassRecords
            //        //{
            //        //    Lastname = "Score",
            //        //    Firstname = "Highest Possible",
            //        //    GradingPeriod = 1
            //        //});
            //        FirstGradingGradebook.AutoGenerateColumns = false;
            //        FirstGradingGradebook.DataSource = selectedIndex != 0 ? filteredlist : FirstGradingList;
            //        FirstGradingGradebook.BeginEdit(true);
            //        FirstGradingGradebook.ClearSelection();
            //    }
            //}
        }

        private async void CBSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSection = (string)CBSection.SelectedItem;
            var subjectlist = FacultySubjects.Where(x => x.SectionName.Equals(_selectedSection)).Select(x => x.SubjectName).Distinct();
            CBSubject.DataSource = subjectlist.ToList();

            if (CBSection.SelectedIndex > -1)
            {
                await ClassRecords();
                //await ClassRecords(tabcontrol.SelectedIndex);
                await FinalGradeRecords();
            }

            //else
        }

        IEnumerable<Subjects> Subjects = new List<Subjects>();
        private async Task LoadSubjects()
        {
            SubjectsService subjectsService = new SubjectsService();
            var SubjectList = await subjectsService.GetSubjects();
            Subjects = SubjectList.ToList();
        }
        private async void btnSaveClassRecords_Click(object sender, EventArgs e)
        {
            PanelLoadingSaveGradesFirst.Show();
            for (int grades = 0; grades <= FirstGradingGradebook.Rows.Count - 1; grades++)
            {
                bool IsSuccess;
                var teacherID = Settings.Default.ID;
                var student = FirstGradingGradebook.Rows[grades].Cells[0].Value;
                var subject = FirstGradingGradebook.Rows[grades].Cells[29].Value;
                var gradelevel = FirstGradingGradebook.Rows[grades].Cells[28].Value;

                var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;                
                var subjectid = Subjects.First(x => x.ID.Equals(subject) && x.Grade_Level.Equals(gradelevel)).ID;
                try
                {
                    
                    ClassRecordRequestService classRecordRequestService = new ClassRecordRequestService();
                    IsSuccess = await classRecordRequestService.UpdateClassRecordRequest(new ClassRecordRequest
                    {
                        ID = studentid,
                        // TeacherID = teacherID,
                        WrittenWork1 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[1].Value),
                        WrittenWork2 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[2].Value),
                        WrittenWork3 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[3].Value),
                        WrittenWork4 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[4].Value),
                        WrittenWork5 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[5].Value),
                        WrittenWork6 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[6].Value),
                        WrittenWork7 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[7].Value),
                        WrittenWork8 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[8].Value),
                        WrittenWork9 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[9].Value),
                        WrittenWork10 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[10].Value),
                        WrittenWorkTotal = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[11].Value),
                        WrittenWorkPercentage = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[12].Value),
                        TaskPerformance1 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[13].Value),
                        TaskPerformance2 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[14].Value),
                        TaskPerformance3 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[15].Value),
                        TaskPerformance4 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[16].Value),
                        TaskPerformance5 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[17].Value),
                        TaskPerformance6 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[18].Value),
                        TaskPerformance7 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[19].Value),
                        TaskPerformance8 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[20].Value),
                        TaskPerformance9 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[21].Value),
                        TaskPerformance10 = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[22].Value),
                        TaskPerformanceTotal = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[23].Value),
                        TaskPerformancePercentage = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[24].Value),
                        InitialGrade = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[25].Value),
                        QuarterlyGrade = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[26].Value),
                        SchoolYearStart = Convert.ToString(FirstGradingGradebook.Rows[grades].Cells[27].Value),
                        //Grade_Level = Convert.ToInt32(FirstGradingGradebook.Rows[grades].Cells[28].Value),
                        SubjectsName = subjectid,
                        //SectionName = Convert.ToString(FirstGradingGradebook.Rows[grades].Cells[30].Value),
                        //SaveasDraft = Convert.ToInt32(FirstGradingGradebook.Rows[grades].Cells[31].Value),
                        SaveDraft = Convert.ToInt32(FirstGradingGradebook.Rows[grades].Cells[32].Value),
                        GradingPeriod = Convert.ToInt32(FirstGradingGradebook.Rows[grades].Cells[33].Value)
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            for (int grades = 0; grades <= SecondGradingGradebook.Rows.Count - 1; grades++)
            {
                //bool IsSuccess;
                //var teacherID = Settings.Default.ID;
                //var student = SecondGradingGradebook.Rows[grades].Cells[0].Value;
                //var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;
                bool IsSuccess;
                var teacherID = Settings.Default.ID;
                var student = SecondGradingGradebook.Rows[grades].Cells[0].Value;
                var subject = SecondGradingGradebook.Rows[grades].Cells[29].Value;
                var gradelevel = SecondGradingGradebook.Rows[grades].Cells[28].Value;
                var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;
                var subjectid = Subjects.First(x => x.ID.Equals(subject) && x.Grade_Level.Equals(gradelevel)).ID;
                try
                {
                    ClassRecordRequestService classRecordRequestService = new ClassRecordRequestService();
                    IsSuccess = await classRecordRequestService.UpdateClassRecordRequest(new ClassRecordRequest
                    {
                        ID = studentid,
                        //TeacherID = teacherID,
                        WrittenWork1 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[1].Value),
                        WrittenWork2 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[2].Value),
                        WrittenWork3 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[3].Value),
                        WrittenWork4 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[4].Value),
                        WrittenWork5 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[5].Value),
                        WrittenWork6 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[6].Value),
                        WrittenWork7 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[7].Value),
                        WrittenWork8 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[8].Value),
                        WrittenWork9 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[9].Value),
                        WrittenWork10 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[10].Value),
                        WrittenWorkTotal = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[11].Value),
                        WrittenWorkPercentage = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[12].Value),
                        TaskPerformance1 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[13].Value),
                        TaskPerformance2 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[14].Value),
                        TaskPerformance3 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[15].Value),
                        TaskPerformance4 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[16].Value),
                        TaskPerformance5 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[17].Value),
                        TaskPerformance6 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[18].Value),
                        TaskPerformance7 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[19].Value),
                        TaskPerformance8 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[20].Value),
                        TaskPerformance9 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[21].Value),
                        TaskPerformance10 = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[22].Value),
                        TaskPerformanceTotal = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[23].Value),
                        TaskPerformancePercentage = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[24].Value),
                        InitialGrade = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[25].Value),
                        QuarterlyGrade = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[26].Value),
                        //SchoolYearStart = Convert.ToString(SecondGradingGradebook.Rows[grades].Cells[27].Value),
                        //Grade_Level = Convert.ToInt32(SecondGradingGradebook.Rows[grades].Cells[28].Value),
                        SubjectsName = subjectid,
                        //SectionName = Convert.ToString(SecondGradingGradebook.Rows[grades].Cells[30].Value),
                        //SaveasDraft = Convert.ToInt32(SecondGradingGradebook.Rows[grades].Cells[31].Value),
                        SaveDraft = Convert.ToInt32(SecondGradingGradebook.Rows[grades].Cells[32].Value),
                        GradingPeriod = Convert.ToInt32(SecondGradingGradebook.Rows[grades].Cells[33].Value)
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            for (int grades = 0; grades <= ThirdGradingGradebook.Rows.Count - 1; grades++)
            {
                //bool IsSuccess;
                //var teacherID = Settings.Default.ID;
                //var student = SecondGradingGradebook.Rows[grades].Cells[0].Value;
                //var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;
                bool IsSuccess;
                var teacherID = Settings.Default.ID;
                var student = ThirdGradingGradebook.Rows[grades].Cells[0].Value;
                var subject = ThirdGradingGradebook.Rows[grades].Cells[29].Value;
                var gradelevel = ThirdGradingGradebook.Rows[grades].Cells[28].Value;
                var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;
                var subjectid = Subjects.First(x => x.ID.Equals(subject) && x.Grade_Level.Equals(gradelevel)).ID;
                try
                {
                    ClassRecordRequestService classRecordRequestService = new ClassRecordRequestService();
                    IsSuccess = await classRecordRequestService.UpdateClassRecordRequest(new ClassRecordRequest
                    {
                        ID = studentid,
                        //TeacherID = teacherID,
                        WrittenWork1 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[1].Value),
                        WrittenWork2 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[2].Value),
                        WrittenWork3 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[3].Value),
                        WrittenWork4 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[4].Value),
                        WrittenWork5 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[5].Value),
                        WrittenWork6 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[6].Value),
                        WrittenWork7 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[7].Value),
                        WrittenWork8 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[8].Value),
                        WrittenWork9 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[9].Value),
                        WrittenWork10 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[10].Value),
                        WrittenWorkTotal = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[11].Value),
                        WrittenWorkPercentage = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[12].Value),
                        TaskPerformance1 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[13].Value),
                        TaskPerformance2 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[14].Value),
                        TaskPerformance3 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[15].Value),
                        TaskPerformance4 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[16].Value),
                        TaskPerformance5 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[17].Value),
                        TaskPerformance6 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[18].Value),
                        TaskPerformance7 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[19].Value),
                        TaskPerformance8 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[20].Value),
                        TaskPerformance9 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[21].Value),
                        TaskPerformance10 = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[22].Value),
                        TaskPerformanceTotal = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[23].Value),
                        TaskPerformancePercentage = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[24].Value),
                        InitialGrade = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[25].Value),
                        QuarterlyGrade = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[26].Value),
                        //SchoolYearStart = Convert.ToString(SecondGradingGradebook.Rows[grades].Cells[27].Value),
                        //Grade_Level = Convert.ToInt32(ThirdGradingGradebook.Rows[grades].Cells[28].Value),
                        SubjectsName = subjectid,
                        //SectionName = Convert.ToString(SecondGradingGradebook.Rows[grades].Cells[30].Value),
                        //SaveasDraft = Convert.ToInt32(SecondGradingGradebook.Rows[grades].Cells[31].Value),
                        SaveDraft = Convert.ToInt32(ThirdGradingGradebook.Rows[grades].Cells[32].Value),
                        GradingPeriod = Convert.ToInt32(ThirdGradingGradebook.Rows[grades].Cells[33].Value)
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            for (int grades = 0; grades <= FourthGradingGradebook.Rows.Count - 1; grades++)
            {
                //bool IsSuccess;
                //var teacherID = Settings.Default.ID;
                //var student = SecondGradingGradebook.Rows[grades].Cells[0].Value;
                //var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;
                bool IsSuccess;
                var teacherID = Settings.Default.ID;
                var student = FourthGradingGradebook.Rows[grades].Cells[0].Value;
                var subject = FourthGradingGradebook.Rows[grades].Cells[29].Value;
                var gradelevel = FourthGradingGradebook.Rows[grades].Cells[28].Value;
                var studentid = recordslist.First(x => x.Fullname.Equals(student)).ID;
                var subjectid = Subjects.First(x => x.ID.Equals(subject) && x.Grade_Level.Equals(gradelevel)).ID;
                try
                {
                    ClassRecordRequestService classRecordRequestService = new ClassRecordRequestService();
                    IsSuccess = await classRecordRequestService.UpdateClassRecordRequest(new ClassRecordRequest
                    {
                        ID = studentid,
                        //TeacherID = teacherID,
                        WrittenWork1 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[1].Value),
                        WrittenWork2 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[2].Value),
                        WrittenWork3 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[3].Value),
                        WrittenWork4 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[4].Value),
                        WrittenWork5 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[5].Value),
                        WrittenWork6 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[6].Value),
                        WrittenWork7 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[7].Value),
                        WrittenWork8 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[8].Value),
                        WrittenWork9 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[9].Value),
                        WrittenWork10 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[10].Value),
                        WrittenWorkTotal = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[11].Value),
                        WrittenWorkPercentage = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[12].Value),
                        TaskPerformance1 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[13].Value),
                        TaskPerformance2 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[14].Value),
                        TaskPerformance3 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[15].Value),
                        TaskPerformance4 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[16].Value),
                        TaskPerformance5 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[17].Value),
                        TaskPerformance6 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[18].Value),
                        TaskPerformance7 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[19].Value),
                        TaskPerformance8 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[20].Value),
                        TaskPerformance9 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[21].Value),
                        TaskPerformance10 = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[22].Value),
                        TaskPerformanceTotal = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[23].Value),
                        TaskPerformancePercentage = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[24].Value),
                        InitialGrade = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[25].Value),
                        QuarterlyGrade = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[26].Value),
                        //SchoolYearStart = Convert.ToString(SecondGradingGradebook.Rows[grades].Cells[27].Value),
                        //Grade_Level = Convert.ToInt32(FourthGradingGradebook.Rows[grades].Cells[28].Value),
                        SubjectsName = subjectid,
                        //SectionName = Convert.ToString(SecondGradingGradebook.Rows[grades].Cells[30].Value),
                        //SaveasDraft = Convert.ToInt32(SecondGradingGradebook.Rows[grades].Cells[31].Value),
                        SaveDraft = Convert.ToInt32(FourthGradingGradebook.Rows[grades].Cells[32].Value),
                        GradingPeriod = Convert.ToInt32(FourthGradingGradebook.Rows[grades].Cells[33].Value)
                    });
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            //if (IsSuccess)
            //{
                PanelLoadingSaveGradesFirst.Hide();
                string Successmessage = "Successfully saved!";
                string Successtitle = "LGA Connect SOMS Class Records";
                MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                if (Successresult == DialogResult.OK)
                { }
                //MessageBox.Show("Success");
           // }

            //else
            //{
            //    MessageBox.Show("Not Success");
            //}

            //PanelLoadingSaveGradesFirst.Hide();
            //string Successmessage = "Successfully saved!";
            //string Successtitle = "LGA Connect SOMS Class Records";
            //MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

            //DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
            //if (Successresult == DialogResult.OK)
            //{ }
        }

        private void FinalGradeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //string subjectsselected = CBSubject.SelectedItem.ToString();
            //for (int grades = 0; grades < FirstGradingGradebook.Rows.Count; grades++)
            //{
            //    if (grades != 0)
            //    {
            //        double firstgrading = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[26].Value);
            //        double secondgrading = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[26].Value);
            //        double thirdgrading = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[26].Value);
            //        double fourthgrading = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[26].Value);
            //        var averagepersubject = firstgrading + secondgrading + thirdgrading + fourthgrading;
            //        var totals = averagepersubject / 4;

            //        FinalGradeDataGridView.Rows[grades - 1].Cells[subjectsselected].Value = totals;
            //    }

            //    foreach (DataGridViewRow row in FinalGradeDataGridView.Rows)
            //    {
            //        var average = Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[1].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[2].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[3].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[4].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[5].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[6].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[7].Index].Value);
            //        var columns = FinalGradeDataGridView.Columns.Count - 2;
            //        var roundoffWW = String.Format("{0:0.##}", Math.Round(average / columns, 2));
            //        row.Cells[FinalGradeDataGridView.Columns["Average"].Index].Value = roundoffWW;
            //    }
            //}
        }

        public void ComputeFinalGrade()
        {
            string subjectsselected = CBSubject.SelectedItem.ToString();
            for (int grades = 0; grades < FirstGradingGradebook.Rows.Count; grades++)
            {
                if (grades != 0)
                {
                    double firstgrading = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[26].Value);
                    double secondgrading = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[26].Value);
                    double thirdgrading = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[26].Value);
                    double fourthgrading = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[26].Value);
                    var averagepersubject = firstgrading + secondgrading + thirdgrading + fourthgrading;
                    var totals = averagepersubject / 4;

                    FinalGradeDataGridView.Rows[grades - 1].Cells[subjectsselected].Value = totals;
                }

                foreach (DataGridViewRow row in FinalGradeDataGridView.Rows)
                {
                    var average = Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[1].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[2].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[3].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[4].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[5].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[6].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[7].Index].Value);

                    var columns = FinalGradeDataGridView.Columns.Count - 2;

                    var roundoffWW = String.Format("{0:0.##}", Math.Round(average / columns, 2));
                    row.Cells[FinalGradeDataGridView.Columns["Average"].Index].Value = roundoffWW;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subjectsselected = CBSubject.SelectedItem.ToString();
            for (int grades = 0; grades < FirstGradingGradebook.Rows.Count; grades++)
            {
                if (grades != 0)
                {
                    double firstgrading = Convert.ToDouble(FirstGradingGradebook.Rows[grades].Cells[26].Value);
                    double secondgrading = Convert.ToDouble(SecondGradingGradebook.Rows[grades].Cells[26].Value);
                    double thirdgrading = Convert.ToDouble(ThirdGradingGradebook.Rows[grades].Cells[26].Value);
                    double fourthgrading = Convert.ToDouble(FourthGradingGradebook.Rows[grades].Cells[26].Value);
                    var averagepersubject = firstgrading + secondgrading + thirdgrading + fourthgrading;
                    var totals = averagepersubject / 4;
                   
                    FinalGradeDataGridView.Rows[grades - 1].Cells[subjectsselected].Value = totals;
                }

                foreach (DataGridViewRow row in FinalGradeDataGridView.Rows)
                {
                    var average = Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[1].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[2].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[3].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[4].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[5].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[6].Index].Value) + Convert.ToDouble(row.Cells[FinalGradeDataGridView.Columns[7].Index].Value);
                    var columns = FinalGradeDataGridView.Columns.Count - 2;
                    var roundoffWW = String.Format("{0:0.##}", Math.Round(average / columns, 2));
                    row.Cells[FinalGradeDataGridView.Columns["Average"].Index].Value = roundoffWW;
                }
            }
        }
        
        List<Final_Grade> final_Grades = new List<Final_Grade>();
        List<Final_Grade> result = new List<Final_Grade>();
        bool IsSuccess;
        private async void button2_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime other = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            var selectedgradelevel = CBGradeLevel.SelectedItem;
            var selectedsection = CBSection.SelectedItem;
            PanelLoadingSaveGradesFirst.Show();
            for (int grades = 0; grades <= FinalGradeDataGridView.Rows.Count - 1; grades++)
            {                             
                var studentName = Convert.ToString(FinalGradeDataGridView.Rows[grades].Cells[0].Value);               
                var finalaverage = FinalGradeDataGridView.Rows[grades].Cells[8].Value;
                var subject = finalGrades.Where(x => x.SectionName == (string)selectedsection).Select(x => x.SubjectName).Distinct();             

                foreach (var sub in subject)
                {
                    final_Grades.Add(new Final_Grade
                    {
                        StudentName = studentName,
                        subjectname = sub,
                        finalgrade = Convert.ToDouble(FinalGradeDataGridView.Rows[grades].Cells[sub].Value),
                        average = Convert.ToDouble(finalaverage),                      
                    });

                     result = final_Grades.ToList();
                }

                   
                    foreach (var r in result)
                    {
                        ClassRecordRequestService classRecordRequestService = new ClassRecordRequestService();
                        IsSuccess = await classRecordRequestService.UpdateFinalGrade(new ClassRecordRequest
                        {
                            studentname = r.StudentName,
                            subjectname = r.subjectname,
                            finalgrade = r.finalgrade,
                            average = r.average,
                            datemodified = other
                            
                        });                     
                    }         
            }

            if (IsSuccess)
                {
                     PanelLoadingSaveGradesFirst.Hide();
                string Successmessage = "Successfully saved";
                string Successtitle = "LGA Connect SOMS Class records";
                MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                if (Successresult == DialogResult.OK)
                {
                    
                }                               
                }

                else
                {
                string Successmessage = "Not successfull";
                string Successtitle = "LGA Connect SOMS Class records";
                MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Error);
                if (Successresult == DialogResult.OK)
                {

                }
            }          
                }       
        private async void CBSY_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(CBSY.SelectedIndex > -1)
            //{
            //    await ClassRecords(tabcontrol.SelectedIndex);
            //}
        }


        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void btnExportToPdf(object sender, EventArgs e)
        {
            
            IsMenuVisible();           
        }

        public void GeneratePDF(int gradingperiod, string quarter)
        {
            var selectedGradeLevel = CBGradeLevel.SelectedItem;
            var selectedSection = CBSection.SelectedItem;
            var selectedSubject = CBSubject.SelectedItem;
            var selectedSubjectID = FacultySubjects.First(x => x.SubjectName.Equals(selectedSubject) && x.GradeLevel.Equals(selectedGradeLevel)).SubjectID;
            var selectedGradingPeriod = tabcontrol.SelectedIndex;

            var generateToPdf = recordslist.Where(x => x.GradingPeriod == gradingperiod && x.SubjectName == selectedSubjectID && x.SectionName.Equals((string)selectedSection) && x.Grade_Level.Equals(selectedGradeLevel)).Select(i => new { i.Fullname, i.WrittenWork1, i.WrittenWork2, i.WrittenWork3, i.WrittenWork4, i.WrittenWork5, i.WrittenWork6, i.WrittenWork7, i.WrittenWork8, i.WrittenWork9, i.WrittenWork10, i.WrittenWorkTotal, i.WrittenWorkPercentage, i.TaskPerformance1, i.TaskPerformance2, i.TaskPerformance3, i.TaskPerformance4, i.TaskPerformance5, i.TaskPerformance6, i.TaskPerformance7, i.TaskPerformance8, i.TaskPerformance9, i.TaskPerformance10, i.TaskPerformanceTotal, i.TaskPerformancePercentage, i.InitialGrade, i.QuarterlyGrade }).ToList();

            DataGridView pdfgradebook = new DataGridView();
            this.Controls.Add(pdfgradebook);
            pdfgradebook.Hide();

            pdfgradebook.DataSource = generateToPdf.ToList();
            if (pdfgradebook.Rows.Count > 0)
            {
                var datetime = DateTime.Now.ToString("yyyy");
                var schoolYearEnd = int.Parse(datetime) + 1;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Ladder of Gems Academy Class Record.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(pdfgradebook.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.SpacingBefore = 30;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in pdfgradebook.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                iTextSharp.text.Font fon = FontFactory.GetFont("ARIAL", 5);
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in pdfgradebook.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(Convert.ToString(cell.Value));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {

                                Document pdfDoc = new Document(PageSize.TABLOID.Rotate());
                                PdfWriter.GetInstance(pdfDoc, stream);
                                Paragraph p = new Paragraph("Ladder of Gems Academy, Inc.");
                                Paragraph a = new Paragraph(selectedGradeLevel + " " + selectedSection);
                                Paragraph s = new Paragraph(selectedSubject.ToString() + " | " + quarter);
                                Paragraph c = new Paragraph("Class record");
                                Paragraph y1 = new Paragraph(datetime + " - " + schoolYearEnd);
                                p.Alignment = Element.ALIGN_CENTER;
                                a.Alignment = Element.ALIGN_CENTER;
                                y1.Alignment = Element.ALIGN_CENTER;
                                s.Alignment = Element.ALIGN_CENTER;
                                c.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Open();
                                pdfDoc.Add(p);
                                pdfDoc.Add(a);
                                pdfDoc.Add(s);
                                pdfDoc.Add(c);
                                pdfDoc.Add(y1);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            string Successmessage = "Class Record successfully save as pdf file";
                            string Successtitle = "LGA Connect SOMS Class Record";
                            MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                            DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                            if (Successresult == DialogResult.OK)
                            { }
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

        public void GeneratePDFFinalGrade()
        {
            var selectedGradeLevel = CBGradeLevel.SelectedItem;
            var selectedSection = CBSection.SelectedItem;
            var selectedSubject = CBSubject.SelectedItem;
            var selectedSubjectID = FacultySubjects.First(x => x.SubjectName.Equals(selectedSubject) && x.GradeLevel.Equals(selectedGradeLevel)).SubjectID;
            var selectedGradingPeriod = tabcontrol.SelectedIndex;
                   
            if (FinalGradeDataGridView.Rows.Count > 0)
            {
                var datetime = DateTime.Now.ToString("yyyy");
                var schoolYearEnd = int.Parse(datetime) + 1;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Ladder of Gems Academy Class Record.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(FinalGradeDataGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.SpacingBefore = 30;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in FinalGradeDataGridView.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                iTextSharp.text.Font fon = FontFactory.GetFont("ARIAL", 5);
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in FinalGradeDataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(Convert.ToString(cell.Value));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {

                                Document pdfDoc = new Document(PageSize.TABLOID.Rotate());
                                PdfWriter.GetInstance(pdfDoc, stream);
                                Paragraph p = new Paragraph("Ladder of Gems Academy, Inc.");
                                Paragraph a = new Paragraph(selectedGradeLevel + " " + selectedSection);
                                Paragraph s = new Paragraph("Final Grades");
                                Paragraph c = new Paragraph("Class record");
                                Paragraph y1 = new Paragraph(datetime + " - " + schoolYearEnd);
                                p.Alignment = Element.ALIGN_CENTER;
                                a.Alignment = Element.ALIGN_CENTER;
                                y1.Alignment = Element.ALIGN_CENTER;
                                s.Alignment = Element.ALIGN_CENTER;
                                c.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Open();
                                pdfDoc.Add(p);
                                pdfDoc.Add(a);
                                pdfDoc.Add(s);
                                pdfDoc.Add(c);
                                pdfDoc.Add(y1);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            string Successmessage = "Class Record successfully save as pdf file";
                            string Successtitle = "LGA Connect SOMS Class Record";
                            MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                            DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                            if (Successresult == DialogResult.OK)
                            { }                          
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rdFirstGrading.Checked)
            {
                GeneratePDF(1, "First Quarter");
                panel2.Hide();
            }

            else if (rdSecondGrading.Checked)
            {
                GeneratePDF(2, "Second Quarter");
                panel2.Hide();
            }

            else if (rdThirdGrading.Checked)
            {
                GeneratePDF(3, "Third Quarter");
                panel2.Hide();
            }

            else if (rdFourthGrading.Checked)
            {
                GeneratePDF(4, "Fourth Quarter");
                panel2.Hide();
            }

            else if (rdFinalGrade.Checked)
            {
                GeneratePDFFinalGrade();
                panel2.Hide();
            }
        }
    }
}
