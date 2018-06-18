namespace LittleFilsh.Tools
{
    partial class Form1
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
            this.btnKey = new System.Windows.Forms.Button();
            this.txtkeySourse = new System.Windows.Forms.TextBox();
            this.txtkeyValue = new System.Windows.Forms.TextBox();
            this.txtPwdValue = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(353, 27);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(207, 23);
            this.btnKey.TabIndex = 0;
            this.btnKey.Text = "生成密钥";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // txtkeySourse
            // 
            this.txtkeySourse.Location = new System.Drawing.Point(62, 29);
            this.txtkeySourse.Name = "txtkeySourse";
            this.txtkeySourse.Size = new System.Drawing.Size(273, 21);
            this.txtkeySourse.TabIndex = 1;
            // 
            // txtkeyValue
            // 
            this.txtkeyValue.Location = new System.Drawing.Point(577, 27);
            this.txtkeyValue.Name = "txtkeyValue";
            this.txtkeyValue.Size = new System.Drawing.Size(273, 21);
            this.txtkeyValue.TabIndex = 2;
            // 
            // txtPwdValue
            // 
            this.txtPwdValue.Location = new System.Drawing.Point(577, 68);
            this.txtPwdValue.Name = "txtPwdValue";
            this.txtPwdValue.Size = new System.Drawing.Size(273, 21);
            this.txtPwdValue.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(62, 70);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(273, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "生成密码";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 572);
            this.Controls.Add(this.txtPwdValue);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkeyValue);
            this.Controls.Add(this.txtkeySourse);
            this.Controls.Add(this.btnKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.TextBox txtkeySourse;
        private System.Windows.Forms.TextBox txtkeyValue;
        private System.Windows.Forms.TextBox txtPwdValue;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button button1;
    }
}

