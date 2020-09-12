using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;
        
        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public string MostrarMascota()
        {
            StringBuilder stringBuilder = new StringBuilder();//UNA FORMA DE CREAR TEXTO ORGANIZADO;
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            stringBuilder.AppendLine($"Especie: {this.especie}");

            return stringBuilder.ToString();

            /*StringBuilder stringBuilder = new StringBuilder();

            // Con AppendFormat() y \n
            stringBuilder.AppendFormat("Nombre: {0}\n", this.nombre.ToUpper());

            // Con AppendLine() y Template Strings
            stringBuilder.AppendLine($"Fecha de Nacimiento (custom): {this.fechaNacimiento.ToString("dd - MM - yyyy")}");
            stringBuilder.AppendLine($"Fecha de Nacimiento (corta): {this.fechaNacimiento.ToShortDateString()}");
            stringBuilder.AppendLine($"Fecha de Nacimiento (larga): {this.fechaNacimiento.ToLongDateString()}");

            // Con AppendLine() y string.Format()
            stringBuilder.AppendLine(String.Format("Especie: {0}", this.especie));

            return stringBuilder.ToString();*/
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;

            int edad = hoy.Year - this.fechaNacimiento.Year;

            if (this.fechaNacimiento.AddYears(edad) > hoy)
            {
                edad--;
            }

            return edad;
        }

    }
}
