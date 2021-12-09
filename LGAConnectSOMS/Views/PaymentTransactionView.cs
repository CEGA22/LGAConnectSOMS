using LGAConnectSOMS.Models;
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
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(240, 52, 52);
            btnClose.Image = LGAConnectSOMS.Properties.Resources.close_button;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.Image = LGAConnectSOMS.Properties.Resources.CloseBlack;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private async void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnAddTransactionRecord_Click(object sender, EventArgs e)
        {            
            //DateTime da = DateTime.Now;
            var studentnumber = txtStudentNumber.Text;
            var studentid = studentaccount.First(x => x.StudentNumber == studentnumber).id;
            var studentbalance = studentaccount.First(x => x.StudentNumber == studentnumber).Balance;
            int amount = int.Parse(txtAmount.Text);
            var remainingbalance =  studentbalance - amount;         

            try
            {
                TransactionHistoryService transactionHistoryService = new TransactionHistoryService();
                var IsSuccess = await transactionHistoryService.CreateStudentRequest(new TransactionHistory
                {
                    Studentid = studentid,
                    Amount = amount,
                    Note = Note.Text,                    
                    Balance = remainingbalance
                });

                if (IsSuccess)
                {
                    MessageBox.Show("Transaction Complete");
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
    }
}
