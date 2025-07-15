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
    public partial class Inicio : Form
    {
        private static EUsuario usuarioActual;
        private static ToolStripMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private static ToolStripMenuItem SubMenuActivo = null;
        public Inicio(EUsuario objusuario = null)
        {
            usuarioActual = objusuario;
            InitializeComponent();
            lblUsuario.Text = usuarioActual.NombreCompleto;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            int idRol = usuarioActual.Rol.IdRol;
            DListaPermiso permisosRol = new DListaPermiso().ObtenerPermisosPorRol(idRol);

            foreach (ToolStripMenuItem iconmenu in Menu.Items)
            {
                bool encontrado = false;

                // Recorrer la lista enlazada circular 
                NodoListaPermiso actual = permisosRol.primero;

                if (actual != null)
                {
                    do
                    {
                        if (actual.Dato.NombreMenu == iconmenu.Name)
                        {
                            encontrado = true;
                            break;
                        }
                        actual = actual.Siguiente;

                    } while (actual != permisosRol.primero);
                }
                iconmenu.Visible = encontrado;
            }
            lblUsuario.Text = usuarioActual.NombreCompleto;
        }
        private void AbrirFormulario(ToolStripMenuItem menu, ToolStripMenuItem subMenu, Form formulario)
        {
            /*
            if (MenuActivo != null)//si nuestro menu activo es difernte null, que hay un menu anteriri q le emos seleccionado su color de fondo sera color blanco
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;//cambie color de fondo al menu que se esta mostrando
            MenuActivo = menu;//menu que deceo que se muestre

            // Si ya hay un formulario abierto, ciérralo
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            // Actualizar referencias al nuevo formulario y menú
            FormularioActivo = formulario;

            formulario.TopLevel = false;//que no sea superior
            formulario.FormBorderStyle = FormBorderStyle.None;//que no tenga ningun borde
            formulario.Dock = DockStyle.Fill;//que rellene todo el espacio libre
            formulario.BackColor = Color.DimGray;//que el formulario se del color SteelBlue

            Contenedor.Controls.Add(formulario);//agregar al panel el formulario
            formulario.Show();//Mostrar formulario*/
            // Restaurar colores anteriores
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
                MenuActivo.ForeColor = Color.Black;
            }

            if (SubMenuActivo != null)
            {
                SubMenuActivo.BackColor = Color.White;
                SubMenuActivo.ForeColor = Color.Black;
            }

            // Pintar el nuevo menú y submenú
            menu.BackColor = Color.Silver;
            menu.ForeColor = Color.Black;

            if (subMenu != null)
            {
                subMenu.BackColor = Color.Silver;
                subMenu.ForeColor = Color.Black;
            }

            MenuActivo = menu;
            SubMenuActivo = subMenu;

            // Cerrar formulario anterior
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            // Mostrar nuevo formulario
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DimGray;
            Contenedor.Controls.Clear();
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmUsuarios());
            AbrirFormulario(MenuUsuarios, null, new FrmUsuarios());
        }

        private void SubMenuCategoria_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmCategoria());
            AbrirFormulario(MenuMantenedor, SubMenuCategoria, new FrmCategoria());

        }

        private void SubMenuProducto_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmProducto());
            AbrirFormulario(MenuMantenedor, SubMenuProducto, new FrmProducto());

        }

        private void SubMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmVenta());
            AbrirFormulario(MenuVentas, SubMenuRegistrarVenta, new FrmVenta());
        }

        private void SubMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmCompra(usuarioActual));
            AbrirFormulario(MenuCompras, SubMenuRegistrarCompra, new FrmCompra(usuarioActual));
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmClientes());
            AbrirFormulario(MenuClientes, null, new FrmClientes());
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new FrmProveedores());
            AbrirFormulario(MenuProveedores, null, new FrmProveedores());
        }

        private void SubMenuDetalleCompra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new DetalleCompra());
            AbrirFormulario(MenuCompras, SubMenuDetalleCompra, new DetalleCompra());
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new Inventario());
            AbrirFormulario(MenuInventario, null, new Inventario());
        }

        private void SubMenuDetalleVenta_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new DetalleVenta());
            AbrirFormulario(MenuVentas, SubMenuDetalleVenta, new DetalleVenta());

        }

        private void MenuDeliveri_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((ToolStripMenuItem)sender, new Deliveri());
            AbrirFormulario(MenuDeliveri, null, new Deliveri());
        }
    }
}
