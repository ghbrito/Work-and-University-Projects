using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente Matheus = new Cliente();
            Cliente Thiago = new Cliente();
            ContaCorrente contaMatheus = new ContaCorrente();
            ContaCorrente contaThiago = new ContaCorrente();
            contaMatheus.titular = Matheus;
            contaThiago.titular = Thiago;

            contaMatheus.titular.nome = "Matheus Brito";
            contaMatheus.titular.cpf = "10032015";
            contaMatheus.titular.profissao = "Estudante";
            contaThiago.titular.nome = "Thiago Brito";
            contaThiago.titular.cpf = "12072016";
            contaThiago.titular.profissao = "Estudante";

            
            


            if (contaMatheus.Sacar(50))
                Console.WriteLine("Saque efetuado com sucesso");
            else
                Console.WriteLine("Saldo insuficiente");

            Console.WriteLine("Saldo = " + contaMatheus.saldo);

            contaMatheus.Depositar(200);
            

            Console.WriteLine("Saldo = " + contaMatheus.saldo);

            Console.WriteLine(contaMatheus.Transferir(130,contaThiago));

            Console.WriteLine("Saldo Matheus = R$" + contaMatheus.saldo);
            Console.WriteLine("Saldo Thiago = R$" + contaThiago.saldo);

            Console.ReadLine();
        }
    }
}
