using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankingApplication.BankLogin
{
    public class UserLogin
    {


        public string EnterUsername()
        {
            //Capture input from the console
            Console.WriteLine("Please enter your full name");
            string username = Console.ReadLine();
            return username;
        }
    }
}
