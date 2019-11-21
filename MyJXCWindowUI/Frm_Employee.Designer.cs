namespace MoGuangYuan.MyJXCWindowUI
{
    partial class Frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.cbEmployeeSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeBrief = new System.Windows.Forms.TextBox();
            this.dgEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brief = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmployeeBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtEmployeeBirthday);
            this.gbInfo.Controls.Add(this.txtEmployeeBrief);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.cbEmployeeSex);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtEmployeeID);
            this.gbInfo.Controls.Add(this.txtEmployeeName);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeName, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeID, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnCancel, 0);
            this.gbInfo.Controls.SetChildIndex(this.label3, 0);
            this.gbInfo.Controls.SetChildIndex(this.cbEmployeeSex, 0);
            this.gbInfo.Controls.SetChildIndex(this.label4, 0);
            this.gbInfo.Controls.SetChildIndex(this.label5, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeBrief, 0);
            this.gbInfo.Controls.SetChildIndex(this.dtEmployeeBirthday, 0);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 62;
            this.label3.Text = "性    别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "员工姓名：";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(125, 101);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(131, 21);
            this.txtEmployeeName.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "员工编号：";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(125, 53);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(131, 21);
            this.txtEmployeeID.TabIndex = 57;
            // 
            // cbEmployeeSex
            // 
            this.cbEmployeeSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeSex.FormattingEnabled = true;
            this.cbEmployeeSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbEmployeeSex.Location = new System.Drawing.Point(125, 149);
            this.cbEmployeeSex.Name = "cbEmployeeSex";
            this.cbEmployeeSex.Size = new System.Drawing.Size(131, 20);
            this.cbEmployeeSex.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "简  历：";
            // 
            // txtEmployeeBrief
            // 
            this.txtEmployeeBrief.Location = new System.Drawing.Point(402, 53);
            this.txtEmployeeBrief.MaxLength = 4000;
            this.txtEmployeeBrief.Multiline = true;
            this.txtEmployeeBrief.Name = "txtEmployeeBrief";
            this.txtEmployeeBrief.Size = new System.Drawing.Size(410, 164);
            this.txtEmployeeBrief.TabIndex = 67;
            // 
            // dgEmployeeInfo
            // 
            this.dgEmployeeInfo.AllowUserToAddRows = false;
            this.dgEmployeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.employeeName,
            this.sex,
            this.birthday,
            this.brief});
            this.dgEmployeeInfo.Location = new System.Drawing.Point(13, 12);
            this.dgEmployeeInfo.Name = "dgEmployeeInfo";
            this.dgEmployeeInfo.ReadOnly = true;
            this.dgEmployeeInfo.RowTemplate.Height = 23;
            this.dgEmployeeInfo.Size = new System.Drawing.Size(841, 223);
            this.dgEmployeeInfo.TabIndex = 13;
            this.dgEmployeeInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeInfo_CellClick);
            this.dgEmployeeInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEmployeeInfo_CellFormatting);
            // 
            // employeeID
            // 
            this.employeeID.DataPropertyName = "EmployeeID";
            this.employeeID.HeaderText = "员工编号";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "EmployeeName";
            this.employeeName.HeaderText = "员工姓名";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "Birthday";
            this.birthday.HeaderText = "出生日期";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // brief
            // 
            this.brief.DataPropertyName = "Brief";
            this.brief.HeaderText = "简历";
            this.brief.Name = "brief";
            this.brief.ReadOnly = true;
            // 
            // dtEmployeeBirthday
            // 
            this.dtEmployeeBirthday.CustomFormat = "";
            this.dtEmployeeBirthday.Location = new System.Drawing.Point(124, 194);
            this.dtEmployeeBirthday.Name = "dtEmployeeBirthday";
            this.dtEmployeeBirthday.Size = new System.Drawing.Size(132, 21);
            this.dtEmployeeBirthday.TabIndex = 68;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 571);
            this.Controls.Add(this.dgEmployeeInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Employee";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.lblSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearchCancel, 0);
            this.Controls.SetChildIndex(this.btnNewAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.dgEmployeeInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmployeeSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeBrief;
        private System.Windows.Forms.DataGridView dgEmployeeInfo;
        private System.Windows.Forms.DateTimePicker dtEmployeeBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn brief;
    }
}