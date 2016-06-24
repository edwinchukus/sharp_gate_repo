using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class iphone5s: iphone
    {
        public override void  Model()
        {
            Console.WriteLine("This model of iphone is iphone5s");
        }

        public void LauchDate()
        {
            Console.WriteLine("the launch date was september 2013");
        }

    }
}
