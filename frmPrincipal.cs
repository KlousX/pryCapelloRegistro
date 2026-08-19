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
                //Busqueda Secuencial
                Int32 i = 0;
                while (clientes[i].codigo != Convert.ToInt32(txtCodigo.Text) && i < indice)
                {
                    i++;
                }
                if (indice == i)
                {
                    clientes[indice].codigo = Convert.ToInt32(txtCodigo.Text);
                    clientes[indice].deuda = Convert.ToDecimal(txtDeuda.Text);
                    clientes[indice].usuario = txtUsuario.Text;
                    clientes[indice].limite = Convert.ToDecimal(txtLimite.Text);

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
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            Decimal  totalDeudores = 0;
            dgvDatos.Rows.Clear();
            for (int i = 0; i < indice; i++)
            {
                if (clientes[i].deuda > 0)
                {
                    dgvDatos.Rows.Add(
                    clientes[i].codigo,
                    clientes[i].usuario,
                    clientes[i].limite,
                    clientes[i].deuda);
                    totalDeudores += clientes[i].deuda;
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
            clientes[indice].codigo = 1;
            clientes[indice].deuda = 5;
            clientes[indice].usuario = "Nico";
            clientes[indice].limite = 1000;

            indice++;

            clientes[indice].codigo = 2;
            clientes[indice].deuda = 10;
            clientes[indice].usuario = "Pedro";
            clientes[indice].limite = 1000;

            indice++;

            clientes[indice].codigo = 3;
            clientes[indice].deuda = 15;
            clientes[indice].usuario = "Ana";
            clientes[indice].limite = 1000;

            indice++;

            clientes[indice].codigo = 4;
            clientes[indice].deuda = 0;
            clientes[indice].usuario = "Juan Pedro";
            clientes[indice].limite = 1000;

            indice++;
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
