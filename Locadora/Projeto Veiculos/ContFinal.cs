using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class ContFinal
    {
        public string TipoC;
        public string Cliente;
        public string Empresa;
        public string Veiculo;
        public string Aluguel;

        public string GetContratos()
        {
            return TipoC + Cliente + Empresa + Veiculo + Aluguel;
        }
    }
}
