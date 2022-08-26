using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        

        static void UtilizandoStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    //Console.WriteLine(linha);
                    var conta = ConverterStringParaContaCorrente(linha);
                    Console.WriteLine($"Agência: {conta.Agencia}, Número: {conta.Numero}, " +
                        $"Saldo: {conta.Saldo}, Titular: {conta.Titular.Nome}");
                }
                //Console.WriteLine(leitor.ReadLine());
                //Console.WriteLine(leitor.ReadToEnd());
            }

        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');//retorna um Array de strings
            ContaCorrente conta = new ContaCorrente(int.Parse(campos[0]), int.Parse(campos[1]));

            conta.Depositar(double.Parse(campos[2].Replace('.', ',')) - conta.Saldo);
            //Replace foi usado para o caso de um arquivo que tenha '.' no lugar de ',' no campo saldo
            //Pois o parse não lê o ponto e converte as casas decimais em número, alterando o resultado esperado.
            //Com o replace, caso o formato do arquivo tenha ponto ele troca por vírgula para fazer a leitura correta
            conta.Titular.Nome = campos[3];
            return conta;
        }

    }
}
