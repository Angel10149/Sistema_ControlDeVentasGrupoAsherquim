using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EProducto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public ECategoria Categoria { get; set; }
        public int IdCategoria { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        //public string FechaRegistro { get; set; }
        public string[] getdata()
        {
            string[] data = new string[8];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdProducto + "";
            data[2] = "";
            data[3] = Nombre;
            data[4] = Descripcion;
            data[5] = "";// Categoria !=null ? Categoria.IdCategoria.ToString():"0";
            data[6] = "";// Categoria != null ? Categoria.Descripcion : "Sin categoria";
            data[7] = "";
            data[8] = ""; // EstadoValor
            data[9] = IdCategoria + "";
            data[10] = Estado ? "1" : "0"; // EstadoValor
            data[11] = Estado ? "Activo" : "Inactivo";

            return data;
        }
    }
}
