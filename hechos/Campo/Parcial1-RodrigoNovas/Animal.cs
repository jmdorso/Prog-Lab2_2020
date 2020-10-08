using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_RodrigoNovas
{
    public abstract class Animal
    {
        private int kilosAlimento;
        private string nombre;

        //constructores

        public Animal(string nombre, int volumen)
        {

            this.nombre = nombre;

            this.kilosAlimento = volumen;


        }


        //propiedades


        public abstract bool ComeBalanceado
        {
            get;
        }

        public abstract bool ComePasto
        {
            get;
        }

        public int KilosAlimento
        {
            get
            {
                return kilosAlimento;
            }
        }

        //metodos

        public virtual string Datos()
        {
            StringBuilder str = new StringBuilder(null);

            str.AppendLine("Nombre: " + this.nombre);
            str.AppendLine("Come: " + this.KilosAlimento);
            str.AppendLine("Consume balanceado: " + this.ComeBalanceado);
            str.AppendLine("Consume pasto: " + this.ComePasto);

            return str.ToString();
        }
    }
}
