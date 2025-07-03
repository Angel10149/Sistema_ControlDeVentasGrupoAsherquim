using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace DATO
{
    public class DListaCategoria
    {
        public NodoListaCategoria primero = null;
        public NodoListaCategoria ultimo = null;

        // Constructor con categorias iniciales
        public DListaCategoria()//costructor
        {
            // categoria 1
            ECategoria categoria1 = new ECategoria
            {
                IdCategoria = 1,
                Descripcion = "A",
                Estado = true
            };

            // categoria 2
            ECategoria categoria2 = new ECategoria
            {
                IdCategoria = 2,
                Descripcion = "B",
                Estado = true
            };
            ECategoria categoria3 = new ECategoria
            {
                IdCategoria = 3,
                Descripcion = "C",
                Estado = true
            };

            // Insertar roles
            Agregar(categoria1);
            Agregar(categoria2);
            Agregar(categoria3);
        }
        private int ObtenerSiguienteIdCategoria()
        {
            int maxId = 0;
            ObtenerMaximoID(primero, ref maxId);
            return maxId + 1;
        }
        private void ObtenerMaximoID(NodoListaCategoria nodo, ref int MxId)//crear id ussuario segun como se registra
        {
            if (nodo == null)
            {
                return;
            }

            NodoListaCategoria actual = nodo;
            do
            {
                if (actual.dato.IdCategoria > MxId)
                {
                    MxId = actual.dato.IdCategoria;
                }
                actual = actual.siguiente;
            } while (actual != nodo);
        }
        public int RegistarCategoria(ECategoria cate)
        {
            cate.IdCategoria = ObtenerSiguienteIdCategoria();
            Agregar(cate);
            return cate.IdCategoria;
        }
        private void Agregar(ECategoria categori)
        {
            NodoListaCategoria nuevo = new NodoListaCategoria();
            nuevo.dato = categori;
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
                NodoListaCategoria temp = primero;
                do
                {
                    Console.Write(temp.dato);
                    temp = temp.siguiente;
                }
                while (temp != primero);
            }
        }*/

        public ECategoria BuscarCategoriaPorNombre(string nombre)
        {
            NodoListaCategoria temporal = primero;

            if (temporal == null)
            {
                return null;
            }
            do
            {
                if (temporal.dato.Descripcion == nombre)
                {
                    return temporal.dato;
                }
                temporal = temporal.siguiente;

            } while (temporal != primero);
            return null;
        }
        public ECategoria Eliminar(ECategoria cat)
        {
            if (primero == null)
            {
                //Console.WriteLine("No existe la categoria");
                return null;
            }
            NodoListaCategoria temp = primero;

            do
            {
                if (temp.dato.Descripcion.ToLower() == cat.Descripcion.ToLower())
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
                    return cat;
                }
                temp = temp.siguiente;
            } while (temp != primero);
            return null;
        }
        public int ContarCategoria()
        {
            int contador = 0;
            if (primero == null)
            {
                contador = 0;
                return contador;
            }
            else
            {
                NodoListaCategoria temp = primero;
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
            MostrarEnGridInOrden(primero, gv);
        }

        private void MostrarEnGridInOrden(NodoListaCategoria temp, DataGridView gv)
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
