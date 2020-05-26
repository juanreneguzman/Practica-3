using System;
using System.Data;

namespace EJERCICIOS_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UN NUMERO");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE OTRO NUMERO");
            int n2 = int.Parse(Console.ReadLine());

          

            if (n1%n2==0)

            {
                Console.WriteLine($"El numero {n1} es multiplo de {n2}");


                }

            else
            {
                Console.WriteLine("El numero no es multiplo");
            }
        }
    }
}
