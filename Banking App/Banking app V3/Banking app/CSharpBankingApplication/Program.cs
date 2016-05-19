using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBankingApplication.BankLogin;
using CSharpBankingApplication.Register;


namespace CSharpBankingApplication
{
    class Program
    {
        // Code to take PIN
        public static void Main(string[] args)
        {
            BankAppLogin appLogin = new BankAppLogin();
            //Greet And Welcome Customer
            appLogin.GreetAndWelcomeCustomer();
            Decision decision = new Decision();
            decision.MakeDecision();
            Console.ReadKey();
            //Registration for new customer
            Registration newUser = new Registration();
            newUser.Rgister();
            Registration userDetails = new Registration();
            userDetails.EnterDetails();
        }
    }
}
