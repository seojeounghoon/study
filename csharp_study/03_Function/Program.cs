using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Function
{

    class Calculator
    {
        public static int Plus(int a , int b)
        {
            return a + b;
        }

        public static int Minus(int a , int b)
        {
            return a - b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Plus(10, 4);
            Console.WriteLine(result);


            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            Console.WriteLine("완료");

        }
    }
}
