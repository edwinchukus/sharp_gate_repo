using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping.Exceltion_Handling
{
   public class Calculator
    {
       public void DivideNumber(int a, int b)
       {
           try
           {
                double an = a / b;
                Console.WriteLine(an);
            }
           catch (ArithmeticException e)
           {

               Console.WriteLine("An exception has occurred with details"+ e.StackTrace);
               Console.WriteLine("An exception has occurred with details" + e.Message);
               throw new Exception("I am unable to divide a number with zero");
           }
          
       }
    }
}
