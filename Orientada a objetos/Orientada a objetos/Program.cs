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
            Endereco ed1 = new Endereco();
            Endereco ed2 = new Endereco();

            //Instanciando um novo objeto
            Agencia agencia1 = new Agencia();
            agencia1.numero = 0001;

            Agencia agencia2 = new Agencia();
            agencia2.numero = 0002;

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

            Console.WriteLine("\n---Imprimindo os dados da Agência---");
            Console.WriteLine($"Número: {agencia1.numero}");

            Conta conta1 = new Conta();
            conta1.numero = 1;
            conta1.saldo = 500;
            conta1.limite = 250;
            conta1.agencia = agencia1;

            Conta conta2 = new Conta();
            conta2.numero = 2;
            conta2.saldo = 600;
            conta2.limite = 150;
            conta2.agencia = agencia2;

            Console.WriteLine("\n---Imprimindo os dados da Conta---");
            Console.WriteLine("---Conta 1---");
            Console.WriteLine($"Número: {conta1.numero}");
            Console.WriteLine($"Saldo: {conta1.saldo:c2}");
            Console.WriteLine($"Limite: {conta1.limite:c2}");
            Console.WriteLine($"Agência: {conta1.agencia.numero}");
            conta1.Sacar(50);
            conta1.Depositar(500);
            Console.WriteLine("Saldo atual: {0:c2}", conta1.ConsultarSaldo());
            Console.WriteLine("---Conta 2---");
            Console.WriteLine($"Número: {conta2.numero}");
            Console.WriteLine($"Saldo: {conta2.saldo:c2}");
            Console.WriteLine($"Limite: {conta2.limite:c2}");
            Console.WriteLine($"Agência: {conta2.agencia.numero}");

            Cliente c1 = new Cliente();
            c1.codigo = 128;
            c1.nome = "André Barbosa";
            Cliente c2 = new Cliente();
            c2.codigo = 548;
            c2.nome = "Jaqueline Ferrete";

            c1.cliente = c1;
            c2.cliente = c2;

            Console.WriteLine($"\nCliente: {c1.cliente.nome}");

            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Eduardo";
            funcionario1.salario = 2000;
            funcionario1.AumentarSalario(10);
            double salario = funcionario1.ConsultarSalario();
            Console.WriteLine("\t\t---Imprimindo os dados do funcionário 1---");
            Console.WriteLine($"Nome: {funcionario1.nome}");
            Console.WriteLine($"Salário: {funcionario1.salario}");

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nome = "Sabrina";
            funcionario2.salario = 2500;
            funcionario2.AumentarSalario(10);
            salario = funcionario2.ConsultarSalario();
            Console.WriteLine("\t\t---Imprimindo os dados do funcionário 2---");
            Console.WriteLine($"Nome: {funcionario2.nome}");
            Console.WriteLine($"Salário: {funcionario2.salario}");

            Console.ReadKey();
        }
    }
}
