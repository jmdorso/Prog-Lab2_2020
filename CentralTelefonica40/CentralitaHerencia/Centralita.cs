using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }


        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) 
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        return gananciaLocal;
                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        return gananciaProvincial;
                    }
                default:
                    {
                        return gananciaLocal + gananciaProvincial;
                    }
            }
        }

            public override string ToString()
            {
                StringBuilder auxRetorno = new StringBuilder();

                auxRetorno.AppendLine($"\tLa razon social es: {this.razonSocial}\n");
                auxRetorno.AppendLine($"La ganancia total es: {this.GananciasPorTotal}");
                auxRetorno.AppendLine($"La ganancia local es: {this.GananciasPorLocal}");
                auxRetorno.AppendLine($"La ganancia provincial es: {this.GananciasPorProvincial}");
                auxRetorno.AppendLine("\n\tRegistro de llamadas: \n");
                
                foreach(Llamada llamada in this.listaDeLlamadas)
                {
                    auxRetorno.AppendLine(llamada.ToString());
                }

                return auxRetorno.ToString();
            }

            public void OrdenarLlamadas()
            {
                this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
            }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool auxRetorno = false;

            foreach(Llamada auxLlamada in c.listaDeLlamadas)
            {
                if(llamada == auxLlamada)
                {
                    auxRetorno = true;
                }
            }

            return auxRetorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(c!=nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }
    }
}

