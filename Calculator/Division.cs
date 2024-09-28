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

        // Метод без параметров использует внутренние переменные A и B
        public double Divide()
        {
            if (B == 0)
            {
                return -1;
            }
            return A / B;
        }
    }
}
