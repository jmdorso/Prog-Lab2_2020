using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_RodrigoNovas
{
    public class Vaca:Animal
    {
        public enum Clasificacion {Lechera, Normando, Pasiega, HolandoArgentina, Tudanca}


        private Clasificacion clasificacion;



        //constructores

        public  Vaca(string nombre, int kilosAlimento) : base(nombre, kilosAlimento)
        {
           
        }

        public Vaca (string nombre, int kilosAlimento, Clasificacion clasificacion):this(nombre, kilosAlimento)
        {
            this.clasificacion = clasificacion;
        }


        //propiedades

        public override bool ComeBalanceado
        {
            get
            {
                return true;
            }
        }

        public override bool ComePasto 
        {
        
            get
            {
                return true;
            }
        
        }



        //metodos


        public override string Datos()
        {
            StringBuilder str = new StringBuilder(null);
            str.AppendLine(base.Datos());
            str.AppendLine("Clasificada como: " + this.clasificacion);
            return str.ToString();
        }
    }
}
