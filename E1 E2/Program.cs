using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es el precio del producto");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("1- para efectivo 2- para tarjeta");
            int a = int.Parse(Console.ReadLine());

            if (a== 1) {
                Console.WriteLine("Gracias por su compra");

            
            }
            else
            {
                Console.WriteLine("Digite el numero de 12 digitos de su targeta");
                long b = long.Parse(Console.ReadLine());
                
                Console.WriteLine("gracias por su compra");
            }

        }
    }
}
