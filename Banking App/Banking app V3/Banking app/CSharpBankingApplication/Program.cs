using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBankingApplication.BankLogin;


namespace CSharpBankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAppLogin appLogin = new BankAppLogin();
            appLogin.AppLogin();
            Console.ReadKey();
       
            BankAppLogin registerNewUser = new BankAppLogin();
            registerNewUser.register();
        }
    }
}
