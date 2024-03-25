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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button4 = new Button();
            label4 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(197, 22);
            label1.TabIndex = 1;
            label1.Text = "Заголовок вопроса";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(172, 22);
            label2.TabIndex = 2;
            label2.Text = "Описание вопроса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(294, 22);
            label3.TabIndex = 3;
            label3.Text = "Название теста (10 вопросов)";
            // 
            // button1
            // 
            button1.Location = new Point(16, 35);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(45, 35);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(74, 34);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(379, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 226);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 310);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите ответ";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(12, 353);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 9;
            button4.Text = "Следующий вопрос";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(462, 9);
            label4.Name = "label4";
            label4.Size = new Size(195, 22);
            label4.TabIndex = 10;
            label4.Text = "Осталось: 00:32:48";
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(495, 339);
            button5.Name = "button5";
            button5.Size = new Size(162, 37);
            button5.TabIndex = 11;
            button5.Text = "Завершить";
            button5.UseVisualStyleBackColor = true;
            // 
            // UserTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 393);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserTest";
            Text = "Тест";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button4;
        private Label label4;
        private Button button5;
    }
}