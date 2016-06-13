using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.interfaceNamespace.implementation
{
    public class ToyotaCamry : ICar
    {
        public void Move()
        {
            Console.WriteLine("My car is Toyoto Camry and It can move");
        }

        public double CalculateDistanceAfterRace()
        {
            return 89;
        }

        public string DisplayCarName(string carMake)
        {
            return carMake + "Model Name";
        }

        public bool HasStopped()
        {
            return false;
        }

        public void SoundHorn()
        {
            Console.WriteLine("Peppep");
        }

        public void ShowVehicleName()
        {
            Console.WriteLine("my motor name is {0}", 90);
        }
    }
}
