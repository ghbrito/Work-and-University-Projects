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

        static void utilizandoFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";


            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; //buffer de 1kb
                var numeroDeBytesLidos = -1;// fluxoDoArquivo.Read(buffer, 0, 1024);
                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBufferNaTela(buffer, numeroDeBytesLidos);
                }
            }//Utilização do USING para realizar a liberação do arquivo no sistema após a sua utilização
            //Ele funciona como se fosse o finally e usa o método dispose ao final
        }

        static void EscreverBufferNaTela(byte[] buffer, int numeroDeBytesLidos)
        {

            var encoding = Encoding.Default;
            var texto = encoding.GetString(buffer, 0, numeroDeBytesLidos);

            Console.Write(texto);
            //Console.Write(" ");

        }
    }
}