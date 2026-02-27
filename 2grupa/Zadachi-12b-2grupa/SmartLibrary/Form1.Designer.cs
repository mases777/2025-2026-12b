namespace SmartLibrary
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
            trackBar1 = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            progressBar1 = new ProgressBar();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            checkBox1 = new CheckBox();
            richTextBox1 = new RichTextBox();
            label12 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(719, 38);
            label1.TabIndex = 3;
            label1.Text = "Система за библиотечен абонамент \"SmartLibrary\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 66);
            label2.Name = "label2";
            label2.Size = new Size(240, 38);
            label2.TabIndex = 4;
            label2.Text = "Име на читател:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(280, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 43);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(55, 113);
            label3.Name = "label3";
            label3.Size = new Size(219, 31);
            label3.TabIndex = 11;
            label3.Text = "Ниво на членство:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(280, 113);
            trackBar1.Maximum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(330, 56);
            trackBar1.TabIndex = 12;
            trackBar1.TickStyle = TickStyle.Both;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(280, 152);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 13;
            label4.Text = "Бронз";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(400, 152);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 14;
            label5.Text = "Сребро";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(532, 152);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 15;
            label6.Text = "Злато";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(25, 197);
            label7.Name = "label7";
            label7.Size = new Size(249, 38);
            label7.TabIndex = 16;
            label7.Text = "Категория книга:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Художествена", "Научна", "Учебници" });
            comboBox1.Location = new Point(280, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 45);
            comboBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(91, 255);
            label8.Name = "label8";
            label8.Size = new Size(183, 38);
            label8.TabIndex = 18;
            label8.Text = "Брой книги:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(279, 253);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(330, 43);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(279, 302);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 22);
            progressBar1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label9.Location = new Point(280, 327);
            label9.Name = "label9";
            label9.Size = new Size(336, 23);
            label9.TabIndex = 21;
            label9.Text = "Запълване на лимита (макс. 10 книги)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(13, 366);
            label10.Name = "label10";
            label10.Size = new Size(261, 38);
            label10.TabIndex = 22;
            label10.Text = "Дата на връщане:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(280, 366);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 38);
            dateTimePicker1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(726, 47);
            label11.Name = "label11";
            label11.Size = new Size(316, 38);
            label11.TabIndex = 24;
            label11.Text = "Електронна разписка:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(43, 421);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(534, 35);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Включи застраховка \"Закъснение\" (+2 евро)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(622, 91);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(497, 241);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(703, 335);
            label12.Name = "label12";
            label12.Size = new Size(348, 38);
            label12.TabIndex = 27;
            label12.Text = "История на заеманията:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(622, 385);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(497, 172);
            listBox1.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 492);
            button1.Name = "button1";
            button1.Size = new Size(303, 65);
            button1.TabIndex = 29;
            button1.Text = "Генерирай разписка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(321, 492);
            button2.Name = "button2";
            button2.Size = new Size(152, 65);
            button2.TabIndex = 30;
            button2.Text = "Изчисти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(479, 492);
            button3.Name = "button3";
            button3.Size = new Size(130, 65);
            button3.TabIndex = 31;
            button3.Text = "Изход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 573);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label12);
            Controls.Add(richTextBox1);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBar1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TrackBar trackBar1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private ProgressBar progressBar1;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private Label label12;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
