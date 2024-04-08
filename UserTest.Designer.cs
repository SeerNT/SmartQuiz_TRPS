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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTest));
            auth_label = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            end_test_button = new RoundButton();
            pictureBox1 = new PictureBox();
            test_name_box = new TextBox();
            confirmRegisterBut = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(12, 78);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(197, 22);
            auth_label.TabIndex = 1;
            auth_label.Text = "Заголовок вопроса";
            auth_label.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 2;
            label2.Text = "Описание вопроса";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(294, 22);
            label3.TabIndex = 3;
            label3.Text = "Название теста (10 вопросов)";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 170, 214);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(16, 35);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(45, 35);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(74, 34);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(462, 18);
            label4.Name = "label4";
            label4.Size = new Size(195, 22);
            label4.TabIndex = 10;
            label4.Text = "Осталось: 00:35:48";
            label4.Click += label4_Click_1;
            // 
            // end_test_button
            // 
            end_test_button.BackColor = SystemColors.ControlText;
            end_test_button.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            end_test_button.ForeColor = SystemColors.ControlLightLight;
            end_test_button.Location = new Point(393, 332);
            end_test_button.Name = "end_test_button";
            end_test_button.Size = new Size(209, 52);
            end_test_button.TabIndex = 11;
            end_test_button.Text = "Завершить попытку";
            end_test_button.UseVisualStyleBackColor = false;
            end_test_button.Click += end_test_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(337, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 229);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // test_name_box
            // 
            test_name_box.BorderStyle = BorderStyle.FixedSingle;
            test_name_box.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            test_name_box.Location = new Point(16, 277);
            test_name_box.Name = "test_name_box";
            test_name_box.PlaceholderText = "Введите ответ";
            test_name_box.Size = new Size(274, 33);
            test_name_box.TabIndex = 14;
            // 
            // confirmRegisterBut
            // 
            confirmRegisterBut.BackColor = SystemColors.ControlText;
            confirmRegisterBut.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmRegisterBut.ForeColor = SystemColors.ControlLightLight;
            confirmRegisterBut.Location = new Point(16, 339);
            confirmRegisterBut.Name = "confirmRegisterBut";
            confirmRegisterBut.Size = new Size(274, 37);
            confirmRegisterBut.TabIndex = 15;
            confirmRegisterBut.Text = "Следующий вопрос";
            confirmRegisterBut.UseVisualStyleBackColor = false;
            // 
            // UserTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 393);
            Controls.Add(confirmRegisterBut);
            Controls.Add(test_name_box);
            Controls.Add(end_test_button);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(auth_label);
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
        private Label label4;
        private RoundButton end_test_button;
        private PictureBox pictureBox1;
        private TextBox test_name_box;
        private RoundButton confirmRegisterBut;
    }
}