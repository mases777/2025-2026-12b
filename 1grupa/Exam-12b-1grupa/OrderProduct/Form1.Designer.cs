namespace OrderProduct
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(705, 60);
            label1.TabIndex = 0;
            label1.Text = "Форма за поръчка на продукти";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(124, 38);
            label2.TabIndex = 1;
            label2.Text = "Клиент:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(141, 38);
            label3.TabIndex = 2;
            label3.Text = "Продукт:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 256);
            label4.Name = "label4";
            label4.Size = new Size(223, 76);
            label4.TabIndex = 3;
            label4.Text = "Допълнителни\r\nуслуги:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 350);
            label5.Name = "label5";
            label5.Size = new Size(282, 38);
            label5.TabIndex = 4;
            label5.Text = "Начин на плащане:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 404);
            label6.Name = "label6";
            label6.Size = new Size(176, 38);
            label6.TabIndex = 5;
            label6.Text = "Обща сума:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(314, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 43);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Химикал - 1,20", "Тетрадка - 2,50", "Папка - 3,00", "Маркер - 1,80" });
            comboBox1.Location = new Point(314, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 45);
            comboBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(314, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(333, 32);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Експресна доставка (+3,00 лв)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(314, 300);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(346, 32);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Подаръчна опаковка (+2,00 лв)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(314, 350);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 32);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "В брой";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(477, 350);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 32);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "С карта";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(314, 404);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(268, 43);
            textBox2.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(683, 95);
            button1.Name = "button1";
            button1.Size = new Size(213, 65);
            button1.TabIndex = 13;
            button1.Text = "Пресметни";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(683, 238);
            button2.Name = "button2";
            button2.Size = new Size(213, 65);
            button2.TabIndex = 14;
            button2.Text = "Изчисти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(683, 381);
            button3.Name = "button3";
            button3.Size = new Size(213, 65);
            button3.TabIndex = 15;
            button3.Text = "Изход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(12, 202);
            label7.Name = "label7";
            label7.Size = new Size(186, 38);
            label7.TabIndex = 16;
            label7.Text = "Количество:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(314, 202);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(268, 43);
            numericUpDown1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 457);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private NumericUpDown numericUpDown1;
    }
}
