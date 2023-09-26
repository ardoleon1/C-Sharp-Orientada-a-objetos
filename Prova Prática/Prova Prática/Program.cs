//Nomes: Leonardo Pereira Mendes Ribas | Patricia de O. Silva 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Prática
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Prova Prática---");
            Console.WriteLine("Seja bem-vindo(a) ao Posto Douglas Legramante!\nOs frentistas Leonardo e Patrícia irão te ajudar!");
            BombaDeCombustivel bomba = new BombaDeCombustivel("Gasolina", 5, 1000);
            double valor;
            string tipo;
            int cont = 7;
            do
            {
                Console.WriteLine("\nO que você deseja? Escolhe uma das alternativas:");
                Console.WriteLine("[1] Abastecer por Valor\n[2] Abastecer por Litro\n[3] Alterar Valor\n[4] Alterar Tipo de Combustível\n[5] Alterar Quantidade de Combustível\n" +
                    "[6] Sair\n");
                cont = int.Parse(Console.ReadLine());
                switch (cont)
                {
                    case 1:
                        do
                        {
                            Console.Write("\nDigite o valor: ");
                            valor = double.Parse(Console.ReadLine());
                            if (valor <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Valor inválido!");
                            }
                            else
                            {
                                Console.Clear();
                                bomba.AbastecerPorValor(valor);
                            }
                        } while (valor <= 0);
                        break;
                    case 2:
                        do
                        {
                            Console.Write("\nDigite a quantidade de litro(s): ");
                            valor = double.Parse(Console.ReadLine());
                            if (valor <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Valor inválido!");
                            }
                            else
                            {
                                Console.Clear();
                                bomba.AbastecerPorLitro(valor);
                            }
                        } while (valor <= 0);
                        break;
                    case 3:
                        do
                        {
                            Console.Write("\nDigite o valor: ");
                            valor = double.Parse(Console.ReadLine());
                            if (valor <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Valor inválido!");
                            }
                            else
                            {
                                Console.Clear();
                                bomba.alterarValor(valor);
                            }
                        } while (valor <= 0);
                        break;
                    case 4:
                        Console.Write("\nDigite o Tipo de Combustível: ");
                        tipo = Console.ReadLine();
                        Console.Clear();
                        bomba.alterarCombustivel(tipo);
                        break;
                    case 5:
                        do
                        {
                            Console.Write("\nDigite a quantidade: ");
                            valor = double.Parse(Console.ReadLine());
                            if (valor <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Valor inválido!");
                            }
                            else
                            {
                                Console.Clear();
                                bomba.alterarQuantidadeCombustivel(valor);
                            }
                        } while (valor <= 0);
                        break;
                }

            } while (cont != 6);
            Console.Clear();
            Console.WriteLine("Tenha um bom dia!");

            Console.ReadKey();
        }
    }
}
