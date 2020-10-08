using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable: Persona
    {
        private EParentesco parentesco;
        private string telefono;

        #region Propiedades
        /// <summary>
        /// retorna el parentesco, setea el parentesco
        /// </summary>
        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }
        /// <summary>
        /// retorna el telefomo, setea el telefono
        /// </summary>
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        #endregion

        #region constructor
        /// <summary>
        /// Pide todos sus atributos y los setea
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="dni"></param>
        /// <param name="female"></param>
        /// <param name="parentesco"></param>
        /// <param name="telefono"></param>
        public Responsable(string name, string lastName, int dni, bool female,EParentesco parentesco, string telefono):base(name,lastName,dni,female)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos del responsable del alumno en pantalla
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DATOS DEL RESPONSABLE: \n");
            mensaje.AppendLine($"Parentesco: {this.Parentesco}");
            mensaje.AppendLine($"Responsable: \n " + base.ToString());
            mensaje.AppendLine($"Telefono: {this.telefono}");
            

            return mensaje.ToString();
        }
        #endregion
    }
}
