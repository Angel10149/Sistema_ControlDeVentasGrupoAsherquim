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
    public partial class Login : Form
    {
        private DArbolUsuario arbolUsuarios = ArbolUsuarioGlobal.ArbolUsuarios;
        public Login()
        {
            InitializeComponent();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            /*Inicio form = new Inicio();

            form.Show();//muestre
            this.Hide();//oculta el Login

            form.FormClosing += Frm_Cerrando;// se una cuando cierra
            */
            if (TxtCodigoUsuario.Text == "" && TxtClave.Text == "")
            {
                MessageBox.Show("no puede ingresar, agregue datos");
                return;
            }
            else if (TxtCodigoUsuario.Text == "" || TxtClave.Text == "")
            {
                MessageBox.Show("Complete todos los datos");
                return;
            }
            else
            {
                int documento = int.Parse(TxtCodigoUsuario.Text.Trim());//Trim elimina espacios al final y inicio
                string clave = TxtClave.Text.Trim();
                //LUsuario logicaUsuario = new LUsuario();
                EUsuario usuario = arbolUsuarios.BuscarUsuario(documento, clave);
                if (usuario != null)
                {
                    Inicio form = new Inicio(usuario); // Si necesitas pasar el usuario
                    form.Show();
                    this.Hide();
                    form.FormClosing += Frm_Cerrando;
                }
                else
                {
                    //MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Usuario o clave incorrectos");
                    TxtCodigoUsuario.Clear();
                    TxtClave.Clear();
                }
            }
        }
        private void Frm_Cerrando(object sender, FormClosingEventArgs e)
        {//al regresar limpie los txt
            TxtCodigoUsuario.Clear();
            TxtClave.Clear();
            //al cerrar inicio muestre el login
            this.Show();
        }
    }
}
