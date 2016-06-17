using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Lifetime;
using System.Threading;
using ColdPlayProject.area_of_emphasis;


namespace ColdPlayProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter date of birth");
            string dob = Console.ReadLine();

            CasioCalculator calc = new CasioCalculator();
            try
            {
                calc.Divide(dob, 0);
            }
            catch (Exception)
            {
                
            }



        }
    }

    public class CasioCalculator
    {
        public void Divide(string dob, int i)
        {
            try
            {
                Console.WriteLine(int.Parse(dob) / i);
            }
            catch (Exception exception)
            {
                throw new ArithmeticException(exception.Message);
            }
        }
    }
}


