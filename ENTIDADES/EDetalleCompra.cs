using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EDetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public EProducto Producto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string[] getdata()
        {
            string[] data = new string[7];
            data[0] = IdDetalleCompra.ToString();
            data[1] = Producto != null ? Producto.IdProducto.ToString() : "0"; // ID del producto
            data[2] = Producto != null ? Producto.Nombre : "Sin nombre";
            data[3] = Cantidad.ToString();
            data[4] = PrecioCompra.ToString("0.00");
            data[5] = PrecioVenta.ToString("0.00");
            data[6] = MontoTotal.ToString("0.00");
            return data;
        }
    }
}
