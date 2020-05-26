using System;

namespace el_mayor_es
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un entero de dos cifras");
            int entero = int.Parse(Console.ReadLine());

            int n1 = entero / 10;
            int n2 = entero %10;
            
            if (n1 > n2)
            {

                Console.WriteLine($"{n1} es mayor que {n2}");

            }
            else { Console.WriteLine($"{n2} es mayor que {n1}"); }

        }
    }
}
