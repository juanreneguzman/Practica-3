using System;

namespace EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UN NUMERO");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 == 0)
            {
                Console.WriteLine(" El producto de 0 por cualquier número es 0 ");
            }
            else
            {
                Console.WriteLine("DIGITE UN SEGUNDO NUMERO");
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 * n2;

                Console.WriteLine($"El producto es {resultado}");
            }
        }

    }
}
