namespace TextAnalize
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
            textBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '/', '(', ')', '\'', '\"' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            int wordWithoutSpace = 0;
            if (checkBox1.Checked)
                foreach (char c in text)
                {
                    if (" ".Contains(c)) continue;
                    wordWithoutSpace++;
                }
            else wordWithoutSpace = text.Length;
            label8.Text = wordWithoutSpace.ToString();
            label9.Text = wordCount.ToString();
            int vowelCount = 0;
            foreach (char c in text)
                if ("aeiouAEIOUаеиоуъАЕИОУЪ".Contains(c)) vowelCount++;
            label10.Text = vowelCount.ToString();
            int upper = 0, lower = 0;
            foreach (char c in text)
            {
                if (char.IsUpper(c)) upper++;
                if (char.IsLower(c)) lower++;
            }
            if (radioButton1.Checked)
                label11.Text = $"ГЛАВНИ БУКВИ: {upper.ToString()}";
            if (radioButton2.Checked)
                label11.Text = $"малки букви: {lower.ToString()}";
            if (checkBox2.Checked)
            {
                int wordCapitalize = 0;
                foreach (var item in words)
                    if (char.IsUpper(item[0])) wordCapitalize++;
                label12.Text = wordCapitalize.ToString();
            }
            else label12.Text = "0";
        }
    }
}
