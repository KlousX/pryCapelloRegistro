using System;
using System.Collections.Generic;
using System.Configuration;
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

        public static void Precarga()
        {
            clientes[indice].codigo = 1;
            clientes[indice].usuario = "Nico";
            clientes[indice].limite = 100;
            clientes[indice].deuda = 50;
            indice++;

            clientes[indice].codigo = 2;
            clientes[indice].usuario = "Pedro";
            clientes[indice].limite = 200;
            clientes[indice].deuda = 100;
            indice++;

            clientes[indice].codigo = 3;
            clientes[indice].usuario = "Bruno";
            clientes[indice].limite = 300;
            clientes[indice].deuda = 150;
            indice++;

            clientes[indice].codigo = 4;
            clientes[indice].usuario = "Joaquin";
            clientes[indice].limite = 500;
            clientes[indice].deuda = 250;
            indice++;
        }

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
                    clientes[indice].usuario = usu;
                    clientes[indice].limite = Convert.ToDecimal(lim);
                    clientes[indice].deuda = Convert.ToInt32(deu);

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

            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].codigo > clientes[k + 1].codigo)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarCodigoDescendente()
        { 

            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].codigo < clientes[k + 1].codigo)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarNombreAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].usuario.CompareTo(clientes[k +1].usuario) > 0)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarNombreDescendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].usuario.CompareTo(clientes[k + 1].usuario) < 0)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarDeudaAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].deuda > clientes[k + 1].deuda)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarDeudaDescendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].deuda < clientes[k + 1].deuda)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarLimiteAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].limite > clientes[k + 1].limite)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }


        public void OrdenarLimiteDescendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].limite < clientes[k + 1].limite)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }
    }
    }
