using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class DArbolUsuario
    {
        private static DArbolUsuario _instancia;
        public static DArbolUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DArbolUsuario();
                }
                return _instancia;
            }
        }
        public DNodoArbolUsuario RaizPrincipal = null;
        private DArbolUsuario()
        {
            EUsuario usuarioAdmin = new EUsuario
            {
                CodigoUsuario = 101010,
                IdUsuario = 1,
                NombreCompleto = "Usuario Administrador",
                Correo = "admin@correo.com",
                Clave = "123",
                Rol = new ERol { IdRol = 1, Descripcion = "ADMINISTRADOR" },
                Estado = true
            };

            EUsuario usuarioEmpleado = new EUsuario
            {
                CodigoUsuario = 202020,
                IdUsuario = 2,
                NombreCompleto = "Usuario Empleado",
                Correo = "empleado@correo.com",
                Clave = "456",
                Rol = new ERol { IdRol = 2, Descripcion = "EMPLEADO" },
                Estado = true
            };
            InsertarDato(ref RaizPrincipal, usuarioAdmin);
            InsertarDato(ref RaizPrincipal, usuarioEmpleado);
        }
        private int ObtenerSiguienteIdUsuario()
        {
            int maxId = 0;
            ObtenerMaximoID(RaizPrincipal, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(DNodoArbolUsuario raiz, ref int MD)
        {
            if (raiz == null)
            {
                return;
            }
            if (raiz.dato.IdUsuario > MD)
            {
                MD =raiz.dato.IdUsuario;
            }
            ObtenerMaximoID(raiz.izquierda, ref MD);
            ObtenerMaximoID(raiz.derecha, ref MD);
        }

        public int Registrar(EUsuario usuario, out string mensaje)
        {

            mensaje = "";
            if (Buscar(usuario.CodigoUsuario) != null)
            {
                mensaje = "El usuario ya existe en el sistema.";
                return 0;
            }
            usuario.IdUsuario = ObtenerSiguienteIdUsuario();
            InsertarDato(ref RaizPrincipal, usuario);
            mensaje = "Usuario registrado correctamente";
            return usuario.IdUsuario;
        }
        private void InsertarDato(ref DNodoArbolUsuario raiz, EUsuario dato)
        {
            if (raiz == null)
            {
                DNodoArbolUsuario nuevo = new DNodoArbolUsuario();
                nuevo.dato = dato;
                raiz = nuevo;
            }
            else
            {
                if (dato.CodigoUsuario < raiz.dato.CodigoUsuario)
                {
                    InsertarDato(ref raiz.izquierda, dato);
                }
                else if (dato.CodigoUsuario > raiz.dato.CodigoUsuario)
                {
                    InsertarDato(ref raiz.derecha, dato);
                }
            }
        }
        private DNodoArbolUsuario BuscarMayor(DNodoArbolUsuario raiz)
        {
            if (raiz.derecha == null)
            {
                return raiz;
            }
            else
            {
                return BuscarMayor(raiz.derecha);
            }
        }
        private DNodoArbolUsuario BuscarMenor(DNodoArbolUsuario raiz)
        {
            if (raiz.izquierda == null)
            {
                return raiz;
            }
            else
            {
                return BuscarMenor(raiz.izquierda);
            }
        }
        public bool Editar(EUsuario usuario, out string mensaje)
        {
            mensaje = "";
            EUsuario encontrado = Buscar(usuario.CodigoUsuario);
            if (encontrado == null)
            {
                mensaje = "Usuario No Econtrado";
                return false;
            }
            encontrado.CodigoUsuario = usuario.CodigoUsuario;
            encontrado.CodigoUsuario = usuario.CodigoUsuario;
            encontrado.NombreCompleto = usuario.NombreCompleto;
            encontrado.Correo = usuario.Correo;
            encontrado.Clave = usuario.Clave;
            encontrado.Rol.IdRol = usuario.Rol.IdRol;
            encontrado.Estado = usuario.Estado;

            mensaje = "Datos Del Usuario Actualizado";
            return true;
        }
        public bool EliminarUsuario(int IDUsu, out string mensaje)
        {
            mensaje = "";
            if (Buscar (IDUsu) == null)
            {
                mensaje = "El Usuario No Existe";
                return false;
            }
            EliminarRaiz(ref RaizPrincipal, IDUsu);
            mensaje = "Usuario Eliminado Correctamente";
            return true;
        }
        private void EliminarRaiz(ref DNodoArbolUsuario raiz, int Id)
        {
            if (raiz == null)
            {
                Console.WriteLine("El Paciente No existe en el Registro");
            }
            else
            {
                if (Id < raiz.dato.CodigoUsuario)
                {
                    EliminarRaiz(ref raiz.izquierda, Id);
                }
                else if (Id > raiz.dato.CodigoUsuario)
                {
                    EliminarRaiz(ref raiz.derecha, Id);
                }
                else
                {
                    if (raiz.izquierda == null && raiz.derecha == null)
                    {
                        raiz = null;
                    }
                    else if (raiz.izquierda != null && raiz.derecha == null)
                    {
                        DNodoArbolUsuario mayor = BuscarMayor(raiz.izquierda);
                        EUsuario auxiliar = raiz.dato;
                        raiz.dato = mayor.dato;
                        mayor.dato = auxiliar;
                        EliminarRaiz(ref raiz.izquierda, Id);
                    }
                    else
                    {
                        if (Id > RaizPrincipal.dato.CodigoUsuario)
                        {
                            DNodoArbolUsuario menor = BuscarMenor(raiz.izquierda);
                            raiz.dato = menor.dato;
                            EliminarRaiz(ref raiz.izquierda, menor.dato.CodigoUsuario);
                        }
                        else
                        {
                            DNodoArbolUsuario mayor = BuscarMayor(raiz.derecha);
                            raiz.dato = mayor.dato;
                            EliminarRaiz(ref raiz.derecha, mayor.dato.CodigoUsuario);
                        }
                    }
                }
            }
        }
        public EUsuario Buscar (int CodigoUsu)
        {
            EUsuario dat = BuscarRaizz(RaizPrincipal, CodigoUsu);
            return dat;
        }
        private EUsuario BuscarRaizz(DNodoArbolUsuario raiz, int CodigoU)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (CodigoU < raiz.dato.CodigoUsuario)
                {
                    return BuscarRaizz(raiz.izquierda, CodigoU);
                }
                else if (CodigoU > raiz.dato.CodigoUsuario)
                {
                    return BuscarRaizz(raiz.derecha, CodigoU);
                }
                else
                {
                    return raiz.dato;
                }
            }
        }
        public EUsuario BuscarUsuario(int Document, string clav)
        {
            EUsuario Usu = BuscarRai(RaizPrincipal, Document, clav);
            return Usu;
        }
        private EUsuario BuscarRai(DNodoArbolUsuario raiz, int id, string clave)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (id < raiz.dato.CodigoUsuario)
                {
                    return BuscarRai(raiz.izquierda, id, clave);
                }
                else if (id > raiz.dato.CodigoUsuario)
                {
                    return BuscarRai(raiz.derecha, id, clave);
                }
                else
                {
                    return raiz.dato;
                }
            }
        }
    }
}
