using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    //Criando uma nova classe para lançar tipos específicos de exceções
    internal class SaldoInsuficienteException : OperacaoFinanceiraException//Exception // antes ela herdava diretamente de Exception, mas como SaldoInsuficiente está
        //diretamente relacionado a uma operação financeira, fica mais correto ela herdar de OperacaoFinanceiraException
    {
        public double Saldo { get; } //Como se fosse readonly
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Foi feita uma tentativa de saque no valor de R$"+valorSaque+", porém o saldo é apenas de R$"+saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;

        }

        public SaldoInsuficienteException(string mensagem) 
            : base(mensagem)
        {

        }
        public SaldoInsuficienteException(string mensagem,Exception excecaoInterna) : base(mensagem,excecaoInterna)
        {

        }
    }
}
