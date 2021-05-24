namespace E_Card
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.labExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labUserRecharge = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labUserConsumption = new System.Windows.Forms.Label();
            this.pbUserInfo = new System.Windows.Forms.PictureBox();
            this.labUserInfo = new System.Windows.Forms.Label();
            this.pbUserConsumption = new System.Windows.Forms.PictureBox();
            this.pbUserRecharge = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserRecharge)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1292, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripExit
            // 
            this.toolStripExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(34, 28);
            this.toolStripExit.Text = "toolStripExit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.Location = new System.Drawing.Point(55, 9);
            this.labExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(80, 18);
            this.labExit.TabIndex = 1;
            this.labExit.Text = "退出系统";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1292, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labUserRecharge);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.labUserConsumption);
            this.groupBox1.Controls.Add(this.pbUserInfo);
            this.groupBox1.Controls.Add(this.labUserInfo);
            this.groupBox1.Controls.Add(this.pbUserConsumption);
            this.groupBox1.Controls.Add(this.pbUserRecharge);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(414, 637);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能菜单项";
            // 
            // labUserRecharge
            // 
            this.labUserRecharge.AutoSize = true;
            this.labUserRecharge.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserRecharge.Location = new System.Drawing.Point(108, 585);
            this.labUserRecharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserRecharge.Name = "labUserRecharge";
            this.labUserRecharge.Size = new System.Drawing.Size(199, 21);
            this.labUserRecharge.TabIndex = 9;
            this.labUserRecharge.Text = "充值及消费记录查询";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labUserConsumption
            // 
            this.labUserConsumption.AutoSize = true;
            this.labUserConsumption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserConsumption.Location = new System.Drawing.Point(108, 384);
            this.labUserConsumption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserConsumption.Name = "labUserConsumption";
            this.labUserConsumption.Size = new System.Drawing.Size(178, 21);
            this.labUserConsumption.TabIndex = 8;
            this.labUserConsumption.Text = "模拟地铁刷卡消费";
            // 
            // pbUserInfo
            // 
            this.pbUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbUserInfo.Image")));
            this.pbUserInfo.Location = new System.Drawing.Point(165, 106);
            this.pbUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pbUserInfo.Name = "pbUserInfo";
            this.pbUserInfo.Size = new System.Drawing.Size(62, 70);
            this.pbUserInfo.TabIndex = 4;
            this.pbUserInfo.TabStop = false;
            this.pbUserInfo.Click += new System.EventHandler(this.pbUserInfo_Click);
            // 
            // labUserInfo
            // 
            this.labUserInfo.AutoSize = true;
            this.labUserInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserInfo.Location = new System.Drawing.Point(108, 195);
            this.labUserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserInfo.Name = "labUserInfo";
            this.labUserInfo.Size = new System.Drawing.Size(178, 21);
            this.labUserInfo.TabIndex = 7;
            this.labUserInfo.Text = "用户基本信息管理";
            // 
            // pbUserConsumption
            // 
            this.pbUserConsumption.Image = ((System.Drawing.Image)(resources.GetObject("pbUserConsumption.Image")));
            this.pbUserConsumption.Location = new System.Drawing.Point(165, 296);
            this.pbUserConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.pbUserConsumption.Name = "pbUserConsumption";
            this.pbUserConsumption.Size = new System.Drawing.Size(62, 70);
            this.pbUserConsumption.TabIndex = 5;
            this.pbUserConsumption.TabStop = false;
            this.pbUserConsumption.Click += new System.EventHandler(this.pbUserConsumption_Click);
            // 
            // pbUserRecharge
            // 
            this.pbUserRecharge.Image = ((System.Drawing.Image)(resources.GetObject("pbUserRecharge.Image")));
            this.pbUserRecharge.Location = new System.Drawing.Point(165, 495);
            this.pbUserRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.pbUserRecharge.Name = "pbUserRecharge";
            this.pbUserRecharge.Size = new System.Drawing.Size(62, 70);
            this.pbUserRecharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserRecharge.TabIndex = 6;
            this.pbUserRecharge.TabStop = false;
            this.pbUserRecharge.Click += new System.EventHandler(this.pbUserRecharge_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 832);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "一卡通";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserRecharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labUserRecharge;
        private System.Windows.Forms.Label labUserConsumption;
        private System.Windows.Forms.PictureBox pbUserInfo;
        private System.Windows.Forms.Label labUserInfo;
        private System.Windows.Forms.PictureBox pbUserConsumption;
        private System.Windows.Forms.PictureBox pbUserRecharge;
    }
}

