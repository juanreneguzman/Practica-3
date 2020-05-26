using System;

namespace EJERCICIO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UN NUMERO ENTERO");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1>0 && n2>0)
            {
                Console.WriteLine("LOS DOS NUMEROS SON POSITIVOS");

            }
            if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine("LOS DOS NUMEROS SON NEGATIVOS");

            }

            if (n1>0 || n2 > 0)
            {
                Console.WriteLine("Uno de los numeros es positivo");
            }

        }
    }
}
