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
            

            if (car.Colours == Car.CarColours.WhiteCar)
            {
                Console.WriteLine("You bought an orange car");
            }else if (car.Colours == Car.CarColours.black)
            {
                Console.WriteLine("You bought an Black car");
                car.Colours = Car.CarColours.blue;
            }else if (car.Colours == Car.CarColours.WhiteCar)
            {
                Console.WriteLine("You bought an white car");
            }else if (car.Colours == Car.CarColours.blue)
            {
                Console.WriteLine("You bought an blue car");
            }

        }



    }
}


