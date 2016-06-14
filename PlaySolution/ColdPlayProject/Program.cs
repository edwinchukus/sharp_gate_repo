using System;
using System.Collections.Generic;
using ColdPlayProject.inheritance;
using ColdPlayProject.interfaceNamespace;
using ColdPlayProject.interfaceNamespace.implementation;
using ColdPlayProject.list_in_csharp;
using ColdPlayProject.one_dim_arrays;
using ColdPlayProject.polymorphism.overloadding;
using ColdPlayProject.polymorphism.overriding;
using ColdPlayProject.two_dim_arrays;
using Father = ColdPlayProject.polymorphism.overriding.Father;
using Son = ColdPlayProject.inheritance.Son;


namespace ColdPlayProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
                        HondaCivic hc = new HondaCivic();
                        string n = hc.DisplayCarName("5241 Honda");
                        Console.WriteLine(n);
            
                        ToyotaCamry camry = new ToyotaCamry();
                        String nn = camry.DisplayCarName("TC");
                        Console.WriteLine(nn);

            ICar car = new HondaCivic();
            bool h = car.HasStopped();
            ICar car1 = new ToyotaCamry();
            bool h1 = car1.HasStopped();

            IVehicle veh = new HondaCivic();
            veh.ShowVehicleName();

            List<int> n3 = new List<int>();

        }
    }
}


// = Object Oriented Programming = 
        //Encapsulation
        //Inheritance
        //Polymorphism
        //Abstract
        //Interface