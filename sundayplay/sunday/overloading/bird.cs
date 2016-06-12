using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunday.overloading
{
    public class bird
    {
        public void Eat()
        {
            Console.WriteLine("i am a bird that {0}");
        }

        public void Eat(string corn)
        {
            Console.WriteLine("we went to the resturant and ate"+corn+"") ;  
        }
    }
}
