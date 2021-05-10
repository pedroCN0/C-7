using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class EmpresaVeiculos
    {
        private string Nome;
        private string Endereço;
        private int CNPJ;

        public void RegistraEmpresa()
        {
            Console.Write("Digite o nome da empresa contratada: ");
            Nome = Console.ReadLine();
            Console.Write("Digite o endereço da empresa contratada: ");
            Endereço = Console.ReadLine();
            Console.Write("Digite o CNPJ da empresa contratada: ");
            CNPJ = int.Parse(Console.ReadLine());
        }
        public string ExibirEmpresa()
        {
            string Empresa = "\r\nNome da empresa contratada: " + Nome + "\r\nEndereço da empresa contratada: " + Endereço + "\r\nCNPJ: " + CNPJ; 
            return Empresa;
        }
    }
}
