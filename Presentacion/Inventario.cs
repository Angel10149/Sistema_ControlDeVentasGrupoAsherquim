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
    public partial class Inventario : Form
    {
        DListaDetalleCompra detallecompra = ListaDetalleCompraGlobal.ListaDetalleCompra;
        DListaCompra listacompra = DListaCompraGlobal.listaCompra;
        DListaDetalleVenta DetalleVenta = ListaDetalleVentaGlobal.ListaDetalleVenta;
        DListaVenta listaventa = DListaVentaGlobal.listaVenta;
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            detallecompra.MostrarGrid(DgvDataDetalleCompra);
            listacompra.MostrarGrid(DgvDataCompra);
            DetalleVenta.MostrarGrid(DgvDataDetalleVenta);
            listaventa.MostrarGrid(DgvDataVenta);
        }
    }
}
