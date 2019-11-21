namespace MoGuangYuan.MyJXCWindowUI
{
    partial class Frm_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Supplier));
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplierFax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContacter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplierBankAccount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSupplierBankName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierTel = new System.Windows.Forms.TextBox();
            this.txtSupplierZipCode = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpellingCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.dgSupplierInfo = new System.Windows.Forms.DataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.txtSupplierEmail);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txtSupplierFax);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.txtContacter);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.txtSupplierBankAccount);
            this.gbInfo.Controls.Add(this.label12);
            this.gbInfo.Controls.Add(this.txtSupplierBankName);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtSupplierTel);
            this.gbInfo.Controls.Add(this.txtSupplierZipCode);
            this.gbInfo.Controls.Add(this.txtSupplierAddress);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtSpellingCode);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtSupplierName);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtSupplierID);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnCancel, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierID, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpellingCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.label3, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierAddress, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierZipCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierTel, 0);
            this.gbInfo.Controls.SetChildIndex(this.label5, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierBankName, 0);
            this.gbInfo.Controls.SetChildIndex(this.label12, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierBankAccount, 0);
            this.gbInfo.Controls.SetChildIndex(this.label11, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtContacter, 0);
            this.gbInfo.Controls.SetChildIndex(this.label10, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierFax, 0);
            this.gbInfo.Controls.SetChildIndex(this.label4, 0);
            this.gbInfo.Controls.SetChildIndex(this.label6, 0);
            this.gbInfo.Controls.SetChildIndex(this.label7, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSupplierEmail, 0);
            this.gbInfo.Controls.SetChildIndex(this.label8, 0);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 99;
            this.label8.Text = "Email：";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(636, 196);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierEmail.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 97;
            this.label7.Text = "电  话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 96;
            this.label6.Text = "邮  编：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 95;
            this.label4.Text = "地  址：";
            // 
            // txtSupplierFax
            // 
            this.txtSupplierFax.Location = new System.Drawing.Point(371, 197);
            this.txtSupplierFax.Name = "txtSupplierFax";
            this.txtSupplierFax.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierFax.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 93;
            this.label10.Text = "联 系 人：";
            // 
            // txtContacter
            // 
            this.txtContacter.Location = new System.Drawing.Point(636, 148);
            this.txtContacter.Name = "txtContacter";
            this.txtContacter.Size = new System.Drawing.Size(131, 21);
            this.txtContacter.TabIndex = 92;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 91;
            this.label11.Text = "银行账户：";
            // 
            // txtSupplierBankAccount
            // 
            this.txtSupplierBankAccount.Location = new System.Drawing.Point(636, 100);
            this.txtSupplierBankAccount.Name = "txtSupplierBankAccount";
            this.txtSupplierBankAccount.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierBankAccount.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(567, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 89;
            this.label12.Text = "开户银行：";
            // 
            // txtSupplierBankName
            // 
            this.txtSupplierBankName.Location = new System.Drawing.Point(636, 52);
            this.txtSupplierBankName.Name = "txtSupplierBankName";
            this.txtSupplierBankName.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierBankName.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 87;
            this.label5.Text = "传  真：";
            // 
            // txtSupplierTel
            // 
            this.txtSupplierTel.Location = new System.Drawing.Point(371, 149);
            this.txtSupplierTel.Name = "txtSupplierTel";
            this.txtSupplierTel.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierTel.TabIndex = 86;
            // 
            // txtSupplierZipCode
            // 
            this.txtSupplierZipCode.Location = new System.Drawing.Point(371, 101);
            this.txtSupplierZipCode.Name = "txtSupplierZipCode";
            this.txtSupplierZipCode.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierZipCode.TabIndex = 85;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(371, 53);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierAddress.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 83;
            this.label3.Text = "拼 音 码：";
            // 
            // txtSpellingCode
            // 
            this.txtSpellingCode.Location = new System.Drawing.Point(125, 149);
            this.txtSpellingCode.Name = "txtSpellingCode";
            this.txtSpellingCode.Size = new System.Drawing.Size(131, 21);
            this.txtSpellingCode.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 81;
            this.label2.Text = "名  称：";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(125, 101);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierName.TabIndex = 80;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 79;
            this.label1.Text = "编  号：";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(125, 53);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(131, 21);
            this.txtSupplierID.TabIndex = 78;
            // 
            // dgSupplierInfo
            // 
            this.dgSupplierInfo.AllowUserToAddRows = false;
            this.dgSupplierInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.supplierName,
            this.spellingCode,
            this.address,
            this.zipCode,
            this.tel,
            this.fax,
            this.bankName,
            this.bankAccount,
            this.contacter,
            this.email});
            this.dgSupplierInfo.Location = new System.Drawing.Point(13, 12);
            this.dgSupplierInfo.Name = "dgSupplierInfo";
            this.dgSupplierInfo.RowTemplate.Height = 23;
            this.dgSupplierInfo.Size = new System.Drawing.Size(841, 223);
            this.dgSupplierInfo.TabIndex = 9;
            this.dgSupplierInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplierInfo_CellClick);
            this.dgSupplierInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgSupplierInfo_CellFormatting);
            // 
            // supplierID
            // 
            this.supplierID.DataPropertyName = "SupplierID";
            this.supplierID.HeaderText = "编号";
            this.supplierID.Name = "supplierID";
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "SupplierContact";
            this.supplierName.HeaderText = "名称";
            this.supplierName.Name = "supplierName";
            // 
            // spellingCode
            // 
            this.spellingCode.DataPropertyName = "SupplierContact";
            this.spellingCode.HeaderText = "拼音码";
            this.spellingCode.Name = "spellingCode";
            // 
            // address
            // 
            this.address.DataPropertyName = "SupplierContact";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // zipCode
            // 
            this.zipCode.DataPropertyName = "SupplierContact";
            this.zipCode.HeaderText = "邮编";
            this.zipCode.Name = "zipCode";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "SupplierContact";
            this.tel.HeaderText = "电话";
            this.tel.Name = "tel";
            // 
            // fax
            // 
            this.fax.DataPropertyName = "SupplierContact";
            this.fax.HeaderText = "传真";
            this.fax.Name = "fax";
            // 
            // bankName
            // 
            this.bankName.DataPropertyName = "SupplierContact";
            this.bankName.HeaderText = "开户银行";
            this.bankName.Name = "bankName";
            // 
            // bankAccount
            // 
            this.bankAccount.DataPropertyName = "SupplierContact";
            this.bankAccount.HeaderText = "银行帐户";
            this.bankAccount.Name = "bankAccount";
            // 
            // contacter
            // 
            this.contacter.DataPropertyName = "SupplierContact";
            this.contacter.HeaderText = "联系人";
            this.contacter.Name = "contacter";
            // 
            // email
            // 
            this.email.DataPropertyName = "SupplierContact";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // Frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.dgSupplierInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Supplier";
            this.Text = "供应商信息管理";
            this.Load += new System.EventHandler(this.Frm_Supplier_Load);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.lblSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearchCancel, 0);
            this.Controls.SetChildIndex(this.btnNewAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.dgSupplierInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplierFax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContacter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplierBankAccount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSupplierBankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierTel;
        private System.Windows.Forms.TextBox txtSupplierZipCode;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpellingCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.DataGridView dgSupplierInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellingCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}