using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.interfaceNamespace
{
    public interface ICar : IVehicle
    {

        void Move();

        double CalculateDistanceAfterRace();

        string DisplayCarName(string carMake);

        bool HasStopped();

    }
}
