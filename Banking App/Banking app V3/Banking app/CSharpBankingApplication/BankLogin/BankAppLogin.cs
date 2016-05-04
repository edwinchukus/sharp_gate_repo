using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankingApplication.BankLogin
{
    public class BankAppLogin
    {
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
                int aPin = 9999;
                int Pin = int.Parse(Console.ReadLine());              
               if (aPin == Pin)
               {
                 Console.WriteLine("account balance is £90b");   
               }
               else
               {
                   Console.WriteLine("the cctv is now saving your face info");
               }
           }
            else if (userInput.Equals("casi"))
           {
                Console.WriteLine("Welcome casi . please enter your Pin");
               
               int cPIN = int.Parse(Console.ReadLine());
               int casiPIN = 1234;
               if (cPIN == casiPIN)
               {
                   Console.WriteLine("welcome to your account");
               }
               else
               {
                   Console.WriteLine("invalid PIN entered trying again");
                }
               
           }
           else if (userInput.Equals("sam"))
           {
                Console.WriteLine("Sam welcome to your account");
                Console.WriteLine("Please enter your pin");
                int sPin = 1981;
                int Pin =int.Parse(Console.ReadLine());
                if (sPin == Pin)
                {
                    Console.WriteLine("thank you, account bal is £89b");
                }
                else
                {
                    Console.WriteLine("wrong pin, goodbye");
                }
          }
        }

        public void register()
        {
            
        }

    }
}
