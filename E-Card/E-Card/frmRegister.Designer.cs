namespace E_Card
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.btnrReturn_1 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPwd_2 = new System.Windows.Forms.TextBox();
            this.labPwd_2 = new System.Windows.Forms.Label();
            this.txtAccount_2 = new System.Windows.Forms.TextBox();
            this.labAccount_2 = new System.Windows.Forms.Label();
            this.txtPwd_3 = new System.Windows.Forms.TextBox();
            this.labPwd_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnrReturn_1
            // 
            this.btnrReturn_1.Location = new System.Drawing.Point(348, 309);
            this.btnrReturn_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrReturn_1.Name = "btnrReturn_1";
            this.btnrReturn_1.Size = new System.Drawing.Size(153, 60);
            this.btnrReturn_1.TabIndex = 10;
            this.btnrReturn_1.Text = "返回(&R)";
            this.btnrReturn_1.UseVisualStyleBackColor = true;
            this.btnrReturn_1.Click += new System.EventHandler(this.btnrReturn_1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(66, 309);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 60);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "注册(&A)";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPwd_2
            // 
            this.txtPwd_2.Location = new System.Drawing.Point(219, 148);
            this.txtPwd_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd_2.Name = "txtPwd_2";
            this.txtPwd_2.PasswordChar = '*';
            this.txtPwd_2.Size = new System.Drawing.Size(256, 28);
            this.txtPwd_2.TabIndex = 7;
            // 
            // labPwd_2
            // 
            this.labPwd_2.AutoSize = true;
            this.labPwd_2.BackColor = System.Drawing.Color.Transparent;
            this.labPwd_2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPwd_2.Location = new System.Drawing.Point(94, 150);
            this.labPwd_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPwd_2.Name = "labPwd_2";
            this.labPwd_2.Size = new System.Drawing.Size(73, 21);
            this.labPwd_2.TabIndex = 8;
            this.labPwd_2.Text = "密码：";
            // 
            // txtAccount_2
            // 
            this.txtAccount_2.Location = new System.Drawing.Point(219, 70);
            this.txtAccount_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccount_2.Name = "txtAccount_2";
            this.txtAccount_2.Size = new System.Drawing.Size(256, 28);
            this.txtAccount_2.TabIndex = 6;
            // 
            // labAccount_2
            // 
            this.labAccount_2.AutoSize = true;
            this.labAccount_2.BackColor = System.Drawing.Color.Transparent;
            this.labAccount_2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAccount_2.Location = new System.Drawing.Point(94, 72);
            this.labAccount_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccount_2.Name = "labAccount_2";
            this.labAccount_2.Size = new System.Drawing.Size(73, 21);
            this.labAccount_2.TabIndex = 5;
            this.labAccount_2.Text = "账号：";
            // 
            // txtPwd_3
            // 
            this.txtPwd_3.Location = new System.Drawing.Point(219, 225);
            this.txtPwd_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd_3.Name = "txtPwd_3";
            this.txtPwd_3.PasswordChar = '*';
            this.txtPwd_3.Size = new System.Drawing.Size(260, 28);
            this.txtPwd_3.TabIndex = 12;
            // 
            // labPwd_3
            // 
            this.labPwd_3.AutoSize = true;
            this.labPwd_3.BackColor = System.Drawing.Color.Transparent;
            this.labPwd_3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPwd_3.Location = new System.Drawing.Point(94, 226);
            this.labPwd_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPwd_3.Name = "labPwd_3";
            this.labPwd_3.Size = new System.Drawing.Size(115, 21);
            this.labPwd_3.TabIndex = 11;
            this.labPwd_3.Text = "确认密码：";
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.txtPwd_3);
            this.Controls.Add(this.labPwd_3);
            this.Controls.Add(this.btnrReturn_1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwd_2);
            this.Controls.Add(this.labPwd_2);
            this.Controls.Add(this.txtAccount_2);
            this.Controls.Add(this.labAccount_2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegister";
            this.Text = "注册界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrReturn_1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPwd_2;
        private System.Windows.Forms.Label labPwd_2;
        private System.Windows.Forms.TextBox txtAccount_2;
        private System.Windows.Forms.Label labAccount_2;
        private System.Windows.Forms.TextBox txtPwd_3;
        private System.Windows.Forms.Label labPwd_3;
    }
}