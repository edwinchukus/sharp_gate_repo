using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.inheritance
{
    public class Son : Father
    {
       

        public void MakePhoneCalls()
        {
            base.MakePhoneCalls();
//            Console.WriteLine("I am calling ..." + mobilePhoneNumber);
        }
    }
}
