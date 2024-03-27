using System.Drawing.Drawing2D;

namespace SmartQuiz
{
    public class RoundButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
                           Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Здесь параметры округлости кнопки
            int borderRadius = 15;
            float borderThickness = 1.75f;
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.Silver, borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }

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
            auth_label = new Label();
            loginBut = new RoundButton();
            registerBut = new RoundButton();
            SuspendLayout();
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(279, 222);
            login.Margin = new Padding(6, 0, 6, 0);
            login.Name = "login";
            login.Size = new Size(183, 56);
            login.TabIndex = 0;
            login.Text = "Логин:";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(279, 326);
            password.Margin = new Padding(6, 0, 6, 0);
            password.Name = "password";
            password.Size = new Size(221, 56);
            password.TabIndex = 1;
            password.Text = "Пароль:";
            // 
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(529, 222);
            loginBox.Margin = new Padding(6, 6, 6, 6);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(407, 47);
            loginBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(529, 326);
            passwordBox.Margin = new Padding(6, 6, 6, 6);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(407, 47);
            passwordBox.TabIndex = 3;
            // 
            // auth_label
            // 
            auth_label.Anchor = AnchorStyles.None;
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(357, 73);
            auth_label.Margin = new Padding(6, 6, 6, 6);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(510, 81);
            auth_label.TabIndex = 6;
            auth_label.Text = "Авторизация:";
            auth_label.Click += auth_label_Click;
            // 
            // loginBut
            // 
            loginBut.BackColor = Color.Black;
            loginBut.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            loginBut.ForeColor = Color.White;
            loginBut.Location = new Point(329, 431);
            loginBut.Margin = new Padding(6, 6, 6, 6);
            loginBut.Name = "loginBut";
            loginBut.Size = new Size(139, 68);
            loginBut.TabIndex = 4;
            loginBut.Text = "Вход";
            loginBut.UseVisualStyleBackColor = false;
            loginBut.Click += loginBut_Click;
            // 
            // registerBut
            // 
            registerBut.BackColor = Color.Black;
            registerBut.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            registerBut.ForeColor = Color.White;
            registerBut.Location = new Point(589, 431);
            registerBut.Margin = new Padding(6, 6, 6, 6);
            registerBut.Name = "registerBut";
            registerBut.Size = new Size(295, 68);
            registerBut.TabIndex = 5;
            registerBut.Text = "Регистрация";
            registerBut.UseVisualStyleBackColor = false;
            registerBut.Click += registerBut_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1242, 781);
            Controls.Add(auth_label);
            Controls.Add(registerBut);
            Controls.Add(loginBut);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(password);
            Controls.Add(login);
            Margin = new Padding(6, 6, 6, 6);
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
        private Label auth_label;
        private RoundButton loginBut;
        private RoundButton registerBut;

        public TextBox currLogin()
        {
            return loginBox;
        }

        public TextBox currPassword()
        {
            return passwordBox;
        }
    }

    
}
