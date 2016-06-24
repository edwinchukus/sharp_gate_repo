using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.EnumConcepts
{


    public class Car
    {
        public CarColours Colours { get; set; } = CarColours.black;


        public enum CarColours
        {
            WhiteCar,
            blue ,
            black ,
            orange 
        }
    }
}
