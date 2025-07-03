using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class DListaVenta
    {
        public NodoListaVenta primero = null;
        public NodoListaVenta ultimo = null;

        public void Agregar(EVentas venta)
        {
            NodoListaVenta nuevo = new NodoListaVenta();
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
        public EVentas BuscarVentaPorId(int Venta)
        {
            NodoListaVenta temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdVentas == Venta)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
    }
}
