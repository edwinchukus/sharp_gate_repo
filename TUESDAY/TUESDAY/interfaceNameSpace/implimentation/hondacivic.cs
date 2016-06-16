using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUESDAY.interfaceNameSpace.implimentation
{
    public class hondacivic:Icar
    {
        public void Move()
        {
            Console.WriteLine("here honda on the move");
            
        }

        public string Brake()
        {
            Console.WriteLine("i need car {}, Brake");

        }
        public double Speed()
        {
            Console.WriteLine(" am covering 80km");
        }

        public bool isTheCarMoving()
        {
            Console.WriteLine("yes the car is moving ");
        }
    }
}
