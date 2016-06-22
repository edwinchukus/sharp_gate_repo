using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaSharkProject.Property
{
    public class BankAccount
    {

        private double _initialAmount = 1000;
        private string pin = "123A";
        private string _yourPin;

        


        public BankAccount(string yourPin)
        {
            this._yourPin = yourPin;
        }


        private double GetAmount()
        {
            return _initialAmount;
        }




        public double InitialAmount
        {
            get
            {
                if (pin.Equals(_yourPin))
                {
                    return _initialAmount;
                }
                else
                {
                    throw new Exception("You are a bloody thief");
                }
            }

            private set
            {
                if (pin.Equals(_yourPin))
                {
                    _initialAmount = value;
                }
                else
                {
                    throw new AccessViolationException("The account you are acessing is not yours");
                }
            }

        }


        public void ChangeAmount()
        {
            InitialAmount = 5.0;
            Console.WriteLine(_initialAmount);
        }
    }
}
