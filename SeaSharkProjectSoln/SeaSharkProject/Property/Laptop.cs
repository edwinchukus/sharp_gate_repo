using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaSharkProject.Property
{
    public class Laptop
    {
        private int _age;
        private string _colour;
        


        public int Age
        {
            get
            {
                if (_age >= 1)
                {
                   _age = 12 + _age;
                }
                return _age;
            }
            private set { _age = value; }
        }

        public int I { get; private set; }

        public void ComputeAge()
        {
            Age = 25;
        }

        

        public string GetLaptopColour()
        {
            return _colour;
        }


        private void SetLaptopColour(string colour)
        {
            this._colour = colour;
        }


        public string LaptopName { get; set; }
        public double Amount { get; set; }
        public int NumberOfBattery { get; set; }
        public bool IsCharged { get; set; }




    }
}
