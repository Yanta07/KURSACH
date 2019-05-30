// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using calculator.CalcMathematics;
using calculator.Parser.Context;
using calculator.Parser.Exceptions;

namespace calculator.Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        readonly Calc _c;
        private CalcMath _cMath;

        int k; //количество нажатий кнопки MRC

        public Form1()
        {
            InitializeComponent();

            _cMath = new CalcMath();
            _c = new Calc();

            labelNumber.Text = "0";
        }

        //кнопка Очистка (CE)
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";

            _c.Clear_A();

            k = 0;
        }

        //кнопка изменения знака у числа
        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            RemoveMultipleDots();
            if (labelNumber.Text.IndexOf("∞", StringComparison.Ordinal) == -1)
                labelNumber.Text += ".";
        }

        private double TryExecuteExpression()
        {
            var context = new ReflectionContext(_cMath);
            double value = 0;
            try
            {
                value = Parser.Parser.Parse(labelNumber.Text).Eval(context);
            }
            catch (SyntaxException e)
            {
                MessageBox.Show(e.Message);
            }

            return value;
        }

        private void RemoveMultipleDots()
        {
            int n;
            if ((n = labelNumber.Text.IndexOf('.')) != -1)
                labelNumber.Text = string.Concat(labelNumber.Text.Substring(0, n + 1), labelNumber.Text.Substring(n + 1).Replace(".", ""));
        }

        string GetNumberFromEnd(string text)
        {
            int i = text.Length - 1;
            while (i >= 0)
            {
                if (text[i] == '.')
                {
                    i--;
                    continue;
                }
                if (!char.IsNumber(text[i])) break;
                i--;
            }
            return text.Substring(i + 1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }

        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞", StringComparison.Ordinal) != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && labelNumber.Text.IndexOf(".", StringComparison.Ordinal) != 1)
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && labelNumber.Text.IndexOf(".", StringComparison.Ordinal) != 2)
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }

        //кнопка Равно
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            labelNumber.Text = TryExecuteExpression().ToString(CultureInfo.InvariantCulture);

            _c.Clear_A();

            k = 0;

        }

        //кнопка Умножение
        private void buttonMult_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "*";
        }

        //кнопка Деление
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "/";
        }

        //кнопка Сложение
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "+";
        }

        //кнопка Вычитание
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "-";
        }

        //кнопка Корень произвольной степени
        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "@";
        }

        //кнопка Возведение в произвольную степень
        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "^";
        }

        private void SetLabelNumberFunction(string funcName)
        {
            string lastNumber = GetNumberFromEnd(labelNumber.Text);
            if (lastNumber == "") labelNumber.Text += funcName + "(";
            else labelNumber.Text = labelNumber.Text.Replace(lastNumber, "") + funcName + "(" + lastNumber + ")";
        }

        //кнопка Корень квадратный
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Root");
        }

        //кнопка Квадрат числа
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "^2";
        }

        //кнопка Факториал
        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Fact");
        }

        //кнопка М+
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            _c.M_Sum(TryExecuteExpression());
        }

        //кнопка М-
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            _c.M_Subtraction(TryExecuteExpression());
        }

        //кнопка М*
        private void buttonMMult_Click(object sender, EventArgs e)
        {
            _c.M_Multiplication(TryExecuteExpression());
        }

        //кнопка М/
        private void buttonMDiv_Click(object sender, EventArgs e)
        {
            _c.M_Division(TryExecuteExpression());
        }

        //кнопка МRC
        private void buttonMRC_Click(object sender, EventArgs e)
        {
                k++;

                if (k == 1)
                    labelNumber.Text = _c.MemoryShow().ToString();

                if (k == 2)
                {
                    _c.Memory_Clear();
                    labelNumber.Text = "0";

                    k = 0;
                }
        }

        private void LParan_Click(object sender, EventArgs e)
        {
            labelNumber.Text += '(';
        }

        private void RParan_Click(object sender, EventArgs e)
        {
            labelNumber.Text += ')';
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Cos");
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Sin");
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Tan");
        }

        private void Acos_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Acos");
        }

        private void Asin_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Asin");
        }

        private void Atan_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Atan");
        }

        private void Log_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Log");
        }

        private void Ln_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Ln");
        }

        private void Proc_Click(object sender, EventArgs e)
        {
            SetLabelNumberFunction("Proc");
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "pi";
            CorrectNumber();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "e";
            CorrectNumber();
        }

        private void РежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Location = new Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2 + 50,
                (Screen.PrimaryScreen.Bounds.Height - Height) / 2+100);
        }

    }
}
