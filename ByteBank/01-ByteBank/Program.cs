using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMatheus = new ContaCorrente();  //criação de uma instância da classe ContaCorrente

            contaMatheus.titular = "Matheus Barcelos Guimaraes Brito";
            contaMatheus.agencia = 3040;
            contaMatheus.numero = 082442;
            contaMatheus.saldo = 2350.75;

            Console.WriteLine("A conta do titular " + contaMatheus.titular + " tem o número " + contaMatheus.numero +
                " , agência " + contaMatheus.agencia + " e tem o saldo de R$" + contaMatheus.saldo);


            Console.ReadLine();
        }
    }
}
