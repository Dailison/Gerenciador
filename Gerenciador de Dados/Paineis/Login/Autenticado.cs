using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Dados.Paineis.Login
{
    public class Autenticado
    {
        private String Nome { get; set; }

        public Autenticado(String nome)
        {
            this.Nome = nome;
        }
    }
}
