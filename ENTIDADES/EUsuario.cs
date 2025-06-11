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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
