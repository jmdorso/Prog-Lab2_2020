using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            int añoInicio;
            int añoFin;
            int contadorAñosBisiestos=0;
            Console.Write("Ingrese el primer año: ");
            string cadena = Console.ReadLine();
            int.TryParse(cadena, out añoInicio);//para convertir
            Console.Write("Ingrese el segundo año: ");
            cadena = Console.ReadLine();
            int.TryParse(cadena, out añoFin);//para convertir
            while(añoFin <= añoInicio)
            {
                Console.Write("ERROR! El segundo año debe ser mayor al primero, reingrese: ");
                cadena = Console.ReadLine();
                int.TryParse(cadena, out añoFin);//para convertir
            }
            Console.Write("\n");
            Console.WriteLine("Años bisiestos desde {0} a {1}",añoInicio,añoFin);
            for (int añoActual=añoInicio;añoActual<=añoFin;añoActual++)
            {
                if(añoActual % 4 == 0)
                {
                    contadorAñosBisiestos++;
                    Console.WriteLine("{0}",añoActual);
                }
            }
            Console.Write("\nEntre el {0} y el {1}, hay {2} años bisiestos", añoInicio,añoFin,contadorAñosBisiestos);
            Console.ReadLine();
        }
    }
}
