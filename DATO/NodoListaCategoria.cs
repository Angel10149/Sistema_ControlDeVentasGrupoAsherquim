using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class NodoListaCategoria
    {
        public ECategoria dato;
        public NodoListaCategoria siguiente = null;
        public NodoListaCategoria anterior = null;
    }
}
