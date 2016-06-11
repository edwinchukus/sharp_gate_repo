
using System;
using System.Runtime.InteropServices;
using SeaLionProject.fish;
using SeaSharkProject.access_modifiers;
using SeaSharkProject.basics;
using SeaSharkProject.calf;
using SeaSharkProject.concepts;
using SeaSharkProject.facebook;
using SeaSharkProject.gettersAndSetters;
using SeaSharkProject.Property;

namespace SeaSharkProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ans = 0;

            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();

            Fish fish = new Fish();


     

            fish.ComputeAmount(num, ans); 





        }


        
    }
}
