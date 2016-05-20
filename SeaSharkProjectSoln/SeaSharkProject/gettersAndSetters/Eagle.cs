using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaSharkProject.gettersAndSetters
{
    public class Eagle
    {


        private string eagleName = "White Eagle";
        private double eagleWieght = 5.00;
        private bool hasWings = true;
        private int numberOfEaglesEyes = 2;
        private string name;

        public string GetEagleName()
        {
            return eagleName;
        }

        private double GetEagleWeight()
        {
            return eagleWieght;
        }

        
        public bool GetHasWings()
        {
            return hasWings;
        }


        public int GetNumberOfEyes()
        {
            return numberOfEaglesEyes;
        }

       
        public void SetEagleName(string eagleName)
        {
            this.eagleName = eagleName;
        }

        public void SetEagleWeight(double eagleWieght)
        {
            this.eagleWieght = eagleWieght;
        }

        public void SetHasWings(bool hasWings)
        {
            this.hasWings = hasWings;
        }

        public void SetEagleName(int numberOfEaglesEyes)
        {
            this.numberOfEaglesEyes = numberOfEaglesEyes;
        }



        public void Fly()
        {
            Console.WriteLine("Yes I am an eagle, the king of birds");
        }


    }
}
