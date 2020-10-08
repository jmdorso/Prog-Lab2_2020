using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHoraa)
            : this(patente, modelo)
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
            auxRetorno.AppendLine("PICK UP");
            auxRetorno.AppendLine("");
            auxRetorno.Append(base.ImprimirTicket());
            auxRetorno.AppendLine($"MODELO : {this.modelo}\r");
            auxRetorno.AppendLine($"VALOR HORA: ${valorHora}\r");
            auxRetorno.AppendLine($"VALOR ESTADIA HASTA AHORA (${valorHora} x {cantEstadia} horas): {valorEstadia}\r");
            auxRetorno.AppendLine("---------------------");

            return auxRetorno.ToString();
        }

        public override bool Equals(object obj)
        {
            //Verifico que sea del mismo tipo
            if (obj.GetType() == typeof(PickUp))
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
