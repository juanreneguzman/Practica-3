using System;

namespace tarea_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro numero");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 != 0)
            {

                Console.WriteLine($"El resultado es {n1/n2}");

            }
            else { Console.WriteLine("Error: no se puede dividir entre 0"); }
        }

    }
}
