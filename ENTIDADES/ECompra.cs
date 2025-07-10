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
            string[] data = new string[8];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdCompra +"";
            data[2] = (Usuario?.IdUsuario ?? 0)+"";
            data[3] = Usuario?.NombreCompleto ?? "Sin Usuario";
            data[4] = (Proveedor?.IdProveedor ?? 0).ToString();
            data[5] = Proveedor?.RazonSocial ?? "Sin Proveedor";
            data[6] = NumeroDocumento;
            data[7] = MontoTotal+"";
            return data;
        }
    }
}