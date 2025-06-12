using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
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
            Inicio form = new Inicio();

            form.Show();//muestre
            this.Hide();//oculta el Login

            form.FormClosing += Frm_Cerrando;// se una cuando cierra        }
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
