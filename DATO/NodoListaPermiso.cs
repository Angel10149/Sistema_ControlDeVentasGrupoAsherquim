using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class NodoListaPermiso
    {
        public EPermiso Dato;
        public NodoListaPermiso Siguiente = null;
        public NodoListaPermiso Anterior = null;

    }
}
