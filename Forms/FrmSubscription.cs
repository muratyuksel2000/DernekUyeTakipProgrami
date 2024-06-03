using DernekTakip01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakip01.Forms
{
    public partial class FrmSubscription : Form
    {
        public FrmSubscription()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmSubscription_Load(object sender, EventArgs e)
        {
            GetMemberList();
            GetSubscriptionList();

            dgMember.Visible = false;
        }
        void GetSubscriptionList()
        {
            var subscriptions = db.Subscriptions.ToList();
            dgSubscription.Rows.Clear();
            foreach (var subscription in subscriptions)
            {
                dgSubscription.Rows.Add(subscription.Id, subscription.Member.IdentificationNumber, subscription.Member.Name, subscription.Member.Surname, subscription.Year, subscription.Amount);
            }
        }
        void GetMemberList()
        {
            var members = db.Members.ToList();
            dgMember.Rows.Clear();
            foreach (var member in members)
            {
                dgMember.Rows.Add(member.Id, member.IdentificationNumber, member.Name, member.Surname, member.Phone, member.DateOfBirth, member.City, member.BloodGroup, member.Email);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgMember.Visible = true;
            dgSubscription.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {


        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void dgMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemberId.Text = dgMember.CurrentRow.Cells[0].Value.ToString();
            txtIdentificationNumber.Text = dgMember.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgMember.CurrentRow.Cells[2].Value.ToString();
            txtSurname.Text = dgMember.CurrentRow.Cells[3].Value.ToString();
            mskdPhone.Text = dgMember.CurrentRow.Cells[4].Value.ToString();



            dgMember.Visible = false;
            dgSubscription.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "" || txtIdentificationNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtYear.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Subscription subscription = new Subscription();
            subscription.Year = txtYear.Text;
            subscription.Amount = Convert.ToDouble(txtAmount.Text);
            subscription.MemberId = Convert.ToInt32(txtMemberId.Text);

            subscription.CreateDate = dtDate.Value;
            subscription.UpdateDate = dtDate.Value;
            db.Subscriptions.Add(subscription);
            db.SaveChanges();
            GetSubscriptionList();

            MessageBox.Show("Seçilen Üyenin Aidat Kaydı Güncellenmiştir!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtMemberId.Text);
            var subscription = db.Subscriptions.Where(s => s.Id == id).SingleOrDefault();
            if (subscription == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Subscriptions.Remove(subscription);
            db.SaveChanges();
            MessageBox.Show("Seçilen Üyenin Aidat Kaydı Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetSubscriptionList();
            btnClear.PerformClick();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "" || txtIdentificationNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtYear.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Subscriptions.Count(c => c.Year == txtYear.Text) > 0 && db.Subscriptions.Count(c => c.Member.IdentificationNumber == txtIdentificationNumber.Text) > 0)
            {
                MessageBox.Show("Girilen Yıl İçin Aidat Kaydı Yapılmıştır!.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Subscription subscription = new Subscription();
            subscription.Year = txtYear.Text;
            subscription.Amount = Convert.ToDouble(txtAmount.Text);
            subscription.MemberId = Convert.ToInt32(txtMemberId.Text);
            subscription.CreateDate = dtDate.Value;
            subscription.UpdateDate = dtDate.Value;
            db.Subscriptions.Add(subscription);
            db.SaveChanges();
            GetSubscriptionList();

            MessageBox.Show("Aidat Kaydı Tamamlanmıştır!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }

            }
            dgMember.Visible = false;
            dgSubscription.Visible = true; 
            
            foreach (var c in this.Controls)
            {
                if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).Text = "";
                }

            }
            dgMember.Visible = false;
            dgSubscription.Visible = true;
        }
    }
}
