using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.abstractConcept.domesticAnimal
{
    public class Dog : Animal
    {
        public Dog(string myName, int myAge, bool hasStartedClass, double mySpeed, long myPhoneNumber) : base(myName, myAge, hasStartedClass, mySpeed, myPhoneNumber)
        {
        }

        public override string ShowAnimalName()
        {
            string name =  "The animal name is "+ _myName;
            return name;
        }

        public override void CalculateSpeed()
        {
            double speed = _mySpeed;
            Console.WriteLine(speed);
            Console.WriteLine("Speed from the dog class is {0}", speed);
        }
    }
}
