namespace DernekTakip01
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            lbTitle = new Label();
            toolStrip1 = new ToolStrip();
            btnMembership = new ToolStripButton();
            btnDues = new ToolStripButton();
            btnDuesPaid = new ToolStripButton();
            btnExit = new ToolStripButton();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(lbTitle);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 126);
            panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(19, 103);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(67, 18);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Altbaşlık";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMembership, btnDues, btnDuesPaid, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1509, 32);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMembership
            // 
            btnMembership.Image = (Image)resources.GetObject("btnMembership.Image");
            btnMembership.ImageTransparentColor = Color.Magenta;
            btnMembership.Name = "btnMembership";
            btnMembership.Size = new Size(77, 29);
            btnMembership.Text = "ÜYELİK";
            btnMembership.Click += btnMembership_Click;
            // 
            // btnDues
            // 
            btnDues.Image = (Image)resources.GetObject("btnDues.Image");
            btnDues.ImageTransparentColor = Color.Magenta;
            btnDues.Name = "btnDues";
            btnDues.Size = new Size(109, 29);
            btnDues.Text = "AİDAT KAYIT";
            btnDues.Click += btnDues_Click;
            // 
            // btnDuesPaid
            // 
            btnDuesPaid.Image = (Image)resources.GetObject("btnDuesPaid.Image");
            btnDuesPaid.ImageTransparentColor = Color.Magenta;
            btnDuesPaid.Name = "btnDuesPaid";
            btnDuesPaid.Size = new Size(119, 29);
            btnDuesPaid.Text = "AİDAT ÖDEME";
            btnDuesPaid.Click += btnDuesPaid_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(67, 29);
            btnExit.Text = "ÇIKIŞ";
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(525, 58);
            label1.TabIndex = 0;
            label1.Text = "DERNEK OTOMASYONU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 126);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1509, 483);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1509, 483);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 609);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANASAYFA";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ToolStrip toolStrip1;
        private Label lbTitle;
        private ToolStripButton btnDues;
        private ToolStripButton btnMembership;
        private PictureBox pictureBox1;
        private ToolStripButton btnDuesPaid;
        private ToolStripButton btnRevenue;
        private ToolStripButton btnExit;
    }
}