using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monday.abstractNameSapec;

namespace Monday
{
    class Program
    {
       public static void Main(string[] args)
        {
         Dog dog= new Dog ("Whisky", 5, true);
           string name = dog.ShowAnimalName();
           dog.Run();

        }

    }
}
