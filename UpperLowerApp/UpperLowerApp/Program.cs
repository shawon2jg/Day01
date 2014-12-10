using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int LOWER, UPPER;
            Console.Write("Enter Lower Number:");
            LOWER = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Upper Number:");
            UPPER = Convert.ToInt16(Console.ReadLine());
            for (int i = LOWER; i < UPPER; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
