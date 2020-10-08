using System.Text;

namespace Entidades
{
    public abstract class Botella
    {
        #region Campos

        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        #endregion

        #region Propiedades

        /// <summary>
        /// Esta propiedad retorna la capacidad convertida a litros (divide por 1000)
        /// </summary>
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        /// <summary>
        /// get: devuelve el contenido en mililitros
        /// set: setea el contenido en mililitros si el valor es mayor igual a 0
        /// </summary>
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                if ( value >= 0 )
                {
                    contenidoML = value;
                }
            }
        }

        /// <summary>
        /// Esta propiedad utiliza regla de 3 simple para retornar la proporción de contenido dentro de una botella. 
        /// </summary>
        public float PorcentajeContenido
        {
            get
            {
                return this.contenidoML * 100 / this.capacidadML;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor único que valida si la capacidad es menor al contenido.
        /// Si la capacidad es menor al contenido, el contenido es reemplazado por la capacidad.
        /// Así nunca se podrá tener más contenido en una botella que la capacidad que ésta es capaz de guardar.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        protected Botella (string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;

            if(capacidadML < contenidoML)
            {
                contenidoML = capacidadML;
            }

            this.contenidoML = contenidoML;
        }

        /// <summary>
        /// Retorna todos los datos de una botella
        /// [Capacidad] [Contenido] [Marca]
        /// </summary>
        /// <returns></returns>
        protected virtual string GenerarInforme() // es virtual para que las clases hijas puedan hacer override
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Capacidad (en ML): " + this.capacidadML.ToString() +
                           "\nContenido (en ML): " + this.contenidoML.ToString() +
                           "\nMarca: " + this.marca);

            return retorno.ToString();
        }

        /// <summary>
        /// Método abstracto sin implementación
        /// </summary>
        /// <returns></returns>
        public abstract int ServirMedida(); // la idea es que las clases hijas estén obligadas a implementarlo


        /// <summary>
        /// Retorna todos los datos de una botella llamando al método privado GenerarInforme()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GenerarInforme(); // GenerarInforme() devuelve un string
        }

        #endregion

        #region Tipos anidados

        /// <summary>
        /// Material del que puede estar hecho una botella
        /// [Plastico][Vidrio]
        /// </summary>
        public enum Tipo
        {
            Plastico, Vidrio
        }

        #endregion
    }
}
