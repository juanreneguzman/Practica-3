using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE 3 NUMEROS");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            
            if (n1>n2 || n1 > n3 )
            {
                Console.WriteLine($"El numero {n1} es mayor que {n2} y {n3}");
            }

            if (n2 > n1 || n2 > n3)
            {
                Console.WriteLine($"El numero {n2} es mayor que {n1} y {n3}");
            }

            if (n3 > n1 || n3 > n2)
            {
                Console.WriteLine($"El numero {n3} es mayor que {n1} y {n2}");
            }
        }
    }
}
