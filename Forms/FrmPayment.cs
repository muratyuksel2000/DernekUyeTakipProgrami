using DernekTakip01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DernekTakip01.Forms
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();


        private void FrmPayment_Load(object sender, EventArgs e)
        {
            GetMemberList("");

            cbMonth.Items.Add("OCAK");
            cbMonth.Items.Add("ŞUBAT");
            cbMonth.Items.Add("MART");
            cbMonth.Items.Add("NİSAN");
            cbMonth.Items.Add("MAYIS");
            cbMonth.Items.Add("HAZİRAN");
            cbMonth.Items.Add("TEMMUZ");
            cbMonth.Items.Add("AĞUSTOS");
            cbMonth.Items.Add("EYLÜL");
            cbMonth.Items.Add("EKİM");
            cbMonth.Items.Add("KASIM");
            cbMonth.Items.Add("ARALIK");
        }
        void GetMemberList(string searchText)
        {
            var members = db.Members.Where(s => s.IdentificationNumber.Contains(searchText) || s.Name.Contains(searchText) || s.Surname.Contains(searchText) || s.Phone.Contains(searchText)).ToList();
            dgMember.Rows.Clear();
            foreach (var member in members)
            {
                dgMember.Rows.Add(member.Id, member.IdentificationNumber, member.Name, member.Surname, member.Phone, member.DateOfBirth, member.City, member.BloodGroup, member.Email);
            }
        }
        void GetSubscriptionList(int memberId)
        {
            var subscriptions = db.Subscriptions.Where(s => s.MemberId == memberId).ToList();
            dgSubscription.Rows.Clear();
            foreach (var subscription in subscriptions)
            {
                dgSubscription.Rows.Add(subscription.Id, subscription.Member.IdentificationNumber, subscription.Year, subscription.Amount);
            }
            Calculate();
        }


        void GetPaymentList(int memberId)
        {
            var payments = db.Payments.Where(s => s.MemberId == memberId).ToList();
            dgPayment.Rows.Clear();
            foreach (var payment in payments)
            {
                string month = payment.Month;
                string paymentDate = payment.CreateDate.ToShortDateString();
                double paidAmount = payment.Paid;

                dgPayment.Rows.Add(payment.Id, month, paymentDate, paidAmount);
            }
            Calculate();
        }

        void Calculate()
        {
            double amounts = 0;
            for (int i = 0; i < dgSubscription.Rows.Count; i++)
            {
                var cellValue = dgSubscription.Rows[i].Cells[3].Value;
                if (cellValue != null && cellValue.ToString() != "")
                {
                    amounts += Convert.ToDouble(cellValue);
                }
            }
            lbSubscription.Text = amounts.ToString("0.00 TL");

            double paids = 0;
            foreach (DataGridViewRow row in dgPayment.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    paids += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            lbPayment.Text = paids.ToString("0.00 TL");


            double diff = amounts - paids;
            lbDiff.Text = diff.ToString("0.00 TL");
            if (diff < 0)
            {
                lbDiff.ForeColor = Color.White;
            }
            else
            {
                lbDiff.ForeColor = Color.Yellow;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetMemberList(txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbMonth.Text == "" || txtPaid.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            int memberId = Convert.ToInt32(dgMember.CurrentRow.Cells[0].Value.ToString());
            Payment payment = new Payment();
            payment.MemberId = memberId;
            payment.Month = cbMonth.Text;
            foreach (DataGridViewRow row in dgMember.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == memberId)
                {
                    row.Cells[1].Value = cbMonth.Text;
                    break;
                }
            }

            payment.Paid = Convert.ToDouble(txtPaid.Text);
            payment.CreateDate = dtDate.Value;
            payment.UpdateDate = dtDate.Value;
            db.Payments.Add(payment);
            db.SaveChanges();
            GetPaymentList(memberId);
            dgMember.Refresh();
            btnClear.PerformClick();

        }

        private void dgMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberId = Convert.ToInt32(dgMember.CurrentRow.Cells[0].Value.ToString());
            GetSubscriptionList(memberId);
            GetPaymentList(memberId);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    (c as ComboBox).Text = "";
                }

            }
            dgMember.Visible = false;
            dgSubscription.Visible = true;
        }
    }
}
