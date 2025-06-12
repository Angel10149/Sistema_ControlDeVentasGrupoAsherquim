using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class DListaRol
    {
        public NodoListaRol primero = null;
        public NodoListaRol ultimo = null;

        // Constructor con roles iniciales
        public DListaRol()
        {
            // Rol Administrador
            ERol rolAdmin = new ERol
            {
                IdRol = 1,
                Descripcion = "ADMINISTRADOR",
            };

            // Rol Empleado
            ERol rolEmpleado = new ERol
            {
                IdRol = 2,
                Descripcion = "EMPLEADO",
            };

            // Insertar roles
            Agregar(rolAdmin);
            Agregar(rolEmpleado);
        }
        private void Agregar(ERol rol)
        {
            NodoListaRol nuevo = new NodoListaRol();
            nuevo.dato = rol;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                nuevo.siguiente = nuevo;
                nuevo.anterior = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;

                nuevo.siguiente = primero;
                primero.anterior = nuevo;

                ultimo = nuevo;
            }
        }
        public ERol BuscarRolPorId(int idRol)
        {
            NodoListaRol temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.IdRol == idRol)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
    }
}
