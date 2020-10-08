using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        #region Campos

        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton; // static para que sea de clase y no haga falta instanciar para llamar a Cantina.singleton

        #endregion

        #region Propiedades

        /// <summary>
        /// Retorna la lista de botellas
        /// </summary>
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        #endregion

        #region Métodos

        private Cantina (int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public static Cantina GetCantina (int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }

            return singleton;
        }

        public static bool operator + (Cantina c, Botella b)
        {
            bool retorno = false; // por default no hay lugar en la cantina

            if (c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                retorno = true;
            }

            return retorno;
        }

        #endregion
    }
}
