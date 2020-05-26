using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UN NUMERO");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 4 == 0) {

                Console.WriteLine("el numero es multiplo de 4");

            }
            if (n1 % 5 == 0)
            {
                Console.WriteLine("El numero es multiplo de 5");
            }
        }
    }
}
