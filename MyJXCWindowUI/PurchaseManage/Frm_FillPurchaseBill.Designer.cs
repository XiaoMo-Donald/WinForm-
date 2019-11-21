namespace MoGuangYuan.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_FillPurchaseBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FillPurchaseBill));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSeave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTheNewDetailInformation = new System.Windows.Forms.Button();
            this.btnDeleteTheDetailInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.ValueChanged += new System.EventHandler(this.dtPurchaseDate_ValueChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(112, 309);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(65, 23);
            this.btnModify.TabIndex = 27;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(199, 309);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(58, 23);
            this.btnUndo.TabIndex = 28;
            this.btnUndo.Text = "撤消";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSeave
            // 
            this.btnSeave.Enabled = false;
            this.btnSeave.Location = new System.Drawing.Point(653, 309);
            this.btnSeave.Name = "btnSeave";
            this.btnSeave.Size = new System.Drawing.Size(75, 23);
            this.btnSeave.TabIndex = 29;
            this.btnSeave.Text = "存盘";
            this.btnSeave.UseVisualStyleBackColor = true;
            this.btnSeave.Click += new System.EventHandler(this.btnSeave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(742, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTheNewDetailInformation
            // 
            this.btnTheNewDetailInformation.Enabled = false;
            this.btnTheNewDetailInformation.Location = new System.Drawing.Point(19, 540);
            this.btnTheNewDetailInformation.Name = "btnTheNewDetailInformation";
            this.btnTheNewDetailInformation.Size = new System.Drawing.Size(421, 23);
            this.btnTheNewDetailInformation.TabIndex = 31;
            this.btnTheNewDetailInformation.Text = "增加明细信息";
            this.btnTheNewDetailInformation.UseVisualStyleBackColor = true;
            this.btnTheNewDetailInformation.Click += new System.EventHandler(this.btnTheNewDetailInformation_Click);
            // 
            // btnDeleteTheDetailInformation
            // 
            this.btnDeleteTheDetailInformation.Enabled = false;
            this.btnDeleteTheDetailInformation.Location = new System.Drawing.Point(446, 540);
            this.btnDeleteTheDetailInformation.Name = "btnDeleteTheDetailInformation";
            this.btnDeleteTheDetailInformation.Size = new System.Drawing.Size(401, 23);
            this.btnDeleteTheDetailInformation.TabIndex = 32;
            this.btnDeleteTheDetailInformation.Text = "删除明细信息";
            this.btnDeleteTheDetailInformation.UseVisualStyleBackColor = true;
            this.btnDeleteTheDetailInformation.Click += new System.EventHandler(this.btnDeleteTheDetailInformation_Click);
            // 
            // Frm_FillPurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.btnDeleteTheDetailInformation);
            this.Controls.Add(this.btnTheNewDetailInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSeave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FillPurchaseBill";
            this.Text = "填写进货单";
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.cbSupplier, 0);
            this.Controls.SetChildIndex(this.dtPurchaseDate, 0);
            this.Controls.SetChildIndex(this.txtStockDate, 0);
            this.Controls.SetChildIndex(this.txtOnProcess, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.lbPurChaseID, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnUndo, 0);
            this.Controls.SetChildIndex(this.btnSeave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnTheNewDetailInformation, 0);
            this.Controls.SetChildIndex(this.btnDeleteTheDetailInformation, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSeave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTheNewDetailInformation;
        private System.Windows.Forms.Button btnDeleteTheDetailInformation;
    }
}