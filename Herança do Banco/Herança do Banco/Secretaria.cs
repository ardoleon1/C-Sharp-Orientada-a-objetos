using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_do_Banco
{
    public class Secretaria : Funcionario
    {
        private int numRamal;

        public Secretaria(string nome, double salario, int numRamal) : base(nome, salario)
        {
            NumRamal = numRamal;
        }

        public int NumRamal { get { return numRamal; } set { numRamal = value; } }

        public override string ToString()
        {
            return base.ToString() + $"\nNúmero do Ramal: {NumRamal}";
        }
    }
}
