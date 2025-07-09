using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class DVertice
    {
        public string dato;

        //trabajar la lista temp
        public DVertice sig = null;

        //trabajar el grafo permanente

        public DArista listaAristas = null;
        public void MostrarArista()
        {
            DArista temp = listaAristas;
            int i = 1;
            while (temp != null)
            {
                DArista v = temp;
                Console.WriteLine(i + ". Ir hacia v" + v.destino.dato + " - " + v.costo
                    );
                temp = temp.sigArista;
                i++;
            }
        }
    }
}
