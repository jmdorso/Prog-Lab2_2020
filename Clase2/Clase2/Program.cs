using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades1;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Alumno.Mostrar("Pepe", 23));
            Console.WriteLine(Alumno.Mostrar("Lucas", 23));
            Console.WriteLine(Alumno.Mostrar("Roman", 23));
            Console.ReadKey();
        }
    }
}
