using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
            :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento estacionamiento)
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine("");
            auxRetorno.AppendLine($"ESTACIONAMIENTO {estacionamiento.nombre}");
            auxRetorno.AppendLine("");
            auxRetorno.AppendLine($"ESPACIO DISPONIBLE: {estacionamiento.espacioDisponible} Lugares");
            auxRetorno.AppendLine($"OCUPADO: {estacionamiento.vehiculos.Count} Lugares");
            
            foreach (Vehiculo vehiculo in estacionamiento.vehiculos)
            {
                auxRetorno.AppendLine(vehiculo.ConsultarDatos());
            }
            return auxRetorno.ToString();
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && !string.IsNullOrEmpty(vehiculo.Patente) && estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible)
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string auxRetorno = "El vehículo no es parte del estacionamiento";
            if (estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                auxRetorno = vehiculo.ImprimirTicket();
            }
            return auxRetorno;
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool auxRetorno = false;
            foreach (Vehiculo unVehiculo in estacionamiento.vehiculos)
            {
                if (unVehiculo == vehiculo)
                {
                    auxRetorno = true;
                    break;
                }
            }
            return auxRetorno;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
    }
}
