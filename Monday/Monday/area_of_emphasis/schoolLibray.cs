using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.area_of_emphasis
{
    public class schoolLibray
    {
        protected string bookTopic = "c#";
        public string typeOfProficiency = "good programmer"; 


        public void IssueBook()
        {
            string bookname= "Old man and the medal";
            int numberOFBookINSchool = 254;
            Console.WriteLine("Am a learner in c# class so i need books{0} with my {1}withing school {3}");
            Console.WriteLine(" kindly issue me this book{0} please for a week");
        }


    }
}
