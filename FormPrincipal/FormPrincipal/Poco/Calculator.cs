using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Poco
{
    public class Calculator
    {
        public double a { get; set; }
        public double b { get; set; }

        public double Suma()
        {
            return a + b;
        }


        public double Resta()
        {
            return a - b;
        }

        public double Multiplicacion()
        {
            return a * b;
        }

        public double Division()
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

        public double Potencia()
        {
            return Math.Pow(a,b);
        }

        public double Raiz()
        {
            return Math.Pow(a,1/b);
        }
    }
}
