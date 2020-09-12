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
            // Instanciar las 4 mascotas
            Mascota mascota1 = new Mascota("Salem", new DateTime(1990, 01, 20),"gato");
            Mascota mascota2 = new Mascota("Fatiga", new DateTime(2000, 02, 18), "perro");
            Mascota mascota3 = new Mascota("Perry", new DateTime(2006, 03, 05), "ornitorrinco");
            Mascota mascota4 = new Mascota("Golden", new DateTime(1994, 04, 26), "perro");

            // Mostrar en consola utilizando el método MostrarDatos que devuelve un string, los datos de mascota.
            Console.WriteLine(mascota1.MostrarMascota());
            Console.WriteLine(mascota2.MostrarMascota());
            Console.WriteLine(mascota3.MostrarMascota());
            Console.WriteLine(mascota4.MostrarMascota());

            // Realizar un método que devuelva la edad de la mascota. Usando DateTime (Devuelve un int).
            // Mostrar "{nombre} tiene {edad} años", usando un getter para el nombre y el método que calcula la edad.
            Console.WriteLine($"{mascota1.GetNombre()} tiene {mascota1.CalcularEdad()} años");
            Console.WriteLine($"{mascota2.GetNombre()} tiene {mascota2.CalcularEdad()} años");
            Console.WriteLine($"{mascota3.GetNombre()} tiene {mascota3.CalcularEdad()} años");
            Console.WriteLine($"{mascota4.GetNombre()} tiene {mascota4.CalcularEdad()} años");

            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            Mascota gato = new Mascota("Simba", new DateTime(2015, 10, 8), "Gato");
            Console.WriteLine(gato.MostrarMascota());
            gato.SetNombre("Nala");
            Console.WriteLine(gato.MostrarMascota());

            Console.ReadKey();
        }
    }
}
