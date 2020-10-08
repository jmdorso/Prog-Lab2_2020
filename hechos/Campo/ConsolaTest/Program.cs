using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_RodrigoNovas;
namespace ConsolaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rodrigo Novas";

            // Mi central
            Campo campo;
            
            campo = new Campo(1500);

            bool pudo = campo + new Cerdo("Pegy", 300);
            pudo = campo + new Cerdo("Babe", 250);
            pudo = campo + new Vaca("Rosalinda", 450, Vaca.Clasificacion.Lechera);
            pudo = campo + new Vaca("Lola", 325);
            pudo = campo + new Caballo("Secretariat", 175, true);
            if (!(campo + new Caballo("BoJack", 1, false)))
            {
                Console.WriteLine("ERROR!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(campo.ToString());
            }

            Console.ReadKey();
        }
    }
}
