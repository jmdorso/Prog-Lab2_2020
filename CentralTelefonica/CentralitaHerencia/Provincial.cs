using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 };
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : base (llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;  
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float auxRetorno = 0;

            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        auxRetorno = this.duracion * (float)0.99;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        auxRetorno = this.duracion * (float)1.25;
                        break;
                    }
                case Franja.Franja_3:
                    {
                        auxRetorno = this.duracion * (float)0.66;
                        break;
                    }
            }
            return auxRetorno;
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine(base.Mostrar());
            auxRetorno.AppendLine($"La franja horaria es: {this.franjaHoraria}");
            auxRetorno.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");

            return auxRetorno.ToString();
        }
    }
}
