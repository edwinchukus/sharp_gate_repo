using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace SeaSharkProject.basics
{

    /// <summary>
    /// This class is for codes that my students are using ...
    /// </summary>
    public class Friday
    {
        private int _has;


        /// <summary>
        /// This one take no argument
        /// </summary>
        public Friday()
        {
            this._has = 1250;
        }
        
        
        /// <summary>
        /// This constructor takes one argument in the form of a banking PIN
        /// </summary>
        public Friday(int myPin)
        {
            _has = myPin;
        }


        /// <summary>
        /// Message
        /// </summary>
        /// <param name="newStudentName"></param>
        /// <returns></returns>
        public string GreetNewStudent(string newStudentName)
        {
            // The first line below is taking student name and printing it out on the console
            Console.WriteLine("The new Student name is "+ newStudentName);
            // The code bwlow is appending syudent name to the greeing
            string greeting = "Welcome, "+ newStudentName+" to TrainCentre Plc and it is a pleasure to havee you";
           
            Console.WriteLine("The new Student name is " + newStudentName);
            return greeting;
        }



        /// <summary>
        /// This method when called, returns your account details.
        /// </summary>
        public void CheckAccountBalance(long accountNumber, string accountSortCode)
        {
            // In this case, if any condition is correct, then I will do the job below
            if (!((accountNumber == 20856362) || (accountSortCode == "20-28-01")))
            {
                Console.WriteLine("The balance is $5000"); 
            }
            // In this case, if both conditions are correct, then I will do the job below
            if ((accountNumber == 208563) && (accountSortCode == "20-28-01"))
            {
                Console.WriteLine("The balance is $5000");
            }
        }

    
        public void DosStuff(long accountNumber, string accountSortCode)
        {
            // In this case, if any condition is correct, then I will do the job below
            if ((accountNumber != 208563) | (accountSortCode == "20-28-01") | (accountNumber == 208563))
            {
                Console.WriteLine("The balance is $5000");
            }
            // In this case, if both conditions are correct, then I will do the job below
            if ((accountNumber == 208563) & (accountSortCode == "20-28-01") & (accountNumber == 208563))
            {
                Console.WriteLine("The balance is $5000");
            }
        }




        /// <summary>
        /// This method grab the 
        /// </summary>
        public void GetAndre()
        {
            Console.WriteLine("Andre Iniesta");
            Console.WriteLine(_has);
        }


        // SOLID Principle 


        /// <summary>
        /// This 
        /// </summary>
        /// <param name="name"></param>
        public void GetAndre(string name)
        {
            bool ans = name.ToLower().Equals("edwin");

            Console.WriteLine("There is only a firstname "+ name);
        }
        public void GetAndre(string firstname, string lastname)
        {
            Console.WriteLine("There is firstname " + firstname + " and last name "+lastname);
        }


        /// <summary>
        /// This method takes no argument but returns today's date
        /// </summary>
        public void GeDate()
        {

            Console.WriteLine("Tested and worked properly");
        }
    }
}
