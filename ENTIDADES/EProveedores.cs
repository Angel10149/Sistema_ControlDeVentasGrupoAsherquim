using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EProveedores
    {
        public int IdProveedor { get; set; }
        public int Documento { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        //public string FechaRegistro { get; set; }

        public string[] getdata()
        {
            string[] data = new string[08];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdProveedor + "";
            data[2] = Documento + "";
            data[3] = RazonSocial;
            data[4] = Correo;//cada data es una columna de la tabla
            data[5] = Telefono;
            data[6] = Estado ? "1" : "0"; // EstadoValor
            data[7] = Estado ? "Activo" : "Inactivo";

            return data;// convierte el array a una cadena separada por comas
        }
    }
}
