using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Windows.Forms;

namespace DATO
{
    public class DArbolProveedores
    {
        public NodoArbolProveedores RaizPrincipal = null;
        //Usuarios Predefinidos
        public DArbolProveedores()
        {

            if (RaizPrincipal == null)
            {
                EProveedores proveedor = new EProveedores
                {
                    IdProveedor = 1,
                    Documento = 101010,
                    RazonSocial = "Proveedor ABC S.A.",
                    Correo = "contacto@abc.com",
                    Telefono = "+51 911 123 678",
                    Estado = true
                };

                EProveedores proveedor1 = new EProveedores
                {
                    IdProveedor = 2,
                    Documento = 202020,
                    RazonSocial = "Distribuciones ABC",
                    Correo = "ventas@abc.com",
                    Telefono = "+51 911 765 432",
                    Estado = true
                };
                InsertarDato(ref RaizPrincipal, proveedor);
                InsertarDato(ref RaizPrincipal, proveedor1);
            }

        }
        //Registrar Usuaro
        private int ObtenerSiguienteIdProveedor()
        {
            int maxId = 0;
            ObtenerMaximoID(RaizPrincipal, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoArbolProveedores raiz, ref int MxId)//crear id ussuario segun como se registra
        {
            if (raiz == null)
            {
                return;
            }
            if (raiz.dato.IdProveedor > MxId)
            {
                MxId = raiz.dato.IdProveedor;
            }
            ObtenerMaximoID(raiz.izquierda, ref MxId);
            ObtenerMaximoID(raiz.derecha, ref MxId);
        }
        public int RegistrarProveedor(EProveedores Proveedor, out string Mensaje)
        {
            Mensaje = "";

            if (Proveedor.Documento == 0)
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }
            if (Proveedor.RazonSocial.Replace(" ", "") == "")//replace elimina los espacios
            {
                Mensaje += "Es necesario el nombre completo del Proveedor\n";
            }
            /*if (Mensaje != "")
            {
                return 0;
            }*/
            if (Buscar(Proveedor.Documento) != null)
            {
                Mensaje = "En el sistema ya existe un Proveedor\ncon ese codigo";
                return 0;
            }
            Proveedor.IdProveedor = ObtenerSiguienteIdProveedor();
            InsertarDato(ref RaizPrincipal, Proveedor);
            Mensaje = "Proveedor registrado correctamente";
            return Proveedor.IdProveedor;
        }
        private void InsertarDato(ref NodoArbolProveedores raiz, EProveedores dato)
        {
            if (raiz == null)
            {
                NodoArbolProveedores nuevo = new NodoArbolProveedores();
                nuevo.dato = dato;
                raiz = nuevo;
            }
            else
            {
                if (dato.Documento < raiz.dato.Documento)
                {
                    InsertarDato(ref raiz.izquierda, dato);
                }
                else if (dato.Documento > raiz.dato.Documento)
                {
                    InsertarDato(ref raiz.derecha, dato);
                }
            }
        }
        //Editar Proveedor
        public bool EditarUsuario(EProveedores Proveedor, out string Mensaje)
        {
            Mensaje = "";

            if (Proveedor.Documento == 0)
            { Mensaje += "Es necesario el documento del Proveedor\n"; }


            if (string.IsNullOrWhiteSpace(Proveedor.RazonSocial))
            { Mensaje += "Es necesario el nombre completo del Proveedor\n"; }

            if (Mensaje != "")
            { return false; }

            return Editar(Proveedor, out Mensaje);
        }
        private bool Editar(EProveedores Proveedor, out string mensaje)
        {
            mensaje = "";
            EProveedores encontrado = Buscar(Proveedor.Documento);
            if (encontrado == null)
            {
                mensaje = "Proveedor No Encontrado";
                return false;
            }

            encontrado.RazonSocial = Proveedor.RazonSocial;
            encontrado.Correo = Proveedor.Correo;
            encontrado.Telefono = Proveedor.Telefono;
            encontrado.Estado = Proveedor.Estado;
            // Buscar rol completo desde lista de roles

            mensaje = "Datos del Proveedor actualizados";
            return true;
        }
        //Eliminar Proveedor
        private NodoArbolProveedores BuscarMayor(NodoArbolProveedores raiz)
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
        private NodoArbolProveedores BuscarMenor(NodoArbolProveedores raiz)
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
        public void EliminarProveedores(int Documento)
        {
            EliminarRaiz(ref RaizPrincipal, Documento);
        }
        private void EliminarRaiz(ref NodoArbolProveedores raiz, int Id)
        {
            if (raiz == null)
            {
                return;
            }
            else
            {
                if (Id < raiz.dato.Documento)
                {
                    EliminarRaiz(ref raiz.izquierda, Id);
                }
                else if (Id > raiz.dato.Documento)
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
                        NodoArbolProveedores mayor = BuscarMayor(raiz.izquierda);
                        EProveedores auxiliar = raiz.dato;
                        raiz.dato = mayor.dato;
                        mayor.dato = auxiliar;
                        EliminarRaiz(ref raiz.izquierda, Id);
                    }
                    else
                    {
                        if (Id > RaizPrincipal.dato.Documento)
                        {
                            NodoArbolProveedores menor = BuscarMenor(raiz.izquierda);
                            raiz.dato = menor.dato;
                            EliminarRaiz(ref raiz.izquierda, menor.dato.Documento);
                        }
                        else
                        {
                            NodoArbolProveedores mayor = BuscarMayor(raiz.derecha);
                            raiz.dato = mayor.dato;
                            EliminarRaiz(ref raiz.derecha, mayor.dato.Documento);
                        }
                    }
                }
            }
        }

        //Buscar Proveedor
        public EProveedores Buscar(int CodigoUsu)
        {
            EProveedores dat = BuscarRaizz(RaizPrincipal, CodigoUsu);
            return dat;
        }
        private EProveedores BuscarRaizz(NodoArbolProveedores raiz, int CodigoU)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (CodigoU < raiz.dato.Documento)
                {
                    return BuscarRaizz(raiz.izquierda, CodigoU);
                }
                else if (CodigoU > raiz.dato.Documento)
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

        private void MostrarEnGridInOrden(NodoArbolProveedores nodo, DataGridView gv)
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
