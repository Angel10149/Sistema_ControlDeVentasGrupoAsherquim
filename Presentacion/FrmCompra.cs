using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using DATO;
using ENTIDADES;

namespace Presentacion
{
    public partial class FrmCompra : Form
    {
        private EUsuario Usuario;
        public FrmCompra(EUsuario UsuarioIniciado = null)
        {
            Usuario = UsuarioIniciado;
            InitializeComponent();
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            //TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TxtIdProveedor.Text = "0";
            TxtIdProducto.Text = "0";
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new Proveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor.Text = modal.proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal.proveedor.Documento.ToString();
                    txtnombreproveedor.Text = modal.proveedor.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
                }
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new Producto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = modal.producto.IdProducto.ToString();
                    TxtCodProducto.Text = modal.producto.Codigo;
                    txtproducto.Text = modal.producto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    TxtCodProducto.Select();
                }

            }
        }

        private void TxtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(TxtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio ECompra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == TxtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                dgvdata.Rows.Add(new object[] {
                    TxtIdProducto.Text,
                    txtproducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * preciocompra).ToString("0.00")

                });

                CalcularTotal();
                LimpiarProducto();
                TxtCodProducto.Select();

            }
        }
        private void LimpiarProducto()
        {
            TxtIdProducto.Text = "0";
            TxtCodProducto.Text = "";
            TxtCodProducto.BackColor = Color.White;
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
        }
    }
}
