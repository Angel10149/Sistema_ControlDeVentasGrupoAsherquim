using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class NodoListaProducto
    {
        public EProducto dato;
        public NodoListaProducto siguiente = null;
        public NodoListaProducto anterior = null;
    }
}
