using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota("Salem", new DateTime(1990, 01, 20),"gato");
            Mascota mascota2 = new Mascota("Fatiga", new DateTime(2000, 02, 18), "perro");
            Mascota mascota3 = new Mascota("Perry", new DateTime(2006, 03, 05), "ornitorrinco");
            Mascota mascota4 = new Mascota("Golden", new DateTime(1994, 04, 26), "perro");

            Console.WriteLine(mascota1.MostrarMascota());
            Console.WriteLine(mascota2.MostrarMascota());
            Console.WriteLine(mascota3.MostrarMascota());
            Console.WriteLine(mascota4.MostrarMascota());

            Console.WriteLine($"{mascota1} tiene {mascota1.CalcularEdad()} años");//CREAR SET Y GET
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
