using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numeroADividir, numeroQueDivide;
            int contadorDeNumPrimos = 0;
            int numero = 0;
            int resto = 0;

            Console.Write("INGRESE UN NUMERO Y LE MOSTRAREMOS TODOS LOS NUMEROS PRIMOS HASTA SU ELECCION: ");
            string cadena = Console.ReadLine();
            int.TryParse(cadena, out numero);//para convertir
            if (numero < 0)
            {
                Console.WriteLine("\nLos numoros negativos no son primos");
            }
            else if(numero < 2)
            {
                Console.WriteLine("\nNo existen numeros primos antes que el {0}",numero);
            }
            else
            {
                Console.WriteLine("\nLista de numeros primos hasta el {0}\n", numero);
                for (numeroADividir = 2; numeroADividir <= numero; numeroADividir++)
                {
                    for (numeroQueDivide = 1; numeroQueDivide <= numeroADividir; numeroQueDivide++)
                    {
                        if (numeroADividir % numeroQueDivide == 0)
                        {
                            resto++;
                        }
                      
                    }
                    if(resto == 2)
                    {
                        Console.WriteLine("#{0}", numeroADividir);
                        contadorDeNumPrimos++;
                        resto = 0;
                    }
                    resto = 0;
                }
                Console.WriteLine("\n\tHay {0} numeros primos hasta el # {1}", contadorDeNumPrimos, numero);
            }
            Console.ReadKey();
        }
    }
}
