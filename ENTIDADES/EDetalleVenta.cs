using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EDetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public EProducto Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public string[] getdata()
        {
            string[] data = new string[6];
            data[0] = IdDetalleVenta.ToString();
            data[1] = Producto != null ? Producto.IdProducto.ToString() : "0"; // ID del producto
            data[2] = Producto != null ? Producto.Nombre : "Sin nombre";
            data[3] = PrecioVenta.ToString("0.00");
            data[4] = Cantidad.ToString();
            data[5] = SubTotal.ToString("0.00");
            return data;
        }
    }
}
