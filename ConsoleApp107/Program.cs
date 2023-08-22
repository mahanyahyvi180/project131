using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.Write($"{counter}");
                ++counter;
            } while (counter <= 10);

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
