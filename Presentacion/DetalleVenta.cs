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
    public partial class DetalleVenta : Form
    {
        DListaDetalleVenta ListaDetalleVenta = ListaDetalleVentaGlobal.ListaDetalleVenta;
        DListaVenta listaventas = DListaVentaGlobal.listaVenta;

        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
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
            EVentas venta = listaventas.BuscarVentaPorDocumento(numeroDocumento);

            if (venta == null)
            {
                MessageBox.Show("No se encontró la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar información de la venta
            txtnumerodocumento.Text = venta.NumeroDocumento;
            txtusuario.Text = venta.Usuario?.NombreCompleto ?? "";
            txtdoccliente.Text = venta.Cliente?.Documento.ToString() ?? "";
            txtnombrecliente.Text = venta.Cliente?.NombreCompleto ?? "";

            // Mostrar detalles
            dgvdata.Rows.Clear();
            ListaDetalleVenta.MostrarDetallesPorDocumento(numeroDocumento, dgvdata);

            //DListaDetalleCompraGlobal.ListaDetalleCompra.MostrarDetallesPorIdCompra(compra.IdCompra, dgvdata);

            MessageBox.Show("Monto registrado: " + venta.MontoTotal.ToString("0.00"));
            // Mostrar total
            txtmontototal.Text = venta.MontoTotal.ToString("0.00");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";
            txtbusqueda.Text = "";
            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
        }
    }
}
