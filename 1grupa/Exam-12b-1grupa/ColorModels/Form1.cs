namespace ColorModels
{
    public partial class Form1 : Form
    {
        string hexCode = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateColorAndHex(object sender, EventArgs e)
        {
            int red = trackBar1.Value;
            int green = trackBar2.Value;
            int blue = trackBar3.Value;
            label7.Text = red.ToString();
            label8.Text = green.ToString();
            label9.Text = blue.ToString();
            Color newColor = Color.FromArgb(red, green, blue);
            panel1.BackColor = newColor;
            string hexR = red.ToString("X2");
            string hexG = green.ToString("X2");
            string hexB = blue.ToString("X2");
            hexCode = $"#{hexR}{hexG}{hexB}";
            label5.Text = $"HEX код\n{hexCode}";
            double perceivedBrightness = (red * 0.299) + (green * 0.587) + (blue * 0.114);
            if (perceivedBrightness < 128)
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
            else
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            label6.Text = (perceivedBrightness < 128) ? "Проверка\r\nза четливост\r\nТъмен фон\r\n(Бял текст)" : "Проверка\r\nза четливост\r\nСветъл фон\r\n(Черен текст)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            label5.Text = "HEX код";
            label6.Text = "Проверка\r\nза четливост";
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            panel1.BackColor = Color.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hexCode);
        }
    }
}
