using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Lifetime;
using System.Threading;
using ColdPlayProject.area_of_emphasis;
using ColdPlayProject.modifierss;
using ReviewProject.FirstReview;
using ReviewProject.SecondReview;
using ReviewTwo;
using Car = ColdPlayProject.EnumConcepts.Car;

namespace ColdPlayProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Car car = new Car();
            
            car.Colours = Car.CarColours.OrangeCar;

            if (car.Colours == Car.CarColours.WhiteCar)
            {
                Console.WriteLine("You bought an orange car");
                car.Make = Car.CarMake.Toyoto;
            }else if (car.Colours == Car.CarColours.BlackCar)
            {
                Console.WriteLine("You bought an Black car");
                car.Colours = Car.CarColours.BlueCar;
            }else if (car.Colours == Car.CarColours.WhiteCar)
            {
                Console.WriteLine("You bought an white car");
            }else if (car.Colours == Car.CarColours.BlueCar)
            {
                Console.WriteLine("You bought an blue car");
            }

        }



    }
}


