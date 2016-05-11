using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeaSharkProject.calf;

namespace SeaSharkProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number?");
            string number1  = Console.ReadLine();
            double num1 = Double.Parse(number1);

            Console.WriteLine("please select what you would like to do?");
            Console.WriteLine("please select +, -,/");
            string operatorInCal = Console.ReadLine();
           

            Console.WriteLine("Please enter your second number?");
            string number2 = Console.ReadLine();
            double num2 = Double.Parse(number2);

            LogicOperation casio = new LogicOperation(num1, num2); //Construction or Instantiation of a class

   

            if (operatorInCal.Equals("+"))
            {
                double an = casio.Add();
                Console.WriteLine(an);
            }else if (operatorInCal.Equals("/"))
            {
                double an = casio.Divide();
                Console.WriteLine(an);
            }
            else
            {
                throw new Exception("There is no such operation in this software!");
            }


        }
    }
}
