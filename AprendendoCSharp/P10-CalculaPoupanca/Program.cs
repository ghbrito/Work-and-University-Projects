using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Project 10 - Savings Calculator");
            double investedValue = 1000;

            //investedValue = investedValue + investedValue * 0.0036; //0.36% = 0.0036
            //Console.WriteLine("After 1 month you'll have R$" + investedValue);
            //investedValue = investedValue + investedValue * 0.0036;
            //Console.WriteLine("After 2 months you'll have R$" + investedValue);

            /*
            int counterMonth = 1;
            
                        while (counterMonth <= 12)
                        {
                            investedValue = investedValue + investedValue * 0.0036; //0.36% = 0.0036
                            Console.WriteLine("After "+counterMonth+" month(s) you'll have R$" + investedValue);
                            //counterMonth += 1;
                            counterMonth++;
                        }
            */


            for (int month = 1; month <= 12; month++)
            {
                investedValue = investedValue + investedValue * 0.0036; //0.36% = 0.0036
                Console.WriteLine("After 1 month you'll have R$" + investedValue);
            }



            Console.ReadLine();
        }
    }
}
