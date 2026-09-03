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
            Int32 cantidadClientes = 0;
            Decimal promDeuda = 0;

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

            promDeuda = totalDeuda / clsVector.indice;
            cantidadClientes = clsVector.indice;

            lblMuestraDeuda.Text = totalDeuda.ToString();
            lblQClientes.Text = cantidadClientes.ToString();
            lblPromDeuda.Text = promDeuda.ToString();
        }
    }
}
