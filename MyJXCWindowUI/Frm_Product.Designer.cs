namespace MoGuangYuan.MyJXCWindowUI
{
    partial class Frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Product));
            this.dgProductInfo = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpellingCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbCategory);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.txtQuantity);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.txtSalePrice);
            this.gbInfo.Controls.Add(this.label12);
            this.gbInfo.Controls.Add(this.txtPurchasePrice);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.txtOrigin);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtUnit);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.txtSpecial);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txtBarcode);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtSpellingCode);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtProductName);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtProductID);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnCancel, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtProductID, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtProductName, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpellingCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.label3, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtBarcode, 0);
            this.gbInfo.Controls.SetChildIndex(this.label4, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpecial, 0);
            this.gbInfo.Controls.SetChildIndex(this.label8, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtUnit, 0);
            this.gbInfo.Controls.SetChildIndex(this.label7, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtOrigin, 0);
            this.gbInfo.Controls.SetChildIndex(this.label6, 0);
            this.gbInfo.Controls.SetChildIndex(this.label5, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtPurchasePrice, 0);
            this.gbInfo.Controls.SetChildIndex(this.label12, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSalePrice, 0);
            this.gbInfo.Controls.SetChildIndex(this.label11, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtQuantity, 0);
            this.gbInfo.Controls.SetChildIndex(this.label10, 0);
            this.gbInfo.Controls.SetChildIndex(this.cbCategory, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // dgProductInfo
            // 
            this.dgProductInfo.AllowUserToAddRows = false;
            this.dgProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.spellingCode,
            this.barcode,
            this.special,
            this.unit,
            this.origin,
            this.categoryID,
            this.purchasePrice,
            this.salePrice,
            this.quantity});
            this.dgProductInfo.Location = new System.Drawing.Point(13, 12);
            this.dgProductInfo.Name = "dgProductInfo";
            this.dgProductInfo.RowTemplate.Height = 23;
            this.dgProductInfo.Size = new System.Drawing.Size(841, 223);
            this.dgProductInfo.TabIndex = 12;
            this.dgProductInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellClick);
            this.dgProductInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProductInfo_CellFormatting);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "ProductID";
            this.productID.HeaderText = "产品编号";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.DataPropertyName = "ProductName";
            this.productName.HeaderText = "产品名称";
            this.productName.Name = "productName";
            // 
            // spellingCode
            // 
            this.spellingCode.DataPropertyName = "SpellingCode";
            this.spellingCode.HeaderText = "拼音码";
            this.spellingCode.Name = "spellingCode";
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "Barcode";
            this.barcode.HeaderText = "条形码";
            this.barcode.Name = "barcode";
            // 
            // special
            // 
            this.special.DataPropertyName = "Special";
            this.special.HeaderText = "规格";
            this.special.Name = "special";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "Unit";
            this.unit.HeaderText = "计量单位";
            this.unit.Name = "unit";
            // 
            // origin
            // 
            this.origin.DataPropertyName = "Origin";
            this.origin.HeaderText = "产地";
            this.origin.Name = "origin";
            // 
            // categoryID
            // 
            this.categoryID.DataPropertyName = "CategoryID";
            this.categoryID.HeaderText = "产地类别";
            this.categoryID.Name = "categoryID";
            // 
            // purchasePrice
            // 
            this.purchasePrice.DataPropertyName = "PurchasePrice";
            this.purchasePrice.HeaderText = "购入价格";
            this.purchasePrice.Name = "purchasePrice";
            // 
            // salePrice
            // 
            this.salePrice.DataPropertyName = "SalePrice";
            this.salePrice.HeaderText = "销售价格";
            this.salePrice.Name = "salePrice";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "数量";
            this.quantity.Name = "quantity";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(371, 197);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(131, 20);
            this.cbCategory.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 49;
            this.label10.Text = "数  量：";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(636, 148);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(131, 21);
            this.txtQuantity.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 47;
            this.label11.Text = "销售价格：";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(636, 100);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(131, 21);
            this.txtSalePrice.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(567, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "购入价格：";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(636, 52);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(131, 21);
            this.txtPurchasePrice.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "产地类别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "产  地：";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(371, 149);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(131, 21);
            this.txtOrigin.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "计量单位：";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(371, 101);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(131, 21);
            this.txtUnit.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "规  格：";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(371, 53);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(131, 21);
            this.txtSpecial.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "条 形 码：";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(125, 197);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(131, 21);
            this.txtBarcode.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "拼 音 码：";
            // 
            // txtSpellingCode
            // 
            this.txtSpellingCode.Location = new System.Drawing.Point(125, 149);
            this.txtSpellingCode.Name = "txtSpellingCode";
            this.txtSpellingCode.Size = new System.Drawing.Size(131, 21);
            this.txtSpellingCode.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "产品名称：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(125, 101);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(131, 21);
            this.txtProductName.TabIndex = 31;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "产品编号：";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(125, 53);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(131, 21);
            this.txtProductID.TabIndex = 29;
            // 
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.dgProductInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Product";
            this.Text = "产品信息管理";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.lblSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearchCancel, 0);
            this.Controls.SetChildIndex(this.btnNewAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.dgProductInfo, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductInfo;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpellingCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellingCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn special;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}