using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Entidades
{
    [Serializable]
    public class Binario<T> : IArchivos<T>
        where T: new()
    {
        public T Leer(string rutaArchivo)
        {
            Stream reader = null;
            BinaryFormatter serializar = null;
            try
            {
                reader = new FileStream(rutaArchivo,FileMode.Open);
                serializar = new BinaryFormatter();
                return (T)serializar.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoExcepcion("No se pudo Leer", e);
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
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public bool Guardar(string rutaArchivo, T objeto)
        {
            
            Stream writer = null;
            BinaryFormatter serializer = null;
            try
            {
                writer = new FileStream(rutaArchivo,FileMode.Create);
                serializer = new BinaryFormatter();
                serializer.Serialize(writer, objeto);
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoExcepcion("No se pudo Guardar", e);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            
            /*
            using (Stream stream = File.Open(rutaArchivo, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objeto);
                stream.Close();
                
            }
            return false;
            */
        }
    }
}
