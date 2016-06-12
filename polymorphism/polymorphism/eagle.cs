using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class eagle
    {
        private int BirdLegs = 2;
        private string birdColour = "whilte";
        private double Birdspeed = 120d;

        internal void Fly()
        {
            throw new NotImplementedException();
        }

        public void Fly(double BirdSpeed)
        {
            Console.WriteLine("i can fly faster than birds");
        }

        public void Fly(int BirdLegs)
        {
            Console.WriteLine("this bird can fly and walk with {0} legs",BirdLegs);
        }

        public void Fly(String birdColour)
        {
         Console.WriteLine("i can fly her bc am an Eagle{0}", birdColour);
        }

    }
}
