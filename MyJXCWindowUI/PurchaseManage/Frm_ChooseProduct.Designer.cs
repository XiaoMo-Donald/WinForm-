namespace MoGuangYuan.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_ChooseProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChooseProduct));
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBySpellingCode = new System.Windows.Forms.TextBox();
            this.dgChooseProductInfo = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgChooseProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(622, 28);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入拼音码：";
            // 
            // txtSearchBySpellingCode
            // 
            this.txtSearchBySpellingCode.Location = new System.Drawing.Point(115, 28);
            this.txtSearchBySpellingCode.Name = "txtSearchBySpellingCode";
            this.txtSearchBySpellingCode.Size = new System.Drawing.Size(146, 21);
            this.txtSearchBySpellingCode.TabIndex = 2;
            this.txtSearchBySpellingCode.TextChanged += new System.EventHandler(this.txtSearchBySpellingCode_TextChanged);
            // 
            // dgChooseProductInfo
            // 
            this.dgChooseProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChooseProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.spellingCode,
            this.barcode,
            this.special,
            this.unit,
            this.origin,
            this.categoryID});
            this.dgChooseProductInfo.Location = new System.Drawing.Point(19, 68);
            this.dgChooseProductInfo.Name = "dgChooseProductInfo";
            this.dgChooseProductInfo.RowTemplate.Height = 23;
            this.dgChooseProductInfo.Size = new System.Drawing.Size(830, 482);
            this.dgChooseProductInfo.TabIndex = 3;
            this.dgChooseProductInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChooseProductInfo_CellClick);
            this.dgChooseProductInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChooseProductInfo_CellDoubleClick);
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
            this.categoryID.HeaderText = "产品类别";
            this.categoryID.Name = "categoryID";
            // 
            // Frm_ChooseProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 575);
            this.Controls.Add(this.dgChooseProductInfo);
            this.Controls.Add(this.txtSearchBySpellingCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ChooseProduct";
            this.Text = "产品选择";
            this.Load += new System.EventHandler(this.Frm_ChooseProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChooseProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBySpellingCode;
        private System.Windows.Forms.DataGridView dgChooseProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellingCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn special;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
    }
}