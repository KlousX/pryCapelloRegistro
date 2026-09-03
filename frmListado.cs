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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        clsVector objVector = new clsVector();

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cboCampo.SelectedIndex)
            {
                case 0:
                    if (cboModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarCodigoAscendente();
                    }
                    else
                    {
                        objVector.OrdenarCodigoDescendente();
                    }
                    break;

                case 1:
                    if (cboModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarNombreAscendente();
                    }
                    else
                    {
                        objVector.OrdenarNombreDescendente();
                    }
                    break;

                case 2:
                    if (cboModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarDeudaAscendente();
                    }
                    else
                    {
                        objVector.OrdenarDeudaDescendente();
                    }
                    break;

                case 3:
                    if (cboModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarLimiteAscendente();
                    }
                    else
                    {
                        objVector.OrdenarLimiteDescendente();
                    }
                    break;
        
            }

            dgvListado.Rows.Clear();

            for(int i = 0; i < clsVector.indice; i++)
            {
                dgvListado.Rows.Add(
                    clsVector.clientes[i].codigo,
                    clsVector.clientes[i].usuario,
                    clsVector.clientes[i].limite,
                    clsVector.clientes[i].deuda
                    );
            }
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            
        }


    }
}
