using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism.interfaceNamesapce.implementation
{
    class ToyotaCamry:ICar
    {
        public void Move()
        {
            Console.WriteLine("my car is toyotaCamry and it can move");
        }

        public double CalculateDistanceAfterRace()
        {
            throw new NotImplementedException();
        }

        public string DisplayCarName()
        {
            throw new NotImplementedException();
        }

        public bool hasTheCarStopped()
        {
            throw new NotImplementedException();
        }
    }
}
