namespace SmartQuiz
{
    partial class QuestionEditor
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Заголовок";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 63);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Описание вопроса...";
            textBox2.Size = new Size(417, 153);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 289);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Правильный ответ";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 235);
            button1.Name = "button1";
            button1.Size = new Size(144, 30);
            button1.TabIndex = 3;
            button1.Text = "Добавить изображение";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(471, 327);
            button3.Name = "button3";
            button3.Size = new Size(186, 43);
            button3.TabIndex = 8;
            button3.Text = "Подтвердить";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(308, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Тип вопроса";
            // 
            // QuestionEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 382);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "QuestionEditor";
            Text = "Новый вопрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button3;
        private ComboBox comboBox1;
    }
}