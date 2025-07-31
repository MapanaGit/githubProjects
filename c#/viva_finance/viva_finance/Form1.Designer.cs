namespace viva_finance
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblTitles = new System.Windows.Forms.Label();
            this.groupBoxLoginForm = new System.Windows.Forms.GroupBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserNm = new System.Windows.Forms.TextBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(78, 148);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VIVA Financial Solutions";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnLogin);
            this.groupBoxLogin.Controls.Add(this.txtPassword);
            this.groupBoxLogin.Controls.Add(this.lblPassword);
            this.groupBoxLogin.Controls.Add(this.lblUserName);
            this.groupBoxLogin.Controls.Add(this.txtUserName);
            this.groupBoxLogin.Location = new System.Drawing.Point(81, 179);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(379, 149);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Admin Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(212, 98);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(46, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(46, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(116, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(171, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblTitles
            // 
            this.lblTitles.AutoSize = true;
            this.lblTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitles.Location = new System.Drawing.Point(78, 148);
            this.lblTitles.Name = "lblTitles";
            this.lblTitles.Size = new System.Drawing.Size(150, 13);
            this.lblTitles.TabIndex = 0;
            this.lblTitles.Text = "XXXX Financial Solutions";
            // 
            // groupBoxLoginForm
            // 
            this.groupBoxLoginForm.Controls.Add(this.loginBtn);
            this.groupBoxLoginForm.Controls.Add(this.txtPass);
            this.groupBoxLoginForm.Controls.Add(this.label2);
            this.groupBoxLoginForm.Controls.Add(this.label3);
            this.groupBoxLoginForm.Controls.Add(this.txtUserNm);
            this.groupBoxLoginForm.Location = new System.Drawing.Point(81, 179);
            this.groupBoxLoginForm.Name = "groupBoxLoginForm";
            this.groupBoxLoginForm.Size = new System.Drawing.Size(379, 149);
            this.groupBoxLoginForm.TabIndex = 1;
            this.groupBoxLoginForm.TabStop = false;
            this.groupBoxLoginForm.Text = "Admin Login";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(212, 98);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(116, 72);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(171, 20);
            this.txtPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // txtUserNm
            // 
            this.txtUserNm.Location = new System.Drawing.Point(116, 40);
            this.txtUserNm.Name = "txtUserNm";
            this.txtUserNm.Size = new System.Drawing.Size(171, 20);
            this.txtUserNm.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 500);
            this.Controls.Add(this.groupBoxLoginForm);
            this.Controls.Add(this.lblTitles);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Login";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxLoginForm.ResumeLayout(false);
            this.groupBoxLoginForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitles;
        private System.Windows.Forms.GroupBox groupBoxLoginForm;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserNm;
    }
}

