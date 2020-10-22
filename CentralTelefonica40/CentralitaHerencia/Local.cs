using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return this.duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine(base.Mostrar());
            auxRetorno.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");

            return auxRetorno.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
