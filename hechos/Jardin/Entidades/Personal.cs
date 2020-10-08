using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal:Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;
        

        #region Propiedades
        /// <summary>
        /// retorna y setea la hora de entrada
        /// </summary>
        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }
        /// <summary>
        /// retorna y setea la hora de entrada
        /// </summary>
        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }
        public abstract double Salario { get; }

        #endregion

        #region Constructores
        /// <summary>
        /// setea todos sus atributos
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="dni"></param>
        /// <param name="female"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        protected Personal(string name, string lastName, int dni, bool female, DateTime horaEntrada, DateTime horaSalida):base(name, lastName,dni,female)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// metodo que obliga implementar a sus clases hijas
        /// </summary>
        /// <returns></returns>
        protected abstract double CalcularSalario();
        /// <summary>
        /// muestra los datos del personal
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DATOS DEL PERSONAL: \n");
            mensaje.AppendLine($"Personal: \n " + base.ToString());
            mensaje.AppendLine($"Hora de entrada: {this.horaEntrada}");
            mensaje.AppendLine($"Hora de salida: {this.horaSalida}");

            return mensaje.ToString();
        }

        #endregion





    }
}
