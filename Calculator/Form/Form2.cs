using System;
using calculator.Converter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator.Form
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            if (comboBox1.Text == "Длина")
            {
                comboBox2.Items.Add("Метры");
                comboBox2.Items.Add("Километры");
                comboBox2.Items.Add("Дециметры");
                comboBox2.Items.Add("Сантиметры");
                comboBox2.Items.Add("Миллиметры");
                comboBox2.Items.Add("Микрометры");
                comboBox2.Items.Add("Нанометры");
                comboBox2.Items.Add("Пикометры");
                comboBox2.Items.Add("Мили");
                comboBox2.Items.Add("Ярды");
                comboBox2.Items.Add("Футы");
                comboBox2.Items.Add("Дюймы");

                comboBox3.Items.Add("Метры");
                comboBox3.Items.Add("Километры");
                comboBox3.Items.Add("Дециметры");
                comboBox3.Items.Add("Сантиометры");
                comboBox3.Items.Add("Миллиметры");
                comboBox3.Items.Add("Микрометры");
                comboBox3.Items.Add("Нанометры");
                comboBox3.Items.Add("Пикометры");
                comboBox3.Items.Add("Мили");
                comboBox3.Items.Add("Ярды");
                comboBox3.Items.Add("Футы");
                comboBox3.Items.Add("Дюймы");


                comboBox2.Text = "Метры";
                comboBox3.Text = "Километры";
            }
            if (comboBox1.Text == "Площадь")
            {
                comboBox2.Items.Add("Квадратные Метры");
                comboBox2.Items.Add("Квадратные Километры");
                comboBox2.Items.Add("Гектары");
                comboBox2.Items.Add("Ары");
                comboBox2.Items.Add("Квадратные Дециметры");
                comboBox2.Items.Add("Квадратные Сантиметры");
                comboBox2.Items.Add("Квадратные Миллиметры");
                comboBox2.Items.Add("Квадратные Мили");
                comboBox2.Items.Add("Квадратные Ярды");
                comboBox2.Items.Add("Квадратные Футы");
                comboBox2.Items.Add("Квадратные Дюймы");

                comboBox3.Items.Add("Квадратные Метры");
                comboBox3.Items.Add("Квадратные Километры");
                comboBox3.Items.Add("Гектары");
                comboBox3.Items.Add("Ары");
                comboBox3.Items.Add("Квадратные Дециметры");
                comboBox3.Items.Add("Квадратные Сантиметры");
                comboBox3.Items.Add("Квадратные Миллиметры");
                comboBox3.Items.Add("Квадратные Мили");
                comboBox3.Items.Add("Квадратные Ярды");
                comboBox3.Items.Add("Квадратные Футы");
                comboBox3.Items.Add("Квадратные Дюймы");

                comboBox2.Text = "Квадратные Метры";
                comboBox3.Text = "Квадратные Километры";
            }

            if (comboBox1.Text == "Объем")
            {
                comboBox2.Items.Add("Кубические Метры");
                comboBox2.Items.Add("Кубические Дециметры");
                comboBox2.Items.Add("Кубические Сантиметры");
                comboBox2.Items.Add("Кубические Миллиметры");
                comboBox2.Items.Add("Литры");

                comboBox3.Items.Add("Кубические Метры");
                comboBox3.Items.Add("Кубические Дециметры");
                comboBox3.Items.Add("Кубические Сантиметры");
                comboBox3.Items.Add("Кубические Миллиметры");
                comboBox3.Items.Add("Литры");

                comboBox2.Text = "Литры";
                comboBox3.Text = "Кубические Метры";
            }

            if (comboBox1.Text == "Скорость")
            {
                comboBox2.Items.Add("Метры в секунду");
                comboBox2.Items.Add("Километры в секунду");
                comboBox2.Items.Add("Километры в час");
                comboBox2.Items.Add("Узлы");
                comboBox2.Items.Add("Мили в час");

                comboBox3.Items.Add("Метры в секунду");
                comboBox3.Items.Add("Километры в секунду");
                comboBox3.Items.Add("Километры в час");
                comboBox3.Items.Add("Узлы");
                comboBox3.Items.Add("Мили в час");

                comboBox2.Text = "Метры в секунду";
                comboBox3.Text = "Километры в час";
            }

            if (comboBox1.Text == "Масса")
            {
                comboBox2.Items.Add("Грамм");
                comboBox2.Items.Add("КилоГрамм");
                comboBox2.Items.Add("МиллиГрамм");
                comboBox2.Items.Add("МикроГрамм");
                comboBox2.Items.Add("Тонна");
                comboBox2.Items.Add("Центнер");
                comboBox2.Items.Add("Фунт");
                comboBox2.Items.Add("Унция");

                comboBox3.Items.Add("Грамм");
                comboBox3.Items.Add("КилоГрамм");
                comboBox3.Items.Add("МиллиГрамм");
                comboBox3.Items.Add("МикроГрамм");
                comboBox3.Items.Add("Тонна");
                comboBox3.Items.Add("Центнер");
                comboBox3.Items.Add("Фунт");
                comboBox3.Items.Add("Унция");

                comboBox2.Text = "Грамм";
                comboBox3.Text = "КилоГрамм";
            }

            if (comboBox1.Text == "Температура")
            {
                comboBox2.Items.Add("Кельвин");
                comboBox2.Items.Add("Цельсий");
                comboBox2.Items.Add("Фаренгейт");

                comboBox3.Items.Add("Кельвин");
                comboBox3.Items.Add("Цельсий");
                comboBox3.Items.Add("Фаренгейт");

                comboBox2.Text = "Цельсий";
                comboBox3.Text = "Кельвин";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void BPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 
             if ((comboBox1.Text == "Длина") || (comboBox1.Text == "Площадь") || (comboBox1.Text == "Объем") || (comboBox1.Text == "Скорость"))
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Converting.SI(comboBox2.Text, comboBox3.Text));
             if (comboBox1.Text == "Масса")
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Converting.Mass(comboBox2.Text, comboBox3.Text));
            if (comboBox1.Text == "Температура")
                textBox2.Text = Convert.ToString(Converting.Temp(comboBox2.Text, comboBox3.Text, Convert.ToDouble(textBox1.Text)));
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
