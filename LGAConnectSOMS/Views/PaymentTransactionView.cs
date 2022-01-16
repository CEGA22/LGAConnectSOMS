using LGAConnectSOMS.Models;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class PaymentTransactionView : Form
    {
        public PaymentTransactionView()
        {
            InitializeComponent();
        }

        private void PaymentTransactionView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        IEnumerable<StudentBalance> studentaccount = new List<StudentBalance>();
        public async void LoadData()
        {
            StudentBalanceService studentService = new StudentBalanceService();
            studentaccount = await studentService.GetStudentBalance();
            var studentbalancelist = studentaccount.Select(x => x.StudentNumber);          
            var datetime = DateTime.Now.ToString("yyyy");   
            for (int year = 2015; year <= DateTime.UtcNow.Year; ++year)
            {
               TransactionDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }

            TransactionDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";


        }
   
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private async void btnAddTransactionRecord_Click(object sender, EventArgs e)
        {
            if(txtStudentNumber.Text == "")
            {
                string message = "Please enter student number";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if(txtAmount.Text == "")
            {
                string message = "Please enter amount";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else if(txtReferenceNumber.Text == "")
            {
                string message = "Please enter reference number";
                string title = "LGA Connect SOMS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }

            else
            {
                DateTime dateTime = DateTime.Now;
                DateTime other = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
                DateTime daterecorded = DateTime.SpecifyKind(TransactionDate.Value, DateTimeKind.Utc);
                var studentnumber = txtStudentNumber.Text;
                var studentid = studentaccount.Where(x => x.StudentNumber == studentnumber).ToList();
                var balance = studentaccount.Where(x => x.StudentNumber == studentnumber).ToList();
                int amount = int.Parse(txtAmount.Text);


                if (studentid.Any())
                {
                    var ID = studentid.First(x => x.StudentNumber == studentnumber).id;
                    var studentbalance = studentaccount.First(x => x.StudentNumber == studentnumber).Balance;
                    var remainingbalance = studentbalance - amount;
                    try
                    {
                        TransactionHistoryService transactionHistoryService = new TransactionHistoryService();
                        var IsSuccess = await transactionHistoryService.CreateStudentRequest(new TransactionHistory
                        {
                            ReferenceNumber = txtReferenceNumber.Text,
                            Studentid = ID,
                            Amount = amount,
                            TransactionDate = daterecorded,
                            DateRecorded = other,
                            Note = Note.Text,                            
                            Balance = remainingbalance
                        });

                        if (IsSuccess)
                        {
                            string Successmessage = "Transaction complete";
                            string Successtitle = "LGA Connect SOMS Payment History";
                            MessageBoxButtons Successbuttons = MessageBoxButtons.OK;

                            DialogResult Successresult = MessageBox.Show(Successmessage, Successtitle, Successbuttons, MessageBoxIcon.Information);
                            if (Successresult == DialogResult.OK)
                            {
                                this.Hide();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Transaction failed");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    string message = "Student number doesn't exist";
                    string title = "LGA Connect SOMS";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK) { }
                }
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TransactionDate_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
}
