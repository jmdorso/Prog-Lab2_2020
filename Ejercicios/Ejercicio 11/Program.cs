using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio_11_Entidades;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int numeroUsuario;
            int sumaNumerosUsuarios = 0;
            int limiteMinimo = -100;
            int limiteMaximo = 100;

            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            double promedio;
            int contador;
            for (contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("INGRESE NUMERO: ");
                string cadena = Console.ReadLine();
                int.TryParse(cadena, out numeroUsuario);//para convertir
                if (Validacion.Validar(numeroUsuario, limiteMinimo, limiteMaximo))
                {
                    Console.WriteLine("Ingreso {0}", numeroUsuario);
                }
                else
                {
                    Console.WriteLine("Error ingreso numero fuera de rango, le queda una chance.");
                    Console.WriteLine("REINGRESE NUMERO: ");
                    cadena = Console.ReadLine();
                    int.TryParse(cadena, out numeroUsuario);//para convertir
                    if (Validacion.Validar(numeroUsuario, limiteMinimo, limiteMaximo))
                    {
                        Console.WriteLine("Ingreso {0}", numeroUsuario);
                    }
                    else
                    {
                        Console.WriteLine("Error, no podra seguir ingresando. Le devolveremos el promedio de lo ingresado hasta el momento");
                        break;
                    }
                }
                sumaNumerosUsuarios = numeroUsuario + sumaNumerosUsuarios;
                if (maximo < numeroUsuario)
                {
                    maximo = numeroUsuario;
                }
                if (minimo > numeroUsuario)
                {
                    minimo = numeroUsuario;
                }
            }
            Console.WriteLine("El Numero Maximo es: {0}", maximo);
            Console.WriteLine("El Numero Minimo es: {0}", minimo);
            promedio = (double)sumaNumerosUsuarios / contador;
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);
            Console.ReadKey();



             Console.ReadKey();
        }
    }
}
