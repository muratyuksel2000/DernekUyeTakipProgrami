using DernekTakip01.Forms;
using DernekTakip01.Models;

namespace DernekTakip01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        void OpenForm(Form f)
        {
            panel2.Controls.Clear();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.BackColor = Color.Red;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ForeColor = Color.Red;
            f.Show();

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbTitle.Text = "ANASAYFA";
            lbTitle.ForeColor = Color.White;
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmMembership());
            lbTitle.Text = "ÜYELÝK";
            lbTitle.ForeColor = Color.White;
        }
        private void btnDues_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSubscription());
            lbTitle.Text = "AÝDAT KAYIT";
            lbTitle.ForeColor = Color.White;
        }

        private void btnDuesPaid_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPayment());
            lbTitle.Text = "AÝDAT ÖDEME";
            lbTitle.ForeColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}