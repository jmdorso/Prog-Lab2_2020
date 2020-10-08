using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            :base (patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            :this (patente,color)
        {
            Automovil.valorHora = valorHora;
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
            auxRetorno.AppendLine("AUTOMOVIL");
            auxRetorno.AppendLine("");
            auxRetorno.Append(base.ImprimirTicket());
            auxRetorno.AppendLine($"COLOR : {this.color}\r");
            auxRetorno.AppendLine($"VALOR HORA: ${valorHora}\r");
            auxRetorno.AppendLine($"VALOR ESTADIA HASTA AHORA (${valorHora} x {cantEstadia} horas): {valorEstadia}\r");
            auxRetorno.AppendLine("---------------------");

            return auxRetorno.ToString();
        }

        public override bool Equals(object obj)
        {
            //Verifico que sea del mismo tipo
            if (obj.GetType() == typeof(Automovil))
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
