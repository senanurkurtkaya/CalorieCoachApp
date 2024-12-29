namespace CalorieCoach.UI
{
    partial class LoginForm
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
            btnRegister = new Button();
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Silver;
            btnRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegister.Location = new Point(34, 205);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 26);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLogin.Location = new Point(158, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 26);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 25);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 25);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Image = Properties.Resources.EmailAddressViewer;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 4;
            label1.Text = "        E-mail :        ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Image = Properties.Resources.PasswordBox;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 5;
            label2.Text = " Password :        ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(392, 316);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}