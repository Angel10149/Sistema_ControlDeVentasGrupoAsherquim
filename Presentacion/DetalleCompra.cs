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
using ENTIDADES;

namespace Presentacion
{
    public partial class DetalleCompra : Form
    {
        DListaDetalleCompra ListaDetalleCompra = ListaDetalleCompraGlobal.ListaDetalleCompra;
        DListaCompra listacompras = DListaCompraGlobal.listaCompra;
        public DetalleCompra()
        {
            InitializeComponent();
        }

        private void DetalleCompra_Load(object sender, EventArgs e)
        {

        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string numeroDocumento = txtbusqueda.Text.Trim();

            if (string.IsNullOrEmpty(numeroDocumento))
            {
                MessageBox.Show("Ingrese el número de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar la compra por número de documento
            ECompra compra = listacompras.BuscarCompraPorDocumento(numeroDocumento);

            if (compra == null)
            {
                MessageBox.Show("No se encontró la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar información de la compra
            txtnumerodocumento.Text = compra.NumeroDocumento;
            txtusuario.Text = compra.Usuario?.NombreCompleto ?? "";
            txtdocproveedor.Text = compra.Proveedor?.Documento.ToString() ?? "";
            txtnombreproveedor.Text = compra.Proveedor?.RazonSocial ?? "";

            // Mostrar detalles
            dgvdata.Rows.Clear();
            ListaDetalleCompra.MostrarDetallesPorDocumento(numeroDocumento, dgvdata);

            //DListaDetalleCompraGlobal.ListaDetalleCompra.MostrarDetallesPorIdCompra(compra.IdCompra, dgvdata);

            MessageBox.Show("Monto registrado: " + compra.MontoTotal.ToString("0.00"));
            // Mostrar total
            TxtMontoTotal.Text = compra.MontoTotal.ToString("0.00");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";

            dgvdata.Rows.Clear();
            TxtMontoTotal.Text = "0.00";
        }

    }
}
