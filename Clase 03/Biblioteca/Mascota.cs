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

        public string MostrarMascota()
        {
            StringBuilder stringBuilder = new StringBuilder();//UNA FORMA DE CREAR TEXTO ORGANIZADO;
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            stringBuilder.AppendLine($"Especie: {this.especie}");

            return stringBuilder.ToString();
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;

            int edad = hoy.Year - this.fechaNacimiento.Year;

            return edad;
        }

    }
}
