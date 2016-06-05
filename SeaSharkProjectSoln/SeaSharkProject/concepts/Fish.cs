using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaSharkProject.concepts
{
    public class Fish
    {
        private bool ans;


        public void Compute(string a)
        {
            int b = int.Parse(a);
            double c = double.Parse(a);
            long d = long.Parse(a);
            float e = float.Parse(a);
            bool s = bool.Parse(a);

            bool h = bool.TryParse(a, out ans);
        }

        public void ComputeAmount(string a, int result)
        {
            if (int.TryParse(a, out result) == true)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The conversion was not successful");
            }
        }



    }
}
