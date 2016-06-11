using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.inheritance
{
    public class CurrentStudent : ProspectiveStudent
    {

        private long schoolId;
        private double tuitionFee;
        private string examNumber;


        public CurrentStudent(string schoolName, int studentID) : base(schoolName, studentID)
        {
        }

        public void WriteExam()
        {
            base.MakeEnquiryAboutUni();
            Console.WriteLine("I am writing examination");
        }


        public void ShowProspectiveStudentID()
        {
            Console.WriteLine(studentID);
        }

       
    }
}
