using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Resolução dos Exercícios---");

            Console.WriteLine("\n---Bola---");
            Bola bola = new Bola("Amarelo", 10.00, "Lisa");
            Console.Write("Digite uma cor: ");
            string cor = Console.ReadLine();
            bola.AlterarCor(cor);
            bola.MostrarCor();

            Console.WriteLine("\n---Quadrado---");
            Quadrado quadrado = new Quadrado(10);
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());
            quadrado.MudarValorLado(valor);
            Console.WriteLine("Perímetro: " + quadrado.CalcularPerimetro() + "cm");
            Console.WriteLine("Área: " + quadrado.CalcularArea() + "cm²");

            Console.WriteLine("\n---Retangulo---");
            Retangulo retangulo = new Retangulo(0.0, 0.0);
            Console.Write("Informe o valor do comprimento em cm: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do largura em cm: ");
            double lado2 = double.Parse(Console.ReadLine());
            retangulo.MudarLadoA(lado1);
            retangulo.MudarLadoB(lado2);
            double totalArea = retangulo.CalcularArea();
            Console.Write("Digite o tamanho do porcelanato em cm²: ");
            double porcelanato = double.Parse(Console.ReadLine());
            double quantidadePor = totalArea / porcelanato;
            Console.Write("Digite o comprimento do rodapé: ");
            double rodape = double.Parse(Console.ReadLine());
            double totalPerimetro = retangulo.CalcularPerimetro();
            double quantidadeRod = totalPerimetro / rodape;
            Console.WriteLine("\nA área total é " + totalArea + " cm²." + "É necessário " + quantidadePor + " itens de porcelanatos e " + quantidadeRod + " itens de rodapés.");

            Console.WriteLine("\n---Pessoa---");
            Pessoa pessoa1 = new Pessoa("Gabriel", 16, 55.0, 170.0);
            pessoa1.Envelhecer();
            pessoa1.Engordar(5.0);
            pessoa1.Emagrecer(4.0);
            pessoa1.Crescer(5.0);
            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Idade: " + pessoa1.idade);
            Console.WriteLine("Peso: " + pessoa1.peso + "kg");
            Console.WriteLine("Altura: " + pessoa1.altura + "cm");

            Console.ReadKey();
        }
    }
}
