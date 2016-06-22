using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.abstractNameSapec.homeAnimal
{
  public  class dog: animal
    {
      public dog(string myName, int myAge, bool hasStartedClass, double mySpeed, long myPhoneNumber) : base(myName, myAge, hasStartedClass, mySpeed, myPhoneNumber)
      {
      }

      public override string ShowAnimalName()
      {
          string name = "The animal name is"+_myName;
          return name;

      }
    }
}
