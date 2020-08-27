using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            int numeroActual;
            int divisor;
            int contadorDeNumPerfectos = 0;
            int acumDivisores = 0;
            for(numeroActual=1; contadorDeNumPerfectos < 4;numeroActual++)
            {
                acumDivisores = 0;
                for(divisor=1; divisor<numeroActual;divisor++)
                {
                    if (numeroActual % divisor == 0)
                    {
                        acumDivisores += divisor;
                    }
                }
                if (acumDivisores == numeroActual)
                {
                    contadorDeNumPerfectos++;
                    Console.WriteLine("El numero {0} es un numero perfecto, ya que la suma de sus divisores da {1}", numeroActual, acumDivisores);
                }
            }
            Console.ReadKey();
        }
            
    }
}
