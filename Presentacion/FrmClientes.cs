using System;
using System.Windows.Forms;
using DATO;
using ENTIDADES;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        private DArbolClientes ArbolClientes = ArbolClientesGlobal.ArbolClientes;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstado.DisplayMember = "Texto";//muestra
            CboEstado.ValueMember = "Valor";//no muestras manejas como valor interno
            CboEstado.SelectedIndex = 0;//seleccionar simpre el primro

            // Mostrar todos los usuarios 
            ArbolClientes.MostrarGrid(DgvData);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            // Validar que el campo Código Usuario no esté vacío y sea número
            if (!int.TryParse(TxtDocumento.Text, out int DocumentoCliente))
            {
                MessageBox.Show("El campo 'Código Usuario' debe ser un número válido.");
                return;
            }

            var estadoSeleccionado = (OpcionCombo)CboEstado.SelectedItem;

            ECliente obJClientes = new ECliente()
            {
                Documento = DocumentoCliente,
                NombreCompleto = TxtNombreCompleto.Text,
                Correo = TxtCorreo.Text,
                Telefono = TxtTelefono.Text,
                Estado = Convert.ToInt32(estadoSeleccionado.Valor) == 1
            };

            if (TxtId.Text == "0")
            {
                //int idusuariogenerado = new DArbolUsuario().RegistrarUsuario(objusuario, out mensaje);
                int idProveedorgenerado = ArbolClientes.RegistrarCliente(obJClientes, out mensaje);

                if (idProveedorgenerado != 0)
                {
                    ArbolClientes.MostrarGrid(DgvData);
                    MessageBox.Show(mensaje);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                obJClientes.IdCliente = Convert.ToInt32(TxtId.Text);

                //bool resultado = new DArbolUsuario().EditarUsuario(objusuario, out mensaje);
                bool resultado = ArbolClientes.EditarUsuario(obJClientes, out mensaje);
                if (resultado)
                {
                    ArbolClientes.MostrarGrid(DgvData);
                    MessageBox.Show(mensaje);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                Limpiar();
                return;
            }
        }
        private void Limpiar()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "0";
            TxtDocumento.Text = "";
            TxtNombreCompleto.Text = "";
            TxtCorreo.Text = "";
            TxtTelefono.Text = "";
            CboEstado.SelectedIndex = 0;

            TxtDocumento.Select();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DgvData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtDocumento.Text = DgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    TxtNombreCompleto.Text = DgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    TxtCorreo.Text = DgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtTelefono.Text = DgvData.Rows[indice].Cells["Telefono"].Value.ToString();

                    foreach (OpcionCombo oc in CboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = CboEstado.Items.IndexOf(oc);
                            CboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtDocumento.Text, out int Documento))
            {
                MessageBox.Show("El campo 'Documento' debe ser un número válido.");
                return;
            }
            //int Documento = int.Parse(TxtDocumento.Text);
            if (TxtId.Text != "0")
            {
                if (TxtId.Text == "1")
                {
                    MessageBox.Show("Este usuario no se puede eliminar");
                    return;
                }
                ArbolClientes.EliminarCliente(Documento);
                MessageBox.Show("Cliente Eliminado Correctamente");
                ArbolClientes.MostrarGrid(DgvData);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede Eliminar\nEl Documento no existe!!");
            }
        }
    }
}
