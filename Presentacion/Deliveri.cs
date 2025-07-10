using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATO;

namespace Presentacion
{
    public partial class Deliveri : Form
    {
        public Deliveri()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            string origen = "A";  // Asegúrate de usar mayúsculas (A, B, C...)
            string destino = TxtDestino.Text.Trim().ToUpper();

            // Suponiendo que ya creaste y configuraste tu grafo antes
            DGrafo grafo = new DGrafo(5);
            grafo.RegistrarVertices();
            grafo.llenarMatriz();
            grafo.llenarMatrizCosto();
            grafo.crearGrafo();

            int costo = grafo.Dijkstra(origen, destino);

            if (costo == -1)
            {
                lbDistancia.Text = "No hay camino posible entre los vértices.";
            }
            else
            {
                lbDistancia.Text = $"Distancia mínima desde {origen} hasta {destino}: {costo} Km";
            }
        }
    }
}
