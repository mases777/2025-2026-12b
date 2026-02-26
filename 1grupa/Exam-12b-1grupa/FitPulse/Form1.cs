using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitPulse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupListView();
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToShortDateString();
            string exercise = comboBox1.Text;
            int duration = (int)numericUpDown1.Value;

            if (string.IsNullOrEmpty(exercise))
            {
                MessageBox.Show("Моля, изберете упражнение!");
                return;
            }

            double burned = duration * (exercise == "Бягане" ? 9 : (exercise == "Плуване" ? 8 : (exercise == "Колоездене" ? 7 : (exercise == "Йога" ? 5 : 10))));

            ListViewItem item = new ListViewItem(selectedDate);
            item.SubItems.Add(exercise);
            item.SubItems.Add(burned.ToString());
            listView1.Items.Add(item);

            UpdateDailyProgress(selectedDate);
        }

        private void UpdateDailyProgress(string date)
        {
            double totalBurnedForDay = 0;
            double goal = (double)numericUpDown2.Value;

            foreach (ListViewItem item in listView1.Items)
                if (item.Text == date) totalBurnedForDay += double.Parse(item.SubItems[2].Text);

            int percent = (int)((totalBurnedForDay / goal) * 100);
            if (percent > 100) percent = 100;

            progressBar1.Value = percent;
            label5.Text = $"Прогрес за {date}: {totalBurnedForDay} / {goal} kcal ({percent}%)";

            if (percent >= 100)
            {
                label5.ForeColor = Color.Green;
                label5.Text += " - ЦЕЛТА Е ПОСТИГНАТА! 🎉";
            }
            else
            {
                label5.ForeColor = Color.Black;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateDailyProgress(e.Start.ToShortDateString());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateDailyProgress(monthCalendar1.SelectionStart.ToShortDateString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Няма данни за експортиране!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Title = "Запази историята на тренировките";
            saveFileDialog1.FileName = "WorkoutHistory.txt";
            saveFileDialog1.Filter = "Текстов файл (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writer.WriteLine("ИСТОРИЯ НА ТРЕНИРОВКИТЕ - FITPULSE");
                        writer.WriteLine(new string('-', 40));
                        writer.WriteLine("{0,-13} {1,-18} {2,-10}", "Дата", "Упражнение", "Калории");
                        writer.WriteLine(new string('-', 40));

                        foreach (ListViewItem item in listView1.Items)
                        {
                            string date = item.Text;
                            string exercise = item.SubItems[1].Text;
                            string calories = item.SubItems[2].Text;

                            writer.WriteLine("{0,-13} {1,-18} {2,-10}", date, exercise, calories);
                        }

                        writer.WriteLine(new string('-', 40));
                        writer.WriteLine($"Генерирано на: {DateTime.Now}");
                    }

                    MessageBox.Show("Данните бяха успешно записани!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Възникна грешка при записа: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 30;
            numericUpDown2.Value = 500;
            progressBar1.Value = 0;
            label5.Text = "Прогрес: 0 / 500 kcal (0%)";
            label5.ForeColor = Color.Black;
        }
    }
}
