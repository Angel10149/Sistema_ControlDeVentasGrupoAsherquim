using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ECategoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        //public string FechaRegistro { get; set; }
        public string[] getdata()
        {
            string[] data = new string[5];
            data[0] = ""; // Columna para el botón seleccionar
            data[1] = IdCategoria + "";
            data[2] = Descripcion;
            data[3] = Estado ? "1" : "0"; // EstadoValor
            data[4] = Estado ? "Activo" : "Inactivo";
            return data;
        }
    }
}
