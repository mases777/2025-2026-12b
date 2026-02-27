namespace DayWater
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
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(769, 38);
            label1.TabIndex = 0;
            label1.Text = "Калкулатор за изчисляване на дневния прием на вода";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(232, 38);
            label2.TabIndex = 1;
            label2.Text = "Въведете тегло:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(284, 76);
            label3.TabIndex = 2;
            label3.Text = "Ниво на физическа\r\nактивност:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(80, 38);
            label4.TabIndex = 3;
            label4.Text = "Пол:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(91, 281);
            label5.Name = "label5";
            label5.Size = new Size(133, 38);
            label5.TabIndex = 4;
            label5.Text = "Резултат";
            label5.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(342, 68);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(147, 43);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Малка/Никаква", "Умерена (1-3 пъти седмично)", "Висока (4+ пъти седмично)" });
            comboBox1.Location = new Point(342, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(475, 45);
            comboBox1.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(137, 221);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 42);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Мъж";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(290, 221);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(113, 42);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Жена";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(479, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(325, 42);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Бременна/Кърмачка";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 341);
            button1.Name = "button1";
            button1.Size = new Size(231, 65);
            button1.TabIndex = 16;
            button1.Text = "Пресметни";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(298, 341);
            button2.Name = "button2";
            button2.Size = new Size(231, 65);
            button2.TabIndex = 17;
            button2.Text = "Изчисти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(584, 341);
            button3.Name = "button3";
            button3.Size = new Size(231, 65);
            button3.TabIndex = 18;
            button3.Text = "Изход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 418);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
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
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
