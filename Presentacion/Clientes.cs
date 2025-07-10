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
    public partial class Clientes : Form
    {
        public ECliente Cliente { get; set; }
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            DArbolClientes arbol = ArbolClientesGlobal.ArbolClientes;
            arbol.MostrarGrid(dgvdata);
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                Cliente = new ECliente()
                {
                    IdCliente = Convert.ToInt32(dgvdata.Rows[iRow].Cells["IdCliente"].Value.ToString()),
                    Documento = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Documento"].Value.ToString()),
                    NombreCompleto = dgvdata.Rows[iRow].Cells["NombreCompleto"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
