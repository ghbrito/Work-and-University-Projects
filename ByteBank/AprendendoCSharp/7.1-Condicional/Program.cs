using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeGuilherme = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            if (idadeGuilherme >= 18 || acompanhado == true)
            {
                Console.WriteLine("Guilherme possui mais de 18 anos de idade ou está acompanhado. Pode entrar.");



            }
            else
            {

                Console.WriteLine("Guilherme é menor de idade e está desacompanhado. Ele não pode entrar.");


            }








            Console.ReadLine();
        }
    }
}
