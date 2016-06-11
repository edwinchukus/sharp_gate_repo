using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    public class monkey
    {
         int NumberOfEyes;
         bool MaleORFemale;
         double Feather;
        public void Walk()
        {
            Console.WriteLine("i can walk");   
        }

        public void Jump()
        {
            Console.WriteLine("monkey can jump");    
        }

        public void Bite()
        {
            Console.WriteLine("monkey bite me");    
        }

        public void Climb()
        {
            Console.WriteLine("monkey will climb");
        }
    }
}
