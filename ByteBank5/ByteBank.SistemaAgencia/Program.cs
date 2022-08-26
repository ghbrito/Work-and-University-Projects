using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            object conta = new ContaCorrente(3040, 082442);
            Console.WriteLine(conta.ToString());
            Console.WriteLine(conta);

            Cliente gui1 = new Cliente();
            gui1.Nome = "Guilherme";
            gui1.CPF = "068619566";
            gui1.Profissao = "Oficial Substituto";

            Cliente gui2 = new Cliente();
            gui2.Nome = "Guilherme";
            gui2.CPF = "068619566";
            gui2.Profissao = "Oficial Substituto";

            if (gui1.Equals(conta))
            {
                Console.WriteLine("São iguais !");
            }
            else
            {
                Console.WriteLine("Não são iguais !");
            }

            string urlParametros = "https://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            Console.WriteLine("A moeda destino é '" + extrator.GetValor("moedaDestino") + "'");
            Console.WriteLine("A moeda origem é '" + extrator.GetValor("moedaOrigem") + "'");
            Console.WriteLine("O valor é '" + extrator.GetValor("VaLOr") + "'");

            if (urlParametros.StartsWith("https://www.bytebank.com.br"))//Existe também o string.EndsWith("   ")
            {
                Console.WriteLine("É uma página do bytebank");
            }


            //Reconhecendo padrões em strings, ex : número de telefone

            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string padrao = "[0-9]{4}[-][0-9]{4}";
            string teste = "Olá, meu telefone é 3637-2320, obrigado!";
            if (Regex.IsMatch(teste, padrao))//Método da classe System.Text.RegularExpressions para retonar se uma strinc contém um padrão definido por outra string
            {
                Console.Write("Número de telefone encontrado na string: ");
                Console.WriteLine(Regex.Match(teste, padrao));//Retornar a string encontrada que respeita o padrão definido
            }

            //padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";//Dessa forma ele vai encontrar tanto os números que tem o 9 na frente, quanto os que não tem
            padrao = "[0-9]{4,5}-?[0-9]{4}";//usando o quantificador '?' ele aceita quando tem o caractere e também quando não tem
            teste = "Olá, meu telefone é 637-2320, obrigado! O celular é 999819175";
            if (Regex.IsMatch(teste, padrao))//Método da classe System.Text.RegularExpressions para retonar se uma strinc contém um padrão definido por outra string
            {
                Console.Write("Número de telefone encontrado na string: ");
                Console.WriteLine(Regex.Match(teste, padrao));//Retornar a string encontrada que respeita o padrão definido
            }


            //DateTime dataFimPagamento = new DateTime(2022, 4, 25);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = TimeSpan.FromMinutes(60);//dataFimPagamento.Subtract(dataCorrente);

            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(dataCorrente);

            //string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);




            //Console.WriteLine(mensagem);


            //ContaCorrente conta = new ContaCorrente(6546, 8665132);

            //FuncionarioAutenticavel funcionario = null;



            //Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            return timeSpan.Days + " dias";
        }
    }
}
