using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndOFcourseProject.areaOFEmphasis;

namespace EndOFcourseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityLibrary ulLibrary= new UniversityLibrary();
            string bookName = ulLibrary.GetBookTopic();
            ulLibrary.setBookTopic("coding");
        }
    }
}
