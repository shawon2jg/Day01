using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter The Number:");
            num = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if ((i%2)==0)
                {
                    Console.WriteLine(i); 
                }
            }
            Console.ReadKey();
        }
    }
}