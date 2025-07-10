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
    public partial class FrmVenta : Form
    {
        private EUsuario Usuarios;
        private DListaProducto ListaProductos = ListaProductoGlobal.listaproducto;
        private DListaDetalleVenta ListaDetalleVenta = ListaDetalleVentaGlobal.ListaDetalleVenta;
        private DListaVenta ListaVentas = DListaVentaGlobal.listaVenta;

        public FrmVenta(EUsuario UsuarioIniciado = null)
        {
            Usuarios = UsuarioIniciado;
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            //TxtIdProveedor.Text = "0";
            TxtIdProducto.Text = "0";
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new Clientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdCliente.Text = modal.Cliente.IdCliente.ToString();
                    TxtDocumentoCliente.Text = modal.Cliente.Documento.ToString();
                    TxtNombreCliente.Text = modal.Cliente.NombreCompleto;
                }
                else
                {
                    TxtDocumentoCliente.Select();
                }
            }

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new Producto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = modal.producto.IdProducto.ToString();
                    TxtCodProducto.Text = modal.producto.Codigo;
                    TxtProducto.Text = modal.producto.Nombre;
                    TxtPrecio.Text = modal.producto.PrecioVenta.ToString("0.00");
                    TxtStock.Text = modal.producto.Stock.ToString();
                    TxtCantidad.Select();
                }
                else
                {
                    TxtCodProducto.Select();
                }

            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(TxtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TxtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(TxtStock.Text) < Convert.ToInt32(TxtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    TxtProducto.Text,
                    precio.ToString("0.00"),
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * precio).ToString("0.00")

                });

                CalcularTotal();
                LimpiarProducto();
                TxtCodProducto.Select();

            }
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            TxtTotalPagar.Text = total.ToString("0.00");
        }
        private void LimpiarProducto()
        {
            TxtIdProducto.Text = "0";
            TxtCodProducto.Text = "";
            TxtProducto.Text = "";
            TxtPrecio.Text = "";
            TxtStock.Text = "";
            TxtCantidad.Value = 1;
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void TxtPagoCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPagoCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
        private void calcularcambio()
        {

            if (TxtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(TxtTotalPagar.Text);

            if (TxtPagoCon.Text.Trim() == "")
            {
                TxtPagoCon.Text = "0";
            }

            if (decimal.TryParse(TxtPagoCon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    TxtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    TxtCambio.Text = cambio.ToString("0.00");

                }
            }



        }
        private void TxtPagoCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            calcularcambio();
            //Crear compra 
            EVentas venta = new EVentas
            {
                Usuario = Usuarios,
                Cliente = new ECliente
                {
                    IdCliente = Convert.ToInt32(TxtIdCliente.Text),
                    Documento = int.Parse(TxtDocumentoCliente.Text),  // ← Esto es necesario
                    NombreCompleto = TxtNombreCliente.Text
                },
                MontoTotal = 0m
            };

            // Registrar la compra para obtener el ID
            int idVenta = ListaVentas.RegistarVenta(venta);

            // Generar Número de Documento en base al ID
            venta.NumeroDocumento = idVenta.ToString("D7"); // D7 = 7 dígitos con ceros a la izquierda

            decimal total = 0m;//m indica q es decimal

            //Registrar cada producto en la lista de detalles
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                string nombreProducto = row.Cells["Producto"].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precioVenta = Convert.ToDecimal(row.Cells["Precio"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);

                // Actualizar stock y precios del producto
                bool actualizado = ListaProductos.RestarStockProducto(idProducto, cantidad);
                if (!actualizado)
                {
                    MessageBox.Show($"No se pudo actualizar el stock del producto con ID {idProducto}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                //Buscar el producto completo para vincularlo al detalle
                EProducto producto = ListaProductos.BuscarProductoPorNombre(nombreProducto);
                if (producto == null)
                {
                    MessageBox.Show($"Producto con nombre {nombreProducto} no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                //Crear detalle y registrar
                EDetalleVenta detalle = new EDetalleVenta
                {
                    IdVenta = idVenta,
                    Producto = producto,
                    PrecioVenta = precioVenta,
                    Cantidad = cantidad,
                    SubTotal = subtotal
                };

                ListaDetalleVenta.RegistarVenta(detalle);
                total += subtotal;
            }

            //Actualizar el monto total de la compra
            venta.MontoTotal = total;

            //Confirmación al usuario
            MessageBox.Show($"Compra registrada exitosamente\nDocumento: {venta.NumeroDocumento}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpiar la interfaz
            dgvdata.Rows.Clear();
            TxtTotalPagar.Text = "0.00";
            TxtCambio.Text = "0.00";
        }
    }
}
