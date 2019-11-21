namespace MoGuangYuan.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_ExamPurchaseBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ExamPurchaseBill));
            this.btnReviewTheSignature = new System.Windows.Forms.Button();
            this.btnCancelTheAuditSignature = new System.Windows.Forms.Button();
            this.btnExaminerUndo = new System.Windows.Forms.Button();
            this.btnExaminerRestore = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtClerk = new System.Windows.Forms.TextBox();
            this.txtExaminer = new System.Windows.Forms.TextBox();
            this.txtCustodian = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPurChaseID
            // 
            this.lbPurChaseID.Click += new System.EventHandler(this.lbPurChaseID_Click);
            // 
            // btnReviewTheSignature
            // 
            this.btnReviewTheSignature.Location = new System.Drawing.Point(28, 309);
            this.btnReviewTheSignature.Name = "btnReviewTheSignature";
            this.btnReviewTheSignature.Size = new System.Drawing.Size(105, 23);
            this.btnReviewTheSignature.TabIndex = 26;
            this.btnReviewTheSignature.Text = "审核签名";
            this.btnReviewTheSignature.UseVisualStyleBackColor = true;
            this.btnReviewTheSignature.Click += new System.EventHandler(this.btnReviewTheSignature_Click);
            // 
            // btnCancelTheAuditSignature
            // 
            this.btnCancelTheAuditSignature.Location = new System.Drawing.Point(148, 309);
            this.btnCancelTheAuditSignature.Name = "btnCancelTheAuditSignature";
            this.btnCancelTheAuditSignature.Size = new System.Drawing.Size(105, 23);
            this.btnCancelTheAuditSignature.TabIndex = 27;
            this.btnCancelTheAuditSignature.Text = "取消审核签名";
            this.btnCancelTheAuditSignature.UseVisualStyleBackColor = true;
            this.btnCancelTheAuditSignature.Click += new System.EventHandler(this.btnCancelTheAuditSignature_Click);
            // 
            // btnExaminerUndo
            // 
            this.btnExaminerUndo.Location = new System.Drawing.Point(653, 309);
            this.btnExaminerUndo.Name = "btnExaminerUndo";
            this.btnExaminerUndo.Size = new System.Drawing.Size(75, 23);
            this.btnExaminerUndo.TabIndex = 28;
            this.btnExaminerUndo.Text = "撤销";
            this.btnExaminerUndo.UseVisualStyleBackColor = true;
            this.btnExaminerUndo.Click += new System.EventHandler(this.btnExaminerUndo_Click);
            // 
            // btnExaminerRestore
            // 
            this.btnExaminerRestore.Location = new System.Drawing.Point(742, 309);
            this.btnExaminerRestore.Name = "btnExaminerRestore";
            this.btnExaminerRestore.Size = new System.Drawing.Size(75, 23);
            this.btnExaminerRestore.TabIndex = 29;
            this.btnExaminerRestore.Text = "恢复";
            this.btnExaminerRestore.UseVisualStyleBackColor = true;
            this.btnExaminerRestore.Click += new System.EventHandler(this.btnExaminerRestore_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 548);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "业务员";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 548);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "审核员";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(602, 548);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 32;
            this.label16.Text = "保管员";
            // 
            // txtClerk
            // 
            this.txtClerk.Location = new System.Drawing.Point(65, 543);
            this.txtClerk.Name = "txtClerk";
            this.txtClerk.ReadOnly = true;
            this.txtClerk.Size = new System.Drawing.Size(196, 21);
            this.txtClerk.TabIndex = 33;
            // 
            // txtExaminer
            // 
            this.txtExaminer.Location = new System.Drawing.Point(366, 544);
            this.txtExaminer.Name = "txtExaminer";
            this.txtExaminer.ReadOnly = true;
            this.txtExaminer.Size = new System.Drawing.Size(196, 21);
            this.txtExaminer.TabIndex = 34;
            // 
            // txtCustodian
            // 
            this.txtCustodian.Location = new System.Drawing.Point(651, 544);
            this.txtCustodian.Name = "txtCustodian";
            this.txtCustodian.ReadOnly = true;
            this.txtCustodian.Size = new System.Drawing.Size(196, 21);
            this.txtCustodian.TabIndex = 35;
            // 
            // Frm_ExamPurchaseBill
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
            this.Controls.Add(this.btnExaminerRestore);
            this.Controls.Add(this.btnExaminerUndo);
            this.Controls.Add(this.btnCancelTheAuditSignature);
            this.Controls.Add(this.btnReviewTheSignature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ExamPurchaseBill";
            this.Text = "审核进货单";
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.btnReviewTheSignature, 0);
            this.Controls.SetChildIndex(this.btnCancelTheAuditSignature, 0);
            this.Controls.SetChildIndex(this.btnExaminerUndo, 0);
            this.Controls.SetChildIndex(this.btnExaminerRestore, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.cbSupplier, 0);
            this.Controls.SetChildIndex(this.dtPurchaseDate, 0);
            this.Controls.SetChildIndex(this.txtStockDate, 0);
            this.Controls.SetChildIndex(this.txtOnProcess, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.lbPurChaseID, 0);
            this.Controls.SetChildIndex(this.txtClerk, 0);
            this.Controls.SetChildIndex(this.txtExaminer, 0);
            this.Controls.SetChildIndex(this.txtCustodian, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReviewTheSignature;
        private System.Windows.Forms.Button btnCancelTheAuditSignature;
        private System.Windows.Forms.Button btnExaminerUndo;
        private System.Windows.Forms.Button btnExaminerRestore;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClerk;
        private System.Windows.Forms.TextBox txtExaminer;
        private System.Windows.Forms.TextBox txtCustodian;
    }
}