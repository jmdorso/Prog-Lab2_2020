using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int numero = 0;
            int acum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            double promedio;
            int i;

            for(i=0;i<5;i++)
            {
                Console.WriteLine("INGRESE NUMERO");
                string cadena = Console.ReadLine();
                int.TryParse(cadena, out numero);//para convertir
                acum = numero + acum;
                if (max < numero) 
                {
                    max = numero;
                }
                if(min > numero)
                {
                    min = numero;
                }
            }
            Console.WriteLine("El Numero Maximo es: {0}", max);
            Console.WriteLine("El Numero Minimo es: {0}", min);
            promedio = (double)acum / i;
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);
            Console.ReadKey();

        }
    }
}
