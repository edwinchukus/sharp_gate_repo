using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading;

namespace ColdPlayProject.exception_handling
{
    public class Calculator
    {

        public void ConnectToDb()
        {
            try
            {
                // Code to connect to a Db
            }
            catch (Exception)
            {
                  
            }
            finally
            {
                //Close the DB Connect  
            }

        }

        public void DivideNumber(int a, int b)
        {
            try
            {
                double an = a/b;
                Console.WriteLine(an);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception has occoured with details " + e.StackTrace);
                Console.WriteLine("An exception has occoured with details " + e.Message);
            }
            
        }
    }
}
