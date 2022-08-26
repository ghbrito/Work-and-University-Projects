using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_1_PrintMultiplesOf3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing multiples of 3, between number 1 and 100
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 ==0)//i / 3 > 1 && 
                {
                    Console.WriteLine("The number "+i+" is a multiple of 3");
                }
            }
            Console.ReadLine();
        }
    }
}
