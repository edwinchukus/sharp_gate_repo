using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewTwo
{
    public class Class1
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }


        public string GetName()
        {
            return name;
        }

        protected void MakeCall()
        {
            Console.WriteLine("Hello Sammy, What is going on here");
        }
    }
}
