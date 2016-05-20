using System;
using System.Runtime.InteropServices;
using SeaLionProject.fish;
using SeaSharkProject.access_modifiers;
using SeaSharkProject.basics;
using SeaSharkProject.calf;
using SeaSharkProject.facebook;
using SeaSharkProject.gettersAndSetters;

namespace SeaSharkProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Eagle eagle = new Eagle();

            //            Console.WriteLine(eagle.eagleName);
            //
            //            eagle.eagleName = "Black Eagle";
            //            Console.WriteLine(eagle.eagleName);

            string name = eagle.GetEagleName();
            Console.WriteLine(name);
            eagle.SetHasWings(false);


            eagle.SetEagleName("Black Eagle");


            string name1 = eagle.GetEagleName();
            Console.WriteLine(name1);

            eagle.Fly();

            // Object Oriented Programming Langauge 
            // Encapsulation
            // Inheritance
            // Polymorphism



        }


        
    }
}
