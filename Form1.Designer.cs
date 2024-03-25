namespace SmartQuiz
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Label();
            password = new Label();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            loginBut = new Button();
            registerBut = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login.Location = new Point(150, 104);
            login.Name = "login";
            login.Size = new Size(83, 27);
            login.TabIndex = 0;
            login.Text = "Логин:";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password.Location = new Point(150, 153);
            password.Name = "password";
            password.Size = new Size(102, 27);
            password.TabIndex = 1;
            password.Text = "Пароль:";
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox.Location = new Point(285, 104);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(221, 27);
            loginBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordBox.Location = new Point(285, 153);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(221, 27);
            passwordBox.TabIndex = 3;
            // 
            // loginBut
            // 
            loginBut.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBut.Location = new Point(177, 202);
            loginBut.Name = "loginBut";
            loginBut.Size = new Size(75, 32);
            loginBut.TabIndex = 4;
            loginBut.Text = "Вход";
            loginBut.UseVisualStyleBackColor = true;
            // 
            // registerBut
            // 
            registerBut.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registerBut.Location = new Point(317, 202);
            registerBut.Name = "registerBut";
            registerBut.Size = new Size(159, 32);
            registerBut.TabIndex = 5;
            registerBut.Text = "Регистрация";
            registerBut.UseVisualStyleBackColor = true;
            registerBut.Click += registerBut_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 382);
            Controls.Add(registerBut);
            Controls.Add(loginBut);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(password);
            Controls.Add(login);
            Name = "Authorization";
            Text = "Авторизация";
            FormClosed += Authorization_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login;
        private Label password;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button loginBut;
        private Button registerBut;
    }
}
