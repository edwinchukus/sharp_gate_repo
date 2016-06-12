using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.inheritance
{
    public class ProspectiveStudent
    {

        protected string schoolName;
        protected int studentID;
        protected string programName;
        protected string emailAddress;
        private double tuitionFee;
        protected long phoneNumber;

        public ProspectiveStudent(string schoolName, int studentID)
        {
            this.schoolName = schoolName;
            this.studentID = studentID;
        }


        protected void MakeEnquiryAboutUni()
        {
            Console.WriteLine("I want to know about this programing");
        }

        public void CourseRegistration()
        {
            Console.WriteLine("I am registering for a course");
        }

        public void CallAdmissionOffice()
        {
            Console.WriteLine("I am calling the school admission to pay tuition fee");
        }

        public void MakeHostleAccommodationEnquiry()
        {
            Console.WriteLine("I am making hostle enquiry from my school");
        }
    }
}
