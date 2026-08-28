using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloRegistro
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsVector objVector = new clsVector();

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Decimal totalDeuda = 0;

            clsVector.Precarga();

            dgvListado.Rows.Clear();

            for (int i = 0; i < clsVector.indice; i++)
            {
                dgvListado.Rows.Add(
                    clsVector.clientes[i].codigo,
                    clsVector.clientes[i].usuario,
                    clsVector.clientes[i].limite,
                    clsVector.clientes[i].deuda
                    );

                totalDeuda = totalDeuda + clsVector.clientes[i].deuda;
            }

            lblMuestraDeuda.Text = totalDeuda.ToString();
        }
    }
}
