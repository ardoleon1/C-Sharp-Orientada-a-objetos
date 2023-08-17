using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientada_a_objetos
{
    public class Conta
    {
        //Atributos da classe conta
        public string nome;
        public string codigo;

        public int numero;
        public double saldo;
        public double limite = 100;

        public Agencia agencia;

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
        public void Sacar(double valor)
        {
            saldo = saldo - valor;
        }
        public double ConsultarSaldo()
        {
            return saldo + limite;
        }
        public void ImprimirExtrato()
        {
            DateTime dt = DateTime.Now;
            string data = dt.ToShortDateString();
            string hora = dt.ToShortTimeString();
            Console.WriteLine("\t\t---Extrato Detalhado---");
            Console.Write("\nData: " + data);
            Console.Write("\t\tHora: " + hora);
            Console.WriteLine($"\nSaldo: {saldo:c2}");
            Console.WriteLine($"\nLimite: {limite:c2}");
        }
    }
}
