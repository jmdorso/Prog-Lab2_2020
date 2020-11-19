using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    
    public class SerializarXML<T> : IArchivos<T>
        where T : new()
    {
        
        public T Leer(string rutaArchivo)
        {
            XmlTextReader leer =null;
            XmlSerializer serializar =null;
            try
            {
                leer = new XmlTextReader(rutaArchivo);
                serializar = new XmlSerializer(typeof(T));
                return (T)serializar.Deserialize(leer);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoExcepcion("No se pudo Leer",e) ;
            }
            /*
            //para instanciar un objeto que permite liberar los recursos
            using (XmlTextReader reader = new XmlTextReader(rutaArchivo))
            {
                //en cuanto salgamos de las llaves, .net llama al dispose
                //y libera reader, no es necesario hacer un close
                //te ahorras el finally y el close
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
            */
            finally
            {
                if (leer != null)
                {
                    leer.Close();
                }
            }
        }

        public bool Guardar(string rutaArchivo, T objeto)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
                return true;
            }

            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }
}
