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
    public partial class FrmUsuarios : Form
    {
        private DArbolUsuario arbolUsuarios = ArbolUsuarioGlobal.ArbolUsuarios;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstado.DisplayMember = "Texto";//muestra
            CboEstado.ValueMember = "Valor";//no muestras manejas como valor interno
            CboEstado.SelectedIndex = 0;//seleccionar simpre el primro

            // Cargar roles
            DListaRol logicaRol = new DListaRol();
            NodoListaRol actual = logicaRol.primero;

            if (actual != null)
            {
                NodoListaRol inicio = actual;

                do
                {
                    ERol rol = actual.dato;

                    CboRol.Items.Add(new OpcionCombo()
                    {
                        Valor = rol.IdRol,
                        Texto = rol.Descripcion
                    });

                    actual = actual.siguiente;

                } while (actual != inicio);
            }

            CboRol.DisplayMember = "Texto";
            CboRol.ValueMember = "Valor";
            CboRol.SelectedIndex = 0;
            // Mostrar todos los usuarios 
            arbolUsuarios.MostrarGrid(DgvData);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            // Validar que el campo Código Usuario no esté vacío y sea número
            if (!int.TryParse(TxtCodigoUsuario.Text, out int codigoUsuario))
            {
                MessageBox.Show("El campo 'Código Usuario' debe ser un número válido.");
                return;
            }

            if (CboRol.SelectedItem == null || CboEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol y un estado.");
                return;
            }

            var rolSeleccionado = (OpcionCombo)CboRol.SelectedItem;
            var estadoSeleccionado = (OpcionCombo)CboEstado.SelectedItem;

            EUsuario objusuario = new EUsuario()
            {
                CodigoUsuario = codigoUsuario,
                NombreCompleto = TxtNombreCompleto.Text,
                Correo = TxtCorreo.Text,
                Clave = TxtClave.Text,
                Rol = new ERol()
                {
                    IdRol = Convert.ToInt32(rolSeleccionado.Valor),
                    Descripcion = rolSeleccionado.Texto
                },
                Estado = Convert.ToInt32(estadoSeleccionado.Valor) == 1
            };

            if (TxtId.Text == "0")
            {
                //int idusuariogenerado = new DArbolUsuario().RegistrarUsuario(objusuario, out mensaje);
                int idusuariogenerado = arbolUsuarios.RegistrarUsuario(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    DgvData.Rows.Add(new object[] {
                "",
                idusuariogenerado,
                objusuario.CodigoUsuario,
                objusuario.NombreCompleto,
                objusuario.Correo,
                objusuario.Clave,
                ((OpcionCombo)CboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString()
                });
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
                // Aquí sí se necesita el ID para editar
                objusuario.IdUsuario = Convert.ToInt32(TxtId.Text);

                //bool resultado = new DArbolUsuario().EditarUsuario(objusuario, out mensaje);
                bool resultado = arbolUsuarios.EditarUsuario(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DgvData.Rows[Convert.ToInt32(TxtIndice.Text)];
                    row.Cells["Id"].Value = TxtId.Text;
                    row.Cells["CodigoUsuario"].Value = TxtCodigoUsuario.Text;
                    row.Cells["NombreCompleto"].Value = TxtNombreCompleto.Text;
                    row.Cells["Correo"].Value = TxtCorreo.Text;
                    row.Cells["Clave"].Value = TxtClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)CboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        private void Limpiar()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "0";
            TxtCodigoUsuario.Text = "";
            TxtNombreCompleto.Text = "";
            TxtCorreo.Text = "";
            TxtClave.Text = "";
            TxtConfirmarClave.Text = "";
            CboRol.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;

            TxtCodigoUsuario.Select();
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DgvData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtCodigoUsuario.Text = DgvData.Rows[indice].Cells["CodigoUsuario"].Value.ToString();
                    TxtNombreCompleto.Text = DgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    TxtCorreo.Text = DgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtClave.Text = DgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    TxtConfirmarClave.Text = DgvData.Rows[indice].Cells["Clave"].Value.ToString();


                    foreach (OpcionCombo oc in CboRol.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvData.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = CboRol.Items.IndexOf(oc);
                            CboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
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
    }
}
