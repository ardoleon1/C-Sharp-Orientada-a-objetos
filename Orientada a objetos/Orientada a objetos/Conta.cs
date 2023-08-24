using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientada_a_objetos
{
    public class Conta
    {
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
        public void ImprimeExtrato()
        {
            Console.WriteLine("Saldo: " + saldo.ToString("c2"));
        }
        public void Transferir(Conta contaDestino, double valor)
        {
            saldo = saldo - valor; //manipula o atributo saldo da conta que chama o método
            contaDestino.saldo = contaDestino.saldo + valor; //manipula o atributo saldo da conta destino

        }
        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }
    }
}