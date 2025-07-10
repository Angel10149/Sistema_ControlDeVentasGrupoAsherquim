using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DListaDetalleVenta
    {
        public NodoDetalleVenta primero = null;
        public NodoDetalleVenta ultimo = null;

        private int ObtenerSiguienteIdVenta()
        {
            int maxId = 0;
            ObtenerMaximoID(primero, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoDetalleVenta nodo, ref int MxId)//crear id compra segun como se registra
        {
            if (nodo == null)
            {
                return;
            }

            NodoDetalleVenta actual = nodo;
            do
            {
                if (actual.dato.IdDetalleVenta > MxId)
                {
                    MxId = actual.dato.IdDetalleVenta;
                }
                actual = actual.siguiente;
            } while (actual != nodo);
        }
        public int RegistarVenta(EDetalleVenta Compr)
        {
            Compr.IdDetalleVenta = ObtenerSiguienteIdVenta();
            Agregar(Compr);
            return Compr.IdDetalleVenta;
        }
        private void Agregar(EDetalleVenta venta)
        {
            NodoDetalleVenta nuevo = new NodoDetalleVenta();
            nuevo.dato = venta;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                nuevo.siguiente = nuevo;
                nuevo.anterior = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;

                nuevo.siguiente = primero;
                primero.anterior = nuevo;

                ultimo = nuevo;
            }
        }
        public EDetalleVenta BuscarVentaPorNombre(int Venta)
        {
            NodoDetalleVenta temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdDetalleVenta == Venta)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public EDetalleVenta BuscarVentaPorId(int IdCompr)
        {
            NodoDetalleVenta temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdDetalleVenta == IdCompr)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public int ContarCompras()
        {
            int contador = 0;
            if (primero == null)
            {
                contador = 0;
                return contador;
            }
            else
            {
                NodoDetalleVenta temp = primero;
                do
                {
                    contador++;
                    temp = temp.siguiente;
                }
                while (temp != primero);
                return contador;
            }
        }
        public void MostrarGrid(DataGridView gv)
        {
            gv.Rows.Clear();
            MostrarEnGridVenta(primero, gv);
        }
        private void MostrarEnGridVenta(NodoDetalleVenta temp, DataGridView gv)
        {
            if (temp != null)
            {
                temp = primero;
                do
                {
                    gv.Rows.Add(temp.dato.getdata());         // Nodo actual
                                                              //Console.Write(temp.dato);
                    temp = temp.siguiente;
                }
                while (temp != primero);
            }
        }
        public void MostrarDetallesPorIdVenta(int idVenta, DataGridView gv)
        {
            gv.Rows.Clear();

            if (primero == null)
                return;

            NodoDetalleVenta actual = primero;
            do
            {
                if (actual.dato.IdVenta == idVenta)
                {
                    gv.Rows.Add(actual.dato.getdata());
                }
                actual = actual.siguiente;
            } while (actual != primero);
        }
        public void MostrarDetallesPorDocumento(string documento, DataGridView gv)
        {
            gv.Rows.Clear();

            if (primero == null)
                return;

            if (!int.TryParse(documento.TrimStart('0'), out int idCompra))
                return; // Documento inválido

            NodoDetalleVenta actual = primero;
            do
            {
                if (actual.dato.IdVenta == idCompra)
                {
                    gv.Rows.Add(actual.dato.getdata());
                }
                actual = actual.siguiente;
            } while (actual != primero);
        }

    }
}
