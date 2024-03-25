namespace SmartQuiz
{
    partial class Questions
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
            button3 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            vScrollBar1 = new VScrollBar();
            vScrollBar2 = new VScrollBar();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            vScrollBar3 = new VScrollBar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 22);
            label1.TabIndex = 0;
            label1.Text = "Создание и редактирование вопросов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(8, 158);
            label2.Name = "label2";
            label2.Size = new Size(271, 22);
            label2.TabIndex = 1;
            label2.Text = "Выбор вопросов для теста";
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(471, 327);
            button3.Name = "button3";
            button3.Size = new Size(186, 43);
            button3.TabIndex = 7;
            button3.Text = "Подтвердить";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 49);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Добавить вопрос...";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(223, 48);
            button1.Name = "button1";
            button1.Size = new Size(97, 24);
            button1.TabIndex = 9;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(372, 48);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 111);
            vScrollBar1.TabIndex = 10;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(372, 191);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(17, 111);
            vScrollBar2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(32, 22);
            label3.TabIndex = 15;
            label3.Text = "#1";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 230);
            button2.Name = "button2";
            button2.Size = new Size(97, 24);
            button2.TabIndex = 16;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(424, 9);
            label4.Name = "label4";
            label4.Size = new Size(233, 22);
            label4.TabIndex = 17;
            label4.Text = "Закрепление учащихся";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(424, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(424, 46);
            label5.Name = "label5";
            label5.Size = new Size(67, 22);
            label5.TabIndex = 19;
            label5.Text = "Группа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(424, 123);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 21;
            label6.Text = "Участники";
            // 
            // vScrollBar3
            // 
            vScrollBar3.Location = new Point(640, 158);
            vScrollBar3.Name = "vScrollBar3";
            vScrollBar3.Size = new Size(17, 111);
            vScrollBar3.TabIndex = 22;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(424, 163);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "ученик1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(424, 196);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 19);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "ученик2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 382);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(vScrollBar3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(vScrollBar2);
            Controls.Add(vScrollBar1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Questions";
            Text = "Вопросы";
            Load += Questions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox textBox1;
        private Button button1;
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
        private ComboBox comboBox1;
        private Label label3;
        private Button button2;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private VScrollBar vScrollBar3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}