using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EUsuario
    {
        public int IdUsuario { get; set; } //numero 1 2 3 el orden en q llegan
        public int CodigoUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public ERol Rol { get; set; }
        public bool Estado { get; set; }
        public string[] getdata()
        {
            string[] data = new string[10];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdUsuario + "";
            data[2] = CodigoUsuario + "";
            data[3] = NombreCompleto;
            data[4] = Correo;
            data[5] = Clave;
            data[6] = Rol != null ? Rol.IdRol.ToString() : "0";
            data[7] = Rol != null ? Rol.Descripcion : "Sin rol";
            data[8] = Estado ? "1" : "0"; // EstadoValor
            data[9] = Estado ? "Activo" : "Inactivo";
            return data;
        }
    }
}
