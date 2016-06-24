using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
   abstract class iphone
    {
       public void Call()
       {
           Console.WriteLine("call method to provide calling features");   
       }

       public virtual void Model()
       {
           
       }
    }
}
