using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division : IDivision
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

        public Division(double a, double b)
        {
            A = a;
            B = b;
        }

        // Реализация метода Divide из интерфейса IDivision
        public double Divide(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return operand1 / operand2;
        }

        // Метод без параметров использует внутренние переменные A и B
        public double Divide()
        {
            if (B == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return A / B;
        }
    }
}
