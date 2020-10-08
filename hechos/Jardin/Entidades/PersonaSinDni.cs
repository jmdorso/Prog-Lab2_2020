using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaSinDni : Exception
    {
        public PersonaSinDni(string message) : base(message)
        {
        }

        public PersonaSinDni(string message, Exception innerException) : base(message, innerException)
        {

        }
        

    }
}
