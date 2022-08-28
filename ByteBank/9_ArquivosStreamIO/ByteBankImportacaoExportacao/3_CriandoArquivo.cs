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
        



        static void CriarArquivoComWrite(string caminhoArquivoOriginal)
        {
            var caminhoNovoArquivo = "ContasExportadas.csv";
            //Se for utilizado o CreateNew ao invés do Create, ele verificará se já existe um
            //arquivo com o mesmo nome. Se já existir ele lança uma exceção
            using (var streamWriter = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var streamReader = new FileStream(caminhoArquivoOriginal, FileMode.Open))
            using (var escritor = new StreamWriter(streamWriter))
            using (var leitor = new StreamReader(streamReader))
            {
                while(!leitor.EndOfStream)
                {
                    var conta = ConverterStringParaContaCorrente(leitor.ReadLine());
                    escritor.WriteLine($"Agência: { conta.Agencia}, Número: { conta.Numero}, " +
                        $"Saldo: {conta.Saldo}, Titular: {conta.Titular.Nome}");
                    //escritor.Flush();
                    //Flush utilizado para despejar as informações do buffer imediatamente para o arquivo
                }
                
            }
            Console.WriteLine("Arquivo Criado. . .");

        }

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "ContasExportadas.csv";
            var contaComoString = "3040,082442,21325.98,Guilherme Brito";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
        }
    }
}
