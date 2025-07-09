using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATO
{
    public class DGrafo
    {
        public DVertice inicio_lista = null;
        public int[,] Matriz_Vertice;
        public int[,] Matriz_Costos;

        public int cantidadVertices = 0;//necesario para dijkstra
        public DGrafo(int n)
        {
            Matriz_Vertice = new int[n, n];
            Matriz_Costos = new int[n, n];
        }
        //METODOS PARA LISTA (insertar y mostrar)
        public void RegistrarVertices()
        {
            int Contador = 0;
            string nombre_vertice = "";
            for (int i = 0; i < Matriz_Vertice.GetLength(0); i++)
            {

                Contador++;
                if (Contador == 1)
                {
                    nombre_vertice = "A";
                }
                else if (Contador == 2)
                {
                    nombre_vertice = "B";
                }
                else if (Contador == 3)
                {
                    nombre_vertice = "C";
                }
                else if (Contador == 4)
                {
                    nombre_vertice = "D";
                }
                else
                {
                    nombre_vertice = "E";
                }
                insertar(nombre_vertice);
            }
        }
        public void insertar(string d)
        {
            //1.Crear el nuevo nodo
            DVertice nuevo = new DVertice();
            nuevo.dato = d;

            if (inicio_lista == null)
            {
                //la lista esta vacia
                //el nuevo debe guardarse en el primero
                inicio_lista = nuevo;
            }
            else
            {
                //2. buscar el ultimo
                DVertice temp = inicio_lista;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                //temp esta ubicado en el ultimo
                //3. ultimo.sig el nuevo
                temp.sig = nuevo;

            }
            cantidadVertices++;
        }
        //mostrar
        public void Mostrar()
        {
            DVertice temp = inicio_lista;
            while (temp != null)
            {
                //Console.WriteLine(temp.dato);
                temp = temp.sig;
            }
        }
        //METODOS PARA MATRIZ 
        public void llenarMatriz()
        {
            int n = 0;//si tiene conexion// si= 1 no=0 
            //int contador = 0;//columnas
            //int temp = 1;//filas
            //Random random = new Random();
            for (int i = 0; i < Matriz_Vertice.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_Vertice.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0) { n = 0; }
                        else if (j == 1) { n = 1; }
                        else if (j == 2) { n = 0; }
                        else if (j == 3) { n = 0; }
                        else if (j == 4) { n = 0; }
                        //else { n = 1; }
                    }
                    else if (i == 1)
                    {
                        if (j == 0) { n = 0; }
                        else if (j == 1) { n = 0; }
                        else if (j == 2) { n = 1; }
                        else if (j == 3) { n = 1; }
                        else if (j == 4) { n = 0; }
                    }
                    else if (i == 2)
                    {
                        if (j == 0) { n = 0; }
                        else if (j == 1) { n = 0; }
                        else if (j == 2) { n = 0; }
                        else if (j == 3) { n = 0; }
                        else if (j == 4) { n = 1; }
                    }
                    else if (i == 3)
                    {
                        if (j == 0) { n = 0; }
                        else if (j == 1) { n = 0; }
                        else if (j == 2) { n = 0; }
                        else if (j == 3) { n = 0; }
                        else if (j == 4) { n = 1; }
                    }
                    else if (i == 4)
                    {
                        if (j == 0) { n = 0; }
                        else if (j == 1) { n = 0; }
                        else if (j == 2) { n = 0; }
                        else if (j == 3) { n = 0; }
                        else if (j == 4) { n = 0; }
                    }
                    //contador++;
                    Matriz_Vertice[i, j] = n;// random.Next(0, 2);
                }
            }
        }
        public void llenarMatrizCosto()
        {
            for (int i = 0; i < Matriz_Costos.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_Costos.GetLength(1); j++)
                {
                    Matriz_Costos[i, j] = 0;
                    // Sin conexión por defecto
                }
            }
            Matriz_Costos[0, 1] = 3;
            Matriz_Costos[1, 2] = 4;
            Matriz_Costos[1, 3] = 6;
            Matriz_Costos[2, 4] = 2;
            Matriz_Costos[3, 4] = 3;
        }
        public void mostrarMatrizcosto()
        {
            DVertice temp = inicio_lista;
            //Console.Write("\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            while (temp != null)
            {
                Console.Write(temp.dato + "\t");
                temp = temp.sig;
            }
            //Console.WriteLine();
            //Console.ResetColor();

            temp = inicio_lista;
            for (int i = 0; i < Matriz_Costos.GetLength(0); i++)
            {
               //Console.ForegroundColor = ConsoleColor.Green;
               //Console.Write("Costo. " + temp.dato + "\t");
                //Console.ResetColor();
                for (int j = 0; j < Matriz_Costos.GetLength(1); j++)
                {
                    //Console.Write(Matriz_Costos[i, j] + "\t");

                }
                //Console.WriteLine();
                temp = temp.sig;
            }
        }
        public void mostrarMatriz()
        {
            DVertice temp = inicio_lista;
            //Console.Write("\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            while (temp != null)
            {
                //Console.Write(temp.dato + "\t");
                temp = temp.sig;
            }
            //Console.WriteLine();
            //Console.ResetColor();

            temp = inicio_lista;
            for (int i = 0; i < Matriz_Vertice.GetLength(0); i++)
            {
               // Console.ForegroundColor = ConsoleColor.Blue;
                //Console.Write("DVertice. " + temp.dato + "\t");
                //Console.ResetColor();
                for (int j = 0; j < Matriz_Vertice.GetLength(1); j++)
                {
                    //Console.Write(Matriz_Vertice[i, j] + "\t");
                }
                //Console.WriteLine();
                temp = temp.sig;
            }
        }
        //METODOS DE GRAFOS
        public void crearGrafo()
        {
            DVertice tempOrigen = inicio_lista;
            for (int i = 0; i < Matriz_Vertice.GetLength(0); i++)//0= filas, origen
            {
                DVertice tempDestino = inicio_lista;
                for (int j = 0; j < Matriz_Vertice.GetLength(1); j++)//1=columnas, destinos
                {
                    if (Matriz_Vertice[i, j] == 1)//si adyacencia o arista
                    {
                        //union
                        DArista nuevo = new DArista();
                        nuevo.destino = tempDestino;
                        //Console.WriteLine("ingrese el costo desde {0} hasta {1}", tempOrigen.dato, tempDestino.dato);
                        //nuevo.costo = int.Parse(Console.ReadLine());
                        //int costo = 0;
                        if (tempOrigen.dato == "A" && tempDestino.dato == "B")
                        {
                            nuevo.costo = 3;
                        }
                        if (tempOrigen.dato == "B" && tempDestino.dato == "C")
                        {
                            nuevo.costo = 4;
                        }
                        if (tempOrigen.dato == "B" && tempDestino.dato == "D")
                        {
                            nuevo.costo = 6;
                        }
                        if (tempOrigen.dato == "C" && tempDestino.dato == "E")
                        {
                            nuevo.costo = 2;
                        }
                        if (tempOrigen.dato == "D" && tempDestino.dato == "E")
                        {
                            nuevo.costo = 3;
                        }

                        if (tempOrigen.listaAristas == null)
                        {
                            tempOrigen.listaAristas = nuevo;
                        }
                        else
                        {
                            DArista temp = tempOrigen.listaAristas;
                            while (temp.sigArista != null)
                            {
                                temp = temp.sigArista;
                            }
                            temp.sigArista = nuevo;
                        }

                    }
                    tempDestino = tempDestino.sig;
                }
                tempOrigen = tempOrigen.sig;
            }
        }

        public void recorrerGrafo(DVertice actual, ref int total)
        {
            //Console.Clear();
            //Console.WriteLine("Recorrido del grafo");
            string vertice = "";
            if (actual.dato == "A")
            {
                vertice = "Plaza de Armas";
            }
            if (actual.dato == "B")
            {
                vertice = "Avenida Perú";
            }
            if (actual.dato == "C")
            {
                vertice = "La Paz";
            }
            if (actual.dato == "D")
            {
                vertice = "Avenida Industrial";
            }
            if (actual.dato == "E")
            {
                vertice = "Salida";
            }
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("vertice actual:" + vertice);//15
            //Console.ResetColor();
            actual.MostrarArista();
            //Console.WriteLine("0.Salir");
            //Console.WriteLine("ingrese una opcion");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion != 0)
            {
                DArista temp = actual.listaAristas;

                for (int i = 1; i < opcion; i++)
                {
                    temp = temp.sigArista;
                }
                total += temp.costo;
                recorrerGrafo(temp.destino, ref total);
            }
            else
            {
                //Console.WriteLine("Costo Total: " + total);
                return;
            }
            //Console.ReadKey();
        }

        public DVertice Buscar(string ubicacion)
        {

            DVertice temp = inicio_lista;
            while (temp != null)
            {
                if (temp.dato == ubicacion)
                {
                    return temp;
                }
                temp = temp.sig;
            }
            return null;
        }

        public void Dijkstra(string origen, string destino)
        {
            // Encontrar los vértices correspondientes al origen y destino
            DVertice vOrigen = Buscar(origen);
            DVertice vDestino = Buscar(destino);

            // Verifica si el vértice de origen o destino no existen y muestra un mensaje de error
            if (vOrigen == null || vDestino == null)
            {
               // Console.WriteLine("El vértice origen o destino no existe.");
                return; // Termina la ejecución del método si no se encuentran los vértices
            }

            // Inicializar y almacenar las distancias y vértices previos visitados en una estructura de lista simple
            ListaEnlazadaDistancias listaDistancias = new ListaEnlazadaDistancias(); // Lista para almacenar distancias desde el origen
            DListaEnlazada visitados = new DListaEnlazada(); // Lista para registrar vértices ya visitados

            // Inicializa las distancias de todos los vértices
            DVertice actual = inicio_lista; // Apunta al primer vértice de la lista de vértices
            while (actual != null)
            {
                // Establece la distancia del origen como 0 y las demás como infinito (int.MaxValue)
                int distanciaInicial;
                if (actual == vOrigen)
                {
                    distanciaInicial = 0;
                }
                else
                {
                    distanciaInicial = int.MaxValue;
                }
                listaDistancias.Agregar(actual, distanciaInicial, null);
                actual = actual.sig;
            }
            // Aplica el algoritmo de Dijkstra hasta que todos los vértices hayan sido visitados
            while (visitados.cantidadVisitados < cantidadVertices)
            {
                // Obtiene el siguiente vértice no visitado con la menor distancia acumulada
                ListaEnlazadaDistancias.NodoDistancia verticeActual = ObtenerVNoVisitadoConMenorDistancia(listaDistancias, visitados);

                if (verticeActual == null)
                {
                    //Console.WriteLine("No se puede encontrar un camino hacia el vértice destino.");
                    return;
                }

                // Agrega el vértice actual a la lista de visitados
                visitados.Agregar(verticeActual.vertice);

                // Actualiza las distancias de los vértices adyacentes
                DArista arista = verticeActual.vertice.listaAristas; // Obtiene la lista de aristas del vértice actual
                while (arista != null)
                {
                    // Obtiene el nodo de distancia del vértice destino de la arista actual
                    ListaEnlazadaDistancias.NodoDistancia nodoDestino = listaDistancias.ObtenerNodo(arista.destino);
                    int nuevadistancia = verticeActual.costo + arista.costo; // Calcula la nueva distancia acumulada

                    // Si la nueva distancia es menor que la distancia previamente conocida, la actualiza
                    if (nuevadistancia < nodoDestino.costo)
                    {
                        nodoDestino.costo = nuevadistancia;
                        nodoDestino.previo = verticeActual.vertice;
                    }
                    arista = arista.sigArista;
                }
            }

            // Mostrar el resultado final
            if (listaDistancias.ObtenerNodo(vDestino).costo == int.MaxValue)
            {

                //Console.WriteLine("No se puede encontrar un camino hacia el vértice destino.");
            }
            else
            {

               //Console.WriteLine("El camino más corto desde " + origen + " hasta " + destino + " es:");
                DVertice actual2 = vDestino;
                string camino = actual2.dato;

                while (actual2 != vOrigen)
                {

                    actual2 = listaDistancias.ObtenerNodo(actual2).previo;

                    camino = actual2.dato + " ir a " + camino;
                }
               // Console.WriteLine(camino);
                //Console.WriteLine("Costo total: " + listaDistancias.ObtenerNodo(vDestino).costo);
            }
        }

        // Verifica si el vértice no está en la lista de visitados y si es el nodo con menor costo encontrado
        private ListaEnlazadaDistancias.NodoDistancia ObtenerVNoVisitadoConMenorDistancia(ListaEnlazadaDistancias listaDistancias, DListaEnlazada visitados)
        {
            //completar segun la logica presentada durante clase 
            ListaEnlazadaDistancias.NodoDistancia menor = null;
            ListaEnlazadaDistancias.NodoDistancia actual = listaDistancias.PrimerNodo; // Asume que tienes un puntero 'inicio' a la lista

            while (actual != null)
            {
                if (!visitados.Contiene(actual.vertice)) // Método que verifica si un vértice ya fue visitado
                {
                    if (menor == null || actual.costo < menor.costo)
                    {
                        menor = actual;
                    }
                }
                actual = actual.siguiente; // Moverse al siguiente nodo
            }

            return menor;
        }
    }
}
