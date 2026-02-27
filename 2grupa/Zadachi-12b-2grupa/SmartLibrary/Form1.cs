using System.Runtime.InteropServices;

namespace SmartLibrary
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            trackBar1.Maximum = 2;
            textBox1.TextChanged += (s, e) => CalculateRealTime();
            trackBar1.ValueChanged += (s, e) => CalculateRealTime();
            comboBox1.SelectedIndexChanged += (s, e) => CalculateRealTime();
            dateTimePicker1.ValueChanged += (s, e) => CalculateRealTime();
            checkBox1.CheckedChanged += (s, e) => CalculateRealTime();
            numericUpDown1.ValueChanged += (s, e) =>
            {
                progressBar1.Value = (int)numericUpDown1.Value * 10;
                CalculateRealTime();
            };
        }
        private void SetProgressBarState(int state)
        {
            SendMessage(progressBar1.Handle, 0x410, (IntPtr)state, IntPtr.Zero);
        }

        private void CalculateRealTime()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                richTextBox1.Text = "Моля, въведете име на читател...";
                richTextBox1.ForeColor = Color.Gray;
                SetProgressBarState(1);
                return;
            }
            richTextBox1.ForeColor = Color.Black;
            TimeSpan duration = dateTimePicker1.Value.Date - DateTime.Now.Date;
            int days = Math.Max(1, duration.Days);
            decimal pricePerDay = 0.50m;
            if (comboBox1.Text == "Научна") pricePerDay = 0.80m;
            else if (comboBox1.Text == "Учебници") pricePerDay = 1.20m;
            decimal total = (pricePerDay * days) * numericUpDown1.Value;
            if (trackBar1.Value == 1) total *= 0.90m;
            else if (trackBar1.Value == 2) total *= 0.75m;
            if (checkBox1.Checked) total += 2.00m;
            if (total > 20.00m)
            {
                SetProgressBarState(2);
                label9.Text = "Внимание: Висока стойност на поръчката!";
                label9.ForeColor = Color.Red;
            }
            else
            {
                SetProgressBarState(1);
                label9.Text = "В рамките на нормалния бюджет.";
                label9.ForeColor = Color.Green;
            }
            DisplayReceipt(days, total);
        }

        private void DisplayReceipt(int days, decimal total)
        {
            string level = "Бронз";            
            if (trackBar1.Value == 1) level = "Сребро";
            if (trackBar1.Value == 2) level = "Злато";
            string category = "";
            if (comboBox1.SelectedIndex == 0) category = "Художествена";
            if (comboBox1.SelectedIndex == 1) category = "Научна";
            if (comboBox1.SelectedIndex == 2) category = "Учебници";
            string insurance = (checkBox1.Checked) ? "Да" : "Не";
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("--- ДИНАМИЧНА РАЗПИСКА ---\r\n");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.AppendText($"- Читател: {textBox1.Text}\r\n");
            richTextBox1.AppendText($"- Ниво: {level}\r\n");
            richTextBox1.AppendText($"- Категория: {category}\r\n");
            richTextBox1.AppendText($"- Период: {days} дни\r\n");
            richTextBox1.AppendText($"- Книги: {numericUpDown1.Value} бр.\r\n");
            richTextBox1.AppendText($"- Застраховка: {insurance}\r\n");
            richTextBox1.AppendText("--------------------------\r\n");
            richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = (total > 20) ? Color.Red : Color.DarkGreen;
            richTextBox1.AppendText($"ОБЩО: {total:F2} евро.\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add($"{DateTime.Now.ToShortTimeString()} - {textBox1.Text} - {numericUpDown1.Value} кн.");
                MessageBox.Show("Данните са записани успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            trackBar1.Value = 0;
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 1;
            progressBar1.Value = 0;
            label9.Text = "Запълване на лимита (макс. 10 книги)";
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
        }
    }
}
