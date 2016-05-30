using System;

namespace ColdPlayProject.arrays
{
    public class ArrayConcept
    {


        private object[,] GetData()
        {
            object[,] myData = new object[4,2];
            myData[0, 0] = "Edwin Nwofor";
            myData[0, 1] = 15;
            myData[1, 0] = true;
            myData[1, 1] = 25000.25;
            return myData;
        }


        public void GetEdwinData()
        {
            object[,] edwinData = GetData();
            foreach (var data in edwinData)
            {
                Console.WriteLine(data);   
            }
        }

        public void DecideDaysName()
        {
            string[] ws = GetWeekNames();
            foreach (var w in ws)
            {
                if (w.Contains("Sunday"))
                {
                    Console.WriteLine("Doing the programming all by myself");
                }
            }
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
            studentAges[3] = 34;
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
            string[] childrenNames = new string[] {"A000502", "A000509", "A000503", "AAA000407"};
            //4
            string[] foods = {"Egbusi Soup", "Akpu", "Pounded Yam", "Fufu"};

        }
    }
}
