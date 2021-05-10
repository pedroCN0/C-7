using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class Cliente
    {
        private string Nome;
        private int Idade;
        private int CPF;
        private string Sobrenome;

        public void RegistraPessoa()
        {
            int age;
            Console.Write("Digite o nome do cliente: ");
            Nome = Console.ReadLine();
            Console.Write("Digite o sobrenome do cliente: ");
            Sobrenome = Console.ReadLine();
            do
            {
                Console.Write("Digite a idade do cliente: ");
                age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("ERRO: Idade inválida(Mínimo: 18 anos), tente novamente.");
                }
                else if (age >= 18)
                {
                    Idade = age;
                    Console.Write("Digite o CPF do cliente: ");
                    CPF = int.Parse(Console.ReadLine());
                }
            } while (Idade < 18);
        }
        public string ExibirCliente()
        {
            string Cliente = "\r\nNome: " + Nome + "\r\nSobrenome: " + Sobrenome + "\r\nIdade: " + Idade + "\r\nCPF: " + CPF;
            return Cliente;
        }
    }
}
