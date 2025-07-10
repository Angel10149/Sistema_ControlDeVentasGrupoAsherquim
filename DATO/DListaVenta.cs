using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DListaVenta
    {
        public NodoListaVenta primero = null;
        public NodoListaVenta ultimo = null;

        private int ObtenerSiguienteIdVenta()
        {
            int maxId = 0;
            ObtenerMaximoID(primero, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoListaVenta nodo, ref int MxId)//crear id compra segun como se registra
        {
            if (nodo == null)
            {
                return;
            }

            NodoListaVenta actual = nodo;
            do
            {
                if (actual.dato.IdVentas > MxId)
                {
                    MxId = actual.dato.IdVentas;
                }
                actual = actual.siguiente;
            } while (actual != nodo);
        }
        public int RegistarVenta(EVentas Compr)
        {
            Compr.IdVentas = ObtenerSiguienteIdVenta();
            Agregar(Compr);
            return Compr.IdVentas;
        }
        private void Agregar(EVentas compra)
        {
            NodoListaVenta nuevo = new NodoListaVenta();
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
        public EVentas BuscarVentaPorDocumento(string Documento)
        {
            NodoListaVenta temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.NumeroDocumento == Documento)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public EVentas BuscarVentaPorId(int IdCompr)
        {
            NodoListaVenta temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdVentas == IdCompr)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public int ContarVentas()
        {
            int contador = 0;
            if (primero == null)
            {
                contador = 0;
                return contador;
            }
            else
            {
                NodoListaVenta temp = primero;
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
        private void MostrarEnGridVenta(NodoListaVenta temp, DataGridView gv)
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
    }
}
