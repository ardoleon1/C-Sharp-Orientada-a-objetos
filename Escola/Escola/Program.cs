using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turma turma1 = new Turma();
            Turma turma2 = new Turma();

            Aluno aluno1 = new Aluno();
            aluno1.nome = "Gabriel";
            aluno1.RG = "134813";
            aluno1.dataNascimento = "29/04/2000";

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Aline";
            aluno2.RG = "143874";
            aluno2.dataNascimento = "18/01/2002";

            turma1.periodo = "Matutino";
            turma1.serie = "7º ano";
            turma1.sigla = 'A';
            turma1.tipoEnsino = "Presencial";
            aluno1.turma = turma1;

            turma2.periodo = "Vespertino";
            turma2.serie = "8º ano";
            turma2.sigla = 'B';
            turma2.tipoEnsino = "EAD";
            aluno2.turma = turma2;

            Console.WriteLine("---Imprimindo os dados dos alunos---");
            Console.WriteLine($"Nome: {aluno1.nome}");
            Console.WriteLine($"RG: {aluno1.RG}");
            Console.WriteLine($"Data de Nascimento: {aluno1.dataNascimento}");
            Console.WriteLine($"Turma: {aluno1.turma.serie}");
            Console.WriteLine($"\nNome: {aluno2.nome}");
            Console.WriteLine($"RG: {aluno2.RG}");
            Console.WriteLine($"Data de Nascimento: {aluno2.dataNascimento}");
            Console.WriteLine($"Turma: {aluno2.turma.serie}");

            Funcionario pessoa1 = new Funcionario();
            pessoa1.nome = "Daniel";
            pessoa1.cargo = "Gerente";
            pessoa1.salarioFuncionario = 7000;

            Funcionario pessoa2 = new Funcionario();
            pessoa2.nome = "Vitória";
            pessoa2.cargo = "Desenvolvedora";
            pessoa2.salarioFuncionario = 4000;

            Console.WriteLine("\n---Imprimindo os dados dos funcionários---");
            Console.WriteLine($"Nome: {pessoa1.nome}");
            Console.WriteLine($"Cargo: {pessoa1.cargo}");
            Console.WriteLine($"Salário: {pessoa1.salarioFuncionario:c2}");
            Console.WriteLine($"\nNome: {pessoa2.nome}");
            Console.WriteLine($"Cargo: {pessoa2.cargo}");
            Console.WriteLine($"Salário: {pessoa2.salarioFuncionario:c2}");

            Console.WriteLine("\n---Imprimindo os dados das turmas---");
            Console.WriteLine($"Período: {turma1.periodo}");
            Console.WriteLine($"Série: {turma1.serie}");
            Console.WriteLine($"Sigla: {turma1.sigla}");
            Console.WriteLine($"Tipo de ensino: {turma1.tipoEnsino}");
            Console.WriteLine($"\nPeríodo: {turma2.periodo}");
            Console.WriteLine($"Série: {turma2.serie}");
            Console.WriteLine($"Sigla: {turma2.sigla}");
            Console.WriteLine($"Tipo de ensino: {turma2.tipoEnsino}");

            Console.ReadKey();
        }
    }
}
