using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepositorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite un numero");
            int var1 = int.Parse(Console.ReadLine());
            if (var1 % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }

            else
            {
                Console.WriteLine("el numero es impar");
            }

            Console.ReadKey();

        }
    }
}
