using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;
        bool flagCarga = false;

        #region Propiedades
        /// <summary>
        /// retorna un legajo, setea un legajo
        /// </summary>
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        /// <summary>
        /// retorna un precio, setea un precio
        /// </summary>
        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }
        /// <summary>
        /// retorna un color de sala, setea un color
        /// </summary>
        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }
        /// <summary>
        /// retorna un responsable del alumno, setea un responsable
        /// </summary>
        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }
        #endregion

        #region constructor
        /// <summary>
        /// Recibe los atributos de la clase padre, y  los setea los valores de los atributos.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="dni"></param>
        /// <param name="female"></param>
        /// <param name="precioCuota"></param>
   
        public Alumno(string name, string lastName, int dni, bool female, float precioCuota) : base(name, lastName, dni, female)
        {
            this.precioCuota = precioCuota;
        }

        /// <summary>
        /// recibe todos sus atributos, y los setea
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="dni"></param>
        /// <param name="female"></param>
        /// <param name="precioCuota"></param>
        /// <param name="legajo"></param>
        /// <param name="responsable"></param>
        /// <param name="colorSala"></param>

        public Alumno(string name, string lastName, int dni, bool female, float precioCuota,int legajo, Responsable responsable, EColores colorSala):this(name,lastName,dni,female,precioCuota)
        {
            this.legajo = legajo;
            this.responsable = responsable;
            this.colorSala = colorSala;
        }
        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Compara a dos alumnos por legajo, si no es null, si no retorna false
        /// </summary>
        /// <param name="alumno1"></param>
        /// <param name="alumno2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            if (!(alumno1 is null) && !(alumno2 is null))
            {
                return alumno1.legajo == alumno2.legajo;
            }
            return false;
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }
        /// <summary>
        /// castea los valores a responsable y lo devuelve al contructor
        /// </summary>
        /// <param name="alumno"></param>
        public static implicit operator Responsable(Alumno alumno)
        {
            return alumno.Responsable;
        }
        /// <summary>
        /// Muestra los datos del alumno en pantalla
        /// </summary>
        /// <returns></returns>
        #endregion

        #region Metodo
        public override string MostrarPersona()
        {

            return "Legajo: " + this.Legajo.ToString() + base.MostrarPersona();
        }
        public string Mostrar(Alumno a)
        {
            return "Legajo: " + a.Legajo + " Color Sala"+a.colorSala+ " Apellido: " + a.Apellido + " Nombre: " + a.Nombre + " Dni: " + a.Dni.ToString() + " Femenino " + a.Femenino + " Precio cuota: " + a.precioCuota.ToString()+ " Responsable" + a.responsable.ToString();
        }
        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DATOS DEL ALUMNO: \n");
            mensaje.AppendLine($"Alumno: \n "+base.ToString());
            mensaje.AppendLine($"Legajo: {this.legajo}");
            mensaje.AppendLine($"Color sala: {this.ColorSala}");
            mensaje.AppendLine($"Responsable del alumno: {this.Responsable.ToString()}");
            mensaje.AppendLine($"Precio de cuota: {this.PrecioCuota}");

            return mensaje.ToString();
        }

        #endregion

    }
}
