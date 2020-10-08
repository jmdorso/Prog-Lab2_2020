using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula: IMensaje<Aula>
    {
        private EColores colorSala;
        private List<Alumno> listaAlumnos;
        private Docente docente;
        private ETurno turno;

        #region Constructores
        /// <summary>
        /// Inicializa la lista de alumnos.
        /// </summary>
        public Aula()
        {
            
        }
        public Aula(EColores colorSalon, Docente docente, ETurno turno):this()
        {
            this.colorSala = colorSalon;
            this.docente = docente;
            this.turno = turno;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// retorna y setea el color de la sala
        /// </summary>
        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }
        /// <summary>
        /// retorna y setea el docente
        /// </summary>
        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }
        /// <summary>
        /// retorna y setea el turno
        /// </summary>
        public ETurno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        /// <summary>
        ///  retorna y setea a lista de almunos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.listaAlumnos; }
            set { this.listaAlumnos = value; }
        }

        public Aula Objeto
        {
            get { return this; }
            set { this.docente = value.docente; }
        }
        #endregion

        #region Sobrecarga de operador +

        public static bool operator +(Aula aula, Alumno alumno)
        {
            bool retorno = false;

            if (aula.Alumnos.Count < 30)
            {
                foreach (Alumno alumno1 in aula.Alumnos)
                {
                    if (alumno == alumno1)
                    {
                        break;
                    }
                }
                retorno = true;

            }
            if (retorno==true)
            {
                aula.Alumnos.Add(alumno);
            }
            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sala Color :" + ColorSala);
            sb.Append("  -  Turno : " + Turno);
            sb.Append("  -  Docente : " + Docente.MostrarPersona());
            
            return sb.ToString();
        }
        public string MostrarAula()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Alumnos: " + Alumnos.ToString());
            return sb.ToString();
        }

        public string Mostrar()
        {
            return this.ToString();
        }

        #endregion




    }
}
