using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_and_testing_pr1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (a < 0 || b < 0 || c < 0) 
            {
                label4.Text = "Ошибка длины старон не могут быть меньше нуля"; 
            }else if (a == 0 || b == 0 || c == 0) 
            {
                label4.Text = "Ошибка длины старон не могут быть равными нулю";
            }else if (a + b <= c || b + c <= a || a + c <= b)
            {
                label4.Text=("Треугольник с такими сторонами не существует.");
            }else if (a == b && b == c)
            {
                label4.Text="Треугольник равнобедренный";
            }else 
            {
                label4.Text = "Треугольник разностаронний"; 
            }

                

        }
    }
}
