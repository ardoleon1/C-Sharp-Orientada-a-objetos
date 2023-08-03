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

            Console.WriteLine("---Imprimindo os dados das Pessoas---");
            Console.WriteLine("\nCódigo: " + natam.codigo);
            Console.WriteLine("Nome: " + natam.nome);
            Console.WriteLine("\nCódigo: " + fernanda.codigo);
            Console.WriteLine("Nome: " + fernanda.nome);
            Console.WriteLine("\nCódigo: " + aline.codigo);
            Console.WriteLine("Nome: " + aline.nome);

            CartaoDeCredito cc1 = new CartaoDeCredito();
            cc1.numero = "5504 4700 8345 4830";
            cc1.dataValidade = "09/2024";

            Console.WriteLine("\n---Imprimindo os dados do Cartão de Crédito---");
            Console.WriteLine($"Número: {cc1.numero}");
            Console.WriteLine($"Data de Validade {cc1.dataValidade}");

            Agencia agencia1 = new Agencia();
            agencia1.numero = 0001;

            Agencia agencia2 = new Agencia();
            agencia2.numero = 0002;

            Console.WriteLine("\n---Imprimindo os dados da Agência---");
            Console.WriteLine($"Número: {agencia1.numero}");

            Conta conta1 = new Conta();
            conta1.numero = 1;
            conta1.saldo = 500;
            conta1.limite = 250;

            Conta conta2 = new Conta();
            conta2.numero = 2;
            conta2.saldo = 600;
            conta2.limite = 150;

            Console.WriteLine("\n---Imprimindo os dados da Conta---");
            Console.WriteLine("---Conta 1---");
            Console.WriteLine($"Número: {conta1.numero}");
            Console.WriteLine($"Saldo: {conta1.saldo}");
            Console.WriteLine($"Limite: {conta1.limite}");
            Console.WriteLine("---Conta 2---");
            Console.WriteLine($"Número: {conta2.numero}");
            Console.WriteLine($"Saldo: {conta2.saldo}");
            Console.WriteLine($"Limite: {conta2.limite}");

            Console.ReadKey();
        }
    }
}
