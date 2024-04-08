namespace SmartQuiz
{
    partial class TestChoice
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
            new_test_label = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            startTest = new RoundButton();
            label4 = new Label();
            roundButton1 = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // new_test_label
            // 
            new_test_label.AutoSize = true;
            new_test_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            new_test_label.Location = new Point(12, 19);
            new_test_label.Name = "new_test_label";
            new_test_label.RightToLeft = RightToLeft.No;
            new_test_label.Size = new Size(210, 32);
            new_test_label.TabIndex = 17;
            new_test_label.Text = "Выберете тест";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 77);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 21;
            label3.Text = "Название теста №1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 46);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(317, 22);
            label1.TabIndex = 23;
            label1.Text = "Ограничение по времени: 01:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(208, 22);
            label2.TabIndex = 24;
            label2.Text = "Количество попыток: 3";
            // 
            // startTest
            // 
            startTest.BackColor = SystemColors.ControlText;
            startTest.Font = new Font("Arial", 16.125F, FontStyle.Italic, GraphicsUnit.Point);
            startTest.ForeColor = SystemColors.ControlLightLight;
            startTest.Location = new Point(12, 220);
            startTest.Name = "startTest";
            startTest.Size = new Size(289, 38);
            startTest.TabIndex = 25;
            startTest.Text = "Начать тестирование";
            startTest.UseVisualStyleBackColor = false;
            startTest.Click += startTest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(413, 9);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 26;
            label4.Text = "ФИО Группа";
            // 
            // roundButton1
            // 
            roundButton1.BackColor = SystemColors.ControlText;
            roundButton1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            roundButton1.ForeColor = SystemColors.ControlLightLight;
            roundButton1.Location = new Point(534, 5);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(109, 30);
            roundButton1.TabIndex = 27;
            roundButton1.Text = "Выход";
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // TestChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 279);
            Controls.Add(roundButton1);
            Controls.Add(label4);
            Controls.Add(startTest);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(new_test_label);
            Name = "TestChoice";
            Text = "Выбор тестирования";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label new_test_label;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RoundButton startTest;
        private Label label4;
        private RoundButton roundButton1;
    }
}