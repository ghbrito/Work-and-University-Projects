using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                CarregarContas();
            }
            catch (Exception )
            {
                Console.WriteLine("CATCH NO MÉTODO MAIN");
            }



            Console.WriteLine("Execução finalizada. Tecle ENTER para sair. . .");
            Console.ReadLine();

        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {

                
                leitor.LerProximaLinha();
            }


            // --------------------------------------------------------------

            //LeitorDeArquivos leitor = null;
            //try
            //{

            //    leitor = new LeitorDeArquivos("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();


            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {

                Metodo();

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            catch (ArgumentException e)
            {

                if (e.ParamName == "numero")
                {

                }
                Console.WriteLine("Argumento com problema: " + e.ParamName);

                Console.WriteLine("Ocorreu uma exceção do tipo Argument Exception.");
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }/*
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
                Console.WriteLine(e.StackTrace);
            }*/
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informações da Exceção Interna (inner exception)");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);

            }
        }
        private static void Metodo()
        {



            ContaCorrente conta = new ContaCorrente(1000, 321566);
            ContaCorrente conta2 = new ContaCorrente(2000, 654999);

            //conta2.Transferir(5000,conta);
            conta2.Sacar(5000);

            Console.WriteLine(ContaCorrente.TaxaOperacao);

            conta.Sacar(10);


            ContaCorrente guilherme = null;
            Console.WriteLine(guilherme.Saldo);

            //return;
        }


    }

}

