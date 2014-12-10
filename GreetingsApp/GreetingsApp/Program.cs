using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hi " + name + " Good Day.");
            Console.ReadKey();
        }
    }
}
