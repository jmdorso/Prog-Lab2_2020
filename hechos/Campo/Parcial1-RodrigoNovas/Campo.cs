using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_RodrigoNovas
{
    public class Campo
    {
       enum Tipo { Pastoreo, Engorde }

        private int alimentoDisponible;
        private static Tipo servicio;
        private List<Animal> animales;


        //constructores
        private  Campo()
            {
               this.animales = new List<Animal>();
            }

        static Campo()
        {
            servicio = Campo.Tipo.Engorde;
        }


        public Campo (int alimento):this()
        {
            this.alimentoDisponible = alimento;
        }

        //propiedades

        private static Tipo TipoServicio
        {
            get
            {
                return servicio;
            }
            set
            {
                servicio = value;
            }
        }


        //operadores

        public static bool operator +(Campo campo, Animal animal)
        {
            if (campo.alimentoDisponible > animal.KilosAlimento)
            {
                campo.animales.Add(animal);
                return true;
            }

            return false;

        }


        //metodos

        public int AlimentoComprometido(Animal animal)
        {

           return AlimentoComprometido() + animal.KilosAlimento;
        }

        public int AlimentoComprometido()
        {
            int totalAlimento= this.alimentoDisponible;
            
            foreach (Animal animal in animales)
            {
                totalAlimento = this.alimentoDisponible - animal.KilosAlimento;
                
            }

            return totalAlimento;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(null);
          
            

            foreach(Animal animal in this.animales)
            {
                if(animal is Caballo)
                {

                    str.AppendLine("Tipo servicio: " + Campo.TipoServicio);
                    str.AppendLine("Alimento comprometido" + this.AlimentoComprometido(animal) + "de" + this.alimentoDisponible);
                    str.AppendLine("" + animal.Datos());
                }
                if (animal is Vaca)
                {
                    str.AppendLine("" + animal.Datos());
                    str.AppendLine("Tipo servicio: " + Campo.TipoServicio);
                    str.AppendLine("Alimento comprometido" + this.AlimentoComprometido(animal) + "de" + this.alimentoDisponible);
                }

                if (animal is Cerdo)
                {
                    str.AppendLine("" + animal.Datos());
                    str.AppendLine("Tipo servicio: " + Campo.TipoServicio);
                    str.AppendLine("Alimento comprometido" + this.AlimentoComprometido(animal) + "de" + this.alimentoDisponible);
                }
            }
            return str.ToString();
        }

    }
}
