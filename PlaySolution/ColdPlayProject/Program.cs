using System;
using System.Collections.Generic;
using System.Threading;
using ColdPlayProject.abstractConcept;
using ColdPlayProject.abstractConcept.domesticAnimal;
using ColdPlayProject.exception_handling;


namespace ColdPlayProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);

            Console.WriteLine("Please enter the second number: ");
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);

            Calculator calc = new Calculator();
            calc.DivideNumber(a, b);

            Thread.Sleep(1000);
        }
    }
}


// = Object Oriented Programming = 
        //Encapsulation
        //Inheritance
        //Polymorphism - Overloading & Overriding
        //Abstract
        //Interface 