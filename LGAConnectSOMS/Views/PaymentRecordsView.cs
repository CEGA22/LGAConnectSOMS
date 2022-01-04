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
    public partial class PaymentRecordsView : Form
    {
        public PaymentRecordsView()
        {
            InitializeComponent();
        }

        //Load
        private void PaymentRecordsView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            LoadData();
        }

        public async void LoadData()
        {
            await DisplayStudentBalance();
            await DisplayTransactionHistory();
            await DisplayPaymentScheme();
            await StudentAccount();
            cmbPaymentScheme.SelectedIndex = -1;
        }
        
        public async Task DisplayStudentBalance()
        {
            StudentBalanceService studentBalanceService = new StudentBalanceService();
            var studentbalancelist = await Task.Run(() => studentBalanceService.GetStudentBalance());
            StudentsBalanceDataGridView.DataSource = studentbalancelist;
            StudentsBalanceDataGridView.CurrentCell = null;
            StudentsBalanceDataGridView.Columns[0].Visible = false;
            StudentsBalanceDataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;           
        }

        public async Task DisplayTransactionHistory()
        {
            TransactionHistoryService transactionHistoryService = new TransactionHistoryService();
            var transactionhistorylist = await Task.Run(() => transactionHistoryService.GetTransactionHistory());
            TransactionHistoryDataGridView.DataSource = transactionhistorylist;
            TransactionHistoryDataGridView.Columns[5].Visible = false;
            TransactionHistoryDataGridView.Columns[7].Visible = false;          
            TransactionHistoryDataGridView.Columns[10].Visible = false;
            TransactionHistoryDataGridView.CurrentCell = null;
            TransactionHistoryDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionHistoryDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionHistoryDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionHistoryDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionHistoryDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionHistoryDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;           
            TransactionHistoryDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionHistoryDataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        IEnumerable<PaymentScheme> paymentScheme = new List<PaymentScheme>();
        public async Task DisplayPaymentScheme()
        {
            PaymentSchemeService paymentSchemeService = new PaymentSchemeService();
            paymentScheme = await paymentSchemeService.GetPaymentScheme();
            var paymentSchemeDetails = paymentScheme.Select(x => x.PaymentMode);
            cmbPaymentScheme.DataSource = paymentSchemeDetails.ToList();           
            cmbPaymentScheme.SelectedIndex = -1;
            txtDescription.Text = "";
            txtDownPayment.Text = "";
            txtTotalTuition.Text = "";
        }

        IEnumerable<StudentAccount> studentaccount = new List<StudentAccount>();
        public async Task StudentAccount()
        {
            StudentService studentService = new StudentService(); 
            studentaccount = await Task.Run(() => studentService.GetStudentAccountOnly());
            var studentnumberlist = studentaccount.Select(x => x.StudentNumber);
        }

        public string downpayment;
        public string totaltuition;
        public int paymentSchemeid = 0;
        private void cmbPaymentScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var downpayment = String.Format(, txtDownPayment.Text);
            if(cmbPaymentScheme.SelectedIndex != -1)
            {
                var selectedScheme = cmbPaymentScheme.Text;
                paymentSchemeid = paymentScheme.First(x => x.PaymentMode == selectedScheme).SchemeID;
                txtDescription.Text = paymentScheme.First(x => x.PaymentMode == selectedScheme).Description;
                downpayment = txtDownPayment.Text = paymentScheme.First(x => x.PaymentMode == selectedScheme).DownPayment.ToString();
                txtDownPayment.Text = String.Format("{0:N}", int.Parse(downpayment));
                totaltuition = txtTotalTuition.Text = paymentScheme.First(x => x.PaymentMode == selectedScheme).Total.ToString();
                txtTotalTuition.Text = String.Format("{0:N}", int.Parse(totaltuition));
            }
        }
            
        //NavigationToOtherForm

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            HomeViewAdmin HV = new HomeViewAdmin();
            HV.Show();
            this.Hide();
        }

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

        private void PaymentRecordsView_FormClosing(object sender, FormClosingEventArgs e)
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
                btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            PaymentTransactionView paymentTransactionView = new PaymentTransactionView();
            paymentTransactionView.ShowDialog();
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {          
            if (!string.IsNullOrEmpty(txtStudentNumber.Text))
            {
                var datetime = DateTime.Now.ToString("yyyy");
                var studentNumber = txtStudentNumber.Text;
                var studentid = studentaccount.First(x => x.StudentNumber == studentNumber).ID;
                var schoolyear = studentaccount.First(x => x.StudentNumber == studentNumber).SchoolYearStart;
                //var totaltuition = txtTotalTuition.Text.ToString();
                //var downpayment = txtDownPayment.Text.ToString();
                var Balance = int.Parse(totaltuition) - int.Parse(downpayment);
                try
                {
                    StudentBalanceRequestService studentBalanceRequestService = new StudentBalanceRequestService();
                    var IsSuccess = await studentBalanceRequestService.CreateStudentBalanceRequest(new StudentBalanceRequest
                    {
                        StudentID = studentid,
                        Total = int.Parse(totaltuition),
                        Balance = Balance,
                        PaymentMode = paymentSchemeid,
                        SchoolYear = int.Parse(schoolyear)
                    });

                    if (IsSuccess)
                    {
                        MessageBox.Show("Added New Student Balance Successfully");
                    }

                    else
                    {
                        MessageBox.Show("Added New Student Balance Not Successfull");
                    }
                }
                catch (Exception x)
                {

                    MessageBox.Show(x.Message);
                }
            }

            else
            {
                MessageBox.Show("Please enter student number!", "LGA Connect SOMS Student Balance");
            }
            
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
