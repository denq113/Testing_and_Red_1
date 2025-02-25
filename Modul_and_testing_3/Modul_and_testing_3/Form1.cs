using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_and_testing_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем числа из TextBox, разделенные пробелами или запятыми
                int[] numbers = textBox1.Text
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (numbers.Length < 2)
                {
                    MessageBox.Show("Введите хотя бы два числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Находим два наименьших элемента
                int min1 = int.MaxValue, min2 = int.MaxValue;
                foreach (int num in numbers)
                {
                    if (num < min1)
                    {
                        min2 = min1;
                        min1 = num;
                    }
                    else if (num < min2)
                    {
                        min2 = num;
                    }
                }

                // Вывод результата
                label1.Text = $"Наименьшие числа: {min1} и {min2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
