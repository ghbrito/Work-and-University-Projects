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
        //static void Main(string[] args)
        //{

        //    //EscritaBinaria();

        //    //Console.ReadLine();
        //    //LeituraBinaria();


        //    //Console.ReadLine();
        //}

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var sr = new BinaryReader(fs))
            {
                var agencia = sr.ReadInt32();
                var numeroConta = sr.ReadInt32();
                var saldo = sr.ReadDouble();
                var titular = sr.ReadString();

                Console.WriteLine($"Agência {agencia}, conta nº {numeroConta}, saldo {saldo}, titular {titular}");
            }
        }
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var sw = new BinaryWriter(fs))
            {
                sw.Write(3040);
                //sw.Write(',');
                sw.Write(203444);
                //sw.Write(',');
                sw.Write(21744.96);
                //sw.Write(',');
                sw.Write("Guilherme Brito");
            }
        }
    }
}
