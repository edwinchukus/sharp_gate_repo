using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColdPlayProject.inheritance;

namespace ColdPlayProject.polymorphism.overriding
{
    public class Father
    {
        protected string _fatherName; 

        public Father(string fatherName)
        {
            this._fatherName = fatherName;
        }

        public void GoToMeeting()
        {
            Console.WriteLine("Going to meeting");
        }

        public virtual void ShowMeYourPhone(string phoneName)
        {
            Console.WriteLine("This is phone: Model {0} - Father", phoneName);
        }

        public virtual long MakePhoneCall()
        {
            Console.WriteLine("Calling ... "+ 50210485);
            return 50210485;
        }

        public static implicit operator Father(inheritance.Son v)
        {
            throw new NotImplementedException();
        }
    }
}
