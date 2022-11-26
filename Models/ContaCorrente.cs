using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal saldo;

        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            this.saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso! R${valor}");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Saldo disponível: R$ {saldo}");
        }

    }
}