using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.arrays
{
    public class ArrayConcept
    {


        public object[] GetData()
        {
            object[] myData = new object[4];
            myData[0] = "Edwin Nwofor";
            myData[1] = 15;
            myData[2] = true;
            myData[4] = 25000.25;
            return myData;
        }


        public void GetEdwinData()
        {
            object[] edwinData = GetData();
            string name = (string)edwinData[0];
        }

        public void DecideDaysName()
        {
            string[] w = GetWeekNames();
        }

        public string[] GetWeekNames()
        {
            string[] week = new string[7];
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednsday";
            week[4] = "Thursday";
            week[5] = "Friday";
            week[6] = "Saturday";
            return week;
        }


        public void GeStudentWithForEachLoopConcept()
        {
            int[] studentAges = new int[6];
            studentAges[0] = 26;
            studentAges[1] = 32;
            studentAges[2] = 29;
            studentAges[3] = 56;
            studentAges[4] = 16;
            studentAges[5] = 38;

            foreach (var age  in studentAges)
            {
                if (age == 56)
                {
                    Console.WriteLine("The age of student is {0}", age);
                    break;
                }
            }
        }

        public void GetArrayIndividualNumbers()
        {
            int[] studentAges = new int[6];
            studentAges[0] = 26;
            studentAges[1] = 32;
            studentAges[2] = 29;
            studentAges[3] = 26;
            studentAges[4] = 26;
            studentAges[5] = 38;

            
            for (int i = 0; i < studentAges.Length; i++)
            {
                if (studentAges[i] == 29)
                {
                    Console.WriteLine("The age of each student is {0}", studentAges[i]);
                }
                
            }
            
        }



        public void LearnArrays()
        {
            // Declaring arrays
            //1
            int[] studentAges = new int[6];
            studentAges[0] = 26;
            studentAges[1] = 32;
            studentAges[2] = 29;
            studentAges[3] = 21;
            studentAges[4] = 45;
            studentAges[5] = 38;
            //2
            int[] childrenAges = new int[4] {3, 1, 80, 25};
            //3
            string[] childrenNames = new string[] {"AAA0001", "AAA0002", "AAA0003", "AAA0004"};
            //4
            string[] foods = {"Egbusi Soup", "Akpu", "Pounded Yam", "Fufu"};

        }
    }
}
