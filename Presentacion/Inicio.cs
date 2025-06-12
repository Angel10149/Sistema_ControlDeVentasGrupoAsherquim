using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        private static EUsuario usuarioActual;
        private static ToolStripMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(EUsuario objusuario=null)
        {
            usuarioActual = objusuario;
            InitializeComponent();
            lblUsuario.Text = usuarioActual.NombreCompleto;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
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
            formulario.Show();//Mostrar formulario
        }
        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmUsuarios());
        }
    }
}
