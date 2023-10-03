using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_do_Banco
{
    public class Gerente : Funcionario
    {
        private string login;
        private string senha;

        public Gerente(string nome, double salario, string login, string senha) : base(nome, salario)
        {
            Login = login;
            Senha = senha;
        }

        public string Login { get { return login; } set { login = value; } }
        public string Senha { get { return senha; } set { senha = value; } }

        public override string ToString()
        {
            return base.ToString() + $"\nLogin: {Login}\nSenha: {Senha}";
        }

        public override double CalcularBonificao()
        {
            return Salario * 0.05;
        }
    }
}
