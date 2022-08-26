using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_LongTermInvestment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 12");


            /*
            double investedValue = 1000;
            double gainFactor = 1.0036;


            
            for (int year = 1; year <= 5; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    investedValue *= gainFactor;
                    Console.WriteLine("Invested value after year " + year + " / month " + month + " is R$"+investedValue);
                }

                gainFactor += 0.0010;
            }

            Console.WriteLine("At the end, you will have R$" + investedValue);
            */



            for (int counterLine = 0; counterLine < 10; counterLine++)
            {
                for (int counterColumn = 0; counterColumn <= 10; counterColumn++)
                {

                    Console.Write("*");
                    if (counterColumn >= counterLine)
                    {
                        break;
                    }
                }
                Console.WriteLine("");
            }

            for (int counterLine = 0; counterLine < 10; counterLine++)
            {
                for (int counterColumn = 0; counterColumn <= counterLine; counterColumn++)
                {

                    Console.Write("*");
                    
                }
                Console.WriteLine("");
            }



            Console.ReadLine();
        }
    }
}
