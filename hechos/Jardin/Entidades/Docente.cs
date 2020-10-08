using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal, IMensaje<Docente>
    {
        private double valorHora;

        #region Propiedades
        /// <summary>
        /// Calcula las horas trabajadas del mes, y lo retorna
        /// </summary>
        public int HorasMensuales
        {
            get 
            {
                TimeSpan horasTrabajadas = new TimeSpan();
                horasTrabajadas = this.HoraSalida.Subtract(this.HoraEntrada);
                int horasMensuales = (int)horasTrabajadas.Hours * 20;
                return horasMensuales;
            }
        }
        /// <summary>
        /// retorna y setea el valor de la hora
        /// </summary>

        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }
        /// <summary>
        /// retorna el calculo del salario
        /// </summary>
        public override double Salario
        {
            get { return this.CalcularSalario(); }
        }

        public Docente Objeto
        {
            get { return this; }
            set { this.Dni = value.Dni; }
        }

    #endregion

    #region Constructor
    public Docente(string name, string lastName, int dni, bool female, DateTime horaEntrada, DateTime horaSalida, double valorHora):base(name, lastName, dni,female,horaEntrada,horaSalida)
        {
            this.valorHora = valorHora;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// calcula el salario, multiplicando valor de hora por horas trabajadas del mes y retorna un double
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            return (double)HorasMensuales * valorHora;
        }
        /// <summary>
        /// muestra los datos del docente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DATOS DEL DOCENTE: \n");
            mensaje.AppendLine($"Docente: \n " + base.ToString());
            mensaje.AppendLine($"Valor hora: {this.valorHora}");
            mensaje.AppendLine($"Salario: {this.CalcularSalario()}");

            return mensaje.ToString();
        }
        public string Mostrar(Docente a)
        {
            return " Apellido: " + a.Apellido + " Nombre: " + a.Nombre + " Dni: " + a.Dni.ToString();
        }

        public string Mostrar()
        {
            return this.ToString();
        }

        //public static explicit operator Docente(List<string> v)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
    }
}
