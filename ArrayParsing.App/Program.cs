using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayParsing.App
{
    internal class Program
    {
        /* A program where a user enters a string and only displays numbers. */

        static void Main(string[] args)
        {
            // Integer for deciding loop.
            int loopChoice = 1;


            // "Do-While" loop that decides whether or not to do user input again.
            do
            {

                Console.WriteLine("Please enter your numbers:\n");
                
                Console.ReadLine();

                string input = "12435";

                int[] onlyNums = Array.ConvertAll(input.Split(','), int.Parse);

                Console.WriteLine("{0}", string.Join(", ", onlyNums));

                Console.ReadLine();

                Console.WriteLine("Do you wish to enter another set of numbers (1 = Yes, 0 = No)?: ");

                Console.Write(loopChoice);

            }while (loopChoice == 1);

            // End message displays if user 
            Console.WriteLine("Thank you for using our program.\nGood bye.");
        }
    }
}