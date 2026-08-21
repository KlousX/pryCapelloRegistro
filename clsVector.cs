using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloRegistro
{
    internal class clsVector
    {
        //Declaracion de una estructura para el registro de clientes
        public struct RegCliente
        {
            public int codigo;
            public decimal deuda;
            public string usuario;
            public decimal limite;
        };

        public static RegCliente[] clientes = new RegCliente[5];

        public static int indice = 0;

        public void Agregar(string cod, string deu, string usu, string lim)
        {
            if (indice < clientes.Length)
            {
                //Busqueda Secuencial
                Int32 i = 0;
                while (clientes[i].codigo != Convert.ToInt32(cod) && i < clsVector.indice)
                {
                    i++;
                }
                if (indice == i)
                {
                    clientes[indice].codigo = Convert.ToInt32(cod);
                    clientes[indice].deuda = Convert.ToDecimal(deu);
                    clientes[indice].usuario = usu;
                    clientes[indice].limite = Convert.ToDecimal(lim);

                }
                else
                {
                    MessageBox.Show("El código ya existe");
                }

            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de clientes");
            }
        }
        
        public void OrdenarCodigoAscendente()
        {

        }

        public void OrdenarCodigoDescendente()
        {

        }

        public void OrdenarNombreAscendente()
        {
        }

        public void OrdenarNombreDescendente()
        {
        }

        public void OrdenarDeudaAscendente()
        {
        }

        public void OrdenarDeudaDescendente()
        {
        }

        public void OrdenarLimiteAscendente()
        {
        }

        public void OrdenarLimiteDescendente()
        {
        }
    }
}
