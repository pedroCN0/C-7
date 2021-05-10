using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class CarroEsporte : VeiculoAlugado
    {
        public void Definircarroes()
        {
            Registraveic();
        }
        public string Exibir()
        {
            string view;
            view = Exibirvl();
            return view;
        }
    }
}
