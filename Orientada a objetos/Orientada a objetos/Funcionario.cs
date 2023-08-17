using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientada_a_objetos
{
    public class Funcionario
    {
        public string nome;
        public double salario = 0;

        public void AumentarSalario(double taxa)
        {
            salario = salario + (salario * (taxa / 100));
        }
        public double ConsultarSalario()
        {
            return salario;
        }
    }
}
