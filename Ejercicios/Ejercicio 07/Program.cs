using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";
            DateTime fechaIngresadaUsuario;//variable formato fecha con horario
            DateTime hoy;//variable formato fecha con horario
            TimeSpan diasTranscurridos;//representa un intervalo de tiempo
            Console.WriteLine("Ingrese fecha de nacimiento (DD/MM/AA): ");
            string cadena = Console.ReadLine();
            DateTime.TryParse(cadena, out fechaIngresadaUsuario);//para convertir
            Console.WriteLine("La fecha de nacimiento es: {0}/{1}/{2}", fechaIngresadaUsuario.Day,fechaIngresadaUsuario.Month,fechaIngresadaUsuario.Year);//MUESTRO ASI PARA OCULTAR LA HORA
            hoy = DateTime.Today;//TODAY sin hora. NOW con hora
            Console.WriteLine("La fecha de hoy es: {0}/{1}/{2}", hoy.Day,hoy.Month,hoy.Year);//MUESTRO ASI PARA OCULTAR LA HORA
            diasTranscurridos = hoy - fechaIngresadaUsuario;
            Console.WriteLine("\nEntre el {0}/{1}/{2} y el {3}/{4}/{5} hay esta cantidad de dias: {6}",fechaIngresadaUsuario.Day,fechaIngresadaUsuario.Month,fechaIngresadaUsuario.Year, hoy.Day, hoy.Month,hoy.Year, diasTranscurridos.Days);//MUESTRO ASI PARA OCULTAR LA HORA
            Console.ReadLine();
        }
    }
}
