using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ECompra
    {
        public int IdCompra { get; set; }
        public EUsuario Usuario { get; set; }
        public EProveedores Proveedor { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public string[] getdata()
        {
            string[] data = new string[12];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdCompra + "";
            data[2] = "";
            data[3] = "";
            data[4] = "";
            data[5] = "";
            data[6] = "";
            data[7] = "";
            data[8] = "";
            return data;
        }
    }
}