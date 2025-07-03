using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ECliente
    {
        public int IdCliente { get; set; }
        public int Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string[] getdata()
        {
            string[] data = new string[08];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdCliente + "";
            data[2] = Documento + "";
            data[3] = NombreCompleto;
            data[4] = Correo;
            data[5] = Telefono;
            data[6] = Estado ? "1" : "0"; // EstadoValor
            data[7] = Estado ? "Activo" : "Inactivo";
            return data;
        }
    }
}
