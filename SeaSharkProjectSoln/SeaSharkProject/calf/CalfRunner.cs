using System;

namespace SeaSharkProject.calf
{
    internal class CalfRunner
    {
        public void CRunner()
        {
            Console.WriteLine("Please enter your first number?");
            var number1 = Console.ReadLine();
            var num1 = double.Parse(number1);

            Console.WriteLine("please select what you would like to do?");
            Console.WriteLine("please select +, -,/");
            var operatorInCal = Console.ReadLine();


            Console.WriteLine("Please enter your second number?");
            var number2 = Console.ReadLine();
            var num2 = double.Parse(number2);

            var casio = new LogicOperation(num1, num2); //Construction or Instantiation of a class


            if (operatorInCal.Equals("+"))
            {
                var an = casio.Add();
                Console.WriteLine(an);
            }
            else if (operatorInCal.Equals("/"))
            {
                var an = casio.Divide();
                Console.WriteLine(an);
            }
            else
            {
                throw new Exception("There is no such operation in this software!");
            }
        }
    }
}