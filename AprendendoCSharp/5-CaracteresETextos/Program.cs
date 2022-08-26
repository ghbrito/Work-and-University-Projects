using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");
            //character
            char primeiraLetra = 'a'; //char aceita somente aspas simples, duplas apenas para texto , string etc
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)66; //66 é o código na tabela ascii da letra B maíuscula
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); //type casting de int para char de toda a soma
            Console.WriteLine(primeiraLetra);


            string titulo = "Estou aprendendo a programar em C# =)";
            Console.WriteLine(titulo);

            string cursosProgramacao = @"Cursos:
- .NET 
- Java 
- JAvascript";

            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }
    }
}
