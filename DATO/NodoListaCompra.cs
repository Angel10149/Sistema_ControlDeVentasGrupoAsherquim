using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class NodoListaCompra
    {
        public ECompra dato;
        public NodoListaCompra siguiente = null;
        public NodoListaCompra anterior = null;
    }
}
