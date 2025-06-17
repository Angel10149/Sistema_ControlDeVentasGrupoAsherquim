using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class EPermiso
    {
        public int IdPermiso { get; set; }
        public ERol Rol { get; set; }
        public string NombreMenu { get; set; }
    }
}
