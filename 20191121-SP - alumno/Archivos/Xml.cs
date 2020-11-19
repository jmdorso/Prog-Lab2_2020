using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Xml<T> : IFiles<T> where T : class
    {

        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            if(File.Exists($"{this.GetDirectoryPath}{nombreArchivo}"))
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            this.Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }
        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter($"{this.GetDirectoryPath}{nombreArchivo}", encoding);
            XmlSerializer xmlSerializer;

            try
            {
                if (objeto != null)
                {
                    xmlWriter.Formatting = Formatting.Indented;
                    xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(xmlWriter, objeto);

                }
                else
                {
                    throw new ErrorArchivosException("Los datos son null");
                }
            }
            catch (Exception exc)
            {
                throw new ErrorArchivosException(exc);
            }
            finally
            {
                xmlWriter.Close();
            }

        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            return this.Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            bool auxRetorno = false;
            XmlTextReader xmlReader = new XmlTextReader($"{this.GetDirectoryPath}{nombreArchivo}");
            XmlSerializer xmlSerializer;

            try
            {
                if (nombreArchivo.Contains('\\') || !FileExists(nombreArchivo))
                {
                    throw new ErrorArchivosException("No existe el archivo");

                }
                else
                {
                    xmlSerializer = new XmlSerializer(typeof(T));
                    objeto = (T)xmlSerializer.Deserialize(xmlReader);   
                    auxRetorno = true;
                }
            }
            catch (Exception exc)
            {
                throw new ErrorArchivosException(exc);
            }
            finally
            {
                xmlReader.Close();
            }

            return auxRetorno;
        }


    }
}
