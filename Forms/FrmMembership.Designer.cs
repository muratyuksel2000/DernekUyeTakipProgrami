namespace DernekTakip01.Forms
{
    partial class FrmMembership
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
            lbBirthDate = new Label();
            mskdDateOfBirth = new MaskedTextBox();
            cbBloodGroup = new ComboBox();
            txtId = new TextBox();
            txtIdentificationNumber = new TextBox();
            mskdPhone = new MaskedTextBox();
            lbPhone = new Label();
            lbEmail = new Label();
            lbBlood = new Label();
            lbCity = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtCity = new TextBox();
            btnSave = new Button();
            txtEmail = new TextBox();
            lbSurname = new Label();
            lbId = new Label();
            lbName = new Label();
            lbIdentificationNumber = new Label();
            txtMemberSearch = new TextBox();
            lbMemberSearch = new Label();
            lbMembers = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgMember).BeginInit();
            SuspendLayout();
            // 
            // lbBirthDate
            // 
            lbBirthDate.AutoSize = true;
            lbBirthDate.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbBirthDate.ForeColor = Color.White;
            lbBirthDate.Location = new Point(47, 337);
            lbBirthDate.Margin = new Padding(4, 0, 4, 0);
            lbBirthDate.Name = "lbBirthDate";
            lbBirthDate.Size = new Size(121, 23);
            lbBirthDate.TabIndex = 104;
            lbBirthDate.Text = "DOĞUM TARİHİ :";
            // 
            // mskdDateOfBirth
            // 
            mskdDateOfBirth.Location = new Point(171, 336);
            mskdDateOfBirth.Mask = "00/00/0000";
            mskdDateOfBirth.Name = "mskdDateOfBirth";
            mskdDateOfBirth.Size = new Size(144, 23);
            mskdDateOfBirth.TabIndex = 90;
            // 
            // cbBloodGroup
            // 
            cbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBloodGroup.FormattingEnabled = true;
            cbBloodGroup.Location = new Point(170, 416);
            cbBloodGroup.Name = "cbBloodGroup";
            cbBloodGroup.Size = new Size(145, 23);
            cbBloodGroup.TabIndex = 92;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 155);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 84;
            // 
            // txtIdentificationNumber
            // 
            txtIdentificationNumber.Location = new Point(171, 187);
            txtIdentificationNumber.Margin = new Padding(4, 3, 4, 3);
            txtIdentificationNumber.MaxLength = 11;
            txtIdentificationNumber.Name = "txtIdentificationNumber";
            txtIdentificationNumber.Size = new Size(144, 23);
            txtIdentificationNumber.TabIndex = 85;
            // 
            // mskdPhone
            // 
            mskdPhone.Location = new Point(171, 295);
            mskdPhone.Mask = "(999) 000 00 00";
            mskdPhone.Name = "mskdPhone";
            mskdPhone.Size = new Size(145, 23);
            mskdPhone.TabIndex = 89;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.ForeColor = Color.White;
            lbPhone.Location = new Point(84, 294);
            lbPhone.Margin = new Padding(4, 0, 4, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(83, 23);
            lbPhone.TabIndex = 103;
            lbPhone.Text = "TELEFON :";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(96, 452);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 23);
            lbEmail.TabIndex = 102;
            lbEmail.Text = "E-MAİL :";
            // 
            // lbBlood
            // 
            lbBlood.AutoSize = true;
            lbBlood.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbBlood.ForeColor = Color.White;
            lbBlood.Location = new Point(64, 417);
            lbBlood.Margin = new Padding(4, 0, 4, 0);
            lbBlood.Name = "lbBlood";
            lbBlood.Size = new Size(103, 23);
            lbBlood.TabIndex = 100;
            lbBlood.Text = "KAN GRUBU :";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCity.ForeColor = Color.White;
            lbCity.Location = new Point(106, 376);
            lbCity.Margin = new Padding(4, 0, 4, 0);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(61, 23);
            lbCity.TabIndex = 99;
            lbCity.Text = "ŞEHİR :";
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 220);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 23);
            txtName.TabIndex = 87;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(171, 255);
            txtSurname.Margin = new Padding(4, 3, 4, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(144, 23);
            txtSurname.TabIndex = 88;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(170, 563);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 30);
            btnClear.TabIndex = 97;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(171, 527);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 30);
            btnUpdate.TabIndex = 98;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(258, 490);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 30);
            btnDelete.TabIndex = 96;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(171, 375);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(144, 23);
            txtCity.TabIndex = 91;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(170, 490);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 30);
            btnSave.TabIndex = 95;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 452);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(144, 23);
            txtEmail.TabIndex = 94;
            // 
            // lbSurname
            // 
            lbSurname.AutoSize = true;
            lbSurname.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbSurname.ForeColor = Color.White;
            lbSurname.Location = new Point(102, 257);
            lbSurname.Margin = new Padding(4, 0, 4, 0);
            lbSurname.Name = "lbSurname";
            lbSurname.Size = new Size(65, 23);
            lbSurname.TabIndex = 86;
            lbSurname.Text = "SOYAD :";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbId.ForeColor = Color.White;
            lbId.Location = new Point(98, 154);
            lbId.Margin = new Padding(4, 0, 4, 0);
            lbId.Name = "lbId";
            lbId.Size = new Size(70, 23);
            lbId.TabIndex = 82;
            lbId.Text = "ÜYE NO :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(129, 222);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(38, 23);
            lbName.TabIndex = 83;
            lbName.Text = "AD :";
            // 
            // lbIdentificationNumber
            // 
            lbIdentificationNumber.AutoSize = true;
            lbIdentificationNumber.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbIdentificationNumber.ForeColor = Color.White;
            lbIdentificationNumber.Location = new Point(129, 187);
            lbIdentificationNumber.Margin = new Padding(4, 0, 4, 0);
            lbIdentificationNumber.Name = "lbIdentificationNumber";
            lbIdentificationNumber.Size = new Size(38, 23);
            lbIdentificationNumber.TabIndex = 81;
            lbIdentificationNumber.Text = "T.C :";
            // 
            // txtMemberSearch
            // 
            txtMemberSearch.Location = new Point(696, 117);
            txtMemberSearch.Name = "txtMemberSearch";
            txtMemberSearch.Size = new Size(149, 23);
            txtMemberSearch.TabIndex = 108;
            // 
            // lbMemberSearch
            // 
            lbMemberSearch.AutoSize = true;
            lbMemberSearch.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberSearch.ForeColor = Color.White;
            lbMemberSearch.Location = new Point(619, 119);
            lbMemberSearch.Name = "lbMemberSearch";
            lbMemberSearch.Size = new Size(71, 23);
            lbMemberSearch.TabIndex = 107;
            lbMemberSearch.Text = "ÜYE ARA";
            // 
            // lbMembers
            // 
            lbMembers.AutoSize = true;
            lbMembers.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMembers.ForeColor = Color.White;
            lbMembers.Location = new Point(335, 117);
            lbMembers.Name = "lbMembers";
            lbMembers.Size = new Size(74, 25);
            lbMembers.TabIndex = 106;
            lbMembers.Text = "ÜYELER";
            // 
            // dgMember
            // 
            dgMember.AllowUserToOrderColumns = true;
            dgMember.BackgroundColor = SystemColors.Control;
            dgMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMember.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgMember.Location = new Point(338, 150);
            dgMember.Margin = new Padding(4, 3, 4, 3);
            dgMember.Name = "dgMember";
            dgMember.RowHeadersWidth = 51;
            dgMember.RowTemplate.Height = 29;
            dgMember.Size = new Size(983, 700);
            dgMember.TabIndex = 105;
            dgMember.CellClick += dgMember_CellClick;
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
            // 
            // Column2
            // 
            Column2.HeaderText = "Ad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Soyad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 115;
            // 
            // Column5
            // 
            Column5.HeaderText = "DogumTarihi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.Width = 95;
            // 
            // Column6
            // 
            Column6.HeaderText = "Sehir";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "KanGrubu";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 140;
            // 
            // FrmMembership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1347, 633);
            Controls.Add(txtMemberSearch);
            Controls.Add(lbMemberSearch);
            Controls.Add(lbMembers);
            Controls.Add(dgMember);
            Controls.Add(lbBirthDate);
            Controls.Add(mskdDateOfBirth);
            Controls.Add(cbBloodGroup);
            Controls.Add(txtId);
            Controls.Add(txtIdentificationNumber);
            Controls.Add(mskdPhone);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(lbBlood);
            Controls.Add(lbCity);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtCity);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(lbSurname);
            Controls.Add(lbId);
            Controls.Add(lbName);
            Controls.Add(lbIdentificationNumber);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmMembership";
            Text = "ÜYE İŞLEMLERİ";
            Load += FrmMembership_Load;
            ((System.ComponentModel.ISupportInitialize)dgMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBirthDate;
        private MaskedTextBox mskdDateOfBirth;
        private ComboBox cbBloodGroup;
        private TextBox txtId;
        private TextBox txtIdentificationNumber;
        private MaskedTextBox mskdPhone;
        private Label lbPhone;
        private Label lbEmail;
        private Label lbBlood;
        private Label lbCity;
        private TextBox txtName;
        private TextBox txtSurname;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtCity;
        private Button btnSave;
        private TextBox txtEmail;
        private Label lbSurname;
        private Label lbId;
        private Label lbName;
        private Label lbIdentificationNumber;
        private TextBox txtMemberSearch;
        private Label lbMemberSearch;
        private Label lbMembers;
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
    }
}