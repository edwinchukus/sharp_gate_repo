using System;
using System.Runtime.InteropServices;
using SeaLionProject.fish;
using SeaSharkProject.access_modifiers;
using SeaSharkProject.basics;
using SeaSharkProject.calf;
using SeaSharkProject.facebook;
using SeaSharkProject.gettersAndSetters;
using SeaSharkProject.Property;

namespace SeaSharkProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Laptop mac = new Laptop();
            Console.WriteLine(mac.LaptopName);
            mac.LaptopName = "Dell Latitude 5201";
            Console.WriteLine(mac.LaptopName);

            Console.WriteLine(mac.Amount = 52.0);
            Console.WriteLine(mac.Amount);
        }


        
    }
}
