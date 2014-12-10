using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationApp
{
    class ArithmeticOperation
    {
        static void Main(string[] args)
        {
            double num1, num2, add, sub, div, mul;
            Console.Write("Enter First Number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            add = num1 + num2;
            sub = num1 - num2;
            div = num1/num2;
            mul = num1*num2;
            Console.WriteLine("Additional Result:" + add);
            Console.WriteLine("Subtraction Result:" + sub);
            Console.WriteLine("Division Result:" + div);
            Console.WriteLine("Multiplication Result:" + mul);
            Console.ReadKey();
        }
    }
}
