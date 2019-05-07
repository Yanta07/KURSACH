﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //интерфейс
    public interface InterfaceCalc
    {
        //а - первый аргумент, b - второй
        void Put_A(double a); //сохранить а

        void Clear_A();

        double Multiplication(double b);

        double Division(double b);

        double Sum(double b);

        double Subtraction(double b); //вычитание

        double SqrtX(double b);

        double DegreeY(double b);

        double Sqrt();

        double Square();

        double Factorial();

        double MemoryShow(); //показать содержимое регистра мамяти

        void Memory_Clear(); //стереть содержимое регистра мамяти

        //* / + - к регистру памяти
        void M_Multiplication(double b);

        void M_Division(double b);

        void M_Sum(double b);

        void M_Subtraction(double b); //вычитание
    }
}
