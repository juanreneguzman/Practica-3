using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero entero");

            int numero = Int32.Parse(Console.ReadLine());



             numero = numero %= 2;

            if (numero == 0) 
            {
                Console.WriteLine("El numero es par");

            }
            else { Console.WriteLine("El numero es impar"); }




        }

        
    }
}
