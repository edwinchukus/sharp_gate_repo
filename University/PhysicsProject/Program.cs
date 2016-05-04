using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace PhysicsProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your Reference Temperature");
            string roomTemp = Console.ReadLine();
            LoopThroughMethod(roomTemp);
        }

        private static void LoopThroughMethod(string roomTemp)
        {
            int roomTemperature = int.Parse(roomTemp);
            Console.WriteLine();
            for (int i = 0; i < roomTemperature; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("This AC is now switched off bc temp is " + i);
                    continue;
                }
                WriteMessage();
            }
        }

        private static void WriteMessage()
        {
            Console.WriteLine("Hello World");
        }
    }



}
