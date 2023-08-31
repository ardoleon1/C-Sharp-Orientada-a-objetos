using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomba_de_Combustível
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 5---");
            Console.WriteLine("Seja bem-vindo(a) ao Posto Douglas Legramante!");
            int cont = 0;
            {
                Console.WriteLine("O que você deseja? Escolhe uma das alternativas:");
                Console.WriteLine("[1] Abastecer por valor\n[2] Abastecer por Litro\n[3] Alterar Valor\n[4] Alterar Tipo de Combustível\n[5] Alterar Quantidade de Combustível\n[6] Sair");
                cont = int.Parse(Console.ReadLine());
                switch (cont)
                {

                }

            } while (cont != 6);
            Console.WriteLine("Tenha um bom dia!");

            Console.ReadKey();
        }
    }
}
