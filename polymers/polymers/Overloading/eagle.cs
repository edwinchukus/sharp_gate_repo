using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymers.Overloading
{
   public class eagle
    {
       public void Fly()

       {
           Console.WriteLine("I fly higher bc am an Eagle");
           
       }

       public void Fly(string BirdName)
       {
           Console.WriteLine("I fly higher bc am an {}", BirdName);   
       }

       public void Fly(double speed)
       {
           Console.WriteLine("As an Eagle at 4years with 2 wings, i can fly at "+speed+"");   
       }


    }
}
