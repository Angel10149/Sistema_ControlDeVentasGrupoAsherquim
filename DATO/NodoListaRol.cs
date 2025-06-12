using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class NodoListaRol
    {
        public ERol dato;
        public NodoListaRol siguiente = null;
        public NodoListaRol anterior = null;
    }
}
