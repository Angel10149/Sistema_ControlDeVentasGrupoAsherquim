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
        public int IdVenta { get; set; } // para ver a q venta pertenece
        public EProducto Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public string[] getdata()
        {
            string[] data = new string[7];
            data[0] = IdDetalleVenta.ToString();
            data[1] = IdVenta + "";
            data[2] = (Producto?.IdProducto ?? 0) + ""; // ID del producto
            data[3] = Producto != null ? Producto.Nombre : "Sin nombre";
            data[4] = PrecioVenta.ToString("0.00");
            data[5] = Cantidad.ToString();
            data[6] = SubTotal.ToString("0.00");
            return data;
        }
    }
}
