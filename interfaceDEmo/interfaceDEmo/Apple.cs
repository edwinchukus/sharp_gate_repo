using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceDEmo
{
   class Apple:ISmartPhone
    {
        public void OS()
        {
            Console.WriteLine("The os of this smartphone is ios8");
        }

        public void AppStore()
        {
            Console.WriteLine("the appstore for this smartphone is Itune");
        }
        
    }
}
