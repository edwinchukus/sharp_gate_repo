using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace SeaSharkProject.facebook
{
    public class Elephant
    {

        private string _firstStudentName;
        private string _secondStudentName;
        private string _thirdStudentName;
        private string _fourthStudentName;

        public Elephant(string firststudentName, string secondStudentName, string thirdStudentName, string fourthStudentName)
        {
            _firstStudentName = firststudentName;
            _secondStudentName = secondStudentName;
            _thirdStudentName = thirdStudentName;
            _fourthStudentName = fourthStudentName;
        }

        public string GetFirstStudentName()
        {
            return _firstStudentName;
        }

    }
}
