namespace FitPulse
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            button4 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(27, 19);
            label2.Name = "label2";
            label2.Size = new Size(220, 38);
            label2.TabIndex = 4;
            label2.Text = "Изберете дата:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(7, 65);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(328, 18);
            label3.Name = "label3";
            label3.Size = new Size(196, 38);
            label3.TabIndex = 6;
            label3.Text = "Упражнение:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Бягане", "Плуване", "Колоездене", "Силова тренировка", "Йога" });
            comboBox1.Location = new Point(535, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(290, 45);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(391, 73);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 8;
            label4.Text = "Минути:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(536, 71);
            numericUpDown1.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 43);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(959, 412);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(951, 371);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Нова тренировка";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(762, 293);
            button3.Name = "button3";
            button3.Size = new Size(181, 61);
            button3.TabIndex = 21;
            button3.Text = "Изход";
            toolTip1.SetToolTip(button3, "Изход от програмата");
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(7, 293);
            button2.Name = "button2";
            button2.Size = new Size(166, 61);
            button2.TabIndex = 20;
            button2.Text = "Изчисти";
            toolTip1.SetToolTip(button2, "Изчисти");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(278, 247);
            label5.Name = "label5";
            label5.Size = new Size(226, 23);
            label5.TabIndex = 19;
            label5.Text = "Прогрес: 0 / 500 kcal (0%)";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(278, 216);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(665, 27);
            progressBar1.TabIndex = 18;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown2.Location = new Point(578, 301);
            numericUpDown2.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(121, 43);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(234, 303);
            label1.Name = "label1";
            label1.Size = new Size(331, 38);
            label1.TabIndex = 16;
            label1.Text = "Дневна цел (калории):";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(278, 144);
            button1.Name = "button1";
            button1.Size = new Size(665, 65);
            button1.TabIndex = 15;
            button1.Text = "ЗАПИШИ ТРЕНИРОВКА";
            toolTip1.SetToolTip(button1, "Кликнете тук, за да добавите тренировката към историята");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(listView1);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(951, 371);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "История и статистика";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Location = new Point(659, 304);
            button4.Name = "button4";
            button4.Size = new Size(284, 59);
            button4.TabIndex = 16;
            button4.Text = "Експортирай в TXT";
            toolTip1.SetToolTip(button4, "Експортирай в текстов файл");
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(945, 365);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Дата";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Упражнение";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Изгорени калории";
            columnHeader3.Width = 200;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 412);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Фитнес тракер \"FitPulse\"";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private ToolTip toolTip1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label5;
        private ProgressBar progressBar1;
        private NumericUpDown numericUpDown2;
        private Button button2;
        private Button button3;
        private Button button4;
        private SaveFileDialog saveFileDialog1;
    }
}
