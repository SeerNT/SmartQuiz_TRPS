namespace SmartQuiz
{
    partial class TestTypeChoice
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
            chooseTextTestBut = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // chooseTextTestBut
            // 
            chooseTextTestBut.Font = new Font("Arial", 14.25F);
            chooseTextTestBut.Location = new Point(12, 290);
            chooseTextTestBut.Name = "chooseTextTestBut";
            chooseTextTestBut.Size = new Size(174, 43);
            chooseTextTestBut.TabIndex = 0;
            chooseTextTestBut.Text = "Текстовый";
            chooseTextTestBut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F);
            button1.Location = new Point(12, 145);
            button1.Name = "button1";
            button1.Size = new Size(174, 65);
            button1.TabIndex = 1;
            button1.Text = "Множественный выбор";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 14.25F);
            button2.Location = new Point(12, 228);
            button2.Name = "button2";
            button2.Size = new Size(174, 43);
            button2.TabIndex = 2;
            button2.Text = "Соответствия";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название теста...";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(7, 103);
            label2.Name = "label2";
            label2.Size = new Size(267, 22);
            label2.TabIndex = 5;
            label2.Text = "Выбор необходимого типа";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(471, 327);
            button3.Name = "button3";
            button3.Size = new Size(186, 43);
            button3.TabIndex = 6;
            button3.Text = "Подтвердить";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 61);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Лимит времени...";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // TestTypeChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 382);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chooseTextTestBut);
            Name = "TestTypeChoice";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Создание нового теста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseTextTestBut;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Button button3;
        private TextBox textBox2;
    }
}