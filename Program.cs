using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args) 
        {
           decimal num1=0; decimal num2=0;
            //Console.WriteLine("enter num1 ");
            // decimal.TryParse(Console.ReadLine(), out num1);
            //// Console.WriteLine("enter num2 ");
            // decimal.TryParse(Console.ReadLine(), out num2);
            // Console.WriteLine("enter operation for (+.-.*./)");
            // string operation = Console.ReadLine();
            while (true)
            {
                clc(num1, num2); 

                Console.WriteLine("Would you like to perform another arithmetic operation? (y/n)");
                string continueChoice = Console.ReadLine().ToLower();

                if (continueChoice != "y")
                    break; 
            }

           // clc(num1,num2);
           
        }
        static void clc(decimal num1 , decimal num2)
        {
           Console.WriteLine("enter num1 ");
            decimal.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("enter num2 ");
            decimal.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("enter operation for (+.-.*./)");
            string operation=Console.ReadLine();

            switch (operation) 
            {
                case "+":
                    decimal process = num1 + num2;
                    Console.WriteLine(string.Format("{0}+{1}={2}",num1,num2, process));
                    break;
                    case"-":
                    decimal  result= num1 - num2;
                    Console.WriteLine(string.Format("{0}-{1}={2}", num1, num2, result));
                    break;
                case "*":
                    decimal multiplication = num1 * num2;
                    Console.WriteLine(string.Format("{0}*{1}={2}", num1, num2, multiplication));
                    break;
                case "/":
                    decimal division = num1 / num2;
                    Console.WriteLine(string.Format("{0}/{1}={2}", num1, num2, division));
                    break;
                    default:
                    Console.WriteLine("worng operoation...");
                    break;


         
         
            }

            Console.ReadLine();
        }





    }




}

