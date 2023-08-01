using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientada_a_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um novo objeto
            Conta natam = new Conta();
            //Passando valores para os atributos
            natam.codigo = "258945-8";
            natam.nome = "Natam da Silva Gomes";

            Conta fernanda = new Conta();
            fernanda.codigo = "35457-5";
            fernanda.nome = "Fernanda Lima";

            Conta aline = new Conta();
            aline.codigo = "14738-9";
            aline.nome = "Aline Pereira";

            Console.WriteLine("---Imprimindo os dados dos Objetos---");
            Console.WriteLine("\nCódigo: " + natam.codigo);
            Console.WriteLine("Nome: " + natam.nome);
            Console.WriteLine("\nCódigo: " + fernanda.codigo);
            Console.WriteLine("Nome: " + fernanda.nome);
            Console.WriteLine("\nCódigo: " + aline.codigo);
            Console.WriteLine("Nome: " + aline.nome);

            Console.ReadKey();
        }
    }
}
