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
        static void Main(string[] args)
        {
            UsarStreamDeEntrada();

            Console.ReadLine();
        }

        static void UsarStreamDeEntrada()
        {
            //File.ReadAllLines("caminhoArquivo");
            //ReadAllBytes
            //    WriteAllLines
            //    WriteAllText




            using (var inputStream = Console.OpenStandardInput())//O Console.ReadLine faz essa mesma função
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];
                while (true)
                {


                    var bytesLidos = inputStream.Read(buffer, 0, buffer.Length);

                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();

                    Console.WriteLine($"Bytes lidos do console: {bytesLidos}");
                }

            }
        }
    }
}
