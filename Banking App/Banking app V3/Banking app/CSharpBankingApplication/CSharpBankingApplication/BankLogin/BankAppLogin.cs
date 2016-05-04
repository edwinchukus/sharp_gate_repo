using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankingApplication.BankLogin
{
    public class BankAppLogin
    {
        //i will introduce  a constant at class level
        private const string userName = "casi";
        private const double casiPIN = 1234;
       public void AppLogin()
        {
           //welcome the user to the app & prompt them to enter username
           Console.WriteLine("Welcome to the Banking App");
           Console.WriteLine("Please enter your full name");

           //Capture input from the console
           string userInput = Console.ReadLine();

           if (userInput.Equals("Andre Dada"))
           {
               Console.WriteLine("Welcome Andre Dada. Please enter your PIN");
           }
            else if (userName.Equals("casi"))
           {
                Console.WriteLine("Welcome casi . please enter your Pin");
                var PIN = Console.ReadLine();
               double cPIN = double.Parse(PIN);

               if (cPIN == casiPIN)
               {
                   Console.WriteLine("welcome to your account");
               }
               else
               {
                   Console.WriteLine("invalid PIN entered trying again");
               }
               return;
           }
           
        }

    }
}
