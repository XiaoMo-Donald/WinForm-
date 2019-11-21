namespace MoGuangYuan.MyJXCWindowUI
{
    partial class Frm_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Customer));
            this.dgCustomerInfo = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerFax = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContacter = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCustomerBankAccount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCustomerBankName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCustomerTel = new System.Windows.Forms.TextBox();
            this.txtCustomerZipCode = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSpellingCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.txtCustomerEmail);
            this.gbInfo.Controls.Add(this.label13);
            this.gbInfo.Controls.Add(this.label14);
            this.gbInfo.Controls.Add(this.label15);
            this.gbInfo.Controls.Add(this.txtCustomerFax);
            this.gbInfo.Controls.Add(this.label16);
            this.gbInfo.Controls.Add(this.txtContacter);
            this.gbInfo.Controls.Add(this.label17);
            this.gbInfo.Controls.Add(this.txtCustomerBankAccount);
            this.gbInfo.Controls.Add(this.label18);
            this.gbInfo.Controls.Add(this.txtCustomerBankName);
            this.gbInfo.Controls.Add(this.label19);
            this.gbInfo.Controls.Add(this.txtCustomerTel);
            this.gbInfo.Controls.Add(this.txtCustomerZipCode);
            this.gbInfo.Controls.Add(this.txtCustomerAddress);
            this.gbInfo.Controls.Add(this.label20);
            this.gbInfo.Controls.Add(this.txtSpellingCode);
            this.gbInfo.Controls.Add(this.label21);
            this.gbInfo.Controls.Add(this.txtCustomerName);
            this.gbInfo.Controls.Add(this.label22);
            this.gbInfo.Controls.Add(this.txtCustomerID);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnCancel, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerID, 0);
            this.gbInfo.Controls.SetChildIndex(this.label22, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerName, 0);
            this.gbInfo.Controls.SetChildIndex(this.label21, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpellingCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.label20, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerAddress, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerZipCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerTel, 0);
            this.gbInfo.Controls.SetChildIndex(this.label19, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerBankName, 0);
            this.gbInfo.Controls.SetChildIndex(this.label18, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerBankAccount, 0);
            this.gbInfo.Controls.SetChildIndex(this.label17, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtContacter, 0);
            this.gbInfo.Controls.SetChildIndex(this.label16, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerFax, 0);
            this.gbInfo.Controls.SetChildIndex(this.label15, 0);
            this.gbInfo.Controls.SetChildIndex(this.label14, 0);
            this.gbInfo.Controls.SetChildIndex(this.label13, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerEmail, 0);
            this.gbInfo.Controls.SetChildIndex(this.label9, 0);
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
            // dgCustomerInfo
            // 
            this.dgCustomerInfo.AllowUserToAddRows = false;
            this.dgCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName,
            this.spellingCode,
            this.address,
            this.zipCode,
            this.tel,
            this.fax,
            this.bankName,
            this.bankAccount,
            this.contacter,
            this.email});
            this.dgCustomerInfo.Location = new System.Drawing.Point(13, 12);
            this.dgCustomerInfo.Name = "dgCustomerInfo";
            this.dgCustomerInfo.RowTemplate.Height = 23;
            this.dgCustomerInfo.Size = new System.Drawing.Size(841, 223);
            this.dgCustomerInfo.TabIndex = 78;
            this.dgCustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerInfo_CellClick);
            this.dgCustomerInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCustomerInfo_CellFormatting);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "CustomerID";
            this.customerID.HeaderText = "编号";
            this.customerID.Name = "customerID";
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "CustomerContact";
            this.customerName.HeaderText = "名称";
            this.customerName.Name = "customerName";
            // 
            // spellingCode
            // 
            this.spellingCode.DataPropertyName = "CustomerContact";
            this.spellingCode.HeaderText = "拼音码";
            this.spellingCode.Name = "spellingCode";
            // 
            // address
            // 
            this.address.DataPropertyName = "CustomerContact";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // zipCode
            // 
            this.zipCode.DataPropertyName = "CustomerContact";
            this.zipCode.HeaderText = "邮编";
            this.zipCode.Name = "zipCode";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "CustomerContact";
            this.tel.HeaderText = "电话";
            this.tel.Name = "tel";
            // 
            // fax
            // 
            this.fax.DataPropertyName = "CustomerContact";
            this.fax.HeaderText = "传真";
            this.fax.Name = "fax";
            // 
            // bankName
            // 
            this.bankName.DataPropertyName = "CustomerContact";
            this.bankName.HeaderText = "开户银行";
            this.bankName.Name = "bankName";
            // 
            // bankAccount
            // 
            this.bankAccount.DataPropertyName = "CustomerContact";
            this.bankAccount.HeaderText = "银行帐户";
            this.bankAccount.Name = "bankAccount";
            // 
            // contacter
            // 
            this.contacter.DataPropertyName = "CustomerContact";
            this.contacter.HeaderText = "联系人";
            this.contacter.Name = "contacter";
            // 
            // email
            // 
            this.email.DataPropertyName = "CustomerContact";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "Email：";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(636, 196);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerEmail.TabIndex = 121;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 120;
            this.label13.Text = "电  话：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 119;
            this.label14.Text = "邮  编：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 118;
            this.label15.Text = "地  址：";
            // 
            // txtCustomerFax
            // 
            this.txtCustomerFax.Location = new System.Drawing.Point(371, 197);
            this.txtCustomerFax.Name = "txtCustomerFax";
            this.txtCustomerFax.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerFax.TabIndex = 117;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(568, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 116;
            this.label16.Text = "联 系 人：";
            // 
            // txtContacter
            // 
            this.txtContacter.Location = new System.Drawing.Point(636, 148);
            this.txtContacter.Name = "txtContacter";
            this.txtContacter.Size = new System.Drawing.Size(131, 21);
            this.txtContacter.TabIndex = 115;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(567, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 114;
            this.label17.Text = "银行账户：";
            // 
            // txtCustomerBankAccount
            // 
            this.txtCustomerBankAccount.Location = new System.Drawing.Point(636, 100);
            this.txtCustomerBankAccount.Name = "txtCustomerBankAccount";
            this.txtCustomerBankAccount.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerBankAccount.TabIndex = 113;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(567, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 112;
            this.label18.Text = "开户银行：";
            // 
            // txtCustomerBankName
            // 
            this.txtCustomerBankName.Location = new System.Drawing.Point(636, 52);
            this.txtCustomerBankName.Name = "txtCustomerBankName";
            this.txtCustomerBankName.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerBankName.TabIndex = 111;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(312, 202);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 110;
            this.label19.Text = "传  真：";
            // 
            // txtCustomerTel
            // 
            this.txtCustomerTel.Location = new System.Drawing.Point(371, 149);
            this.txtCustomerTel.Name = "txtCustomerTel";
            this.txtCustomerTel.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerTel.TabIndex = 109;
            // 
            // txtCustomerZipCode
            // 
            this.txtCustomerZipCode.Location = new System.Drawing.Point(371, 101);
            this.txtCustomerZipCode.Name = "txtCustomerZipCode";
            this.txtCustomerZipCode.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerZipCode.TabIndex = 108;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(371, 53);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerAddress.TabIndex = 107;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(56, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 106;
            this.label20.Text = "拼 音 码：";
            // 
            // txtSpellingCode
            // 
            this.txtSpellingCode.Location = new System.Drawing.Point(125, 149);
            this.txtSpellingCode.Name = "txtSpellingCode";
            this.txtSpellingCode.Size = new System.Drawing.Size(131, 21);
            this.txtSpellingCode.TabIndex = 105;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 104;
            this.label21.Text = "客户名称：";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(125, 101);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerName.TabIndex = 103;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(55, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 102;
            this.label22.Text = "客户编号：";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(125, 53);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerID.TabIndex = 101;
            // 
            // Frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.dgCustomerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Customer";
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.Frm_Customer_Load);
            this.Controls.SetChildIndex(this.lblSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearchCancel, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNewAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.dgCustomerInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustomerInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustomerFax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtContacter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCustomerBankAccount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCustomerBankName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCustomerTel;
        private System.Windows.Forms.TextBox txtCustomerZipCode;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSpellingCode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
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