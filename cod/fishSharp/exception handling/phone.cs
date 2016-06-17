using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishSharp.exception_handling
{
    public class phone
    {

        public void DivideNumber(int a, int b)
        {

            try
            {
                double an = a / b;
                Console.WriteLine(an);
            }
            catch (Exception exception)
            {
                
               
            }
            

        }

        internal double DivideNumber()
        {
            throw new NotImplementedException();
        }
    }
}
