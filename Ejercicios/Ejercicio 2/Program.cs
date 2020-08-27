using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            int numero = 0;
            Console.WriteLine("INGRESE NUMERO");
            string cadena = Console.ReadLine();
            int.TryParse(cadena, out numero);//para convertir
            while(numero <= 0)
            {
                Console.WriteLine("ERROR. REINGRESE NUMERO");
                cadena = Console.ReadLine();
                int.TryParse(cadena, out numero);//para convertir
            }
            Console.WriteLine("El cuadrado es {0} y el cubo es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            Console.ReadKey();
                    

        }
    }
}
