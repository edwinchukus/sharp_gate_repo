using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.inheritance
{
    public class Father
    {

        protected long mobilePhoneNumber = 52212012;

//        public Father(long mobilePhoneNumber)
//        {
//            this.mobilePhoneNumber = mobilePhoneNumber;
//        }

        protected void MakePhoneCalls()
        {
            Console.WriteLine("I am calling ..."+ mobilePhoneNumber);
        }
    }
}
