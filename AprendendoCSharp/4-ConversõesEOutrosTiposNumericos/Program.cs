using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversõesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            int salarioEmInteiro = (int)salario;
            //Forçando o C# a converter o double em int, mesmo perdendo precisão - para converter é preciso fazer os parênteses fazendo um casting
            Console.WriteLine("Salario em inteiro = " + salarioEmInteiro);

            long idadeUniverso;
            idadeUniverso = 13000000000; //Para utilizar um número maior que 2 bilhoes é preciso usar a variável long, uma vez que int suporte até 32bits
            //Long é uma variável de 64 bits , contra 32 do int. Já a variável short suporta até 16 bits (um pouco mais que 16000)
            Console.WriteLine(idadeUniverso);

            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);


            float altura = 1.80f;
            Console.WriteLine(altura);



            Console.ReadLine();

        }
    }
}
