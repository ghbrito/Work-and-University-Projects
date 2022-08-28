using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis");

            int idade;
            idade = 32;

            Console.Write("Idade é ");
            Console.WriteLine(idade);

            idade = (idade + 10) * 2;

            Console.Write("Agora sua idade é "+idade+", parabéns!\n");
            //Console.WriteLine(idade);


            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
