
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.OpticsDir;
using Test.QuantumPhysicsDir.SubQP;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is so cool learning C#. Please press the Enter key on your keyboard");
            Console.ReadKey();

            //Prompt the user to enter a name
            Console.WriteLine("Please enter your name");
            Console.WriteLine(".............................");

            //Get the user name from the console
            string enterName = Console.ReadLine();
            Console.WriteLine(".............................");

            //Create a new object of Class Andre
            Andre human = new Andre();
            human.EyeSight();
            human.LegRun();
            Console.WriteLine(".............................");
            Console.WriteLine("Press any key to exit the application");

            Console.ReadKey();
        }
    }
}
