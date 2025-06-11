using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATO
{
    public class DArbolUsuario
    {
        public DNodoArbolUsuario RaizPrincipal = null;
        public void Insertar(EUsuario d)
        {
            InsertarDato(ref RaizPrincipal, d);
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
        public void EliminarUsuario(EUsuario dato)
        {
            EliminarRaiz(ref RaizPrincipal, dato);
        }
        private void EliminarRaiz(ref DNodoArbolUsuario raiz, EUsuario BuscandoDato)
        {
            if (raiz == null)
            {
                Console.WriteLine("El Paciente No existe en el Registro");
            }
            else
            {
                if (BuscandoDato.CodigoUsuario < raiz.dato.CodigoUsuario)
                {
                    EliminarRaiz(ref raiz.izquierda, BuscandoDato);
                }
                else if (BuscandoDato.CodigoUsuario > raiz.dato.CodigoUsuario)
                {
                    EliminarRaiz(ref raiz.derecha, BuscandoDato);
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
                        EliminarRaiz(ref raiz.izquierda, BuscandoDato);
                    }
                    else
                    {

                        if (BuscandoDato.CodigoUsuario > RaizPrincipal.dato.CodigoUsuario)
                        {
                            DNodoArbolUsuario menor = BuscarMenor(raiz.izquierda);
                            raiz.dato = menor.dato;
                            EliminarRaiz(ref raiz.izquierda, menor.dato);
                        }
                        else
                        {
                            DNodoArbolUsuario mayor = BuscarMayor(raiz.derecha);
                            raiz.dato = mayor.dato;
                            EliminarRaiz(ref raiz.derecha, mayor.dato);
                        }
                    }
                }
            }
        }
        public EUsuario BuscarPersona(EUsuario dato)
        {
            EUsuario per = BuscarRaiz(RaizPrincipal, dato);
            return per;
        }
        private EUsuario BuscarRaiz(DNodoArbolUsuario raiz, EUsuario BuscandoDato)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (BuscandoDato.CodigoUsuario < raiz.dato.CodigoUsuario)
                {
                    return BuscarRaiz(raiz.izquierda, BuscandoDato);
                }
                else if (BuscandoDato.CodigoUsuario > raiz.dato.CodigoUsuario)
                {
                    return BuscarRaiz(raiz.derecha, BuscandoDato);
                }
                else
                {
                    return raiz.dato;
                }
            }
        }

    }
}
