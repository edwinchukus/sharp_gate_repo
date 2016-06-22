using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fishSharp.exception_handling;

namespace fishSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);

            Console.WriteLine("please enter the first number");
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);


            phone ph=new phone();
            double answer = ph.DivideNumber();
            Console.WriteLine(answer);
        } 
    }
}
