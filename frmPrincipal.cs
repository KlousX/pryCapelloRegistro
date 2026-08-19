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

        clsVector objVector = new clsVector();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (clsVector.indice < clsVector.clientes.Length)
            {
                //Busqueda Secuencial
                Int32 i = 0;
                while (clsVector.clientes[i].codigo != Convert.ToInt32(txtCodigo.Text) && i < clsVector.indice)
                {
                    i++;
                }
                if (clsVector.indice == i)
                {
                    clsVector.clientes[clsVector.indice].codigo = Convert.ToInt32(txtCodigo.Text);
                    clsVector.clientes[clsVector.indice].deuda = Convert.ToDecimal(txtDeuda.Text);
                    clsVector.clientes[clsVector.indice].usuario = txtUsuario.Text;
                    clsVector.clientes[clsVector.indice].limite = Convert.ToDecimal(txtLimite.Text);
                        
                    txtCodigo.Clear();
                    txtDeuda.Clear();
                    txtUsuario.Clear();
                    txtLimite.Clear();
                    txtCodigo.Focus();
                    Listar();
                }
                else
                {
                    MessageBox.Show("El código ya existe");
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }

            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de clientes");
            }
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

        private void Listar()
        {
            decimal totalDeuda = 0;
            dgvDatos.Rows.Clear();
            for (int i = 0; i < clsVector.indice; i++)
            {
                dgvDatos.Rows.Add(
                    clsVector.clientes[i].codigo,
                    clsVector.clientes[i].usuario,
                    clsVector.clientes[i].limite,
                    clsVector.clientes[i].deuda);
                totalDeuda += clsVector.clientes[i].deuda;
            }
            lblMuestraDeuda.Text = totalDeuda.ToString();       
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            Decimal  totalDeudores = 0;
            dgvDatos.Rows.Clear();
            for (int i = 0; i < clsVector.indice; i++)
            {
                if (clsVector.clientes[i].deuda > 0)
                {
                    dgvDatos.Rows.Add(
                    clsVector.clientes[i].codigo,
                    clsVector.clientes[i].usuario,
                    clsVector.clientes[i].limite,
                    clsVector.clientes[i].deuda);
                    totalDeudores += clsVector.clientes[i].deuda;
                }
            }

            lblMuestraDeuda.Text = totalDeudores.ToString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            
            Precarga(); 
            Listar();
        }

        private void ControlTxt()
        {
            if (txtCodigo.Text != "" && txtDeuda.Text != "" && txtUsuario.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
        }

        private void Precarga()
        {
            clsVector.clientes[clsVector.indice].codigo = 1;
            clsVector.clientes[clsVector.indice].deuda = 5;
            clsVector.clientes[clsVector.indice].usuario = "Nico";
            clsVector.clientes[clsVector.indice].limite = 1000;

            clsVector.indice++;

            clsVector.clientes[clsVector.indice].codigo = 2;
            clsVector.clientes[clsVector.indice].deuda = 10;
            clsVector.clientes[clsVector.indice].usuario = "Pedro";
            clsVector.clientes[clsVector.indice].limite = 1000;

            clsVector.indice++;

            clsVector.clientes[clsVector.indice].codigo = 3;
            clsVector.clientes[clsVector.indice].deuda = 15;
            clsVector.clientes[clsVector.indice].usuario = "Ana";
            clsVector.clientes[clsVector.indice].limite = 1000;

            clsVector.indice++;

            clsVector.clientes[clsVector.indice].codigo = 4;
            clsVector.clientes[clsVector.indice].deuda = 0;
            clsVector.clientes[clsVector.indice].usuario = "Juan Pedro";
            clsVector.clientes[clsVector.indice].limite = 1000;

            clsVector.indice++;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlTxt();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ControlTxt();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ControlTxt();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            ControlTxt();
        }
    }
}
