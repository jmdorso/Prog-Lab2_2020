using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Administrativa:Personal
    {
        private ECargo cargo;
        public static double salarioBase;

        #region Propiedades
        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public override double Salario
        {
            get { return this.CalcularSalario(); }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Setea el salario base en 3000
        /// </summary>
        static Administrativa()
        {
            Administrativa.salarioBase = 3000;
        }
        /// <summary>
        /// recibe todos los atributos y los setea
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="dni"></param>
        /// <param name="female"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="salarioBase"></param>
        public Administrativa(string name, string lastName, int dni, bool female, DateTime horaEntrada, DateTime horaSalida, double salarioBase, ECargo cargo) :base(name,lastName,dni,female,horaEntrada,horaSalida)
        {
            Administrativa.salarioBase = salarioBase;
            this.cargo = cargo;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// Calcula el salario de los empleados, multiplicando por su porcentaje correspondiente y lo divide 
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            return Administrativa.salarioBase * (double)this.cargo / 100;
        }
        /// <summary>
        /// muestra los datos del personal administrativo
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DATOS DEL EMPLEADO DE ADMINISTRATIVA: \n");
            mensaje.AppendLine($"Empleado: \n " + base.ToString());
            mensaje.AppendLine($"Cargo: {this.cargo}");
            mensaje.AppendLine($"Salario Base: {Administrativa.salarioBase}");
            mensaje.AppendLine($"Salario Total: {this.CalcularSalario()}");

            return mensaje.ToString();
        }
        #endregion



    }
}
