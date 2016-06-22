using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.abstractNameSapec
{
   public  abstract class animal
   {
       protected string _myName;
       protected int _myAge;
       protected bool _hasStartedClass;
       protected double _mySpeed;
       protected long _myPhoneNumber;


       protected animal(string myName, int myAge, bool hasStartedClass, double mySpeed, long myPhoneNumber)
       {
            this._myName = _myName;
            this._myAge = _myAge;
            this._hasStartedClass = _hasStartedClass;
            this._mySpeed = _mySpeed;
            this._myPhoneNumber = _myPhoneNumber;

        }

        public void Run()
       {
            Console.WriteLine("the animalcan run at {0}", _mySpeed);
          

       } 
        public abstract string ShowAnimalName();



   }
}
