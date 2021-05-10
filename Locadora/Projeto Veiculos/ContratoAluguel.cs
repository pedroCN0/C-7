using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class ContratoAluguel
    {
        private double valor;
        private int validade;
        private string data;

        public void DefinirAlguel(int a)
        {
            int dia, mes = 0, ano = 0;
            do
            {
                Console.Write("Digite o dia: ");
                dia = int.Parse(Console.ReadLine());
                if (dia > 31)
                {
                    Console.WriteLine("ERRO: Dia inválido");
                }
                else if (dia <= 31)
                {
                    Console.Write("Digite o mes: ");
                    mes = int.Parse(Console.ReadLine());
                    if (mes > 12)
                    {
                        Console.WriteLine("ERRO: Mês inválido");
                    }
                    else if (mes < 12)
                    {
                        Console.Write("Digite o ano: ");
                        ano = int.Parse(Console.ReadLine());
                        if (ano >= 2019)
                        {
                            data = dia + " / " + mes + " / " + ano;
                        }
                        Console.Write("Dias que o cliente irá alugar o automóvel: ");
                        validade = int.Parse(Console.ReadLine());
                    }
                }
            } while (dia == 0 || mes == 0 || ano == 0);

            if (a == 1)
            {
                valor = validade * 500;
            }
            else if (a == 2)
            {
                valor = validade * 300;
            }
            else if (a == 3)
            {
                valor = validade * 100;
            }
            else if (a == 4)
            {
                valor = validade * 150;
            }
        }
        public string ExibirAluguel()
        {
            string Aluguel = "\r\nData: " + data + "\r\nO valor do seu aluguel é: R$" + valor;
            return Aluguel;
        }
    }
}
