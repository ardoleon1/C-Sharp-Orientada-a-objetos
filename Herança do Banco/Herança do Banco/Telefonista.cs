using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_do_Banco
{
    public class Telefonista : Funcionario
    {
        private int codigoEstacao;

        public Telefonista(string nome, double salario, int codigoEstacao) : base(nome, salario)
        {
            CodigoEstacao = codigoEstacao;
        }

        public int CodigoEstacao { get { return codigoEstacao; } set { codigoEstacao = value; } }

        public override string ToString()
        {
            return base.ToString() + $"\nCódigo da Estação de Trabalho: {CodigoEstacao}";
        }
    }
}
