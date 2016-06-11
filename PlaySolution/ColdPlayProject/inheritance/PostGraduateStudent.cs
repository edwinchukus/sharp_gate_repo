using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.inheritance
{
    public class PostGraduateStudent : CurrentStudent
    {


        public PostGraduateStudent(string schoolName, int studentID) : base(schoolName, studentID)
        {
        }


        public void ShowProspectiveStudentID()
        {
            Console.WriteLine(studentID);
        }

        
    }
}
