﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprobantesLogic;


namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        private static Stack<Comprobante> comprobantes;

        public Comiqueria() {

            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();

        }

        public Producto this[Guid codigo] {
            get {
                Producto p = null;
                foreach (Producto c in this.productos) {
                    if (codigo == (Guid)c) {
                        p = c;
                        break;
                    }
                }

                return p;
            } }

        public List<Comprobante> this[Producto producto, bool ordenar] {

            get
            {
                List<Comprobante> lista = new List<Comprobante>();

                foreach (Comprobante c in Comiqueria.comprobantes) {

                    Producto p = (Producto)c.Venta;

                    if ((Guid)p == (Guid)producto) {

                        lista.Add(c);

                    }
                }

                if (ordenar) {
                    lista.Sort();
                    lista.Reverse();
                }

                return lista;
            }

        }

        #region sobreCarga

        
        public static bool operator ==(Comiqueria c, Producto p) {

            bool todoOk = false;

            foreach (Producto aux in c.productos) {
                if (p.Descripcion == aux.Descripcion) {
                    todoOk = true;
                    break;
                }

            }

            return todoOk;

        }

        public static bool operator !=(Comiqueria c, Producto p) {

            return !(c == p);
        }

        public static Comiqueria operator +(Comiqueria c, Producto p) {

            if (c != p) {
                c.productos.Add(p);
            }

            return c;

        }

        public static bool operator ==(Comiqueria comiqueria, Comprobante comprobante) {

            bool todoOK = false;

            foreach (Comprobante c in Comiqueria.comprobantes) {

                if (c == comprobante) {
                    todoOK = true;
                }

            }

            return todoOK;
           

        }

        public static bool operator !=(Comiqueria comiqueria, Comprobante comprobante) {

            return !(comiqueria == comprobante);

        }

        #endregion

        static Comiqueria() {

            Comiqueria.comprobantes = new Stack<Comprobante>();
        }

        public void Vender(Producto p) {
            Vender(p, 1); 
        }

        public void Vender(Producto producto, int cantidad) {

            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);

        }

        public string ListarVentas()
        {
            this.ventas.Sort(Venta.OrdenarLista);
            StringBuilder texto = new StringBuilder();

            foreach (Venta v in this.ventas)
            {
                texto.AppendFormat($"{v.ObtenerBreveDescripcion()}\n");
            }

            return texto.ToString();
        }

        public Dictionary<Guid, string> ListarProductos(){

            Dictionary<Guid, string> texto = new Dictionary<Guid,string>();

            foreach(Producto c in this.productos)
            {
                if (!(texto.ContainsKey((Guid)c)))
                {
                    texto.Add((Guid)c, c.Descripcion);
                   
                }
            }
            return texto;

        }

        private bool AgregarComprobante(Comprobante comprobante) {

            bool todoOk = true;

            foreach (Comprobante c in Comiqueria.comprobantes) {

                if (c.Venta == comprobante.Venta) {

                    todoOk = false;

                }

            }

            if (todoOk) {

                Comiqueria.comprobantes.Push(comprobante);

            }

            return todoOk;

        }

        private bool AgregarComprobante(Venta venta) {

            Factura fac = new Factura(venta, Factura.TipoFactura.B);

            return this.AgregarComprobante(fac);
            
        }




    }
}
