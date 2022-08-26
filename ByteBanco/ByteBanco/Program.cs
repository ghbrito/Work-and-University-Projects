using ByteBanco.Funcionarios;
using ByteBanco.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


           

            Funcionario carlos = new Funcionario(2000,"321556549");

            carlos.Nome = "Carlos";
            

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos: "+carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor("65498752");
            roberta.Nome = "Roberta";
            

            Console.WriteLine(roberta.CPF);

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário Roberta: "+roberta.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: "+ roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            */

            //CalcularBonificacao();

            UsarSistema();


            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario roberta = new Diretor("665498333");
            gerenciadorBonificacao.Registrar(roberta);
            Funcionario guilherme = new Desenvolvedor("06861959996");
            gerenciadorBonificacao.Registrar(guilherme);
            roberta.GetBonificacao();


            Console.WriteLine("Bonificações : " + gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("65498752");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");



            sistemaInterno.Logar(roberta,"122");
            
        }

    }
}
