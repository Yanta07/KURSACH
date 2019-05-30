// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace calculator
{
    public class Calc
    {
        private double _a = 0;
        private double _memory = 0;

        public void Put_A(double a)
        {
            this._a = a;
        }

        public void Clear_A()
        {
            _a = 0;
        }

        //показать содержимое регистра мамяти
        public double MemoryShow()
        {
            return _memory;
        }

        //стереть содержимое регистра мамяти
        public void Memory_Clear()
        {
            _memory = 0.0;
        }

        //* / + - к регистру памяти
        public void M_Multiplication(double b)
        {
            _memory *= b;
        }

        public void M_Division(double b)
        {
            _memory /= b;
        }

        public void M_Sum(double b)
        {
            _memory += b;
        }

        public void M_Subtraction(double b)
        {
            _memory -= b;
        }

    }
}
