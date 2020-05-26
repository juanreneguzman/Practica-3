using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UN NUMERO ENTERO");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 10 == 0)
            {
                Console.WriteLine("El numero es multiplo de 10. Digite otro numero");
                int n2 = int.Parse(Console.ReadLine());

                if (n2 % 10 == 0)
                {
                    Console.WriteLine($"El numero {n2} tambien es multiplo de 10");

                }
            }

            else
            {
                Console.WriteLine($"EL numero {n1} no es multiplo de 10");
            }
        }  

    }
}
