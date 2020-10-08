using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private static short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
            ruedas = 2;
        }

        public Moto(string patente, int cilindrada)
            : base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedaas)
            : this(patente, cilindrada)
        {
            ruedas = ruedaas;
        }

        public Moto(string patente,int cilindrada, short ruedaas, int valorHoraa)
            : this(patente,cilindrada,ruedaas)
        {
            valorHora = valorHoraa;
        }

        public override string ConsultarDatos()
        {
            return this.ImprimirTicket();
        }

        public override string ImprimirTicket()
        {
            StringBuilder auxRetorno = new StringBuilder();
            int valorEstadia;
            int cantEstadia;

            TimeSpan auxCantEstadia = DateTime.Now.Subtract(base.ingreso);
            cantEstadia = auxCantEstadia.Hours;
            valorEstadia = cantEstadia * valorHora;

            auxRetorno.AppendLine("");
            auxRetorno.AppendLine("MOTO");
            auxRetorno.AppendLine("");
            auxRetorno.Append(base.ImprimirTicket());
            auxRetorno.AppendLine($"CILINDRADA : {this.cilindrada}\r");
            auxRetorno.AppendLine($"RUEDAS : {ruedas}\r");
            auxRetorno.AppendLine($"VALOR HORA: ${valorHora}\r");
            auxRetorno.AppendLine($"VALOR ESTADIA HASTA AHORA (${valorHora} x {cantEstadia} horas): {valorEstadia}\r");
            auxRetorno.AppendLine("---------------------");

            return auxRetorno.ToString();
        }

        public override bool Equals(object obj)
        {
            //Verifico que sea del mismo tipo
            if (obj.GetType() == typeof(Moto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
