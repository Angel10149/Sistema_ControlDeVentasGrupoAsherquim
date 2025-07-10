using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class DListaPermiso
    {
        public NodoListaPermiso primero = null;
        public NodoListaPermiso ultimo = null;
        public void AgregarPermisosAdmin()
        {
            int idRol = 1;

            Agregar(new EPermiso
            {
                IdPermiso = 1,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuUsuarios",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 2,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuMantenedor",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 3,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuVentas",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 4,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuCompras",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 5,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuClientes",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 6,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuProveedores",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 7,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuReportes",
            });
            Agregar(new EPermiso
            {
                IdPermiso = 8,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuDeliveri",
            });
            Agregar(new EPermiso
            {
                IdPermiso = 9,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuInventario",
            });
        }

        public void AgregarPermisosEmpleado()
        {
            int idRol = 2;

            Agregar(new EPermiso
            {
                IdPermiso = 10,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuVentas",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 11,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuCompras",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 12,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuClientes",
            });

            Agregar(new EPermiso
            {
                IdPermiso = 13,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuProveedores",
            });
            Agregar(new EPermiso
            {
                IdPermiso = 14,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuDeliveri",
            });
            Agregar(new EPermiso
            {
                IdPermiso = 15,
                Rol = new ERol { IdRol = idRol, Descripcion = "ADMINISTRADOR" },
                NombreMenu = "MenuInventario",
            });
        }
        private void Agregar(EPermiso permiso)
        {
            NodoListaPermiso nuevo = new NodoListaPermiso { Dato = permiso };

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                nuevo.Siguiente = nuevo;
                nuevo.Anterior = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;

                nuevo.Siguiente = primero;
                primero.Anterior = nuevo;

                ultimo = nuevo;
            }
        }
        public DListaPermiso ObtenerPermisosPorRol(int idRol)
        {
            DListaPermiso permisos = new DListaPermiso();

            if (idRol == 1)
            {
                permisos.AgregarPermisosAdmin();
            }
            else if (idRol == 2)
            {
                permisos.AgregarPermisosEmpleado();
            }
            return permisos;
        }
    }
}
