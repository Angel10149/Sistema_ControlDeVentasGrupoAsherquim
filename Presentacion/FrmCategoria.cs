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
    public partial class FrmCategoria : Form
    {
        private DListaCategoria listacategoria = ListaCategoriaGlobal.listacategoria;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstado.DisplayMember = "Texto";//muestra
            CboEstado.ValueMember = "Valor";//no muestras manejas como valor interno
            CboEstado.SelectedIndex = 0;//seleccionar simpre el primro

            listacategoria.MostrarGrid(DgvData);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            var EstadoSeleccionado = (OpcionCombo)CboEstado.SelectedItem;

            ECategoria obJCategoria = new ECategoria()
            {
                IdCategoria = Convert.ToInt32(TxtId.Text),
                Descripcion = TxtDescripcion.Text,

                Estado = Convert.ToInt32(EstadoSeleccionado.Valor) == 1
            };

            if (TxtId.Text == "0")
            {
                //int idusuariogenerado = new DArbolUsuario().RegistrarUsuario(objusuario, out mensaje);
                int idCategoriagenerada = listacategoria.RegistarCategoria(obJCategoria);

                if (idCategoriagenerada != 0)
                {
                    listacategoria.MostrarGrid(DgvData);
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
                //editar producto
                //MessageBox.Show("Si nesesita editar presione editar");
            }
        }
        private void Limpiar()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "0";
            TxtDescripcion.Text = "";
            CboEstado.SelectedIndex = 0;

            TxtDescripcion.Select();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text != "0")
            {
                ECategoria temp = new ECategoria()
                {
                    IdCategoria = Convert.ToInt32(TxtId.Text),
                    Descripcion = TxtDescripcion.Text,

                };
                listacategoria.Eliminar(temp);
                MessageBox.Show("Proveedor Eliminado Correctamente");
                listacategoria.MostrarGrid(DgvData);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede Eliminar\nEl Documento no existe!!");
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DgvData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtDescripcion.Text = DgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

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
