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
            accept_question_button = new RoundButton();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 51);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Заголовок";
            textBox1.Size = new Size(439, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 134);
            textBox2.Margin = new Padding(6, 6, 6, 6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Описание вопроса...";
            textBox2.Size = new Size(771, 322);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 617);
            textBox3.Margin = new Padding(6, 6, 6, 6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Правильный ответ";
            textBox3.Size = new Size(301, 39);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(22, 501);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(267, 64);
            button1.TabIndex = 3;
            button1.Text = "Добавить изображение";
            button1.UseVisualStyleBackColor = true;
            // 
            // accept_question_button
            // 
            accept_question_button.BackColor = SystemColors.ActiveCaptionText;
            accept_question_button.Font = new Font("Arial", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            accept_question_button.ForeColor = SystemColors.Control;
            accept_question_button.Location = new Point(875, 698);
            accept_question_button.Margin = new Padding(6, 6, 6, 6);
            accept_question_button.Name = "accept_question_button";
            accept_question_button.Size = new Size(345, 92);
            accept_question_button.TabIndex = 8;
            accept_question_button.Text = "Подтвердить";
            accept_question_button.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(572, 51);
            comboBox1.Margin = new Padding(6, 6, 6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 40);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Тип вопроса";
            // 
            // QuestionEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 815);
            Controls.Add(comboBox1);
            Controls.Add(accept_question_button);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(6, 6, 6, 6);
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
        private RoundButton accept_question_button;
        private ComboBox comboBox1;
    }
}