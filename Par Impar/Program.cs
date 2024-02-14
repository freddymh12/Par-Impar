using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int num = int.Parse(Console.ReadLine());

            if (Par(num))
            {
                Console.WriteLine($"{num} es un número par.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{num} es un número impar.");
                Console.ReadKey();
            }
        }

        static bool Par(int numero)
        {
            return numero % 2 == 0;
        }

    }
}
