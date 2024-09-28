﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiplaction : IMultiplaction
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Multiplaction(double a, double b)
        {
            A = a;
            B = b;
        }

        // Реализация метода Multiply из интерфейса IMultiplication
        public double Multiply(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        // Метод без параметров использует внутренние переменные A и B
        public double Multiply()
        {
            return A * B;
        }
    }
}
