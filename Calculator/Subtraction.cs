using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Subtraction : ISubtraction
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

        public Subtraction(double a, double b)
        {
            A = a;
            B = b;
        }

        // Метод без параметров использует внутренние переменные A и B
        public double Subtract()
        {
            return A - B;
        }
    }
}
