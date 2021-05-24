namespace E_Card
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labAccount_1 = new System.Windows.Forms.Label();
            this.txtAccount_1 = new System.Windows.Forms.TextBox();
            this.txtPwd_1 = new System.Windows.Forms.TextBox();
            this.labPwd_1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAccount_1
            // 
            this.labAccount_1.AutoSize = true;
            this.labAccount_1.BackColor = System.Drawing.Color.Transparent;
            this.labAccount_1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAccount_1.Location = new System.Drawing.Point(135, 92);
            this.labAccount_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccount_1.Name = "labAccount_1";
            this.labAccount_1.Size = new System.Drawing.Size(73, 21);
            this.labAccount_1.TabIndex = 0;
            this.labAccount_1.Text = "账号：";
            // 
            // txtAccount_1
            // 
            this.txtAccount_1.Location = new System.Drawing.Point(228, 90);
            this.txtAccount_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccount_1.Name = "txtAccount_1";
            this.txtAccount_1.Size = new System.Drawing.Size(256, 28);
            this.txtAccount_1.TabIndex = 1;
            // 
            // txtPwd_1
            // 
            this.txtPwd_1.Location = new System.Drawing.Point(228, 171);
            this.txtPwd_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd_1.Name = "txtPwd_1";
            this.txtPwd_1.PasswordChar = '*';
            this.txtPwd_1.Size = new System.Drawing.Size(256, 28);
            this.txtPwd_1.TabIndex = 2;
            // 
            // labPwd_1
            // 
            this.labPwd_1.AutoSize = true;
            this.labPwd_1.BackColor = System.Drawing.Color.Transparent;
            this.labPwd_1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPwd_1.Location = new System.Drawing.Point(135, 172);
            this.labPwd_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPwd_1.Name = "labPwd_1";
            this.labPwd_1.Size = new System.Drawing.Size(73, 21);
            this.labPwd_1.TabIndex = 2;
            this.labPwd_1.Text = "密码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(94, 261);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录(&Enter)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 261);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 60);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labRegister
            // 
            this.labRegister.AutoSize = true;
            this.labRegister.BackColor = System.Drawing.Color.Transparent;
            this.labRegister.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRegister.ForeColor = System.Drawing.Color.Blue;
            this.labRegister.Location = new System.Drawing.Point(20, 354);
            this.labRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRegister.Name = "labRegister";
            this.labRegister.Size = new System.Drawing.Size(98, 18);
            this.labRegister.TabIndex = 5;
            this.labRegister.Text = "注册账号？";
            this.labRegister.Click += new System.EventHandler(this.labRegister_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 393);
            this.Controls.Add(this.labRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd_1);
            this.Controls.Add(this.labPwd_1);
            this.Controls.Add(this.txtAccount_1);
            this.Controls.Add(this.labAccount_1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAccount_1;
        private System.Windows.Forms.TextBox txtAccount_1;
        private System.Windows.Forms.TextBox txtPwd_1;
        private System.Windows.Forms.Label labPwd_1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labRegister;
    }
}