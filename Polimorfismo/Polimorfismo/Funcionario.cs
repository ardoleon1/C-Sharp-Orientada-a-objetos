using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Funcionario //Classe abstrata
    {
        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        public abstract void AtualizarDados();
    }
}
