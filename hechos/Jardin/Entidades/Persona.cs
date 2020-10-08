using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

        private string nombre;
        private string apellido;
        private int dni;
        private bool femenino;

        #region Propiedades

        /// <summary>
        /// retorna y nombre, y setea el nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        /// <summary>
        /// retorna el apellid, setea el apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        /// <summary>
        /// retorna el dni, setea el dni
        /// </summary>
        public int Dni
        {
            
            get { 
                return this.dni; }
            set {
                ValidarPersonasSinDni(value);
                this.dni = value; }
        }
        /// <summary>
        /// retorna true o false en caso de que lo sea, lo setea
        /// </summary>
        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }
        #endregion

        #region Constructores
   
        protected Persona(string name, string lastName, int dni)
        {
            this.nombre = name;
            this.apellido = lastName;
            this.dni = dni;
        }
        protected Persona(string name, string lastName, int dni, bool female):this(name, lastName, dni)
        {
            this.femenino = female;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// Muestra los datos de una persona
        /// </summary>
        /// <returns></returns>
        public virtual string ToString()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"Apellido: {this.apellido}");
            mensaje.AppendLine($"DNI: {this.Dni}");
            if (Femenino == true)
            {
                mensaje.AppendLine("Sexo: Femenino");
            }
            else
            {
                mensaje.AppendLine("sexo: Masculino");
            }
            return mensaje.ToString();
        }
        public virtual string MostrarPersona()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append(" " + Apellido.ToString());
            mensaje.AppendLine(", " + Nombre.ToString());
            mensaje.AppendLine(", " + Dni.ToString());

            return mensaje.ToString();
        }
        public void ValidarPersonasSinDni(int value)
        {
            if (value < 1000000)
            {
                throw new PersonaSinDni("DNI Incorrecto");
            }
        }
        #endregion

    }
}
