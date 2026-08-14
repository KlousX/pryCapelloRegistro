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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaracion de una estructura para el registro de clientes
        private struct RegCliente
        {
            public int codigo;
            public decimal deuda;
            public string usuario;
            public decimal limite;
        };

        private RegCliente[] clientes = new RegCliente[5];

        private int indice = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (indice < clientes.Length)
            {
                clientes[indice].codigo = Convert.ToInt32(txtCodigo.Text);
                clientes[indice].deuda = Convert.ToDecimal(txtDeuda.Text);
                clientes[indice].usuario = txtUsuario.Text;
                clientes[indice].limite = Convert.ToDecimal(txtLimite.Text);

                indice++;
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de clientes");
            }

            txtCodigo.Clear();
            txtDeuda.Clear();
            txtUsuario.Clear();
            txtLimite.Clear();
            btnListar.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            decimal totalDeuda = 0;
            dgvDatos.Rows.Clear();

            for (int i = 0; i < indice; i++)
            {
                dgvDatos.Rows.Add(
                    clientes[i].codigo,
                    clientes[i].usuario,
                    clientes[i].limite,
                    clientes[i].deuda);
                totalDeuda += clientes[i].deuda;
            }

            lblMuestraDeuda.Text = totalDeuda.ToString();


            txtCodigo.Focus();
        }

        private void btnCargar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCargar_Click(sender, e);
            }

        }

        private void txtLimite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCargar_Click(sender, e);
                AcceptButton = btnCargar;
            }
        }
    }
}
