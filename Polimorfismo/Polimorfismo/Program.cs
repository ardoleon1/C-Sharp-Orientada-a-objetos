using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie um novo projeto
             * Defina uma interface AreaCalculavel com o método calcularArea() que retorna um double
             * Defina 3 classes: quadrado, retângulo e circulo com seu(s) respectivo(s) atributos(s)
             * Implemente o método calcularArea() nas respectivas classes
             * Crie um objeto de cada classe e calcule sua área
             * Teste a aplicação
             */
            
            GeradorDeExtrato gerador = new GeradorDeExtrato();

            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 2000;

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 1000;

            gerador.ImprimeExtratoBasico(cp);
            gerador.ImprimeExtratoBasico(cc);

            cc.GerarExtrato();

            Gerente ge = new Gerente();
            ge.Nome = "Otávio";

            Telefonista te = new Telefonista();
            te.Nome = "Maria";

            Ponto ponto = new Ponto();
            ponto.RegistrarEntrada(ge);
            ponto.RegistrarEntrada(te);
            ponto.RegistrarSaida(ge);
            ponto.RegistrarSaida(te);

            Console.ReadKey();
        }
    }
}
