using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.EnumConcepts
{


    public class Car
    {
        public CarColours Colours { get; set; } = CarColours.BlackCar;
        public CarMake Make { get; set; } = CarMake.Toyoto;

        public enum CarColours
        {
            WhiteCar = 1,
            BlueCar,
            BlackCar,
            OrangeCar 
        }


        public enum CarMake
        {
            Volvo,
            Toyoto,
            Mazda
        }
    }
}
