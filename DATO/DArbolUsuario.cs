using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DArbolUsuario
    {
        public DNodoArbolUsuario RaizPrincipal = null;
        //Usuarios Predefinidos
        public DArbolUsuario()
        {

            if (RaizPrincipal == null)
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
                    Estado = false
                };
                InsertarDato(ref RaizPrincipal, usuarioAdmin);
                InsertarDato(ref RaizPrincipal, usuarioEmpleado);
            }

        }
        //Registrar Usuaro
        private int ObtenerSiguienteIdUsuario()
        {
            int maxId = 0;
            ObtenerMaximoID(RaizPrincipal, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(DNodoArbolUsuario raiz, ref int MxId)//crear id ussuario segun como se registra
        {
            if (raiz == null)
            {
                return;
            }
            if (raiz.dato.IdUsuario > MxId)
            {
                MxId = raiz.dato.IdUsuario;
            }
            ObtenerMaximoID(raiz.izquierda, ref MxId);
            ObtenerMaximoID(raiz.derecha, ref MxId);
        }
        public int RegistrarUsuario(EUsuario usuario, out string Mensaje)
        {
            Mensaje = "";

            if (usuario.CodigoUsuario == 0)
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }
            if (usuario.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }
            if (usuario.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            if (Mensaje != "")
            {
                return 0;
            }
            Mensaje = "";
            if (Buscar(usuario.CodigoUsuario) != null)
            {
                Mensaje = "El usuario ya existe en el sistema.";
                return 0;
            }
            usuario.IdUsuario = ObtenerSiguienteIdUsuario();
            InsertarDato(ref RaizPrincipal, usuario);
            Mensaje = "Usuario registrado correctamente";
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
        //Editar Usuario
        public bool EditarUsuario(EUsuario usuario, out string Mensaje)
        {
            Mensaje = "";

            if (usuario.CodigoUsuario == 0)
                Mensaje += "Es necesario el documento del usuario\n";

            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
                Mensaje += "Es necesario el nombre completo del usuario\n";

            if (string.IsNullOrWhiteSpace(usuario.Clave))
                Mensaje += "Es necesario la clave del usuario\n";

            if (Mensaje != "")
                return false;

            return Editar(usuario, out Mensaje);
        }
        private bool Editar(EUsuario usuario, out string mensaje)
        {
            mensaje = "";
            EUsuario encontrado = Buscar(usuario.CodigoUsuario);
            if (encontrado == null)
            {
                mensaje = "Usuario No Encontrado";
                return false;
            }

            encontrado.CodigoUsuario = usuario.CodigoUsuario;
            encontrado.NombreCompleto = usuario.NombreCompleto;
            encontrado.Correo = usuario.Correo;
            encontrado.Clave = usuario.Clave;

            // Buscar rol completo desde lista de roles
            DListaRol logicaRol = new DListaRol();
            ERol rolCompleto = logicaRol.BuscarRolPorId(usuario.Rol.IdRol);
            if (rolCompleto != null)
            {
                encontrado.Rol = rolCompleto;
            }
            else
            {
                encontrado.Rol = new ERol { IdRol = usuario.Rol.IdRol, Descripcion = "Sin rol" };
            }

            encontrado.Estado = usuario.Estado;

            mensaje = "Datos del usuario actualizados";
            return true;
        }
        //Eliminar usuario
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
        public bool EliminarUsuario(EUsuario usuario, out string mensaje)
        {
            mensaje = "";
            if (Buscar(usuario.CodigoUsuario) == null)
            {
                mensaje = "El Usuario No Existe";
                return false;
            }
            EliminarRaiz(ref RaizPrincipal, usuario.CodigoUsuario);
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
        //Buscar usuario para Iniciar sesion
        public EUsuario BuscarUsuario(int CodigoUsuario, string clave)
        {
            EUsuario Usu = BuscarRaiz(RaizPrincipal, CodigoUsuario, clave);
            return Usu;
        }
        private EUsuario BuscarRaiz(DNodoArbolUsuario raiz, int Codigousuario, string clave)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (Codigousuario < raiz.dato.CodigoUsuario)
                {
                    return BuscarRaiz(raiz.izquierda, Codigousuario, clave);
                }
                else if (Codigousuario > raiz.dato.CodigoUsuario)
                {
                    return BuscarRaiz(raiz.derecha, Codigousuario, clave);
                }
                else
                {
                    if (clave == raiz.dato.Clave)
                    {
                        return raiz.dato;
                    }
                    else { return null; }
                }
            }
        }
        //Buscar usuario
        public EUsuario Buscar(int CodigoUsu)
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

        public void MostrarGrid(DataGridView gv)
        {
            gv.Rows.Clear();
            MostrarEnGridInOrden(RaizPrincipal, gv);
        }

        private void MostrarEnGridInOrden(DNodoArbolUsuario nodo, DataGridView gv)
        {
            if (nodo != null)
            {
                MostrarEnGridInOrden(nodo.izquierda, gv); // Lado izquierdo (menores)

                gv.Rows.Add(nodo.dato.getdata());         // Nodo actual

                MostrarEnGridInOrden(nodo.derecha, gv);   // Lado derecho (mayores)
            }
        }
    }
}
