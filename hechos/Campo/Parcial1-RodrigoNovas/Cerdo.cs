using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_RodrigoNovas
{
   public class Cerdo: Vaca
    {



        //constructor

        public Cerdo(string nombre, int kilosAlimentos):base(nombre, kilosAlimentos)
        {


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
                return false;
            }

        }

    }
}
