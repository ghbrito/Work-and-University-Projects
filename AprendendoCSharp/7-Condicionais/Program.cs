using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeGuilherme = 16;
            int quantidadePessoas = 2;


            if (idadeGuilherme >= 18)
            {
                Console.WriteLine("Guilherme possui mais de 18 anos de idade. Pode entrar.");



            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Guilherme náo possui 18 anos ou mais por[em ele est[a acompanhado e poder[a entrar.");
                }
                else
                {
                    Console.WriteLine("Guilherme é menor de idade. Ele não pode entrar.");
                }

            }








            Console.ReadLine();
        }
    }
}
