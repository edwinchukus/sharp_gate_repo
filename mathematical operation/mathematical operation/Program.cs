using System;
using System.Collections.Generic;
using System.Linq;using System.Threading.Tasks;

using System.Text;

namespace mathematical_operation
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please key in your password");
            string customerName = Console.ReadLine();
            if(customerName.Equals("andre"))
            {
                Console.WriteLine("lives in london");  
            }
            else if (customerName.Equals("casi"))
            {
                Console.WriteLine("lives in Bratford"); 
            }
            else if (customerName.Equals("sam"))
            {

                Console.WriteLine("northamnpton");
            }
            else
            {
                Console.WriteLine("The person does not exit in the class");
            }
 
            
           
       }
  }
            

            
   

        }
    

