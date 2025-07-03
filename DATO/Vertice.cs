using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class Vertice
    {
        public EVerticeDato dato;
        //trabajar la lista temp
        public Vertice sig = null;

        //trabajar el grafo permanente
        public Arista ListaAristas = null;
    }
}
