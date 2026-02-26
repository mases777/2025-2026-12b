namespace OrderProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            numericUpDown1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (comboBox1.SelectedIndex == 0)
                price = 1.20;
            if (comboBox1.SelectedIndex == 1)
                price = 2.50;
            if (comboBox1.SelectedIndex == 2)
                price = 3.00;
            if (comboBox1.SelectedIndex == 3)
                price = 1.80;
            price *= int.Parse(numericUpDown1.Value.ToString());
            if (checkBox1.Checked) price += 3.00;
            if (checkBox2.Checked) price += 2.00;
            textBox2.Text = $"{price:f2} лева";
        }
    }
}
