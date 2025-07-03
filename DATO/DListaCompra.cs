using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class DListaCompra
    {
        public NodoListaCompra primero = null;
        public NodoListaCompra ultimo = null;

        public void Agregar(ECompra compra)
        {
            NodoListaCompra nuevo = new NodoListaCompra();
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
        public ECompra BuscarCompraPorId(int Compra)
        {
            NodoListaCompra temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdCompra == Compra)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
    }
}
