using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class NodoDetalleCompra
    {
        public EDetalleCompra dato;
        public NodoDetalleCompra siguiente = null;
        public NodoDetalleCompra anterior = null;
    }
}
