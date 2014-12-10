using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSmallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Big number is:" + num1);
                Console.WriteLine("Small number is:" + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Big number is:" + num2);
                Console.WriteLine("Small number is:" + num1);
            }
            else
            {
                Console.WriteLine("Number is equal");
            }
            Console.ReadKey();
        }
    }
}
