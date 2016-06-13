using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.polymorphism.overriding
{
    public class Daughter : Father
    {

        public Daughter(string fatherName) : base(fatherName)
        {
        }

        public string FatherName { get { return _fatherName; } private set { _fatherName = value; } }

        public override void ShowMeYourPhone(string phoneName)
        {
           base.ShowMeYourPhone(phoneName);
        }


        public override long MakePhoneCall()
        {
            Console.WriteLine("Calling ---- " + 8555224525);
            return 8555224525;
        }

       
    }
}
