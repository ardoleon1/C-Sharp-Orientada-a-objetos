using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_do_Banco
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public double Salario { get { return salario; } set { salario = value; } }

        public override string ToString()
        {
            return $"Nome: {Nome}\nSalário: {Salario:c2}";
        }

        public virtual double CalcularBonificao()
        {
            return salario * 0.10;
        }
    }
}
