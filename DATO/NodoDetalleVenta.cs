using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class NodoDetalleVenta
    {
        public EDetalleVenta dato;
        public NodoDetalleVenta siguiente = null;
        public NodoDetalleVenta anterior = null;
    }
}
