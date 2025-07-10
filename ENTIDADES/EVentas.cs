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
        public ECliente Cliente { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public decimal MontoPgo { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public string[] getdata()
        {
            string[] data = new string[12];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdVentas + "";
            data[2] = (Usuario?.IdUsuario ?? 0) + "";
            data[3] = Usuario?.NombreCompleto ?? "Sin Usuario";
            data[4] = (Cliente?.IdCliente ?? 0).ToString();
            data[5] = Cliente?.NombreCompleto ?? "Sin cliente";
            data[6] = NumeroDocumento;
            data[7] = DocumentoCliente;
            data[8] = MontoPgo + "";
            data[9] = MontoCambio + "";
            data[10] = MontoTotal + "";
            return data;
        }

    }
}
