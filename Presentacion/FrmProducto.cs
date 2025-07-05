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
    public partial class FrmProducto : Form
    {
        private DListaProducto listaproducto = ListaProductoGlobal.listaproducto;

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstado.DisplayMember = "Texto";//muestra
            CboEstado.ValueMember = "Valor";//no muestras manejas como valor interno
            CboEstado.SelectedIndex = 0;//seleccionar simpre el primro
            // Cargar Categorias
            DListaCategoria logicaCategoria = ListaCategoriaGlobal.listacategoria;
            NodoListaCategoria actual = logicaCategoria.primero;

            if (actual != null)
            {
                NodoListaCategoria inicio = actual;

                do
                {
                    ECategoria cat = actual.dato;

                    CboCategoria.Items.Add(new OpcionCombo()
                    {
                        Valor = cat.IdCategoria,
                        Texto = cat.Descripcion
                    });

                    actual = actual.siguiente;

                } while (actual != inicio);
            }

            CboCategoria.DisplayMember = "Texto";
            CboCategoria.ValueMember = "Valor";
            CboCategoria.SelectedIndex = 0;
            listaproducto.MostrarGrid(DgvData);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            var CategoriaSeleccionado = (OpcionCombo)CboCategoria.SelectedItem;
            var Seleccionado = (OpcionCombo)CboEstado.SelectedItem;

            EProducto obJProducto = new EProducto()
            {
                IdProducto = Convert.ToInt32(TxtId.Text),
                Codigo = TxtCodigo.Text,
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                Categoria = new ECategoria()
                {
                    IdCategoria = Convert.ToInt32(CategoriaSeleccionado.Valor),
                    Descripcion = CategoriaSeleccionado.Texto
                },
                Estado = Convert.ToInt32(CategoriaSeleccionado.Valor) == 1
            };

            if (TxtId.Text == "0")
            {
                //int idusuariogenerado = new DArbolUsuario().RegistrarUsuario(objusuario, out mensaje);
                int idProductogenerado = listaproducto.RegistarProducto(obJProducto);

                if (idProductogenerado != 0)
                {
                    listaproducto.MostrarGrid(DgvData);
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
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            CboCategoria.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;

            TxtCodigo.Select();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            //int Documento = int.Parse(TxtDocumento.Text);
            if (TxtId.Text != "0")
            {

                //listaproducto.EliminarProductos(Descripcion);
                MessageBox.Show("Proveedor Eliminado Correctamente");
                //arbolProveedores.MostrarGrid(DgvData);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede Eliminar\nEl Documento no existe!!");
            }
        }
    }
}
