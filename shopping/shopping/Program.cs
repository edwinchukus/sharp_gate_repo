using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shopping.Exceltion_Handling;

namespace shopping
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);

            Console.WriteLine("please enter the second number");
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);

            Calculator  calc = new Calculator();
            double answer = calc.DivideNumber(a, b);
            Console.WriteLine(answer);


        }
    }
}
