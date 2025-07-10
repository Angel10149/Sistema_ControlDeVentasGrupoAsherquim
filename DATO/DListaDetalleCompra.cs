using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DListaDetalleCompra
    {
        public NodoDetalleCompra primero = null;
        public NodoDetalleCompra ultimo = null;

        private int ObtenerSiguienteIdCompra()
        {
            int maxId = 0;
            ObtenerMaximoID(primero, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoDetalleCompra nodo, ref int MxId)//crear id compra segun como se registra
        {
            if (nodo == null)
            {
                return;
            }

            NodoDetalleCompra actual = nodo;
            do
            {
                if (actual.dato.IdDetalleCompra > MxId)
                {
                    MxId = actual.dato.IdDetalleCompra;
                }
                actual = actual.siguiente;
            } while (actual != nodo);
        }
        public int RegistarCompra(EDetalleCompra Compr)
        {
            Compr.IdDetalleCompra = ObtenerSiguienteIdCompra();
            Agregar(Compr);
            return Compr.IdDetalleCompra;
        }
        private void Agregar(EDetalleCompra compra)
        {
            NodoDetalleCompra nuevo = new NodoDetalleCompra();
            nuevo.dato = compra;
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
        public EDetalleCompra BuscarCompraPorNombre(int Compra)
        {
            NodoDetalleCompra temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdDetalleCompra == Compra)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public EDetalleCompra BuscarCompraPorId(int IdCompr)
        {
            NodoDetalleCompra temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdDetalleCompra == IdCompr)
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
                NodoDetalleCompra temp = primero;
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
            MostrarEnGridCompra(primero, gv);
        }
        private void MostrarEnGridCompra(NodoDetalleCompra temp, DataGridView gv)
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
        public void MostrarDetallesPorIdCompra(int idCompra, DataGridView gv)
        {
            gv.Rows.Clear();

            if (primero == null)
                return;

            NodoDetalleCompra actual = primero;
            do
            {
                if (actual.dato.IdCompra == idCompra)
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

            NodoDetalleCompra actual = primero;
            do
            {
                if (actual.dato.IdCompra == idCompra)
                {
                    gv.Rows.Add(actual.dato.getdata());
                }
                actual = actual.siguiente;
            } while (actual != primero);
        }
    }
}
