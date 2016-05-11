using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeaSharkProject.calf;
using SeaSharkProject.facebook;

namespace SeaSharkProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Elephant elephant = new Elephant("Edwin", "Loveth", "Anney", "Hiltler");

            string name = elephant.GetFirstStudentName();
            Console.WriteLine(name);

            Elephant pigon = new Elephant("Avan Rolf", "Jeff Morgan", "Roy Fielding", "David Cameron");
            string name1 = pigon.GetFirstStudentName();
            Console.WriteLine(name1);
        }
    }
}
