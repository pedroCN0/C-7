using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class Caminhão : VeiculoAlugado
    {
        public void Definircaminhão()
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
