using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBankingApplication.BankLogin;

namespace CSharpBankingApplication.Register
{
     public class Registration
    {

        private string FirstName;
        private string LastName;
        
        public void Rgister()
        {
            BankAppLogin greetings = new BankAppLogin();
            greetings.GreetAndWelcomeCustomer();
        }

        public void EnterDetails()
        {
            // registration form
            Console.WriteLine("Please enter your first and last name and press enter");
             if ((FirstName.Equals(Console.ReadLine())) && (LastName.Equals(Console.ReadLine())))
             {
                 Console.WriteLine(" please read terms and conditions");
             }return;

        }
    }
}
