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
    public partial class frmAgregarClientes : Form
    {
        public frmAgregarClientes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsVector.Agregar(txtCodigo.Text, txtDeuda.Text, txtUsuario.Text, txtLimite.Text);

            txtCodigo.Clear();
            txtDeuda.Clear();
            txtLimite.Clear();
            txtUsuario.Clear();
        }
    }
}
