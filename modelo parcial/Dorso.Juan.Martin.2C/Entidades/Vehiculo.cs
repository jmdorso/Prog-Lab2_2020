using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region atributos
        protected DateTime ingreso;
        private string patente;
        #endregion

        #region propiedad
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length <= 6)
                {
                    this.patente = value;
                }
            }
        }
        #endregion

        #region constructor
        public Vehiculo(string patente)
        {
            Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        #endregion

        #region Metodos
        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("PATENTE {0}",this.patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine(this.ToString());
            auxRetorno.AppendLine($"INGRESO : {this.ingreso}\r");

            return auxRetorno.ToString();
        }
        #endregion

        #region operadores
        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return (vehiculoUno.patente == vehiculoDos.patente && vehiculoUno.Equals(vehiculoDos));
        }

        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return !(vehiculoUno.patente == vehiculoDos.patente && (vehiculoUno.Equals(vehiculoDos)));
        }
        #endregion
    }
}
