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
    public partial class Proveedor : Form
    {
        public EProveedores proveedor { get; set; }

        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            DArbolProveedores arbol = ArbolProveedoresGlobal.ArbolProveedores;
            arbol.MostrarGrid(dgvdata);
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                proveedor = new EProveedores()
                {
                    IdProveedor = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Documento"].Value.ToString()),
                    RazonSocial = dgvdata.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
