using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matematica
    {
        /// <summary>
        /// Constructor por defecto, sino lo declaro, al crear otro constructor, al momento de usarlo se pierde el por defecto
        /// </summary>
        public Matematica()
        {

        }
        /// <summary>
        /// constructor con un valor
        /// </summary>
        /// <param name="a"></param>
        public Matematica(int a)
        {

        }
        public void Probador()
        {
            this.Sumar(;//al poner parentesis nos deja ekegir que metodo vamos a usar
        }
        /// <summary>
        /// Suma de dos enteros
        /// </summary>
        /// <param name="a">1er entero</param>
        /// <param name="b">2do entero</param>
        /// <returns></returns>
        public double Sumar(int a, int b)
        {
            return a + b;
        }
        private double Sumar(float a, float b)//probamos sobrecarga, en los metodos pueden cambiar retorno, privacidad, y si o si los argumentos
        {
            return a + b;
        }
        private float Sumar(float a, int b)//probamos sobrecarga
        {
            return a + b;
        }
        private string Sumar(int a, float b)//probamos sobrecarga
        {
            return  "";// a + b;
        }

        public bool TryParsePropio(string valor, out int res)//COMO HACER TRY PARSE PROPIO, EN CLASES MAS ADELANTE LO VAMOS A NECESITAR
        {
            try
            {
                res = int.Parse(valor);
                // Lo puedo convertir
                return true;
            }
            catch(Exception ex)
            {
                // No lo puedo convertir
                res = 0;
                return false;
            }
        }
    }
}
