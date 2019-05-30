// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;

namespace calculator.Converter
{
    public class Converting
    {
        public static double SI(string input1, string input2)
        {
            double value1 = 0;
            double value2 = 0;
            if (input1.Contains("Метры"))
                value1 = 1;
            if (input1.Contains("Кило"))
                value1 = Math.Pow(10, 3);
            if (input1.Contains("Деци"))
                value1 = Math.Pow(10, -1);
            if (input1.Contains("Санти"))
                value1 = Math.Pow(10, -2);
            if (input1.Contains("Милли"))
                value1 = Math.Pow(10, -3);
            if (input1.Contains("Микро"))
                value1 = Math.Pow(10, -6);
            if (input1.Contains("Нано"))
                value1 = Math.Pow(10, -9);
            if (input1.Contains("Пико"))
                value1 = Math.Pow(10, -12);
            if (input1.Contains("Гектары"))
                value1 = Math.Pow(10, 4);
            if (input1.Contains("Ары"))
                value1 = Math.Pow(10, 2);
            if (input1.Contains("Мили"))
                value1 = 1609.344;
            if (input1.Contains("Ярды"))
                value1 = 0.9144;
            if (input1.Contains("Футы"))
                value1 = 0.3048;
            if (input1.Contains("Дюймы"))
                value1 = 0.0254;
            if (input1.Contains("Литры"))
                value1 = Math.Pow(10, -3);
            if (input1.Contains("Километры в час"))
                value1 = 0.27778;
            if (input1.Contains("Узлы"))
                value1 = 0.51444;
            if (input1.Contains("Мили в час"))
                value1 = 0.44704;

            if (input2.Contains("Метры"))
                value2 = 1;
            if (input2.Contains("Кило"))
                value2 = Math.Pow(10, 3);
            if (input2.Contains("Деци"))
                value2 = Math.Pow(10, -1);
            if (input2.Contains("Санти"))
                value2 = Math.Pow(10, -2);
            if (input2.Contains("Милли"))
                value2 = Math.Pow(10, -3);
            if (input2.Contains("Микро"))
                value2 = Math.Pow(10, -6);
            if (input2.Contains("Нано"))
                value2 = Math.Pow(10, -9);
            if (input2.Contains("Пико"))
                value2 = Math.Pow(10, -12);
            if (input2.Contains("Гектары"))
                value2 = Math.Pow(10, 4);
            if (input2.Contains("Ары"))
                value2 = Math.Pow(10, 2);
            if (input2.Contains("Мили"))
                value2 = 1609.344;
            if (input2.Contains("Ярды"))
                value2 = 0.9144;
            if (input2.Contains("Футы"))
                value2 = 0.3048;
            if (input2.Contains("Дюймы"))
                value2 = 0.0254;
            if (input2.Contains("Литры"))
                value2 = Math.Pow(10, -3);
            if (input2.Contains("Километры в час"))
                value2 = 0.27778;
            if (input2.Contains("Узлы"))
                value2 = 0.51444;
            if (input2.Contains("Мили в час"))
                value2 = 0.44704;

            if (input1.Contains("Квадратные"))
                value1 = Math.Pow(value1, 2);

            if (input2.Contains("Квадратные"))
                value2 = Math.Pow(value2, 2);

            if (input1.Contains("Кубические"))
                value1 = Math.Pow(value1, 3);

            if (input2.Contains("Кубические"))
                value2 = Math.Pow(value2, 3);

            var value = value1 / value2;

            return value;
        }

        public static double Mass(string input1, string input2)
        {
            double value1 = 0;
            double value2 = 0;
            if (input1.Contains("Грамм"))
                value1 = 1;
            if (input1.Contains("Кило"))
                value1 = Math.Pow(10, 3);
            if (input1.Contains("Милли"))
                value1 = Math.Pow(10, -3);
            if (input1.Contains("Микро"))
                value1 = Math.Pow(10, -6);
            if (input1.Contains("Тонна"))
                value1 = Math.Pow(10, 6);
            if (input1.Contains("Центнер"))
                value1 = Math.Pow(10, 5);
            if (input1.Contains("Фунт"))
                value1 = 453.59237;
            if (input1.Contains("Унция"))
                value1 = 28.3495231;

            if (input2.Contains("Грамм"))
                value2 = 1;
            if (input2.Contains("Кило"))
                value2 = Math.Pow(10, 3);
            if (input2.Contains("Милли"))
                value2 = Math.Pow(10, -3);
            if (input2.Contains("Микро"))
                value2 = Math.Pow(10, -6);
            if (input2.Contains("Тонна"))
                value2 = Math.Pow(10, 6);
            if (input2.Contains("Центнер"))
                value2 = Math.Pow(10, 5);
            if (input2.Contains("Фунт"))
                value2 = 453.59237;
            if (input2.Contains("Унция"))
                value2 = 28.3495231;

            var value = value1 / value2;

            return value;
        }

        public static double Temp(string input1, string input2, double value1)
        {
            double value = 0;

            if (input1.Contains("Кельвин") && input2.Contains("Цельсий"))
                value = value1 - 273.15;

            if (input1.Contains("Кельвин") && input2.Contains("Фаренгейт"))
                value = value1 * 1.8 - 459.67;

            if (input1.Contains("Цельсий") && input2.Contains("Кельвин"))
                value = value1 + 273.15;

            if (input1.Contains("Цельсий") && input2.Contains("Фаренгейт"))
                value = value1 * 1.8 + 32;

            if (input1.Contains("Фаренгейт") && input2.Contains("Кельвин"))
                value = (value1 + 459.67) / 1.8;

            if (input1.Contains("Фаренгейт") && input2.Contains("Цельсий"))
                value = (value1 - 32) / 1.8;

            return value;
        }
    }
}
