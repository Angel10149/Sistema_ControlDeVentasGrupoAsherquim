using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class DListaEnlazada
    {
        public DVertice PrimerVertice = null;
        public int cantidadVisitados = 0;
        public void Agregar(DVertice v)//add O insertar
        {
            DVertice nuevo = new DVertice();

            nuevo.dato = v.dato;
            nuevo.listaAristas = v.listaAristas;
            if (PrimerVertice == null)
            {
                PrimerVertice = nuevo;
            }
            else
            {
                DVertice temp = PrimerVertice;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
            cantidadVisitados++;
        }

        public bool Contiene(DVertice v)//contains o buscar
        {
            DVertice temp = PrimerVertice;
            while (temp != null)
            {
                if (temp.dato == v.dato)
                {
                    return true;
                }
                temp = temp.sig;
            }
            return false;
        }
    }

    public class ListaEnlazadaDistancias
    {
        public class NodoDistancia
        {
            public DVertice vertice;
            public int costo;//costo
            public DVertice previo;
            public NodoDistancia siguiente;
        }
        public NodoDistancia PrimerNodo = null;
        public int cantidadNodos = 0;

        public void Agregar(DVertice vertice, int costo, DVertice previo)
        {
            NodoDistancia nuevoNodo = new NodoDistancia
            {
                vertice = vertice,
                costo = costo,
                previo = previo,
                siguiente = null
            };

            if (PrimerNodo == null)
            {
                PrimerNodo = nuevoNodo;
            }
            else
            {
                NodoDistancia temp = PrimerNodo;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoNodo;
            }
            cantidadNodos++;
        }

        public NodoDistancia ObtenerNodo(DVertice v)
        {
            NodoDistancia temp = PrimerNodo;
            while (temp != null)
            {
                if (temp.vertice == v)
                {
                    return temp;
                }
                temp = temp.siguiente;
            }
            return null;
        }
    }
}
