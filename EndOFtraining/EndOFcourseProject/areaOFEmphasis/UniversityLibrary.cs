using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOFcourseProject.areaOFEmphasis
{
     public class UniversityLibrary

     {
         public string bookTopic = "coding";

         protected void IssueBook()
         {

             Console.WriteLine("i am a post{0} graduate student and love coding{1} with my colleague");
             Console.WriteLine("book in the {0}library and i have been given permission{ to borrow this book{} from libray today");
         }

         public void ShowProgramme()
         {
             Console.WriteLine(bookTopic);
         }
    }
}
