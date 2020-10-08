using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        #region Campos

        const int MEDIDA = 330;
        protected Tipo tipo;

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor sin parámetro de tipo.
        /// Asigna [Vidrio] como tipo.
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {
            // no hace falta hacer más nada acá
        }

        /// <summary>
        /// Constructor con todos los parámetros de Cerveza
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Retorna todos los datos de una botella de cerveza
        /// [Capacidad] [Contenido] [Marca] [Tipo]
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.ToString() + "\nTipo de botella: " + this.tipo);

            return retorno.ToString();
        }

        /// <summary>
        /// Devuelve el tipo de botella de una cerveza
        /// [Plastico] [Vidrio]
        /// </summary>
        /// <param name="cerveza"></param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        /// <summary>
        /// Retorna lo que puede servir una botella de cerveza.
        /// Sirve el 80% de la medida establecida (para dejar lugar para la espuma).
        /// Si el contenido de la botella es menor igual a la medida, se sirve todo el contenido.
        /// Sino, se sirve la medida.
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            int retorno;
            double medida = MEDIDA * 0.8;

            if ((int)medida <= this.capacidadML)
            {
                // gasto el 80% de la medida constante 
                retorno = this.contenidoML - (int)medida; // devuelvo el contenido que queda para gastar
                this.contenidoML -= (int)medida; // actualizo el contenido que queda en la botella
            }
            else // gasto el contenido
            {
                retorno = this.contenidoML; // sirve todo el contenido que tiene
                this.contenidoML = 0; // la botella queda vacía
            }

            return retorno;
        }

        #endregion
    }
}
