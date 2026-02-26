namespace TextAnalize
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(255, 9);
            label1.Name = "label1";
            label1.Size = new Size(652, 38);
            label1.TabIndex = 2;
            label1.Text = "Текстов анализатор и генератор на статистика";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(241, 114);
            label2.TabIndex = 3;
            label2.Text = "Въведете или\r\nкопирайте текст\r\nв кутията";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(279, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(592, 335);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 336);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Опции за анализ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(0, 278);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(178, 35);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "малки букви";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 233);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(213, 35);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "ГЛАВНИ БУКВИ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 123);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(235, 66);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Думи, започващи\r\nс главна буква";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 46);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(175, 66);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Игнорирай\r\nинтервалите";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(279, 417);
            label3.Name = "label3";
            label3.Size = new Size(238, 31);
            label3.TabIndex = 6;
            label3.Text = "Общ брой символи:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(279, 460);
            label4.Name = "label4";
            label4.Size = new Size(198, 31);
            label4.TabIndex = 7;
            label4.Text = "Общ брой думи:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(633, 417);
            label5.Name = "label5";
            label5.Size = new Size(156, 31);
            label5.TabIndex = 8;
            label5.Text = "Брой гласни:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(633, 460);
            label6.Name = "label6";
            label6.Size = new Size(185, 31);
            label6.TabIndex = 9;
            label6.Text = "Резултат букви:";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(889, 65);
            button1.Name = "button1";
            button1.Size = new Size(213, 103);
            button1.TabIndex = 15;
            button1.Text = "Анализирай\r\nтекста";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(889, 219);
            button2.Name = "button2";
            button2.Size = new Size(213, 65);
            button2.TabIndex = 16;
            button2.Text = "Изчисти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(889, 335);
            button3.Name = "button3";
            button3.Size = new Size(213, 65);
            button3.TabIndex = 17;
            button3.Text = "Изход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(533, 417);
            label8.Name = "label8";
            label8.Size = new Size(27, 31);
            label8.TabIndex = 18;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(533, 460);
            label9.Name = "label9";
            label9.Size = new Size(27, 31);
            label9.TabIndex = 19;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(856, 417);
            label10.Name = "label10";
            label10.Size = new Size(27, 31);
            label10.TabIndex = 20;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(856, 460);
            label11.Name = "label11";
            label11.Size = new Size(27, 31);
            label11.TabIndex = 21;
            label11.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(346, 523);
            label7.Name = "label7";
            label7.Size = new Size(501, 31);
            label7.TabIndex = 22;
            label7.Text = "Общ брой думи, започващи с главна буква:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(856, 521);
            label12.Name = "label12";
            label12.Size = new Size(27, 31);
            label12.TabIndex = 23;
            label12.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 593);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label7;
        private Label label12;
    }
}
