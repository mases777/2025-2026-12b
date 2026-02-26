namespace ColorModels
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            trackBar3 = new TrackBar();
            trackBar2 = new TrackBar();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(321, 9);
            label1.Name = "label1";
            label1.Size = new Size(650, 38);
            label1.TabIndex = 1;
            label1.Text = "Конвертор на цветови модели (RGB към HEX)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(trackBar3);
            groupBox1.Controls.Add(trackBar2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1284, 253);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "RGB компоненти";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(1213, 181);
            label9.Name = "label9";
            label9.Size = new Size(33, 38);
            label9.TabIndex = 10;
            label9.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(1213, 119);
            label8.Name = "label8";
            label8.Size = new Size(33, 38);
            label8.TabIndex = 9;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(1213, 58);
            label7.Name = "label7";
            label7.Size = new Size(33, 38);
            label7.TabIndex = 8;
            label7.Text = "0";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(227, 181);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(980, 56);
            trackBar3.TabIndex = 7;
            trackBar3.Scroll += UpdateColorAndHex;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(227, 119);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(980, 56);
            trackBar2.TabIndex = 6;
            trackBar2.Scroll += UpdateColorAndHex;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(9, 181);
            label4.Name = "label4";
            label4.Size = new Size(155, 38);
            label4.TabIndex = 5;
            label4.Text = "Син (Blue)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(9, 119);
            label3.Name = "label3";
            label3.Size = new Size(203, 38);
            label3.TabIndex = 4;
            label3.Text = "Зелен (Green)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(9, 58);
            label2.Name = "label2";
            label2.Size = new Size(194, 38);
            label2.TabIndex = 3;
            label2.Text = "Червен (Red)";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(227, 58);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(980, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += UpdateColorAndHex;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 203);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(383, 23);
            label6.Name = "label6";
            label6.Size = new Size(192, 76);
            label6.TabIndex = 18;
            label6.Text = "Проверка\r\nза четливост";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(21, 23);
            label5.Name = "label5";
            label5.Size = new Size(130, 38);
            label5.TabIndex = 4;
            label5.Text = "HEX код";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1083, 339);
            button1.Name = "button1";
            button1.Size = new Size(213, 65);
            button1.TabIndex = 15;
            button1.Text = "Копирай HEX";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(1083, 410);
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
            button3.Location = new Point(1083, 481);
            button3.Name = "button3";
            button3.Size = new Size(213, 65);
            button3.TabIndex = 17;
            button3.Text = "Изход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 558);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}
