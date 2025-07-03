using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class DGrafoCategoriaProducto
    {
        public Vertice inicio_lista = null;
        public int[,] Matriz;

        public DGrafoCategoriaProducto(int CantVertice)
        {
            Matriz = new int[CantVertice, CantVertice];
        }
    }
}
