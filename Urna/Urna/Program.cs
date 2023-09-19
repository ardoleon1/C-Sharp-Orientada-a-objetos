using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candidato lula = new Candidato(13, "Luiz Inácio Lula da Silva");
            Candidato ciro = new Candidato(12, "Ciro Gomes");
            Candidato bolsonaro = new Candidato(22, "Jair Messias Bolsonaro");
            Candidato neymar = new Candidato(10, "Menino Ney");
            bool continua = true;
            do
            {
                Console.WriteLine("\t\t---Urna Segura--- Vota, vota e confia!#");
                Console.WriteLine($"[10] - Menino Ney" +
                   $"\n[12] - Ciro Gomes" +
                    $"\n[13] - Luiz Inácio Lula da Silva" +
                    $"\n[22] - Jair Messias Bolsonaro" +
                    $"\n[0] - Voto branco/nulo" +
                    $"\n[99] - Apurar votos");
                Console.Write("\nEscolha uma opção: ");

                int nulo = 0;
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        nulo++;
                        Console.WriteLine("Voto Depositado");
                        break;
                    case 10:
                        neymar.DepositarVoto();
                        Console.WriteLine("Voto Depositado");
                        break;
                    case 12:
                        ciro.DepositarVoto();
                        Console.WriteLine("Voto Depositado");
                        break;
                    case 13:
                        lula.DepositarVoto();
                        Console.WriteLine("Voto Depositado");
                        break;
                    case 22:
                        bolsonaro.DepositarVoto();
                        Console.WriteLine("Voto Depositado");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida:");
                        break;
                }
                Console.Write("\nDigite [1] para realizar outro voto: ");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha != 1)
                {
                    continua = false;
                    
                    
                }
                Console.Clear();
            } while (continua == true);
            Console.Clear();
            Console.WriteLine("\t\t---Totalizando Votos---");
            neymar.ApurarResultado();
            ciro.ApurarResultado();
            lula.ApurarResultado();
            bolsonaro.ApurarResultado();
            Console.ReadKey();
        }
    }
}
