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
            int numeroUsuario = 0;
            int sumaNumerosUsuarios = 0;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            double promedio;
            int contador;
            for(contador=0;contador<5;contador++)
            {
                Console.WriteLine("INGRESE NUMERO");
                string cadena = Console.ReadLine();
                int.TryParse(cadena, out numeroUsuario);//para convertir
                sumaNumerosUsuarios = numeroUsuario + sumaNumerosUsuarios;
                if (maximo < numeroUsuario) 
                {
                    maximo = numeroUsuario;
                }
                if(minimo > numeroUsuario)
                {
                    minimo = numeroUsuario;
                }
            }
            Console.WriteLine("El Numero Maximo es: {0}", maximo);
            Console.WriteLine("El Numero Minimo es: {0}", minimo);
            promedio = (double)sumaNumerosUsuarios / contador;
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);
            Console.ReadKey();

        }
    }
}
