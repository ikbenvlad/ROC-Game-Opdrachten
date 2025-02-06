using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Min(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Mod(int a, int b)
        {
            return a % b;
        }
    }
}
