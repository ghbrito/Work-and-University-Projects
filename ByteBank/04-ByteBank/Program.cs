using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(3040, 082442);






            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaMatheus = new ContaCorrente(3040, 005393);

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
