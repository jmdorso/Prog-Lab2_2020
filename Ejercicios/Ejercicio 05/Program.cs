using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            int numeroUsuario;
            int centroNumerico = 1;
            int sumaAnteriorCentroNumerico;
            int sumaPosteriorCentroNumerico;
            int j;
            int i;
            Console.Write("INGRESE UN NUMERO Y LE MOSTRAREMOS (SI EXISTEN) CENTROS NUMERICOS ENTRE 1 y SU NUMERO: ");
            string cadena = Console.ReadLine();
            int.TryParse(cadena, out numeroUsuario);//para convertir
            while (centroNumerico < numeroUsuario)
            {
                centroNumerico++;
                sumaAnteriorCentroNumerico = 0;
                sumaPosteriorCentroNumerico = 0;
                for(i=1;i<centroNumerico;i++)
                {
                    sumaAnteriorCentroNumerico += i;
                }
                for(j=centroNumerico+1;j<=sumaAnteriorCentroNumerico;j++)
                {
                    if((sumaPosteriorCentroNumerico == sumaAnteriorCentroNumerico) || (sumaPosteriorCentroNumerico > sumaAnteriorCentroNumerico))
                    {
                        break;
                    }
                    sumaPosteriorCentroNumerico += j;
                }
                if(sumaPosteriorCentroNumerico == sumaAnteriorCentroNumerico)
                {

                    Console.WriteLine("\n\tEl #{0} es centro numerico entre el #1 y #{1}", centroNumerico, numeroUsuario);
                    Console.WriteLine("\nLa suma de los numeros anteriores desde #1 hasta #{0} sin incluir es = {1}\nLa suma de los numeros posteriores desde #{0} sin incluir hasta #{2} inclusive es = {3}",centroNumerico, sumaAnteriorCentroNumerico,(j-1),sumaPosteriorCentroNumerico);
                }
            }
            Console.ReadLine();
        }
    }
}
