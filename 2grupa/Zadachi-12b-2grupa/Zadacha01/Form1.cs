namespace Zadacha01
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
            textBox3.Text = "";
            textBox4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox1.Text);
            var y = double.Parse(textBox2.Text);
            var z = int.Parse(textBox3.Text);
            var worker = int.Parse(textBox4.Text);
            var grapes = x * y;
            var wine = 0.4 * grapes / 2.5;
            if (wine >= z)
            {
                var leftWine = wine - z;
                label5.Text = $"Good harvest this year! Total wine: {Math.Floor(wine)} liters.";
                label6.Text = $"{Math.Ceiling(leftWine)} liters left -> {Math.Ceiling(leftWine / worker)} liters per person.";
            }
            else
            {
                label5.Text = $"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.";
            }

        }
    }
}
