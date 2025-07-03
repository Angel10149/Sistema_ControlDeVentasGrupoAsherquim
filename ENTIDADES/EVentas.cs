using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EVentas
    {
        public int IdVentas { get; set;}
        public EUsuario Usuario { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPgo { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public string[] getdata()
        {
            string[] data = new string[8];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdVentas + "";
            data[2] = "";
            data[3] = DocumentoCliente;
            data[4] = NombreCliente;
            data[5] = MontoPgo + "";
            data[6] = MontoCambio + "";
            data[7] = MontoTotal + "";
            return data;
        }
    }
}
