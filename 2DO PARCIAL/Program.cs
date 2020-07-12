using System;
using System.Globalization;

namespace _2DO_PARCIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a las votaciones 2020 \n 1: iniciar el proceso de votacion\n 2:perfil del candidato ");
            int resp = int.Parse(Console.ReadLine());
            int gc = 0;
            int la = 0;
            int lf = 0;
            int dc = 0;
            int cont = 0;
 
            if (resp == 1)
            {
                while (cont <= 999)
                {
                    cont = cont + 1;

                    Random ran = new Random();
                    int ram = ran.Next(1, 5);

                    if (ram == 1) gc = gc + 1;
 
                    else if (ram == 2) la = la + 1;

                    else if (ram == 3) lf = lf + 1;
 
                    else if (ram == 4) dc = dc + 1;
                }
                double por1 = gc  *100 /1000 ;
                double por2 = la * 100 / 1000;
                double por3 = lf * 100 / 1000;
                double por4 = dc * 100 / 1000;

                Console.WriteLine("Juan Rene Guzman acumulo " + gc + " con un porcentaje de " + por1);
                Console.WriteLine("Jhon David Mesa acumulo " + la + " con un porcentaje de " + por2);
                Console.WriteLine("Angela Nuñez " + lf + " con un porcentaje de " + por3);
                Console.WriteLine("joaquin Acevedo acumulo " + dc + " con un porcentaje de " + por4);

            }
            else if (resp ==2)
            {

                Console.WriteLine("Perfiles de candidatos \n 1: Juan Rene Guzman\n 2: Jhon David Mesa\n 3: Angela Nuñez\n 4: Joaquin Acevedo" );
                int res = int.Parse(Console.ReadLine());
                
                if (res == 1) Console.WriteLine("Juan Rene Guzman. Es miembro del Partido Opositor Dominicano (POD) creado en abril del 1982 al cual aspira a presidente ");

                else if (res == 2) Console.WriteLine("Jhon David Mesa. Es miembro del Partido Los Lince (PLL) creado en agosto del 2010 al cual aspira a presidente ");

                else if (res == 3) Console.WriteLine("Angela Nuñez. Es miembro del partido Femenino Dominicano (PFD) creado en julio del 2015 al cual aspira a presidente ");

                else if (res == 4) Console.WriteLine("Joaquin Acevedo. Es miembro del partido Verde (PD) creadod en diciembre del 2007 al cual aspira a presidente ");

            }

        }
    }
}
