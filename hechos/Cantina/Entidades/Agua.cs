using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        #region Campos

        const int MEDIDA = 400;

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor de Agua que llama al constructor de Botella
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="Marca"></param>
        /// <param name="contenidoML"></param>
        public Agua(int capacidadML, string Marca, int contenidoML) : base(Marca, capacidadML, contenidoML)
        {
            // no hace falta hacer nada más
        }

        /// <summary>
        /// Retorna todos los datos de una botella de agua
        /// [Capacidad] [Contenido] [Marca]
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            return base.ToString();
        }

        /// <summary>
        /// Sirve con la MEDIDA constante
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// Retorna lo que puede servir una botella de agua.
        /// Si el contenido de la botella es menor igual a la medida, se sirve todo el contenido.
        /// Sino, se sirve la medida.
        /// </summary>
        /// <param name="medida"></param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {
            int retorno;

            if (medida <= this.contenidoML)
            {
                // gasta medida:
                retorno = this.contenidoML - medida; // devuelvo el contenido que queda para gastar
                this.contenidoML -= medida; // actualizo el contenido que queda en la botella
            }
            else // gasta contenido
            {
                retorno = this.contenidoML; // sirve todo el contenido que tiene
                this.contenidoML = 0; // la botella queda vacía
            }

            return retorno;
        }

        #endregion
    }
}
