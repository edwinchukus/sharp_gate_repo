using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaLionProject.fish
{
    public class SalmonFish
    {

        protected string myFirstName = "Chukwubuikeh";
        private string myLastName = "Nwofor";
        private string myNickName = "ED";



        private void ShowMyFirstName()
        {
            Console.WriteLine("My First Name is {0} and my Last Name is {1} with Nick name as {2}", myFirstName, myLastName, myNickName);
            Console.WriteLine("My real age is {0}", CalculateMyAge());
        }


        protected int CalculateMyAge()
        {
            int ageConstant = 55;
            int myAge = ageConstant - 23;
            return myAge;
        }
    }
}
