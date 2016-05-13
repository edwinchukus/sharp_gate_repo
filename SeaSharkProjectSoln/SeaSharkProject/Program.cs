using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeaSharkProject.basics;
using SeaSharkProject.calf;
using SeaSharkProject.facebook;

namespace SeaSharkProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //NCrunch 
            Friday friday = new Friday(5321);
            
            friday.GetNewStudentDate("I am a boy, from Nigeria, and I am a grown up man now, I can make a decision.");


            friday.GetAndre();
        }


        
    }
}
