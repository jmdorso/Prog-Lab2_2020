using System;
using System.Text;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada { Local, Provincial, Todas };

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();
            
            auxRetorno.AppendLine($"La duracion de la llamada es: {this.duracion}");
            auxRetorno.AppendLine($"El numero de origen: {this.nroOrigen}");
            auxRetorno.AppendLine($"El numero de destino: {this.nroDestino}");
            
            return auxRetorno.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int auxRetorno;

            if(llamada1.duracion > llamada2.duracion)
            {
                auxRetorno = 1;
            }
            else if(llamada1.duracion < llamada2.duracion)
            {
                auxRetorno = -1;
            }
            else
            {
                auxRetorno = 0;
            }

            return auxRetorno;
        }


    }
}
