using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EVerticeDato
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool EsCategoria { get; set; }

        public EProducto Producto { get; set; }
        public ECategoria Categoria { get; set; }

        // Constructor para producto
        public EVerticeDato(EProducto producto)
        {
            Producto = producto;
            Categoria = null;
            Id = producto.IdProducto;
            Descripcion = producto.Descripcion;
            EsCategoria = false;
        }

        // Constructor para categoria
        public EVerticeDato(ECategoria categoria)
        {
            Categoria = categoria;
            Producto = null;
            Id = categoria.IdCategoria;
            Descripcion = categoria.Descripcion;
            EsCategoria = true;
        }
    }
}
