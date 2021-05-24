namespace E_Card
{
    partial class frmUserRecharge
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
            this.gbTopup = new System.Windows.Forms.GroupBox();
            this.labelTime_3 = new System.Windows.Forms.Label();
            this.txtTopup = new System.Windows.Forms.TextBox();
            this.labTopupMoney = new System.Windows.Forms.Label();
            this.btnQueryData_4 = new System.Windows.Forms.Button();
            this.btnTopupMoney = new System.Windows.Forms.Button();
            this.cbGender_4 = new System.Windows.Forms.ComboBox();
            this.txtUserName_4 = new System.Windows.Forms.TextBox();
            this.labUserName_4 = new System.Windows.Forms.Label();
            this.labUserGender_4 = new System.Windows.Forms.Label();
            this.txtUserAge_4 = new System.Windows.Forms.TextBox();
            this.labUserAge_4 = new System.Windows.Forms.Label();
            this.txtCardNumber_4 = new System.Windows.Forms.TextBox();
            this.labCardNumber_4 = new System.Windows.Forms.Label();
            this.gbConsumption = new System.Windows.Forms.GroupBox();
            this.labmoney = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labBalance = new System.Windows.Forms.Label();
            this.btnQueryData_5 = new System.Windows.Forms.Button();
            this.txtCardNumber_5 = new System.Windows.Forms.TextBox();
            this.labCardNumber_5 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.dgCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUsedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTopup.SuspendLayout();
            this.gbConsumption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTopup
            // 
            this.gbTopup.Controls.Add(this.labelTime_3);
            this.gbTopup.Controls.Add(this.txtTopup);
            this.gbTopup.Controls.Add(this.labTopupMoney);
            this.gbTopup.Controls.Add(this.btnQueryData_4);
            this.gbTopup.Controls.Add(this.btnTopupMoney);
            this.gbTopup.Controls.Add(this.cbGender_4);
            this.gbTopup.Controls.Add(this.txtUserName_4);
            this.gbTopup.Controls.Add(this.labUserName_4);
            this.gbTopup.Controls.Add(this.labUserGender_4);
            this.gbTopup.Controls.Add(this.txtUserAge_4);
            this.gbTopup.Controls.Add(this.labUserAge_4);
            this.gbTopup.Controls.Add(this.txtCardNumber_4);
            this.gbTopup.Controls.Add(this.labCardNumber_4);
            this.gbTopup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTopup.Location = new System.Drawing.Point(0, 0);
            this.gbTopup.Margin = new System.Windows.Forms.Padding(4);
            this.gbTopup.Name = "gbTopup";
            this.gbTopup.Padding = new System.Windows.Forms.Padding(4);
            this.gbTopup.Size = new System.Drawing.Size(1200, 285);
            this.gbTopup.TabIndex = 0;
            this.gbTopup.TabStop = false;
            this.gbTopup.Text = "充值区域";
            this.gbTopup.Enter += new System.EventHandler(this.gbTopup_Enter);
            // 
            // labelTime_3
            // 
            this.labelTime_3.AutoSize = true;
            this.labelTime_3.Location = new System.Drawing.Point(927, 171);
            this.labelTime_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime_3.Name = "labelTime_3";
            this.labelTime_3.Size = new System.Drawing.Size(0, 18);
            this.labelTime_3.TabIndex = 24;
            // 
            // txtTopup
            // 
            this.txtTopup.Location = new System.Drawing.Point(560, 158);
            this.txtTopup.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopup.Name = "txtTopup";
            this.txtTopup.Size = new System.Drawing.Size(200, 28);
            this.txtTopup.TabIndex = 23;
            // 
            // labTopupMoney
            // 
            this.labTopupMoney.AutoSize = true;
            this.labTopupMoney.Location = new System.Drawing.Point(453, 164);
            this.labTopupMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTopupMoney.Name = "labTopupMoney";
            this.labTopupMoney.Size = new System.Drawing.Size(98, 18);
            this.labTopupMoney.TabIndex = 22;
            this.labTopupMoney.Text = "充值金额：";
            // 
            // btnQueryData_4
            // 
            this.btnQueryData_4.Location = new System.Drawing.Point(388, 39);
            this.btnQueryData_4.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryData_4.Name = "btnQueryData_4";
            this.btnQueryData_4.Size = new System.Drawing.Size(165, 39);
            this.btnQueryData_4.TabIndex = 21;
            this.btnQueryData_4.Text = "查询数据";
            this.btnQueryData_4.UseVisualStyleBackColor = true;
            this.btnQueryData_4.Click += new System.EventHandler(this.btnQueryData_4_Click);
            // 
            // btnTopupMoney
            // 
            this.btnTopupMoney.Location = new System.Drawing.Point(162, 224);
            this.btnTopupMoney.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopupMoney.Name = "btnTopupMoney";
            this.btnTopupMoney.Size = new System.Drawing.Size(230, 39);
            this.btnTopupMoney.TabIndex = 20;
            this.btnTopupMoney.Text = "一卡通充值";
            this.btnTopupMoney.UseVisualStyleBackColor = true;
            this.btnTopupMoney.Click += new System.EventHandler(this.btnTopupMoney_Click);
            // 
            // cbGender_4
            // 
            this.cbGender_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender_4.FormattingEnabled = true;
            this.cbGender_4.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbGender_4.Location = new System.Drawing.Point(560, 110);
            this.cbGender_4.Margin = new System.Windows.Forms.Padding(4);
            this.cbGender_4.Name = "cbGender_4";
            this.cbGender_4.Size = new System.Drawing.Size(200, 26);
            this.cbGender_4.TabIndex = 19;
            // 
            // txtUserName_4
            // 
            this.txtUserName_4.Location = new System.Drawing.Point(162, 106);
            this.txtUserName_4.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName_4.Name = "txtUserName_4";
            this.txtUserName_4.ReadOnly = true;
            this.txtUserName_4.Size = new System.Drawing.Size(200, 28);
            this.txtUserName_4.TabIndex = 18;
            // 
            // labUserName_4
            // 
            this.labUserName_4.AutoSize = true;
            this.labUserName_4.Location = new System.Drawing.Point(56, 112);
            this.labUserName_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserName_4.Name = "labUserName_4";
            this.labUserName_4.Size = new System.Drawing.Size(98, 18);
            this.labUserName_4.TabIndex = 17;
            this.labUserName_4.Text = "用户姓名：";
            // 
            // labUserGender_4
            // 
            this.labUserGender_4.AutoSize = true;
            this.labUserGender_4.Location = new System.Drawing.Point(453, 114);
            this.labUserGender_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserGender_4.Name = "labUserGender_4";
            this.labUserGender_4.Size = new System.Drawing.Size(98, 18);
            this.labUserGender_4.TabIndex = 16;
            this.labUserGender_4.Text = "用户性别：";
            // 
            // txtUserAge_4
            // 
            this.txtUserAge_4.Location = new System.Drawing.Point(162, 165);
            this.txtUserAge_4.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserAge_4.Name = "txtUserAge_4";
            this.txtUserAge_4.ReadOnly = true;
            this.txtUserAge_4.Size = new System.Drawing.Size(200, 28);
            this.txtUserAge_4.TabIndex = 15;
            // 
            // labUserAge_4
            // 
            this.labUserAge_4.AutoSize = true;
            this.labUserAge_4.Location = new System.Drawing.Point(56, 171);
            this.labUserAge_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserAge_4.Name = "labUserAge_4";
            this.labUserAge_4.Size = new System.Drawing.Size(98, 18);
            this.labUserAge_4.TabIndex = 14;
            this.labUserAge_4.Text = "用户年龄：";
            // 
            // txtCardNumber_4
            // 
            this.txtCardNumber_4.Location = new System.Drawing.Point(162, 44);
            this.txtCardNumber_4.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber_4.Name = "txtCardNumber_4";
            this.txtCardNumber_4.Size = new System.Drawing.Size(200, 28);
            this.txtCardNumber_4.TabIndex = 13;
            // 
            // labCardNumber_4
            // 
            this.labCardNumber_4.AutoSize = true;
            this.labCardNumber_4.Location = new System.Drawing.Point(56, 50);
            this.labCardNumber_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCardNumber_4.Name = "labCardNumber_4";
            this.labCardNumber_4.Size = new System.Drawing.Size(98, 18);
            this.labCardNumber_4.TabIndex = 12;
            this.labCardNumber_4.Text = "用户卡号：";
            // 
            // gbConsumption
            // 
            this.gbConsumption.Controls.Add(this.labmoney);
            this.gbConsumption.Controls.Add(this.dataGridView2);
            this.gbConsumption.Controls.Add(this.labBalance);
            this.gbConsumption.Controls.Add(this.btnQueryData_5);
            this.gbConsumption.Controls.Add(this.txtCardNumber_5);
            this.gbConsumption.Controls.Add(this.labCardNumber_5);
            this.gbConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConsumption.Location = new System.Drawing.Point(0, 285);
            this.gbConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.gbConsumption.Name = "gbConsumption";
            this.gbConsumption.Padding = new System.Windows.Forms.Padding(4);
            this.gbConsumption.Size = new System.Drawing.Size(1200, 390);
            this.gbConsumption.TabIndex = 1;
            this.gbConsumption.TabStop = false;
            this.gbConsumption.Text = "消费信息查询";
            // 
            // labmoney
            // 
            this.labmoney.AutoSize = true;
            this.labmoney.Location = new System.Drawing.Point(790, 52);
            this.labmoney.Name = "labmoney";
            this.labmoney.Size = new System.Drawing.Size(17, 18);
            this.labmoney.TabIndex = 28;
            this.labmoney.Text = "0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCardNumber,
            this.dgUserName,
            this.Cost,
            this.dgInto,
            this.dgOut,
            this.dgUsedTime});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(4, 90);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1192, 296);
            this.dataGridView2.TabIndex = 27;
            // 
            // labBalance
            // 
            this.labBalance.AutoSize = true;
            this.labBalance.Location = new System.Drawing.Point(680, 52);
            this.labBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(98, 18);
            this.labBalance.TabIndex = 26;
            this.labBalance.Text = "账户余额：";
            // 
            // btnQueryData_5
            // 
            this.btnQueryData_5.Location = new System.Drawing.Point(388, 42);
            this.btnQueryData_5.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryData_5.Name = "btnQueryData_5";
            this.btnQueryData_5.Size = new System.Drawing.Size(165, 39);
            this.btnQueryData_5.TabIndex = 24;
            this.btnQueryData_5.Text = "查询数据";
            this.btnQueryData_5.UseVisualStyleBackColor = true;
            this.btnQueryData_5.Click += new System.EventHandler(this.btnQueryData_5_Click);
            // 
            // txtCardNumber_5
            // 
            this.txtCardNumber_5.Location = new System.Drawing.Point(162, 48);
            this.txtCardNumber_5.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber_5.Name = "txtCardNumber_5";
            this.txtCardNumber_5.Size = new System.Drawing.Size(200, 28);
            this.txtCardNumber_5.TabIndex = 25;
            // 
            // labCardNumber_5
            // 
            this.labCardNumber_5.AutoSize = true;
            this.labCardNumber_5.Location = new System.Drawing.Point(56, 52);
            this.labCardNumber_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCardNumber_5.Name = "labCardNumber_5";
            this.labCardNumber_5.Size = new System.Drawing.Size(98, 18);
            this.labCardNumber_5.TabIndex = 24;
            this.labCardNumber_5.Text = "用户卡号：";
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // dgCardNumber
            // 
            this.dgCardNumber.DataPropertyName = "CardNumber";
            this.dgCardNumber.HeaderText = "用户卡号";
            this.dgCardNumber.MinimumWidth = 8;
            this.dgCardNumber.Name = "dgCardNumber";
            this.dgCardNumber.Width = 150;
            // 
            // dgUserName
            // 
            this.dgUserName.DataPropertyName = "UserName";
            this.dgUserName.HeaderText = "用户姓名";
            this.dgUserName.MinimumWidth = 8;
            this.dgUserName.Name = "dgUserName";
            this.dgUserName.Width = 150;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "操作金额";
            this.Cost.MinimumWidth = 8;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // dgInto
            // 
            this.dgInto.DataPropertyName = "Entrance";
            this.dgInto.HeaderText = "进站口";
            this.dgInto.MinimumWidth = 8;
            this.dgInto.Name = "dgInto";
            this.dgInto.Width = 150;
            // 
            // dgOut
            // 
            this.dgOut.DataPropertyName = "Exitof";
            this.dgOut.HeaderText = "出站口";
            this.dgOut.MinimumWidth = 8;
            this.dgOut.Name = "dgOut";
            this.dgOut.Width = 150;
            // 
            // dgUsedTime
            // 
            this.dgUsedTime.DataPropertyName = "Time";
            this.dgUsedTime.HeaderText = "添加时间";
            this.dgUsedTime.MinimumWidth = 8;
            this.dgUsedTime.Name = "dgUsedTime";
            this.dgUsedTime.Width = 150;
            // 
            // frmUserRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.gbConsumption);
            this.Controls.Add(this.gbTopup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserRecharge";
            this.Text = "充值及消费记录查询";
            this.gbTopup.ResumeLayout(false);
            this.gbTopup.PerformLayout();
            this.gbConsumption.ResumeLayout(false);
            this.gbConsumption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTopup;
        private System.Windows.Forms.Button btnTopupMoney;
        private System.Windows.Forms.ComboBox cbGender_4;
        private System.Windows.Forms.TextBox txtUserName_4;
        private System.Windows.Forms.Label labUserName_4;
        private System.Windows.Forms.Label labUserGender_4;
        private System.Windows.Forms.TextBox txtUserAge_4;
        private System.Windows.Forms.Label labUserAge_4;
        private System.Windows.Forms.TextBox txtCardNumber_4;
        private System.Windows.Forms.Label labCardNumber_4;
        private System.Windows.Forms.Button btnQueryData_4;
        private System.Windows.Forms.TextBox txtTopup;
        private System.Windows.Forms.Label labTopupMoney;
        private System.Windows.Forms.GroupBox gbConsumption;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labBalance;
        private System.Windows.Forms.Button btnQueryData_5;
        private System.Windows.Forms.TextBox txtCardNumber_5;
        private System.Windows.Forms.Label labCardNumber_5;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Label labelTime_3;
        private System.Windows.Forms.Label labmoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUsedTime;
    }
}