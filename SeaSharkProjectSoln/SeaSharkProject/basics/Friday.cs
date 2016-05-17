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
        
        
        /// <summary>
        /// This one take no argument
        /// </summary>
        public Friday()
        {
            
        }
        
        
        /// <summary>
        /// This constructor takes one argument in the form of a banking PIN
        /// </summary>
        public Friday(int myPin)
        {
            
        }


        /// <summary>
        /// This is a method that takes in any new student name and greet the student!
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


        public void GetNewStudentDate(string date)
        {
            // Today's date as an example is 13-05-2016 
            string [] splittedDate = date.Split(',');
            string firtWord = splittedDate[0];
            Console.WriteLine(firtWord);
            Console.WriteLine(splittedDate[1]);
            Console.WriteLine(splittedDate[2]);
            Console.WriteLine(splittedDate[3]);
        }


        public void GetAndre()
        {
            Console.WriteLine("There is no name");
        }


        // SOLID Principle 


        /// <summary>
        /// 
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

    }
}
