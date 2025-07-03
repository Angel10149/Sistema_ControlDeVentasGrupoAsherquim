using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DArbolClientes
    {
        public NodoArbolCliente RaizPrincipal = null;
        //Usuarios Predefinidos
        public DArbolClientes()
        {

            if (RaizPrincipal == null)
            {
                ECliente Cliente= new ECliente
                {
                    IdCliente = 1,
                    Documento = 101010,
                    NombreCompleto = "Cliente ABC S.A.",
                    Correo = "contacto@abc.com",
                    Telefono = "+51 911 123 678",
                    Estado = true
                };

                ECliente Cliente1 = new ECliente
                {
                    IdCliente = 2,
                    Documento = 202020,
                    NombreCompleto = "Distribuciones ABC",
                    Correo = "ventas@abc.com",
                    Telefono = "+51 911 765 432",
                    Estado = true
                };
                InsertarDato(ref RaizPrincipal, Cliente);
                InsertarDato(ref RaizPrincipal, Cliente1);
            }

        }
        //Registrar Usuaro
        private int ObtenerSiguienteIdCliente()
        {
            int maxId = 0;
            ObtenerMaximoID(RaizPrincipal, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoArbolCliente raiz, ref int MxId)//crear id ussuario segun como se registra
        {
            if (raiz == null)
            {
                return;
            }
            if (raiz.dato.IdCliente > MxId)
            {
                MxId = raiz.dato.IdCliente;
            }
            ObtenerMaximoID(raiz.izquierda, ref MxId);
            ObtenerMaximoID(raiz.derecha, ref MxId);
        }
        public int RegistrarCliente(ECliente Cliente, out string Mensaje)
        {
            Mensaje = "";

            if (Cliente.Documento == 0)
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }
            if (Cliente.NombreCompleto.Replace(" ", "") == "")//replace elimina los espacios
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }
            /*if (Mensaje != "")
            {
                return 0;
            }*/
            if (Buscar(Cliente.Documento) != null)
            {
                Mensaje = "En el sistema ya existe un Cliente\ncon ese codigo";
                return 0;
            }
            Cliente.IdCliente = ObtenerSiguienteIdCliente();
            InsertarDato(ref RaizPrincipal, Cliente);
            Mensaje = "Cliente registrado correctamente";
            return Cliente.IdCliente;
        }
        private void InsertarDato(ref NodoArbolCliente raiz, ECliente dato)
        {
            if (raiz == null)
            {
                NodoArbolCliente nuevo = new NodoArbolCliente();
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
        //Editar Cliente
        public bool EditarUsuario(ECliente Cliente, out string Mensaje)
        {
            Mensaje = "";

            if (Cliente.Documento == 0)
            { Mensaje += "Es necesario el documento del Cliente\n"; }


            if (string.IsNullOrWhiteSpace(Cliente.NombreCompleto))
            { Mensaje += "Es necesario el nombre completo del Cliente\n"; }

            if (Mensaje != "")
            { return false; }

            return Editar(Cliente, out Mensaje);
        }
        private bool Editar(ECliente Cliente, out string mensaje)
        {
            mensaje = "";
            ECliente encontrado = Buscar(Cliente.Documento);
            if (encontrado == null)
            {
                mensaje = "Cliente No Encontrado";
                return false;
            }

            encontrado.NombreCompleto = Cliente.NombreCompleto;
            encontrado.Correo = Cliente.Correo;
            encontrado.Telefono = Cliente.Telefono;
            encontrado.Estado = Cliente.Estado;
            // Buscar rol completo desde lista de roles

            mensaje = "Datos del Cliente actualizados";
            return true;
        }
        //Eliminar Cliente
        private NodoArbolCliente BuscarMayor(NodoArbolCliente raiz)
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
        private NodoArbolCliente BuscarMenor(NodoArbolCliente raiz)
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
        public void EliminarCliente(int Documento)
        {
            EliminarRaiz(ref RaizPrincipal, Documento);
        }
        private void EliminarRaiz(ref NodoArbolCliente raiz, int Id)
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
                        NodoArbolCliente mayor = BuscarMayor(raiz.izquierda);
                        ECliente auxiliar = raiz.dato;
                        raiz.dato = mayor.dato;
                        mayor.dato = auxiliar;
                        EliminarRaiz(ref raiz.izquierda, Id);
                    }
                    else
                    {
                        if (Id > RaizPrincipal.dato.Documento)
                        {
                            NodoArbolCliente menor = BuscarMenor(raiz.izquierda);
                            raiz.dato = menor.dato;
                            EliminarRaiz(ref raiz.izquierda, menor.dato.Documento);
                        }
                        else
                        {
                            NodoArbolCliente mayor = BuscarMayor(raiz.derecha);
                            raiz.dato = mayor.dato;
                            EliminarRaiz(ref raiz.derecha, mayor.dato.Documento);
                        }
                    }
                }
            }
        }

        //Buscar Cliente
        public ECliente Buscar(int CodigoUsu)
        {
            ECliente dat = BuscarRaizz(RaizPrincipal, CodigoUsu);
            return dat;
        }
        private ECliente BuscarRaizz(NodoArbolCliente raiz, int CodigoU)
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

        private void MostrarEnGridInOrden(NodoArbolCliente nodo, DataGridView gv)
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
