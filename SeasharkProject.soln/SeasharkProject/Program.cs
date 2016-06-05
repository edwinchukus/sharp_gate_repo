using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeasharkProject.oops;

namespace SeasharkProject
{
   public class Program
         
     {
        static void Main(string[] args)
        {
        Eagle eagle= new Eagle();

            string result = eagle.eagleName;
            Console.WriteLine(result);
            
            

        }
    }
}
