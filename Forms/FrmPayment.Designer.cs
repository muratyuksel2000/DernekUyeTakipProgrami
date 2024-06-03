namespace DernekTakip01.Forms
{
    partial class FrmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPayment = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            lbSubscription = new Label();
            label4 = new Label();
            lbPayment = new Label();
            label6 = new Label();
            lbDiff = new Label();
            dtDate = new DateTimePicker();
            label8 = new Label();
            txtPaid = new TextBox();
            btnSave = new Button();
            cbMonth = new ComboBox();
            lbMonth = new Label();
            dgMember = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            dgSubscription = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSubscription).BeginInit();
            SuspendLayout();
            // 
            // dgPayment
            // 
            dgPayment.BackgroundColor = SystemColors.Control;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgPayment.Location = new Point(904, 505);
            dgPayment.Name = "dgPayment";
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(393, 345);
            dgPayment.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ödeme No";
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Aidat Ay";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Ödeme Tarihi";
            Column3.Name = "Column3";
            Column3.Width = 90;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ödenen Tutar";
            Column4.Name = "Column4";
            Column4.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 115);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 110;
            label1.Text = "ARA :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(124, 113);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 26);
            txtSearch.TabIndex = 111;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(919, 55);
            label2.Name = "label2";
            label2.Size = new Size(133, 22);
            label2.TabIndex = 110;
            label2.Text = "AİDAT ÜCRETİ :";
            // 
            // lbSubscription
            // 
            lbSubscription.AutoSize = true;
            lbSubscription.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubscription.ForeColor = Color.White;
            lbSubscription.Location = new Point(1062, 54);
            lbSubscription.Name = "lbSubscription";
            lbSubscription.Size = new Size(44, 22);
            lbSubscription.TabIndex = 110;
            lbSubscription.Text = "0 TL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(940, 80);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 110;
            label4.Text = "ÖDEMELER :";
            // 
            // lbPayment
            // 
            lbPayment.AutoSize = true;
            lbPayment.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbPayment.ForeColor = Color.White;
            lbPayment.Location = new Point(1062, 80);
            lbPayment.Name = "lbPayment";
            lbPayment.Size = new Size(44, 22);
            lbPayment.TabIndex = 110;
            lbPayment.Text = "0 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(915, 105);
            label6.Name = "label6";
            label6.Size = new Size(137, 22);
            label6.TabIndex = 110;
            label6.Text = "KALAN TUTAR :";
            // 
            // lbDiff
            // 
            lbDiff.AutoSize = true;
            lbDiff.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbDiff.ForeColor = Color.White;
            lbDiff.Location = new Point(1062, 105);
            lbDiff.Name = "lbDiff";
            lbDiff.Size = new Size(44, 22);
            lbDiff.TabIndex = 110;
            lbDiff.Text = "0 TL";
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtDate.Location = new Point(75, 76);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(223, 26);
            dtDate.TabIndex = 112;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(467, 86);
            label8.Name = "label8";
            label8.Size = new Size(149, 19);
            label8.TabIndex = 110;
            label8.Text = "ÖDENECEK TUTAR :";
            // 
            // txtPaid
            // 
            txtPaid.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPaid.Location = new Point(613, 83);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(116, 26);
            txtPaid.TabIndex = 111;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(650, 115);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 29);
            btnSave.TabIndex = 113;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbMonth
            // 
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(613, 52);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(116, 23);
            cbMonth.TabIndex = 139;
            // 
            // lbMonth
            // 
            lbMonth.AutoSize = true;
            lbMonth.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMonth.ForeColor = Color.White;
            lbMonth.Location = new Point(574, 53);
            lbMonth.Margin = new Padding(4, 0, 4, 0);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(35, 23);
            lbMonth.TabIndex = 140;
            lbMonth.Text = "AY :";
            // 
            // dgMember
            // 
            dgMember.AllowUserToOrderColumns = true;
            dgMember.BackgroundColor = SystemColors.Control;
            dgMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMember.Columns.AddRange(new DataGridViewColumn[] { Column0, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5, Column6, Column7, Column8 });
            dgMember.Location = new Point(54, 150);
            dgMember.Margin = new Padding(4, 3, 4, 3);
            dgMember.Name = "dgMember";
            dgMember.RowHeadersWidth = 51;
            dgMember.RowTemplate.Height = 29;
            dgMember.Size = new Size(832, 700);
            dgMember.TabIndex = 142;
            dgMember.CellClick += dgMember_CellClick;
            // 
            // Column0
            // 
            Column0.HeaderText = "ID";
            Column0.MinimumWidth = 6;
            Column0.Name = "Column0";
            Column0.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "TC";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Ad";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Soyad";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Column5
            // 
            Column5.HeaderText = "DogumTarihi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.Width = 85;
            // 
            // Column6
            // 
            Column6.HeaderText = "Sehir";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 90;
            // 
            // Column7
            // 
            Column7.HeaderText = "KanGrubu";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 65;
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 110;
            // 
            // dgSubscription
            // 
            dgSubscription.AllowUserToOrderColumns = true;
            dgSubscription.BackgroundColor = SystemColors.Control;
            dgSubscription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubscription.Columns.AddRange(new DataGridViewColumn[] { Column10, Column9, Column15, Column11 });
            dgSubscription.Location = new Point(904, 150);
            dgSubscription.Name = "dgSubscription";
            dgSubscription.RowHeadersWidth = 51;
            dgSubscription.RowTemplate.Height = 29;
            dgSubscription.Size = new Size(393, 345);
            dgSubscription.TabIndex = 143;
            // 
            // Column10
            // 
            Column10.HeaderText = "Aidat No";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 60;
            // 
            // Column9
            // 
            Column9.HeaderText = "T.C.";
            Column9.Name = "Column9";
            // 
            // Column15
            // 
            Column15.HeaderText = "Yıl";
            Column15.Name = "Column15";
            Column15.Width = 70;
            // 
            // Column11
            // 
            Column11.HeaderText = "Yıllık Aidat Ücreti";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(331, 119);
            label3.Name = "label3";
            label3.Size = new Size(220, 19);
            label3.TabIndex = 153;
            label3.Text = "*Aidat Ödemesi İçin Üye Seçiniz!..";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(741, 113);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 30);
            btnClear.TabIndex = 156;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1361, 717);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(dgSubscription);
            Controls.Add(dgMember);
            Controls.Add(cbMonth);
            Controls.Add(lbMonth);
            Controls.Add(btnSave);
            Controls.Add(dtDate);
            Controls.Add(txtPaid);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(lbDiff);
            Controls.Add(label6);
            Controls.Add(lbPayment);
            Controls.Add(label4);
            Controls.Add(lbSubscription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgPayment);
            Name = "FrmPayment";
            Text = "FrmPayment";
            Load += FrmPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSubscription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPayment;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Label lbSubscription;
        private Label label4;
        private Label lbPayment;
        private Label label6;
        private Label lbDiff;
        private DateTimePicker dtDate;
        private Label label8;
        private TextBox txtPaid;
        private Button btnSave;
        private ComboBox cbMonth;
        private Label lbMonth;
        private DataGridView dgMember;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridView dgSubscription;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column11;
        private Label label3;
        private Button btnClear;
    }
}