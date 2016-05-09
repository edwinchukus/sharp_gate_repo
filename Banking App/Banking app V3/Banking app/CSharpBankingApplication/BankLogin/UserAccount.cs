using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankingApplication.BankLogin
{
    public class UserAccount
    {
        private string _username;


        public UserAccount(string username)
        {
            this._username = username;
        }


        public UserAccount()
        {
            
        }
        public void AndreAccount()
        {
            Console.WriteLine("Welcome Andre Dada. Please enter your PIN");
            const int aPin = 9999;
            long pin = long.Parse(Console.ReadLine());
            if (pin  == aPin)
            {
                Console.WriteLine("account balance is £90.00");
            }
            else
            {
                Console.WriteLine("the cctv is now saving your face info");
            }
        }


        public void CasiAccount()
        {
                Console.WriteLine("Welcome Casi. Please enter your PIN");
                const int aPin = 1234;
                long pin = long.Parse(Console.ReadLine());
                if (pin == aPin)
                {
                    Console.WriteLine("account balance is £90b");
                }
                else
                {
                    Console.WriteLine("the cctv is now saving your face info");
                }
        }



        public void DejiAccount()
        {
                Console.WriteLine("Welcome Deji. Please enter your PIN");
                const int pin = 1235;
                long aPin = long.Parse(Console.ReadLine());
                if (pin == aPin)
                {
                    Console.WriteLine("account balance is £90b");
                }
                else
                {
                    Console.WriteLine("the cctv is now saving your face info");
                }
        }


        public void LayoAccount()
        {
                Console.WriteLine("Welcome Layo. Please enter your PIN");
                const int pin = 1236;
                long aPin = long.Parse(Console.ReadLine());
                if (pin == aPin)
                {
                    Console.WriteLine("account balance is £90b");
                }
                else
                {
                    Console.WriteLine("the cctv is now saving your face info");
                }
          
        }

        public void SamAccount()
        {
                Console.WriteLine("Welcome Sam. Please enter your PIN");
                long pin = long.Parse(Console.ReadLine());
                if (pin == 1237)
                {
                    Console.WriteLine("account balance is £90b");
                }
                else
                {
                    Console.WriteLine("the cctv is now saving your face info");
                }
            
        }


        public void BukkyAccount()
        {
           
                Console.WriteLine("Welcome Bukky. Please enter your PIN");
                const int aPin = 1238;
                long pin = long.Parse(Console.ReadLine());
                if (pin == aPin)
                {
                    Console.WriteLine("account balance is £90b");
                }
                else
                {
                    Console.WriteLine("the cctv is now saving your face info");
                }
           
        }

        public void JoyAccount()
        {
            Console.WriteLine("Welcome Joy. Please enter your PIN");
            const int aPin = 1239;
            long pin = long.Parse(Console.ReadLine());
            if (pin == aPin)
            {
                Console.WriteLine("account balance is £90b");
            }
            else
            {
                Console.WriteLine("the cctv is now saving your face info");
            }
        }

    }
}
