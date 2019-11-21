namespace MoGuangYuan.MyJXCWindowUI.BaseForm
{
    partial class BasePurChaseBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePurChaseBillForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtBeginTime = new System.Windows.Forms.DateTimePicker();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.txtStockDate = new System.Windows.Forms.TextBox();
            this.txtOnProcess = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgPurchaseDetaillInfo = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lbPurChaseID = new System.Windows.Forms.ListBox();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseDetaillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "进货单列表";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.label5);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.label4);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.dtEndTime);
            this.gbSearch.Controls.Add(this.dtBeginTime);
            this.gbSearch.Controls.Add(this.cbSearch);
            this.gbSearch.Location = new System.Drawing.Point(301, 44);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(546, 115);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "查询";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(352, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 21);
            this.txtSearch.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "查询值";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(441, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "结束日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "开始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "查询条件";
            // 
            // dtEndTime
            // 
            this.dtEndTime.Location = new System.Drawing.Point(293, 76);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(115, 21);
            this.dtEndTime.TabIndex = 2;
            // 
            // dtBeginTime
            // 
            this.dtBeginTime.Location = new System.Drawing.Point(90, 76);
            this.dtBeginTime.Name = "dtBeginTime";
            this.dtBeginTime.Size = new System.Drawing.Size(115, 21);
            this.dtBeginTime.TabIndex = 1;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "按单据编号查询",
            "按业务员查询",
            "按审核员查询",
            "按完成状态查询",
            "按订单日期查询"});
            this.cbSearch.Location = new System.Drawing.Point(90, 30);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(164, 20);
            this.cbSearch.TabIndex = 0;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.Enabled = false;
            this.dtPurchaseDate.Location = new System.Drawing.Point(391, 173);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(164, 21);
            this.dtPurchaseDate.TabIndex = 10;
            // 
            // cbSupplier
            // 
            this.cbSupplier.Enabled = false;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(391, 207);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(164, 20);
            this.cbSupplier.TabIndex = 9;
            // 
            // txtStockDate
            // 
            this.txtStockDate.Enabled = false;
            this.txtStockDate.Location = new System.Drawing.Point(391, 242);
            this.txtStockDate.Name = "txtStockDate";
            this.txtStockDate.Size = new System.Drawing.Size(164, 21);
            this.txtStockDate.TabIndex = 11;
            // 
            // txtOnProcess
            // 
            this.txtOnProcess.Enabled = false;
            this.txtOnProcess.Location = new System.Drawing.Point(391, 277);
            this.txtOnProcess.Name = "txtOnProcess";
            this.txtOnProcess.Size = new System.Drawing.Size(164, 21);
            this.txtOnProcess.TabIndex = 12;
            // 
            // txtMemo
            // 
            this.txtMemo.Enabled = false;
            this.txtMemo.Location = new System.Drawing.Point(594, 225);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(253, 73);
            this.txtMemo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "供应商";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "订单日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "入库日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "完成状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "备 注";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "订单编号";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Enabled = false;
            this.txtPurchaseID.Location = new System.Drawing.Point(653, 173);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(164, 21);
            this.txtPurchaseID.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(24, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "进货单列表";
            // 
            // dgPurchaseDetaillInfo
            // 
            this.dgPurchaseDetaillInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPurchaseDetaillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseDetaillInfo.Location = new System.Drawing.Point(19, 370);
            this.dgPurchaseDetaillInfo.Name = "dgPurchaseDetaillInfo";
            this.dgPurchaseDetaillInfo.RowTemplate.Height = 23;
            this.dgPurchaseDetaillInfo.Size = new System.Drawing.Size(828, 164);
            this.dgPurchaseDetaillInfo.TabIndex = 22;
            this.dgPurchaseDetaillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseDetaillInfo_CellClick);
            this.dgPurchaseDetaillInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgPurchaseDetaillInfo_CellFormatting);
            this.dgPurchaseDetaillInfo.CurrentCellChanged += new System.EventHandler(this.dgPurchaseDetaillInfo_CurrentCellChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(590, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "总价(元)";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(687, 341);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 21);
            this.txtTotalPrice.TabIndex = 24;
            // 
            // lbPurChaseID
            // 
            this.lbPurChaseID.FormattingEnabled = true;
            this.lbPurChaseID.ItemHeight = 12;
            this.lbPurChaseID.Location = new System.Drawing.Point(19, 44);
            this.lbPurChaseID.Name = "lbPurChaseID";
            this.lbPurChaseID.Size = new System.Drawing.Size(242, 256);
            this.lbPurChaseID.TabIndex = 25;
            this.lbPurChaseID.Click += new System.EventHandler(this.lbPurChaseID_Click);
            // 
            // BasePurChaseBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.lbPurChaseID);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgPurchaseDetaillInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtOnProcess);
            this.Controls.Add(this.txtStockDate);
            this.Controls.Add(this.dtPurchaseDate);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasePurChaseBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasePurChaseBillForm";
            this.Load += new System.EventHandler(this.BasePurChaseBillForm_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseDetaillInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtBeginTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalPrice;
        protected System.Windows.Forms.DateTimePicker dtPurchaseDate;
        protected System.Windows.Forms.ComboBox cbSearch;
        protected System.Windows.Forms.TextBox txtSearch;
        protected System.Windows.Forms.ComboBox cbSupplier;
        protected System.Windows.Forms.TextBox txtStockDate;
        protected System.Windows.Forms.TextBox txtOnProcess;
        protected System.Windows.Forms.TextBox txtMemo;
        protected System.Windows.Forms.DataGridView dgPurchaseDetaillInfo;
        protected System.Windows.Forms.ListBox lbPurChaseID;
        protected System.Windows.Forms.TextBox txtPurchaseID;
    }
}