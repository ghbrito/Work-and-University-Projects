using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3: Criando Variáveis de Ponto Flutuante");

            double salario = 1200.70;

            Console.WriteLine("Salário inicial é " + salario);

            salario += 250;

            Console.WriteLine("Salário + alimentação = "+salario);

            double idade = 15;

            idade = 15 / 2;

            Console.WriteLine("Double idade 15 / 2 é " + idade);


            idade = 15.0 / 2;
            Console.WriteLine("Double idade 15.0 / 2 é "+idade);



            Console.WriteLine("A execução terminou. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
