namespace E_Card
{
    partial class frmUserInfo
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
            this.components = new System.ComponentModel.Container();
            this.gbInfoEntry = new System.Windows.Forms.GroupBox();
            this.labelTime_1 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.cbUserGender_1 = new System.Windows.Forms.ComboBox();
            this.txtUserName_1 = new System.Windows.Forms.TextBox();
            this.labUserName_1 = new System.Windows.Forms.Label();
            this.labUserGender_1 = new System.Windows.Forms.Label();
            this.txtUserAge_1 = new System.Windows.Forms.TextBox();
            this.labUserAge_1 = new System.Windows.Forms.Label();
            this.txtInitial_1 = new System.Windows.Forms.TextBox();
            this.labInitial_1 = new System.Windows.Forms.Label();
            this.txtCardNumber_1 = new System.Windows.Forms.TextBox();
            this.labCardNumber_1 = new System.Windows.Forms.Label();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQueryData_1 = new System.Windows.Forms.Button();
            this.txtUserName_2 = new System.Windows.Forms.TextBox();
            this.labUserName_2 = new System.Windows.Forms.Label();
            this.MenuDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsDelecte = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.gbInfoEntry.SuspendLayout();
            this.gbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoEntry
            // 
            this.gbInfoEntry.Controls.Add(this.labelTime_1);
            this.gbInfoEntry.Controls.Add(this.labTime);
            this.gbInfoEntry.Controls.Add(this.btnAddInfo);
            this.gbInfoEntry.Controls.Add(this.cbUserGender_1);
            this.gbInfoEntry.Controls.Add(this.txtUserName_1);
            this.gbInfoEntry.Controls.Add(this.labUserName_1);
            this.gbInfoEntry.Controls.Add(this.labUserGender_1);
            this.gbInfoEntry.Controls.Add(this.txtUserAge_1);
            this.gbInfoEntry.Controls.Add(this.labUserAge_1);
            this.gbInfoEntry.Controls.Add(this.txtInitial_1);
            this.gbInfoEntry.Controls.Add(this.labInitial_1);
            this.gbInfoEntry.Controls.Add(this.txtCardNumber_1);
            this.gbInfoEntry.Controls.Add(this.labCardNumber_1);
            this.gbInfoEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfoEntry.Location = new System.Drawing.Point(0, 0);
            this.gbInfoEntry.Name = "gbInfoEntry";
            this.gbInfoEntry.Size = new System.Drawing.Size(800, 187);
            this.gbInfoEntry.TabIndex = 0;
            this.gbInfoEntry.TabStop = false;
            this.gbInfoEntry.Text = "基本信息录入";
            // 
            // labelTime_1
            // 
            this.labelTime_1.AutoSize = true;
            this.labelTime_1.Location = new System.Drawing.Point(553, 90);
            this.labelTime_1.Name = "labelTime_1";
            this.labelTime_1.Size = new System.Drawing.Size(0, 12);
            this.labelTime_1.TabIndex = 14;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.Color.Red;
            this.labTime.Location = new System.Drawing.Point(430, 151);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 17);
            this.labTime.TabIndex = 12;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(129, 144);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(153, 26);
            this.btnAddInfo.TabIndex = 11;
            this.btnAddInfo.Text = "添加用户基本信息";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // cbUserGender_1
            // 
            this.cbUserGender_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserGender_1.FormattingEnabled = true;
            this.cbUserGender_1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbUserGender_1.Location = new System.Drawing.Point(624, 38);
            this.cbUserGender_1.Name = "cbUserGender_1";
            this.cbUserGender_1.Size = new System.Drawing.Size(135, 20);
            this.cbUserGender_1.TabIndex = 10;
            // 
            // txtUserName_1
            // 
            this.txtUserName_1.Location = new System.Drawing.Point(359, 36);
            this.txtUserName_1.Name = "txtUserName_1";
            this.txtUserName_1.Size = new System.Drawing.Size(135, 21);
            this.txtUserName_1.TabIndex = 9;
            // 
            // labUserName_1
            // 
            this.labUserName_1.AutoSize = true;
            this.labUserName_1.Location = new System.Drawing.Point(288, 40);
            this.labUserName_1.Name = "labUserName_1";
            this.labUserName_1.Size = new System.Drawing.Size(65, 12);
            this.labUserName_1.TabIndex = 8;
            this.labUserName_1.Text = "用户姓名：";
            // 
            // labUserGender_1
            // 
            this.labUserGender_1.AutoSize = true;
            this.labUserGender_1.Location = new System.Drawing.Point(553, 41);
            this.labUserGender_1.Name = "labUserGender_1";
            this.labUserGender_1.Size = new System.Drawing.Size(65, 12);
            this.labUserGender_1.TabIndex = 6;
            this.labUserGender_1.Text = "用户性别：";
            // 
            // txtUserAge_1
            // 
            this.txtUserAge_1.Location = new System.Drawing.Point(104, 87);
            this.txtUserAge_1.Name = "txtUserAge_1";
            this.txtUserAge_1.Size = new System.Drawing.Size(135, 21);
            this.txtUserAge_1.TabIndex = 5;
            // 
            // labUserAge_1
            // 
            this.labUserAge_1.AutoSize = true;
            this.labUserAge_1.Location = new System.Drawing.Point(33, 91);
            this.labUserAge_1.Name = "labUserAge_1";
            this.labUserAge_1.Size = new System.Drawing.Size(65, 12);
            this.labUserAge_1.TabIndex = 4;
            this.labUserAge_1.Text = "用户年龄：";
            // 
            // txtInitial_1
            // 
            this.txtInitial_1.Location = new System.Drawing.Point(359, 83);
            this.txtInitial_1.Name = "txtInitial_1";
            this.txtInitial_1.ReadOnly = true;
            this.txtInitial_1.Size = new System.Drawing.Size(135, 21);
            this.txtInitial_1.TabIndex = 3;
            this.txtInitial_1.Text = "100";
            // 
            // labInitial_1
            // 
            this.labInitial_1.AutoSize = true;
            this.labInitial_1.Location = new System.Drawing.Point(288, 87);
            this.labInitial_1.Name = "labInitial_1";
            this.labInitial_1.Size = new System.Drawing.Size(65, 12);
            this.labInitial_1.TabIndex = 2;
            this.labInitial_1.Text = "初始金额：";
            // 
            // txtCardNumber_1
            // 
            this.txtCardNumber_1.Location = new System.Drawing.Point(104, 36);
            this.txtCardNumber_1.Name = "txtCardNumber_1";
            this.txtCardNumber_1.Size = new System.Drawing.Size(135, 21);
            this.txtCardNumber_1.TabIndex = 1;
            // 
            // labCardNumber_1
            // 
            this.labCardNumber_1.AutoSize = true;
            this.labCardNumber_1.Location = new System.Drawing.Point(33, 40);
            this.labCardNumber_1.Name = "labCardNumber_1";
            this.labCardNumber_1.Size = new System.Drawing.Size(65, 12);
            this.labCardNumber_1.TabIndex = 0;
            this.labCardNumber_1.Text = "用户卡号：";
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.dataGridView1);
            this.gbQuery.Controls.Add(this.btnQueryData_1);
            this.gbQuery.Controls.Add(this.txtUserName_2);
            this.gbQuery.Controls.Add(this.labUserName_2);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuery.Location = new System.Drawing.Point(0, 187);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(800, 263);
            this.gbQuery.TabIndex = 1;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询浏览区域";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCardNumber,
            this.dgUserName,
            this.dgUserGender,
            this.dgUserAge,
            this.dgInitial,
            this.dgAddTime});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 199);
            this.dataGridView1.TabIndex = 15;
            // 
            // dgCardNumber
            // 
            this.dgCardNumber.DataPropertyName = "CardNumber";
            this.dgCardNumber.HeaderText = "用户卡号";
            this.dgCardNumber.MinimumWidth = 6;
            this.dgCardNumber.Name = "dgCardNumber";
            // 
            // dgUserName
            // 
            this.dgUserName.DataPropertyName = "UserName";
            this.dgUserName.HeaderText = "用户姓名";
            this.dgUserName.MinimumWidth = 6;
            this.dgUserName.Name = "dgUserName";
            // 
            // dgUserGender
            // 
            this.dgUserGender.DataPropertyName = "UserGender";
            this.dgUserGender.HeaderText = "用户性别";
            this.dgUserGender.MinimumWidth = 6;
            this.dgUserGender.Name = "dgUserGender";
            // 
            // dgUserAge
            // 
            this.dgUserAge.DataPropertyName = "UserAge";
            this.dgUserAge.HeaderText = "用户年龄";
            this.dgUserAge.MinimumWidth = 6;
            this.dgUserAge.Name = "dgUserAge";
            // 
            // dgInitial
            // 
            this.dgInitial.DataPropertyName = "TopupMoney";
            this.dgInitial.HeaderText = "账户金额";
            this.dgInitial.MinimumWidth = 6;
            this.dgInitial.Name = "dgInitial";
            // 
            // dgAddTime
            // 
            this.dgAddTime.DataPropertyName = "TopupTime";
            this.dgAddTime.HeaderText = "添加时间";
            this.dgAddTime.MinimumWidth = 6;
            this.dgAddTime.Name = "dgAddTime";
            // 
            // btnQueryData_1
            // 
            this.btnQueryData_1.Location = new System.Drawing.Point(290, 29);
            this.btnQueryData_1.Name = "btnQueryData_1";
            this.btnQueryData_1.Size = new System.Drawing.Size(110, 26);
            this.btnQueryData_1.TabIndex = 14;
            this.btnQueryData_1.Text = "查询数据";
            this.btnQueryData_1.UseVisualStyleBackColor = true;
            this.btnQueryData_1.Click += new System.EventHandler(this.btnQueryData_1_Click);
            // 
            // txtUserName_2
            // 
            this.txtUserName_2.Location = new System.Drawing.Point(104, 33);
            this.txtUserName_2.Name = "txtUserName_2";
            this.txtUserName_2.Size = new System.Drawing.Size(135, 21);
            this.txtUserName_2.TabIndex = 13;
            // 
            // labUserName_2
            // 
            this.labUserName_2.AutoSize = true;
            this.labUserName_2.Location = new System.Drawing.Point(33, 36);
            this.labUserName_2.Name = "labUserName_2";
            this.labUserName_2.Size = new System.Drawing.Size(65, 12);
            this.labUserName_2.TabIndex = 12;
            this.labUserName_2.Text = "用户姓名：";
            // 
            // MenuDelete
            // 
            this.MenuDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDelecte});
            this.MenuDelete.Name = "删除";
            this.MenuDelete.Size = new System.Drawing.Size(101, 26);
            this.MenuDelete.Text = "conDelete";
            // 
            // tsDelecte
            // 
            this.tsDelecte.Name = "tsDelecte";
            this.tsDelecte.Size = new System.Drawing.Size(100, 22);
            this.tsDelecte.Text = "删除";
            this.tsDelecte.Click += new System.EventHandler(this.tsDelecte_Click);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.MenuDelete;
            this.Controls.Add(this.gbQuery);
            this.Controls.Add(this.gbInfoEntry);
            this.Name = "frmUserInfo";
            this.Text = "用户基本信息管理";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.gbInfoEntry.ResumeLayout(false);
            this.gbInfoEntry.PerformLayout();
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoEntry;
        private System.Windows.Forms.TextBox txtUserName_1;
        private System.Windows.Forms.Label labUserName_1;
        private System.Windows.Forms.Label labUserGender_1;
        private System.Windows.Forms.TextBox txtUserAge_1;
        private System.Windows.Forms.Label labUserAge_1;
        private System.Windows.Forms.TextBox txtInitial_1;
        private System.Windows.Forms.Label labInitial_1;
        private System.Windows.Forms.TextBox txtCardNumber_1;
        private System.Windows.Forms.Label labCardNumber_1;
        private System.Windows.Forms.ComboBox cbUserGender_1;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.Button btnQueryData_1;
        private System.Windows.Forms.TextBox txtUserName_2;
        private System.Windows.Forms.Label labUserName_2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip MenuDelete;
        private System.Windows.Forms.ToolStripMenuItem tsDelecte;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labelTime_1;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddTime;
    }
}