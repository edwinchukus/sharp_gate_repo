using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.polymorphism.overriding
{
    public class Son : Father
    {

        public override void ShowMeYourPhone(string phoneName)
        {
            Console.WriteLine("This is phone - Son " + phoneName);
        }


        public override long MakePhoneCall()
        {
            Console.WriteLine("Calling ---- " + 292955);
            return 292955;
        }


        public Son(string fatherName) : base(fatherName)
        {
        }
    }
}
