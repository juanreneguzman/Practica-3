using System;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            long usu1 = 40215094893;
            int usu1C = 000523;
            long usu2 = 05400832027;
            int usu2C = 270277;
            long usu3 = 00163874632;
            int usu3C = 010199;
            long usu4 = 40237649284;
            int usu4C = 12345678;

            Console.WriteLine("Ingrese su usuario ");
            long respId = long.Parse(Console.ReadLine());
            Console.WriteLine("contraseña");
            int respCl = int.Parse(Console.ReadLine());


            while ((respId != usu1 || respCl != usu1C) && (respId != usu2 || respCl != usu2C) && (respId != usu3 || respCl != usu3C))
            {


                if (respId == usu4 && respCl == usu4C)
                {

                    Console.WriteLine("Usuario inactivo");
                    Console.WriteLine("Ingrese su usuario ");
                    respId = long.Parse(Console.ReadLine());
                    Console.WriteLine("contraseña");
                    respCl = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("CREDENCIALES INCORRECTAS");
                    Console.WriteLine("Ingrese su usuario ");
                    respId = long.Parse(Console.ReadLine());
                    Console.WriteLine("contraseña");
                    respCl = int.Parse(Console.ReadLine());
                }

            }

            if (respId == usu1 && respCl == usu1C)
            {
                Console.WriteLine($"ACTIVO\n Bienvenido Juan Rene Guzman\n  Iniciaste con el usuario {usu1} y tu rol es Administrados");
            }
            else if (respId == usu2 && respCl == usu2C)
            {
                Console.WriteLine($"ACTIVO\n Bienvenida Angela Nuñez\n  Iniciaste con el usuario {usu2} y tu Rol es Supervisor Gral");
            }
            else if (respId == usu3 && respCl == usu3C)
            {
                Console.WriteLine($"ACTIVO\n Bienvenido Alberto Alcantara\n Iniciar con el usuario {usu3} y tu rol es Vendedor");
            }

           


        }


    }
    
}
