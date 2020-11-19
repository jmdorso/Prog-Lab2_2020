using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorArchivoExcepcion : Exception
    {
        public ErrorArchivoExcepcion()
        :this("Error de archivo")
        {

        }
        public ErrorArchivoExcepcion(string msj)
            :this(msj,null)
        {

        }
        public ErrorArchivoExcepcion(string msj, Exception innerException)
            :base(msj,innerException)
        {

        }
    }
}
