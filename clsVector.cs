using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static public RegCliente[] clientes = new RegCliente[5];

        static public int indice = 0;
    }
}
