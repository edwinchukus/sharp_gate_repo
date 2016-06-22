using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okehampton
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator casioCalculator= new Calculator();
            casioCalculator.Add();
            casioCalculator.Divide();
            Console.WriteLine("ans for "  );
            Console.ReadKey();
        }
    }
}
