namespace SmartQuiz
{
    partial class UserTest
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
            auth_label = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            end_test_button = new RoundButton();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(22, 166);
            auth_label.Margin = new Padding(6, 0, 6, 0);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(378, 45);
            auth_label.TabIndex = 1;
            auth_label.Text = "Заголовок вопроса";
            auth_label.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 225);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 38);
            label2.TabIndex = 2;
            label2.Text = "Описание вопроса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 19);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(574, 45);
            label3.TabIndex = 3;
            label3.Text = "Название теста (10 вопросов)";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 170, 214);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(30, 75);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(43, 49);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(84, 75);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(43, 49);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(137, 73);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(43, 49);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.graph1;
            pictureBox1.Location = new Point(626, 152);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 488);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(998, 47);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 45);
            label4.TabIndex = 10;
            label4.Text = "Итого: 0/30";
            label4.Click += label4_Click_1;
            // 
            // end_test_button
            // 
            end_test_button.BackColor = SystemColors.ControlText;
            end_test_button.Font = new Font("Arial", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            end_test_button.ForeColor = SystemColors.ControlLightLight;
            end_test_button.Location = new Point(919, 723);
            end_test_button.Margin = new Padding(6);
            end_test_button.Name = "end_test_button";
            end_test_button.Size = new Size(301, 79);
            end_test_button.TabIndex = 11;
            end_test_button.Text = "Завершить";
            end_test_button.UseVisualStyleBackColor = false;
            end_test_button.Click += end_test_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 602);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 12;
            label1.Text = "Введённый ответ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(30, 687);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(305, 38);
            label5.TabIndex = 13;
            label5.Text = "Правильный ответ:";
            // 
            // UserTest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 838);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(end_test_button);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(auth_label);
            Margin = new Padding(6);
            Name = "UserTest";
            Text = "Тест";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label auth_label;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label4;
        private RoundButton end_test_button;
        private Label label1;
        private Label label5;
    }
}