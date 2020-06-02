using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un dia de la semana");
            string dia = Console.ReadLine();



            if (dia == "sabado" || dia == "domingo") {

                Console.WriteLine("Es fin de semana");

               
            }
            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("Es dia de semana");
            }
            if (dia != "lunes" && dia != "martes" && dia != "miercoles" && dia != "jueves" && dia != "viernes" && dia != "sabado" && dia != "domingo")
            {
                Console.WriteLine("Error");
            }





        }
    }
}
