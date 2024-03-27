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
            auth_label = new Label();
            label2 = new Label();
            button3 = new RoundButton();
            textBox1 = new TextBox();
            button1 = new RoundButton();
            vScrollBar1 = new VScrollBar();
            vScrollBar2 = new VScrollBar();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new RoundButton();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            vScrollBar3 = new VScrollBar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(15, 19);
            auth_label.Margin = new Padding(6, 0, 6, 0);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(740, 45);
            auth_label.TabIndex = 0;
            auth_label.Text = "Создание и редактирование вопросов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 337);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(527, 45);
            label2.TabIndex = 1;
            label2.Text = "Выбор вопросов для теста";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Arial", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(875, 698);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(435, 92);
            button3.TabIndex = 7;
            button3.Text = "Подтвердить";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(22, 105);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Добавить вопрос...";
            textBox1.Size = new Size(357, 39);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(414, 98);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(237, 51);
            button1.TabIndex = 9;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(764, 105);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 237);
            vScrollBar1.TabIndex = 10;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(764, 407);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(17, 237);
            vScrollBar2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 407);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 40);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Название вопроса...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 407);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 43);
            label3.TabIndex = 15;
            label3.Text = "#1";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(22, 491);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(241, 50);
            button2.TabIndex = 16;
            button2.Text = "Добавить вопрос";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(787, 19);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(455, 45);
            label4.TabIndex = 17;
            label4.Text = "Закрепление учащихся";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(787, 171);
            comboBox2.Margin = new Padding(6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(254, 40);
            comboBox2.TabIndex = 18;
            comboBox2.Text = "Название группы...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(787, 98);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 43);
            label5.TabIndex = 19;
            label5.Text = "Группа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(787, 262);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 43);
            label6.TabIndex = 21;
            label6.Text = "Участники";
            // 
            // vScrollBar3
            // 
            vScrollBar3.Location = new Point(1189, 337);
            vScrollBar3.Name = "vScrollBar3";
            vScrollBar3.Size = new Size(17, 237);
            vScrollBar3.TabIndex = 22;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(787, 348);
            checkBox1.Margin = new Padding(6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 36);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "ученик1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(787, 418);
            checkBox2.Margin = new Padding(6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(138, 36);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "ученик2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 815);
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
            Controls.Add(auth_label);
            Margin = new Padding(6);
            Name = "Questions";
            Text = "Вопросы";
            Load += Questions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label auth_label;
        private Label label2;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private VScrollBar vScrollBar3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private RoundButton button3;
        private RoundButton button1;
        private RoundButton button2;
    }
}