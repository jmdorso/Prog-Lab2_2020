using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_RodrigoNovas
{
    public class Caballo:Animal
    {
        private bool corredor;



        public Caballo(string nombre, int kilosAlimentos, bool corredor):base(nombre, kilosAlimentos)
        {

            this.corredor = corredor;
            
        }


        //propiedades

        public override bool ComeBalanceado
        {
            get
            {
                return false;
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
            str.AppendLine("Es de carreras: " + this.corredor);
            return str.ToString();
        }
    }

}

