namespace DayWater
{
    public partial class Form1 : Form
    {
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
            numericUpDown1.Value = 50;
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label5.Text = "";
            label5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int recommend = int.Parse(numericUpDown1.Value.ToString()) * 35;
            switch(comboBox1.SelectedIndex)
            {
                case 1: recommend += 300; break;
                case 2: recommend += 600; break;
            }
            if (checkBox1.Checked) recommend += 700;
            label5.Text = $"Препоръчителен прием: {recommend} мл.";
            label5.Visible = true;
        }
    }
}
