using System.Diagnostics;

namespace EcoDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numericUpDown1.Value = 1;
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length < 3)
            {
                MessageBox.Show("Моля, въведете коректно име на клиент (поне 3 символа)!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal dayPrice = 0;
            int days = (int)numericUpDown1.Value;
            switch (comboBox1.SelectedIndex)
            {
                case 0: dayPrice = 20; break;
                case 1: dayPrice = 30; break;
                case 2: dayPrice = 60; break;
            }
            decimal total = dayPrice * days;

        }
    }
}
