using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClassDemo.NewFolder1;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanstiate iphone class error message occurred as expected
            iphone5s iphone5s= new iphone5s();
            iphone5s.Call();
            iphone5s.LauchDate();
            Console.ReadKey();
        }
    }
}
