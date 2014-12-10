using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count, num1 = 0, num2 = 1, num3;
            Console.Write("Enter The Limit : ");
            count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (i = 0; i <= count; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
            Console.ReadKey();
        }
    }
}
