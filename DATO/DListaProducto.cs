using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DListaProducto
    {
        public NodoListaProducto primero = null;
        public NodoListaProducto ultimo = null;

        // Constructor con roles iniciales
        public DListaProducto()//costructor
        {
            // Rol Administrador
            EProducto P1 = new EProducto
            {
                IdProducto = 1,
                Nombre = "P1",
                Descripcion = "Arroz",
                //Categoria = new ECategoria { IdCategoria = 1, Descripcion = "A", Estado = true },
                IdCategoria = 1,
                Estado = true
            };

            // Rol Empleado
            EProducto P2 = new EProducto
            {
                IdProducto = 2,
                Nombre = "P2",
                Descripcion = "Arina",
                //Categoria = new ECategoria { IdCategoria = 2, Descripcion = "B", Estado = true },
                IdCategoria = 1,
                Estado = true
            };
            EProducto P3 = new EProducto
            {
                IdProducto = 3,
                Nombre = "P3",
                Descripcion = "leche",
                //Categoria = new ECategoria { IdCategoria = 2, Descripcion = "B", Estado = true },
                IdCategoria = 1,
                Estado = true
            };
            EProducto P4 = new EProducto
            {
                IdProducto = 4,
                Nombre = "P4",
                Descripcion = "azucar",
                //Categoria = new ECategoria { IdCategoria = 2, Descripcion = "B", Estado = true },
                IdCategoria = 2,
                Estado = true
            };
            EProducto P5 = new EProducto
            {
                IdProducto = 5,
                Nombre = "P5",
                Descripcion = "Arroz",
                //Categoria = new ECategoria { IdCategoria = 2, Descripcion = "B", Estado = true },
                IdCategoria = 3,
                Estado = true
            };
            EProducto P6 = new EProducto
            {
                IdProducto = 6,
                Nombre = "P6",
                Descripcion = "fideo",
                //Categoria = new ECategoria { IdCategoria = 2, Descripcion = "B", Estado = true },
                IdCategoria = 3,
                Estado = true
            };

            // Insertar roles
            Agregar(P1);
            Agregar(P2);
            Agregar(P3);
            Agregar(P4);
            Agregar(P5);
            Agregar(P6);

        }
        private int ObtenerSiguienteIdProducto()
        {
            int maxId = 0;
            ObtenerMaximoID(primero, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoListaProducto nodo, ref int MxId)//crear id ussuario segun como se registra
        {
            if (nodo == null)
            {
                return;
            }

            NodoListaProducto actual = nodo;
            do
            {
                if (actual.dato.IdProducto > MxId)
                {
                    MxId = actual.dato.IdProducto;
                }
                actual = actual.siguiente;
            } while (actual != nodo);
        }
        public int RegistarProducto(EProducto Produc)
        {
            Produc.IdProducto = ObtenerSiguienteIdProducto();
            Agregar(Produc);
            return Produc.IdProducto;
        }
        private void Agregar(EProducto product)
        {
            NodoListaProducto nuevo = new NodoListaProducto();
            nuevo.dato = product;
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
        /*public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("No hay canciones agregadas");
            }
            else
            {
                NodoListaProducto temp = primero;
                do
                {
                    Console.Write(temp.dato);
                    temp = temp.siguiente;
                }
                while (temp != primero);
            }
        }*/

        public EProducto BuscarProductoPorNombre(string nombre)
        {
            NodoListaProducto temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.Nombre == nombre)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public EProducto Eliminar(EProducto Prod)
        {
            if (primero == null)
            {
                //Console.WriteLine("No existe la categoria");
                return null;
            }
            NodoListaProducto temp = primero;

            do
            {
                if (temp.dato.Nombre.ToLower() == Prod.Nombre.ToLower())
                {
                    if (temp == primero && temp == ultimo)
                    {
                        primero = null;
                        ultimo = null;
                        //actual = null;//general
                    }
                    else if (temp == primero)
                    {
                        primero = primero.siguiente;
                        primero.anterior = ultimo;
                        ultimo.siguiente = primero;
                    }
                    else if (temp == ultimo)
                    {
                        ultimo = ultimo.anterior;
                        ultimo.siguiente = primero;
                        primero.anterior = ultimo;
                    }
                    else
                    {
                        temp.anterior.siguiente = temp.siguiente;
                        temp.siguiente.anterior = temp.anterior;//faltaba el .anterior
                    }
                    //Console.WriteLine("Categoria: " + nombre + " eliminada!");
                    return Prod;
                }
                temp = temp.siguiente;
            } while (temp != primero);
            return null;
        }
        public int ContarProductos()
        {
            int contador = 0;
            if (primero == null)
            {
                contador = 0;
                return contador;
            }
            else
            {
                NodoListaProducto temp = primero;
                do
                {
                    contador++;
                    temp = temp.siguiente;
                }
                while (temp != primero);
                return contador;
            }
        }
        public void MostrarGrid(DataGridView gv)
        {
            gv.Rows.Clear();
            MostrarEnGridProducto(primero, gv);
        }

        private void MostrarEnGridProducto(NodoListaProducto temp, DataGridView gv)
        {
            if (temp != null)
            {
                temp = primero;
                do
                {
                    gv.Rows.Add(temp.dato.getdata());         // Nodo actual
                                                              //Console.Write(temp.dato);
                    temp = temp.siguiente;
                }
                while (temp != primero);
            }
        }
    }
}
