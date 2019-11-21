namespace MoGuangYuan.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_InStockCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InStockCheck));
            this.btnInspectionBySignature = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtCustodian = new System.Windows.Forms.TextBox();
            this.txtExaminer = new System.Windows.Forms.TextBox();
            this.txtClerk = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPurChaseID
            // 
            this.lbPurChaseID.Click += new System.EventHandler(this.lbPurChaseID_Click);
            // 
            // btnInspectionBySignature
            // 
            this.btnInspectionBySignature.Location = new System.Drawing.Point(28, 309);
            this.btnInspectionBySignature.Name = "btnInspectionBySignature";
            this.btnInspectionBySignature.Size = new System.Drawing.Size(223, 23);
            this.btnInspectionBySignature.TabIndex = 26;
            this.btnInspectionBySignature.Text = "货物检验通过签名";
            this.btnInspectionBySignature.UseVisualStyleBackColor = true;
            this.btnInspectionBySignature.Click += new System.EventHandler(this.btnInspectionBySignature_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(742, 309);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 31;
            this.btnRestore.Text = "恢复";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(653, 309);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 30;
            this.btnUndo.Text = "撤销";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // txtCustodian
            // 
            this.txtCustodian.Location = new System.Drawing.Point(651, 542);
            this.txtCustodian.Name = "txtCustodian";
            this.txtCustodian.ReadOnly = true;
            this.txtCustodian.Size = new System.Drawing.Size(196, 21);
            this.txtCustodian.TabIndex = 41;
            // 
            // txtExaminer
            // 
            this.txtExaminer.Location = new System.Drawing.Point(366, 542);
            this.txtExaminer.Name = "txtExaminer";
            this.txtExaminer.ReadOnly = true;
            this.txtExaminer.Size = new System.Drawing.Size(196, 21);
            this.txtExaminer.TabIndex = 40;
            // 
            // txtClerk
            // 
            this.txtClerk.Location = new System.Drawing.Point(65, 541);
            this.txtClerk.Name = "txtClerk";
            this.txtClerk.ReadOnly = true;
            this.txtClerk.Size = new System.Drawing.Size(196, 21);
            this.txtClerk.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(602, 546);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 38;
            this.label16.Text = "保管员";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 546);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "审核员";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "业务员";
            // 
            // Frm_InStockCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.txtCustodian);
            this.Controls.Add(this.txtExaminer);
            this.Controls.Add(this.txtClerk);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnInspectionBySignature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_InStockCheck";
            this.Text = "货物入库检查";
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.cbSupplier, 0);
            this.Controls.SetChildIndex(this.dtPurchaseDate, 0);
            this.Controls.SetChildIndex(this.txtStockDate, 0);
            this.Controls.SetChildIndex(this.txtOnProcess, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.lbPurChaseID, 0);
            this.Controls.SetChildIndex(this.btnInspectionBySignature, 0);
            this.Controls.SetChildIndex(this.btnUndo, 0);
            this.Controls.SetChildIndex(this.btnRestore, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtClerk, 0);
            this.Controls.SetChildIndex(this.txtExaminer, 0);
            this.Controls.SetChildIndex(this.txtCustodian, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInspectionBySignature;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtCustodian;
        private System.Windows.Forms.TextBox txtExaminer;
        private System.Windows.Forms.TextBox txtClerk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}