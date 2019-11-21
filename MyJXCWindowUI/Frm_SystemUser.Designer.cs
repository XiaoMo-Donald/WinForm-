namespace MoGuangYuan.MyJXCWindowUI
{
    partial class Frm_SystemUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SystemUser));
            this.lbUserList = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestroePermissionsForUserFunction = new System.Windows.Forms.Button();
            this.btnRemovePermissionsForUserFunction = new System.Windows.Forms.Button();
            this.btnSelectPermissionsForUserFunction = new System.Windows.Forms.Button();
            this.gbBaseFunction = new System.Windows.Forms.GroupBox();
            this.cbEmployeesInfoManagement = new System.Windows.Forms.CheckBox();
            this.cbCustomerInfoManagement = new System.Windows.Forms.CheckBox();
            this.cbProductInfoManagement = new System.Windows.Forms.CheckBox();
            this.cbSupplierInfoManagement = new System.Windows.Forms.CheckBox();
            this.cbCategoryManagement = new System.Windows.Forms.CheckBox();
            this.gbPurchaseFunction = new System.Windows.Forms.GroupBox();
            this.cbExamPurchaseBill = new System.Windows.Forms.CheckBox();
            this.cbFillPurchaseBill = new System.Windows.Forms.CheckBox();
            this.cbInStockCheck = new System.Windows.Forms.CheckBox();
            this.gbSaleFunction = new System.Windows.Forms.GroupBox();
            this.cbSalesReturn = new System.Windows.Forms.CheckBox();
            this.cbSalesManagement = new System.Windows.Forms.CheckBox();
            this.gbUserFunction = new System.Windows.Forms.GroupBox();
            this.cbUserManagement = new System.Windows.Forms.CheckBox();
            this.cbChangeThePassword = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSelectPermissionsAll = new System.Windows.Forms.Button();
            this.btnRemovePermissionsAll = new System.Windows.Forms.Button();
            this.btnRestorePermissionsAll = new System.Windows.Forms.Button();
            this.btnRestorePermissionsForSaleFunction = new System.Windows.Forms.Button();
            this.btnRemovePermissionsForSaleFunction = new System.Windows.Forms.Button();
            this.btnSelectPermissionsForSaleFunction = new System.Windows.Forms.Button();
            this.btnRestorePermissionsForPurchaseFunction = new System.Windows.Forms.Button();
            this.btnRemovePermissionsForPurchaseFunction = new System.Windows.Forms.Button();
            this.btnSelectPermissionsForPurchaseFunction = new System.Windows.Forms.Button();
            this.btnRestorePermissionsForBaseFunction = new System.Windows.Forms.Button();
            this.btnRemovePermissionsForBaseFunction = new System.Windows.Forms.Button();
            this.btnSelectPermissionsForBaseFunction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInitializePassword = new System.Windows.Forms.Button();
            this.gbBaseFunction.SuspendLayout();
            this.gbPurchaseFunction.SuspendLayout();
            this.gbSaleFunction.SuspendLayout();
            this.gbUserFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserList
            // 
            this.lbUserList.FormattingEnabled = true;
            this.lbUserList.ItemHeight = 12;
            this.lbUserList.Location = new System.Drawing.Point(23, 55);
            this.lbUserList.Name = "lbUserList";
            this.lbUserList.Size = new System.Drawing.Size(177, 460);
            this.lbUserList.TabIndex = 0;
            this.lbUserList.Click += new System.EventHandler(this.lbUserList_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(22, 531);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(402, 28);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确       定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(445, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(399, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取       消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRestroePermissionsForUserFunction
            // 
            this.btnRestroePermissionsForUserFunction.Location = new System.Drawing.Point(226, 492);
            this.btnRestroePermissionsForUserFunction.Name = "btnRestroePermissionsForUserFunction";
            this.btnRestroePermissionsForUserFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRestroePermissionsForUserFunction.TabIndex = 14;
            this.btnRestroePermissionsForUserFunction.Text = "恢复权限";
            this.btnRestroePermissionsForUserFunction.UseVisualStyleBackColor = true;
            this.btnRestroePermissionsForUserFunction.Click += new System.EventHandler(this.btnRestroePermissionsForUserFunction_Click);
            // 
            // btnRemovePermissionsForUserFunction
            // 
            this.btnRemovePermissionsForUserFunction.Location = new System.Drawing.Point(226, 467);
            this.btnRemovePermissionsForUserFunction.Name = "btnRemovePermissionsForUserFunction";
            this.btnRemovePermissionsForUserFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePermissionsForUserFunction.TabIndex = 13;
            this.btnRemovePermissionsForUserFunction.Text = "清除权限";
            this.btnRemovePermissionsForUserFunction.UseVisualStyleBackColor = true;
            this.btnRemovePermissionsForUserFunction.Click += new System.EventHandler(this.btnRemovePermissionsForUserFunction_Click);
            // 
            // btnSelectPermissionsForUserFunction
            // 
            this.btnSelectPermissionsForUserFunction.Location = new System.Drawing.Point(226, 442);
            this.btnSelectPermissionsForUserFunction.Name = "btnSelectPermissionsForUserFunction";
            this.btnSelectPermissionsForUserFunction.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPermissionsForUserFunction.TabIndex = 12;
            this.btnSelectPermissionsForUserFunction.Text = "选择权限";
            this.btnSelectPermissionsForUserFunction.UseVisualStyleBackColor = true;
            this.btnSelectPermissionsForUserFunction.Click += new System.EventHandler(this.btnSelectPermissionsForUserFunction_Click);
            // 
            // gbBaseFunction
            // 
            this.gbBaseFunction.Controls.Add(this.cbEmployeesInfoManagement);
            this.gbBaseFunction.Controls.Add(this.cbCustomerInfoManagement);
            this.gbBaseFunction.Controls.Add(this.cbProductInfoManagement);
            this.gbBaseFunction.Controls.Add(this.cbSupplierInfoManagement);
            this.gbBaseFunction.Controls.Add(this.cbCategoryManagement);
            this.gbBaseFunction.Location = new System.Drawing.Point(326, 137);
            this.gbBaseFunction.Name = "gbBaseFunction";
            this.gbBaseFunction.Size = new System.Drawing.Size(516, 109);
            this.gbBaseFunction.TabIndex = 15;
            this.gbBaseFunction.TabStop = false;
            this.gbBaseFunction.Text = "基础信息管理";
            // 
            // cbEmployeesInfoManagement
            // 
            this.cbEmployeesInfoManagement.AutoSize = true;
            this.cbEmployeesInfoManagement.Location = new System.Drawing.Point(41, 80);
            this.cbEmployeesInfoManagement.Name = "cbEmployeesInfoManagement";
            this.cbEmployeesInfoManagement.Size = new System.Drawing.Size(96, 16);
            this.cbEmployeesInfoManagement.TabIndex = 2;
            this.cbEmployeesInfoManagement.Text = "员工信息管理";
            this.cbEmployeesInfoManagement.UseVisualStyleBackColor = true;
            // 
            // cbCustomerInfoManagement
            // 
            this.cbCustomerInfoManagement.AutoSize = true;
            this.cbCustomerInfoManagement.Location = new System.Drawing.Point(260, 52);
            this.cbCustomerInfoManagement.Name = "cbCustomerInfoManagement";
            this.cbCustomerInfoManagement.Size = new System.Drawing.Size(96, 16);
            this.cbCustomerInfoManagement.TabIndex = 3;
            this.cbCustomerInfoManagement.Text = "客户信息管理";
            this.cbCustomerInfoManagement.UseVisualStyleBackColor = true;
            // 
            // cbProductInfoManagement
            // 
            this.cbProductInfoManagement.AutoSize = true;
            this.cbProductInfoManagement.Location = new System.Drawing.Point(260, 24);
            this.cbProductInfoManagement.Name = "cbProductInfoManagement";
            this.cbProductInfoManagement.Size = new System.Drawing.Size(96, 16);
            this.cbProductInfoManagement.TabIndex = 2;
            this.cbProductInfoManagement.Text = "产品信息管理";
            this.cbProductInfoManagement.UseVisualStyleBackColor = true;
            // 
            // cbSupplierInfoManagement
            // 
            this.cbSupplierInfoManagement.AutoSize = true;
            this.cbSupplierInfoManagement.Location = new System.Drawing.Point(41, 52);
            this.cbSupplierInfoManagement.Name = "cbSupplierInfoManagement";
            this.cbSupplierInfoManagement.Size = new System.Drawing.Size(108, 16);
            this.cbSupplierInfoManagement.TabIndex = 1;
            this.cbSupplierInfoManagement.Text = "供应商信息管理";
            this.cbSupplierInfoManagement.UseVisualStyleBackColor = true;
            // 
            // cbCategoryManagement
            // 
            this.cbCategoryManagement.AutoSize = true;
            this.cbCategoryManagement.Location = new System.Drawing.Point(41, 24);
            this.cbCategoryManagement.Name = "cbCategoryManagement";
            this.cbCategoryManagement.Size = new System.Drawing.Size(96, 16);
            this.cbCategoryManagement.TabIndex = 0;
            this.cbCategoryManagement.Text = "产品分类管理";
            this.cbCategoryManagement.UseVisualStyleBackColor = true;
            // 
            // gbPurchaseFunction
            // 
            this.gbPurchaseFunction.Controls.Add(this.cbExamPurchaseBill);
            this.gbPurchaseFunction.Controls.Add(this.cbFillPurchaseBill);
            this.gbPurchaseFunction.Controls.Add(this.cbInStockCheck);
            this.gbPurchaseFunction.Location = new System.Drawing.Point(326, 256);
            this.gbPurchaseFunction.Name = "gbPurchaseFunction";
            this.gbPurchaseFunction.Size = new System.Drawing.Size(516, 86);
            this.gbPurchaseFunction.TabIndex = 16;
            this.gbPurchaseFunction.TabStop = false;
            this.gbPurchaseFunction.Text = "进货管理";
            // 
            // cbExamPurchaseBill
            // 
            this.cbExamPurchaseBill.AutoSize = true;
            this.cbExamPurchaseBill.Location = new System.Drawing.Point(260, 27);
            this.cbExamPurchaseBill.Name = "cbExamPurchaseBill";
            this.cbExamPurchaseBill.Size = new System.Drawing.Size(84, 16);
            this.cbExamPurchaseBill.TabIndex = 6;
            this.cbExamPurchaseBill.Text = "审核进货单";
            this.cbExamPurchaseBill.UseVisualStyleBackColor = true;
            // 
            // cbFillPurchaseBill
            // 
            this.cbFillPurchaseBill.AutoSize = true;
            this.cbFillPurchaseBill.Location = new System.Drawing.Point(41, 27);
            this.cbFillPurchaseBill.Name = "cbFillPurchaseBill";
            this.cbFillPurchaseBill.Size = new System.Drawing.Size(84, 16);
            this.cbFillPurchaseBill.TabIndex = 4;
            this.cbFillPurchaseBill.Text = "填写进货单";
            this.cbFillPurchaseBill.UseVisualStyleBackColor = true;
            // 
            // cbInStockCheck
            // 
            this.cbInStockCheck.AutoSize = true;
            this.cbInStockCheck.Location = new System.Drawing.Point(41, 55);
            this.cbInStockCheck.Name = "cbInStockCheck";
            this.cbInStockCheck.Size = new System.Drawing.Size(72, 16);
            this.cbInStockCheck.TabIndex = 5;
            this.cbInStockCheck.Text = "检验货物";
            this.cbInStockCheck.UseVisualStyleBackColor = true;
            // 
            // gbSaleFunction
            // 
            this.gbSaleFunction.Controls.Add(this.cbSalesReturn);
            this.gbSaleFunction.Controls.Add(this.cbSalesManagement);
            this.gbSaleFunction.Location = new System.Drawing.Point(328, 352);
            this.gbSaleFunction.Name = "gbSaleFunction";
            this.gbSaleFunction.Size = new System.Drawing.Size(516, 80);
            this.gbSaleFunction.TabIndex = 16;
            this.gbSaleFunction.TabStop = false;
            this.gbSaleFunction.Text = "销售管理";
            // 
            // cbSalesReturn
            // 
            this.cbSalesReturn.AutoSize = true;
            this.cbSalesReturn.Location = new System.Drawing.Point(258, 35);
            this.cbSalesReturn.Name = "cbSalesReturn";
            this.cbSalesReturn.Size = new System.Drawing.Size(72, 16);
            this.cbSalesReturn.TabIndex = 9;
            this.cbSalesReturn.Text = "销售退货";
            this.cbSalesReturn.UseVisualStyleBackColor = true;
            // 
            // cbSalesManagement
            // 
            this.cbSalesManagement.AutoSize = true;
            this.cbSalesManagement.Location = new System.Drawing.Point(39, 35);
            this.cbSalesManagement.Name = "cbSalesManagement";
            this.cbSalesManagement.Size = new System.Drawing.Size(96, 16);
            this.cbSalesManagement.TabIndex = 7;
            this.cbSalesManagement.Text = "前台销售管理";
            this.cbSalesManagement.UseVisualStyleBackColor = true;
            // 
            // gbUserFunction
            // 
            this.gbUserFunction.Controls.Add(this.cbUserManagement);
            this.gbUserFunction.Controls.Add(this.cbChangeThePassword);
            this.gbUserFunction.Location = new System.Drawing.Point(328, 439);
            this.gbUserFunction.Name = "gbUserFunction";
            this.gbUserFunction.Size = new System.Drawing.Size(516, 76);
            this.gbUserFunction.TabIndex = 16;
            this.gbUserFunction.TabStop = false;
            this.gbUserFunction.Text = "用户管理";
            // 
            // cbUserManagement
            // 
            this.cbUserManagement.AutoSize = true;
            this.cbUserManagement.Location = new System.Drawing.Point(258, 35);
            this.cbUserManagement.Name = "cbUserManagement";
            this.cbUserManagement.Size = new System.Drawing.Size(72, 16);
            this.cbUserManagement.TabIndex = 11;
            this.cbUserManagement.Text = "用户管理";
            this.cbUserManagement.UseVisualStyleBackColor = true;
            // 
            // cbChangeThePassword
            // 
            this.cbChangeThePassword.AutoSize = true;
            this.cbChangeThePassword.Location = new System.Drawing.Point(39, 35);
            this.cbChangeThePassword.Name = "cbChangeThePassword";
            this.cbChangeThePassword.Size = new System.Drawing.Size(72, 16);
            this.cbChangeThePassword.TabIndex = 10;
            this.cbChangeThePassword.Text = "修改密码";
            this.cbChangeThePassword.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(643, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 21);
            this.txtName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "姓  名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "用户名：";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(386, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(165, 21);
            this.txtUserName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "密  码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(386, 66);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 21);
            this.txtPassword.TabIndex = 21;
            // 
            // btnSelectPermissionsAll
            // 
            this.btnSelectPermissionsAll.Location = new System.Drawing.Point(386, 104);
            this.btnSelectPermissionsAll.Name = "btnSelectPermissionsAll";
            this.btnSelectPermissionsAll.Size = new System.Drawing.Size(131, 23);
            this.btnSelectPermissionsAll.TabIndex = 23;
            this.btnSelectPermissionsAll.Text = "选择全部权限";
            this.btnSelectPermissionsAll.UseVisualStyleBackColor = true;
            this.btnSelectPermissionsAll.Click += new System.EventHandler(this.btnSelectPermissionsAll_Click);
            // 
            // btnRemovePermissionsAll
            // 
            this.btnRemovePermissionsAll.Location = new System.Drawing.Point(545, 104);
            this.btnRemovePermissionsAll.Name = "btnRemovePermissionsAll";
            this.btnRemovePermissionsAll.Size = new System.Drawing.Size(135, 23);
            this.btnRemovePermissionsAll.TabIndex = 24;
            this.btnRemovePermissionsAll.Text = "清除全部权限";
            this.btnRemovePermissionsAll.UseVisualStyleBackColor = true;
            this.btnRemovePermissionsAll.Click += new System.EventHandler(this.btnRemovePermissionsAll_Click);
            // 
            // btnRestorePermissionsAll
            // 
            this.btnRestorePermissionsAll.Location = new System.Drawing.Point(705, 104);
            this.btnRestorePermissionsAll.Name = "btnRestorePermissionsAll";
            this.btnRestorePermissionsAll.Size = new System.Drawing.Size(137, 23);
            this.btnRestorePermissionsAll.TabIndex = 25;
            this.btnRestorePermissionsAll.Text = "恢复全部权限";
            this.btnRestorePermissionsAll.UseVisualStyleBackColor = true;
            this.btnRestorePermissionsAll.Click += new System.EventHandler(this.btnRestorePermissionsAll_Click);
            // 
            // btnRestorePermissionsForSaleFunction
            // 
            this.btnRestorePermissionsForSaleFunction.Location = new System.Drawing.Point(226, 405);
            this.btnRestorePermissionsForSaleFunction.Name = "btnRestorePermissionsForSaleFunction";
            this.btnRestorePermissionsForSaleFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRestorePermissionsForSaleFunction.TabIndex = 28;
            this.btnRestorePermissionsForSaleFunction.Text = "恢复权限";
            this.btnRestorePermissionsForSaleFunction.UseVisualStyleBackColor = true;
            this.btnRestorePermissionsForSaleFunction.Click += new System.EventHandler(this.btnRestorePermissionsForSaleFunction_Click);
            // 
            // btnRemovePermissionsForSaleFunction
            // 
            this.btnRemovePermissionsForSaleFunction.Location = new System.Drawing.Point(226, 380);
            this.btnRemovePermissionsForSaleFunction.Name = "btnRemovePermissionsForSaleFunction";
            this.btnRemovePermissionsForSaleFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePermissionsForSaleFunction.TabIndex = 27;
            this.btnRemovePermissionsForSaleFunction.Text = "清除权限";
            this.btnRemovePermissionsForSaleFunction.UseVisualStyleBackColor = true;
            this.btnRemovePermissionsForSaleFunction.Click += new System.EventHandler(this.btnRemovePermissionsForSaleFunction_Click);
            // 
            // btnSelectPermissionsForSaleFunction
            // 
            this.btnSelectPermissionsForSaleFunction.Location = new System.Drawing.Point(226, 355);
            this.btnSelectPermissionsForSaleFunction.Name = "btnSelectPermissionsForSaleFunction";
            this.btnSelectPermissionsForSaleFunction.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPermissionsForSaleFunction.TabIndex = 26;
            this.btnSelectPermissionsForSaleFunction.Text = "选择权限";
            this.btnSelectPermissionsForSaleFunction.UseVisualStyleBackColor = true;
            this.btnSelectPermissionsForSaleFunction.Click += new System.EventHandler(this.btnSelectPermissionsForSaleFunction_Click);
            // 
            // btnRestorePermissionsForPurchaseFunction
            // 
            this.btnRestorePermissionsForPurchaseFunction.Location = new System.Drawing.Point(226, 308);
            this.btnRestorePermissionsForPurchaseFunction.Name = "btnRestorePermissionsForPurchaseFunction";
            this.btnRestorePermissionsForPurchaseFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRestorePermissionsForPurchaseFunction.TabIndex = 31;
            this.btnRestorePermissionsForPurchaseFunction.Text = "恢复权限";
            this.btnRestorePermissionsForPurchaseFunction.UseVisualStyleBackColor = true;
            this.btnRestorePermissionsForPurchaseFunction.Click += new System.EventHandler(this.btnRestorePermissionsForPurchaseFunction_Click);
            // 
            // btnRemovePermissionsForPurchaseFunction
            // 
            this.btnRemovePermissionsForPurchaseFunction.Location = new System.Drawing.Point(226, 283);
            this.btnRemovePermissionsForPurchaseFunction.Name = "btnRemovePermissionsForPurchaseFunction";
            this.btnRemovePermissionsForPurchaseFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePermissionsForPurchaseFunction.TabIndex = 30;
            this.btnRemovePermissionsForPurchaseFunction.Text = "清除权限";
            this.btnRemovePermissionsForPurchaseFunction.UseVisualStyleBackColor = true;
            this.btnRemovePermissionsForPurchaseFunction.Click += new System.EventHandler(this.btnRemovePermissionsForPurchaseFunction_Click);
            // 
            // btnSelectPermissionsForPurchaseFunction
            // 
            this.btnSelectPermissionsForPurchaseFunction.Location = new System.Drawing.Point(226, 258);
            this.btnSelectPermissionsForPurchaseFunction.Name = "btnSelectPermissionsForPurchaseFunction";
            this.btnSelectPermissionsForPurchaseFunction.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPermissionsForPurchaseFunction.TabIndex = 29;
            this.btnSelectPermissionsForPurchaseFunction.Text = "选择权限";
            this.btnSelectPermissionsForPurchaseFunction.UseVisualStyleBackColor = true;
            this.btnSelectPermissionsForPurchaseFunction.Click += new System.EventHandler(this.btnSelectPermissionsForPurchaseFunction_Click);
            // 
            // btnRestorePermissionsForBaseFunction
            // 
            this.btnRestorePermissionsForBaseFunction.Location = new System.Drawing.Point(226, 204);
            this.btnRestorePermissionsForBaseFunction.Name = "btnRestorePermissionsForBaseFunction";
            this.btnRestorePermissionsForBaseFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRestorePermissionsForBaseFunction.TabIndex = 34;
            this.btnRestorePermissionsForBaseFunction.Text = "恢复权限";
            this.btnRestorePermissionsForBaseFunction.UseVisualStyleBackColor = true;
            this.btnRestorePermissionsForBaseFunction.Click += new System.EventHandler(this.btnRestorePermissionsForBaseFunction_Click);
            // 
            // btnRemovePermissionsForBaseFunction
            // 
            this.btnRemovePermissionsForBaseFunction.Location = new System.Drawing.Point(226, 179);
            this.btnRemovePermissionsForBaseFunction.Name = "btnRemovePermissionsForBaseFunction";
            this.btnRemovePermissionsForBaseFunction.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePermissionsForBaseFunction.TabIndex = 33;
            this.btnRemovePermissionsForBaseFunction.Text = "清除权限";
            this.btnRemovePermissionsForBaseFunction.UseVisualStyleBackColor = true;
            this.btnRemovePermissionsForBaseFunction.Click += new System.EventHandler(this.btnRemovePermissionsForBaseFunction_Click);
            // 
            // btnSelectPermissionsForBaseFunction
            // 
            this.btnSelectPermissionsForBaseFunction.Location = new System.Drawing.Point(226, 154);
            this.btnSelectPermissionsForBaseFunction.Name = "btnSelectPermissionsForBaseFunction";
            this.btnSelectPermissionsForBaseFunction.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPermissionsForBaseFunction.TabIndex = 32;
            this.btnSelectPermissionsForBaseFunction.Text = "选择权限";
            this.btnSelectPermissionsForBaseFunction.UseVisualStyleBackColor = true;
            this.btnSelectPermissionsForBaseFunction.Click += new System.EventHandler(this.btnSelectPermissionsForBaseFunction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "用户列表";
            // 
            // btnInitializePassword
            // 
            this.btnInitializePassword.Location = new System.Drawing.Point(586, 65);
            this.btnInitializePassword.Name = "btnInitializePassword";
            this.btnInitializePassword.Size = new System.Drawing.Size(222, 23);
            this.btnInitializePassword.TabIndex = 36;
            this.btnInitializePassword.Text = "初始化用户密码";
            this.btnInitializePassword.UseVisualStyleBackColor = true;
            this.btnInitializePassword.Click += new System.EventHandler(this.btnInitializePassword_Click);
            // 
            // Frm_SystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.btnInitializePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRestorePermissionsForBaseFunction);
            this.Controls.Add(this.btnRemovePermissionsForBaseFunction);
            this.Controls.Add(this.btnSelectPermissionsForBaseFunction);
            this.Controls.Add(this.btnRestorePermissionsForPurchaseFunction);
            this.Controls.Add(this.btnRemovePermissionsForPurchaseFunction);
            this.Controls.Add(this.btnSelectPermissionsForPurchaseFunction);
            this.Controls.Add(this.btnRestorePermissionsForSaleFunction);
            this.Controls.Add(this.btnRemovePermissionsForSaleFunction);
            this.Controls.Add(this.btnSelectPermissionsForSaleFunction);
            this.Controls.Add(this.btnRestorePermissionsAll);
            this.Controls.Add(this.btnRemovePermissionsAll);
            this.Controls.Add(this.btnSelectPermissionsAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbUserFunction);
            this.Controls.Add(this.gbSaleFunction);
            this.Controls.Add(this.gbPurchaseFunction);
            this.Controls.Add(this.gbBaseFunction);
            this.Controls.Add(this.btnRestroePermissionsForUserFunction);
            this.Controls.Add(this.btnRemovePermissionsForUserFunction);
            this.Controls.Add(this.btnSelectPermissionsForUserFunction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbUserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_SystemUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户权限管理";
            this.gbBaseFunction.ResumeLayout(false);
            this.gbBaseFunction.PerformLayout();
            this.gbPurchaseFunction.ResumeLayout(false);
            this.gbPurchaseFunction.PerformLayout();
            this.gbSaleFunction.ResumeLayout(false);
            this.gbSaleFunction.PerformLayout();
            this.gbUserFunction.ResumeLayout(false);
            this.gbUserFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserList;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestroePermissionsForUserFunction;
        private System.Windows.Forms.Button btnRemovePermissionsForUserFunction;
        private System.Windows.Forms.Button btnSelectPermissionsForUserFunction;
        private System.Windows.Forms.GroupBox gbBaseFunction;
        private System.Windows.Forms.GroupBox gbPurchaseFunction;
        private System.Windows.Forms.GroupBox gbSaleFunction;
        private System.Windows.Forms.GroupBox gbUserFunction;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSelectPermissionsAll;
        private System.Windows.Forms.Button btnRemovePermissionsAll;
        private System.Windows.Forms.Button btnRestorePermissionsAll;
        private System.Windows.Forms.Button btnRestorePermissionsForSaleFunction;
        private System.Windows.Forms.Button btnRemovePermissionsForSaleFunction;
        private System.Windows.Forms.Button btnSelectPermissionsForSaleFunction;
        private System.Windows.Forms.Button btnRestorePermissionsForPurchaseFunction;
        private System.Windows.Forms.Button btnRemovePermissionsForPurchaseFunction;
        private System.Windows.Forms.Button btnSelectPermissionsForPurchaseFunction;
        private System.Windows.Forms.Button btnRestorePermissionsForBaseFunction;
        private System.Windows.Forms.Button btnRemovePermissionsForBaseFunction;
        private System.Windows.Forms.Button btnSelectPermissionsForBaseFunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSupplierInfoManagement;
        private System.Windows.Forms.CheckBox cbCategoryManagement;
        private System.Windows.Forms.CheckBox cbEmployeesInfoManagement;
        private System.Windows.Forms.CheckBox cbCustomerInfoManagement;
        private System.Windows.Forms.CheckBox cbProductInfoManagement;
        private System.Windows.Forms.CheckBox cbExamPurchaseBill;
        private System.Windows.Forms.CheckBox cbFillPurchaseBill;
        private System.Windows.Forms.CheckBox cbInStockCheck;
        private System.Windows.Forms.CheckBox cbSalesReturn;
        private System.Windows.Forms.CheckBox cbSalesManagement;
        private System.Windows.Forms.CheckBox cbUserManagement;
        private System.Windows.Forms.CheckBox cbChangeThePassword;
        private System.Windows.Forms.Button btnInitializePassword;
    }
}