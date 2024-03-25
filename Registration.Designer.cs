namespace SmartQuiz
{
    partial class Registration
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
            confirmRegisterBut = new Button();
            passwordBox = new TextBox();
            loginBox = new TextBox();
            password = new Label();
            login = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // confirmRegisterBut
            // 
            confirmRegisterBut.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            confirmRegisterBut.Location = new Point(246, 277);
            confirmRegisterBut.Name = "confirmRegisterBut";
            confirmRegisterBut.Size = new Size(159, 32);
            confirmRegisterBut.TabIndex = 11;
            confirmRegisterBut.Text = "Регистрация";
            confirmRegisterBut.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordBox.Location = new Point(285, 153);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(221, 27);
            passwordBox.TabIndex = 9;
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox.Location = new Point(285, 104);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(221, 27);
            loginBox.TabIndex = 8;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password.Location = new Point(150, 153);
            password.Name = "password";
            password.Size = new Size(102, 27);
            password.TabIndex = 7;
            password.Text = "Пароль:";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login.Location = new Point(150, 104);
            login.Name = "login";
            login.Size = new Size(83, 27);
            login.TabIndex = 6;
            login.Text = "Логин:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(285, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(89, 202);
            label1.Name = "label1";
            label1.Size = new Size(163, 54);
            label1.TabIndex = 12;
            label1.Text = "Подтвердите \r\nпароль:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 382);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(confirmRegisterBut);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(password);
            Controls.Add(login);
            Name = "Registration";
            Text = "Регистрация";
            FormClosed += Registration_FormClosed;
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmRegisterBut;
        private TextBox passwordBox;
        private TextBox loginBox;
        private Label password;
        private Label login;
        private TextBox textBox1;
        private Label label1;
    }
}