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
    public partial class frmListadoDeudores : Form
    {
        public frmListadoDeudores()
        {
            InitializeComponent();
        }

        clsVector objVector = new clsVector();

        private void frmListadoDeudores_Load(object sender, EventArgs e)
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

            if (totalDeuda > 0)
            {
                lblMuestraDeuda.Text = totalDeuda.ToString();
            }

            promDeuda = totalDeuda / clsVector.indice;
            cantidadClientes = clsVector.indice;

            lblQClientes.Text = cantidadClientes.ToString();
            lblPromDeuda.Text = promDeuda.ToString();

        }
    }
}
