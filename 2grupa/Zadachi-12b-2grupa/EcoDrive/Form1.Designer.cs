namespace EcoDrive
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(198, 9);
            label1.Name = "label1";
            label1.Size = new Size(803, 38);
            label1.TabIndex = 2;
            label1.Text = "Система за отдаване на автомобили под наем \"EcoDrive\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(215, 38);
            label2.TabIndex = 3;
            label2.Text = "Въведете име:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(300, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 43);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(249, 38);
            label3.TabIndex = 10;
            label3.Text = "Клас автомобил:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Икономичен - 20 евро", "Семеен - 30 евро", "Луксозен - 60 евро" });
            comboBox1.Location = new Point(300, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 45);
            comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(268, 38);
            label4.TabIndex = 12;
            label4.Text = "Брой дни за наем:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(300, 198);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(330, 43);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 262);
            label5.Name = "label5";
            label5.Size = new Size(182, 38);
            label5.TabIndex = 14;
            label5.Text = "Вид гориво:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(300, 262);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(115, 35);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Бензин";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(510, 262);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 35);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Дизел";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 326);
            label6.Name = "label6";
            label6.Size = new Size(117, 38);
            label6.TabIndex = 17;
            label6.Text = "Екстри:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(12, 367);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(239, 35);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "GPS (+2 евро/ден)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(291, 367);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(333, 35);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Застраховка (+5 евро/ден)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(115, 408);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(442, 35);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Детско столче (+3 евро еднократно)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(651, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(548, 368);
            listBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 466);
            button1.Name = "button1";
            button1.Size = new Size(294, 65);
            button1.TabIndex = 22;
            button1.Text = "Обработи договор";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 0);
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(362, 466);
            button2.Name = "button2";
            button2.Size = new Size(262, 65);
            button2.TabIndex = 23;
            button2.Text = "Общ оборот";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(680, 466);
            button3.Name = "button3";
            button3.Size = new Size(231, 65);
            button3.TabIndex = 24;
            button3.Text = "Изчисти";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Location = new Point(967, 466);
            button4.Name = "button4";
            button4.Size = new Size(231, 65);
            button4.TabIndex = 25;
            button4.Text = "Изход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton3.Location = new Point(267, 303);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(186, 35);
            radioButton3.TabIndex = 26;
            radioButton3.TabStop = true;
            radioButton3.Text = "Електрическа";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton4.Location = new Point(510, 303);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(120, 35);
            radioButton4.TabIndex = 27;
            radioButton4.TabStop = true;
            radioButton4.Text = "Хибрид";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 543);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}
