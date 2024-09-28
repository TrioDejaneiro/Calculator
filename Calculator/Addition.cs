using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition: IAddition
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

        public Addition(double a, double b)
        {
            A = a;
            B = b;
        }

        // Метод без параметров использует внутренние переменные A и B
        public double Add()
        {
            return A + B;
        }
    }
}
