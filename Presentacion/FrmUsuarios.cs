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
                    arbolUsuarios.MostrarGrid(DgvData);
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
                //MessageBox.Show("");
                EUsuario encontrado = arbolUsuarios.Buscar(codigoUsuario);
                if (encontrado != null)
                {
                    MessageBox.Show("El usuario ya existe");
                    Limpiar();
                    return;
                }
                else
                {
                    MessageBox.Show("Si nesesita editar presione editar");
                    return;
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
        //editar
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            // Validar que el campo Código Usuario no esté vacío y sea número
            if (!int.TryParse(TxtCodigoUsuario.Text, out int codigoUsuario))
            {
                MessageBox.Show("El campo 'Código Usuario' debe ser un número válido.");
                return;
            }
            /*if (CboRol.SelectedItem == null || CboEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol y un estado.");
                return;
            }*/
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

            if (TxtId.Text != "0")
            {
                EUsuario encontrado = arbolUsuarios.Buscar(codigoUsuario);
                if (TxtId.Text == "1" && Convert.ToInt32(rolSeleccionado.Valor) == 2)
                {
                    MessageBox.Show("A este usuario, no se puede editar el rol");
                }
                // Aquí sí se necesita el ID para editar
                objusuario.IdUsuario = Convert.ToInt32(TxtId.Text);

                //bool resultado = new DArbolUsuario().EditarUsuario(objusuario, out mensaje);
                bool resultado = arbolUsuarios.EditarUsuario(objusuario, out mensaje);
                if (resultado)
                {
                    arbolUsuarios.MostrarGrid(DgvData);
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
                MessageBox.Show("Este usuario no esta registrado\nPrecione guardar para registrarlo");
                return;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCodigoUsuario.Text, out int codigoUsuario))
            {
                MessageBox.Show("El campo 'Código Usuario' debe ser un número válido.");
                return;
            }
            int CodigoUsuario = int.Parse(TxtCodigoUsuario.Text);
            if (TxtId.Text != "0")
            {
                if (TxtId.Text == "1")
                {
                    MessageBox.Show("Este usuario no se puede eliminar");
                    return;
                }
                arbolUsuarios.EliminarUsuario(CodigoUsuario);
                MessageBox.Show("Usuario Eliminado Correctamente");
                arbolUsuarios.MostrarGrid(DgvData);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede Eliminar\nEl usuario no existe!!");
            }
        }
    }
}
