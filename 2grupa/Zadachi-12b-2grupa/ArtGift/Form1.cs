namespace ArtGift
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        string order = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label8.Text = "";
            label8.Visible = false;
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Моля, въведете име на клиента!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Моля, въведете адрес за доставка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal price = 0;
            string product = comboBox1.SelectedItem.ToString();
            switch (comboBox1.SelectedIndex)
            {
                case 0: price += 5; break; 
                case 1: price += 10; break; 
                case 2: price += 8; break; 
            }
            int quantity = int.Parse(numericUpDown1.Value.ToString());
            decimal medium = price * quantity;
            if (checkBox1.Checked) medium += 2;
            if (checkBox2.Checked) medium += 1;
            if (radioButton2.Checked) medium += 3;
            if (quantity > 10)
            {
                medium *= 0.9m;
                MessageBox.Show("Приложена е 10% отстъпка за количество!");
            }
            total += medium;
            string deliveryType = radioButton2.Checked ? "Експресна" : "Стандартна";
            order = $"{textBox1.Text} | {product} * {quantity} броя | Доставка: {deliveryType}";
            listBox1.Items.Add(order);
            label8.Text = $"Обща крайна цена:\r\n{total:f2} евро";
            label8.Visible = true;
        }
    }
}
