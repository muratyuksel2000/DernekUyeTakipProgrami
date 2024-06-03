namespace DernekTakip01.Forms
{
    partial class FrmSubscription
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
            btnSearch = new Button();
            txtAmount = new TextBox();
            lbAmount = new Label();
            lbMemberId = new Label();
            txtMemberId = new TextBox();
            dtDate = new DateTimePicker();
            dgSubscription = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            dgMember = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            txtYear = new TextBox();
            lbYear = new Label();
            txtIdentificationNumber = new TextBox();
            mskdPhone = new MaskedTextBox();
            lbPhone = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            lbSurname = new Label();
            lbName = new Label();
            lbIdentificationNumber = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSubscription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMember).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(257, 183);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 134;
            btnSearch.Text = "GÖZAT";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(181, 371);
            txtAmount.Margin = new Padding(4, 3, 4, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 23);
            txtAmount.TabIndex = 149;
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbAmount.ForeColor = Color.White;
            lbAmount.Location = new Point(55, 371);
            lbAmount.Margin = new Padding(4, 0, 4, 0);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(114, 23);
            lbAmount.TabIndex = 127;
            lbAmount.Text = "AİDAT ÜCRETİ :";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMemberId.ForeColor = Color.White;
            lbMemberId.Location = new Point(108, 184);
            lbMemberId.Margin = new Padding(4, 0, 4, 0);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(70, 23);
            lbMemberId.TabIndex = 124;
            lbMemberId.Text = "ÜYE NO :";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(181, 184);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(68, 23);
            txtMemberId.TabIndex = 122;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtDate.Location = new Point(112, 151);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(220, 26);
            dtDate.TabIndex = 121;
            // 
            // dgSubscription
            // 
            dgSubscription.AllowUserToOrderColumns = true;
            dgSubscription.BackgroundColor = SystemColors.Control;
            dgSubscription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubscription.Columns.AddRange(new DataGridViewColumn[] { Column10, Column9, Column12, Column13, Column15, Column11 });
            dgSubscription.Location = new Point(352, 150);
            dgSubscription.Name = "dgSubscription";
            dgSubscription.RowHeadersWidth = 51;
            dgSubscription.RowTemplate.Height = 29;
            dgSubscription.Size = new Size(592, 700);
            dgSubscription.TabIndex = 120;
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
            // Column12
            // 
            Column12.HeaderText = "Ad";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Soyad";
            Column13.Name = "Column13";
            // 
            // Column15
            // 
            Column15.HeaderText = "Yıl";
            Column15.Name = "Column15";
            Column15.Width = 90;
            // 
            // Column11
            // 
            Column11.HeaderText = "Aidat Ücreti";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 85;
            // 
            // dgMember
            // 
            dgMember.AllowUserToOrderColumns = true;
            dgMember.BackgroundColor = SystemColors.Control;
            dgMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMember.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgMember.Location = new Point(352, 150);
            dgMember.Margin = new Padding(4, 3, 4, 3);
            dgMember.Name = "dgMember";
            dgMember.RowHeadersWidth = 51;
            dgMember.RowTemplate.Height = 29;
            dgMember.Size = new Size(832, 700);
            dgMember.TabIndex = 119;
            dgMember.CellDoubleClick += dgMember_CellDoubleClick;
            // 
            // Column0
            // 
            Column0.HeaderText = "ID";
            Column0.MinimumWidth = 6;
            Column0.Name = "Column0";
            Column0.Width = 40;
            // 
            // Column1
            // 
            Column1.HeaderText = "TC";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Soyad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 90;
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
            // txtYear
            // 
            txtYear.Location = new Point(181, 339);
            txtYear.Margin = new Padding(4, 3, 4, 3);
            txtYear.MaxLength = 11;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 23);
            txtYear.TabIndex = 148;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbYear.ForeColor = Color.White;
            lbYear.Location = new Point(139, 339);
            lbYear.Margin = new Padding(4, 0, 4, 0);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(39, 23);
            lbYear.TabIndex = 139;
            lbYear.Text = "YIL :";
            // 
            // txtIdentificationNumber
            // 
            txtIdentificationNumber.Location = new Point(181, 216);
            txtIdentificationNumber.Margin = new Padding(4, 3, 4, 3);
            txtIdentificationNumber.MaxLength = 11;
            txtIdentificationNumber.Name = "txtIdentificationNumber";
            txtIdentificationNumber.Size = new Size(151, 23);
            txtIdentificationNumber.TabIndex = 144;
            // 
            // mskdPhone
            // 
            mskdPhone.Location = new Point(181, 308);
            mskdPhone.Mask = "(999) 000 00 00";
            mskdPhone.Name = "mskdPhone";
            mskdPhone.Size = new Size(151, 23);
            mskdPhone.TabIndex = 147;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.ForeColor = Color.White;
            lbPhone.Location = new Point(94, 307);
            lbPhone.Margin = new Padding(4, 0, 4, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(83, 23);
            lbPhone.TabIndex = 149;
            lbPhone.Text = "TELEFON :";
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 246);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 145;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(181, 277);
            txtSurname.Margin = new Padding(4, 3, 4, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(151, 23);
            txtSurname.TabIndex = 146;
            // 
            // lbSurname
            // 
            lbSurname.AutoSize = true;
            lbSurname.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbSurname.ForeColor = Color.White;
            lbSurname.Location = new Point(112, 279);
            lbSurname.Margin = new Padding(4, 0, 4, 0);
            lbSurname.Name = "lbSurname";
            lbSurname.Size = new Size(65, 23);
            lbSurname.TabIndex = 145;
            lbSurname.Text = "SOYAD :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(139, 248);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(38, 23);
            lbName.TabIndex = 143;
            lbName.Text = "AD :";
            // 
            // lbIdentificationNumber
            // 
            lbIdentificationNumber.AutoSize = true;
            lbIdentificationNumber.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbIdentificationNumber.ForeColor = Color.White;
            lbIdentificationNumber.Location = new Point(139, 216);
            lbIdentificationNumber.Margin = new Padding(4, 0, 4, 0);
            lbIdentificationNumber.Name = "lbIdentificationNumber";
            lbIdentificationNumber.Size = new Size(38, 23);
            lbIdentificationNumber.TabIndex = 142;
            lbIdentificationNumber.Text = "T.C :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(352, 125);
            label1.Name = "label1";
            label1.Size = new Size(200, 19);
            label1.TabIndex = 152;
            label1.Text = "*Aidat Girişi İçin Üye Seçiniz!..";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(181, 485);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 30);
            btnClear.TabIndex = 155;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(182, 449);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 30);
            btnUpdate.TabIndex = 156;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(269, 412);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 30);
            btnDelete.TabIndex = 154;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(181, 412);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 30);
            btnSave.TabIndex = 153;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // FrmSubscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1382, 601);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtIdentificationNumber);
            Controls.Add(mskdPhone);
            Controls.Add(lbPhone);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(lbSurname);
            Controls.Add(lbName);
            Controls.Add(lbIdentificationNumber);
            Controls.Add(txtYear);
            Controls.Add(lbYear);
            Controls.Add(btnSearch);
            Controls.Add(txtAmount);
            Controls.Add(lbAmount);
            Controls.Add(lbMemberId);
            Controls.Add(txtMemberId);
            Controls.Add(dtDate);
            Controls.Add(dgSubscription);
            Controls.Add(dgMember);
            Name = "FrmSubscription";
            Text = "FrmSubscription";
            Load += FrmSubscription_Load;
            ((System.ComponentModel.ISupportInitialize)dgSubscription).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private TextBox txtAmount;
        private Label lbAmount;
        private Label lbMemberId;
        private TextBox txtMemberId;
        private DateTimePicker dtDate;
        private DataGridView dgSubscription;
        private DataGridView dgMember;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox txtYear;
        private Label lbYear;
        private TextBox txtIdentificationNumber;
        private MaskedTextBox mskdPhone;
        private Label lbPhone;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label lbSurname;
        private Label lbName;
        private Label lbIdentificationNumber;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column11;
        private Label label1;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
    }
}