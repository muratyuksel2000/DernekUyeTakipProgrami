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
    public partial class FrmMembership : Form
    {
        public FrmMembership()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void FrmMembership_Load(object sender, EventArgs e)
        {
            GetMemberList();
            txtIdentificationNumber.Focus();
            txtId.Visible = false;
            lbId.Visible = false;

            cbBloodGroup.Items.Add("A Rh+");
            cbBloodGroup.Items.Add("A Rh-");
            cbBloodGroup.Items.Add("B Rh+");
            cbBloodGroup.Items.Add("B Rh-");
            cbBloodGroup.Items.Add("AB Rh+");
            cbBloodGroup.Items.Add("AB Rh-");
            cbBloodGroup.Items.Add("0 Rh+");
            cbBloodGroup.Items.Add("0 Rh-");
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
        private void dgMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Visible = true;
            lbId.Visible = true;
            txtId.Text = dgMember.CurrentRow.Cells[0].Value.ToString();
            txtIdentificationNumber.Text = dgMember.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgMember.CurrentRow.Cells[2].Value.ToString();
            txtSurname.Text = dgMember.CurrentRow.Cells[3].Value.ToString();
            mskdPhone.Text = dgMember.CurrentRow.Cells[4].Value.ToString();
            mskdDateOfBirth.Text = dgMember.CurrentRow.Cells[5].Value.ToString();
            txtCity.Text = dgMember.CurrentRow.Cells[6].Value.ToString();
            cbBloodGroup.Text = dgMember.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgMember.CurrentRow.Cells[8].Value.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIdentificationNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "" || mskdPhone.Text == "" || mskdDateOfBirth.Text == "" || txtCity.Text == "" || cbBloodGroup.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Members.Count(c => c.IdentificationNumber == txtIdentificationNumber.Text) > 0)
            {
                MessageBox.Show("Girilen T.C. Kimlik Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var member = new Member();
            member.IdentificationNumber = txtIdentificationNumber.Text;
            member.Name = txtName.Text;
            member.Surname = txtSurname.Text;
            member.Phone = mskdPhone.Text;
            member.DateOfBirth = mskdDateOfBirth.Text;
            member.City = txtCity.Text;
            member.BloodGroup = cbBloodGroup.Text;
            member.Email = txtEmail.Text;

            member.CreateDate = DateTime.Now;
            member.UpdateDate = DateTime.Now;
            db.Members.Add(member);
            db.SaveChanges();
            MessageBox.Show("Üye Kaydı Tamamlandı!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetMemberList();
            btnClear.PerformClick();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdentificationNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "" || mskdPhone.Text == "" || mskdDateOfBirth.Text == "" || txtCity.Text == "" || cbBloodGroup.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var member = db.Members.Where(s => s.Id == id).SingleOrDefault();
            if (member == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            member.IdentificationNumber = txtIdentificationNumber.Text;
            member.Name = txtName.Text;
            member.Surname = txtSurname.Text;
            member.Phone = mskdPhone.Text;
            member.DateOfBirth = mskdDateOfBirth.Text;
            member.City = txtCity.Text;
            member.BloodGroup = cbBloodGroup.Text;
            member.Email = txtEmail.Text;
            member.UpdateDate = DateTime.Now;
            db.Members.Update(member);
            db.SaveChanges();
            MessageBox.Show("Üye Bilgileri Güncellendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetMemberList();
            btnClear.PerformClick();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var member = db.Members.Where(s => s.Id == id).SingleOrDefault();
            if (member == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Members.Remove(member);
            db.SaveChanges();
            MessageBox.Show("Üye Kaydı Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetMemberList();
            btnClear.PerformClick();
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
            foreach (var c in Controls)
            {
                if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).Clear();
                }
            }

        }

    }
}
