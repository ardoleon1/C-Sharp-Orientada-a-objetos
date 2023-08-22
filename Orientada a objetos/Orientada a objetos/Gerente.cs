using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientada_a_objetos
{
    public class Gerente
    {
        public string nome;
        public double salario;

        public void AumentarSalario()
        {
            AumentarSalario(10);
        }
        public void AumentarSalario(int taxa)
        {
            salario = salario + (salario * taxa / 100);
        }
        public void ImprimirSalario()
        {
            Console.WriteLine("\t\t---Dados do Gerente---");
            Console.WriteLine($"Nome: {nome}\nSalário: {salario:c2}");
        }
    }
}
