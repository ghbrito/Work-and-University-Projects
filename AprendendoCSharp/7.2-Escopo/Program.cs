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

            bool acompanhado = true;
            string mensagemAdicional = "";

            if (acompanhado == true)
            {
                mensagemAdicional = "Guilherme está acompanhado.";
            }
            else
            {
                mensagemAdicional = "Guilherme não está acompanhado.";
            }

            if (idadeGuilherme >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);



            }
            else
            {

                Console.WriteLine("Não pode entrar.");
                Console.Write(mensagemAdicional);

            }








            Console.ReadLine();
        }
    }
}