using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATO;
using ENTIDADES;

namespace LOGICA
{
    public class LRol
    {
        private DListaRol rol = new DListaRol();
        public ERol BuscarRol(ERol Rol)
        {
            return rol.BuscarRolPorId(Rol.IdRol);
        }
        // Método para acceder al primer nodo
        public NodoListaRol ObtenerPrimerNodo()
        {
            return rol.primero;
        }
    }
}
