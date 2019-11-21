namespace MoGuangYuan.MyJXCWindowUI
{
    partial class Frm_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Category));
            this.dgCategroy = new System.Windows.Forms.DataGridView();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategroy)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtCategoryName);
            this.gbInfo.Controls.Add(this.txtCategoryID);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnCancel, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCategoryID, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCategoryName, 0);
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
            // dgCategroy
            // 
            this.dgCategroy.AllowUserToAddRows = false;
            this.dgCategroy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategroy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategroy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryID,
            this.categoryName});
            this.dgCategroy.Location = new System.Drawing.Point(13, 12);
            this.dgCategroy.MultiSelect = false;
            this.dgCategroy.Name = "dgCategroy";
            this.dgCategroy.ReadOnly = true;
            this.dgCategroy.RowTemplate.Height = 23;
            this.dgCategroy.Size = new System.Drawing.Size(841, 223);
            this.dgCategroy.TabIndex = 7;
            this.dgCategroy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategroy_CellClick);
            // 
            // categoryID
            // 
            this.categoryID.DataPropertyName = "CategoryID";
            this.categoryID.HeaderText = "产品类别编号";
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "CategoryName";
            this.categoryName.HeaderText = "产品类别名称";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(354, 143);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(215, 21);
            this.txtCategoryName.TabIndex = 21;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(354, 100);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(215, 21);
            this.txtCategoryID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "产品类别名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "产品类别编号：";
            // 
            // Frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.dgCategroy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Category";
            this.Text = "产品分类管理";
            this.Load += new System.EventHandler(this.Frm_Category_Load);
            this.Controls.SetChildIndex(this.btnSearchCancel, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.lblSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.dgCategroy, 0);
            this.Controls.SetChildIndex(this.btnNewAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategroy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategroy;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
    }
}