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
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form agregarClientes = new frmAgregarClientes();
            //agregarClientes.MdiParent = this;
            agregarClientes.Show();
        }

        private void clientesOrdPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListadoOrdenado = new frmListado();
            //agregarClientes.MdiParent = this;
            ListadoOrdenado.Show();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Listado = new frmListadoClientes();
            Listado.ShowDialog();
        }

        private void clientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListadoDeudores = new frmListadoDeudores();
            ListadoDeudores.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cerrar = new frmGestion();
            Cerrar.Close();
        }
    }
}
