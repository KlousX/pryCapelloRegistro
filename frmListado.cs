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
                    if (cboCampo.SelectedIndex == 0)
                    {
                        objVector.OrdenarCodigoAscendente();
                    }
                    else
                    {
                        objVector.OrdenarCodigoDescendente();
                    }
                break;  

                case 1:
                    if (cboCampo.SelectedIndex == 1)
                    {
                        objVector.OrdenarNombreAscendente();
                    }
                    else
                    {
                        objVector.OrdenarNombreDescendente();
                    }
                break;

                case 2:
                    if (cboCampo.SelectedIndex == 2)
                    {
                        objVector.OrdenarDeudaAscendente();
                    }
                    else
                    {
                        objVector.OrdenarDeudaDescendente();
                    }
                    break;

                case 3:
                    if (cboCampo.SelectedIndex == 3)
                    {
                        objVector.OrdenarLimiteAscendente();
                    }
                    else
                    {
                        objVector.OrdenarLimiteDescendente();
                    }
                    break;
                    }
                    
            }
        }
    }
}
