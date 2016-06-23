using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewProject.FirstReview
{
    public class Loops
    {

        /*public bool FindProduct(string productName)
        {
            IList<string> itemNames = new List<string>()
            {"Red wine","Soap","Kitchen Knife","Diapers","Green Pea","Burger","Doughnut"};
            foreach (var itemName in itemNames)
            {
                if (productName.Contains(itemName))
                {
                    Console.WriteLine(productName);
                }
            }
            return false;

        }*/

        public bool ComputerMakes(string make)
        {
            IList<string> computerType1 = new List<string>()
            {"windows","imac","hp","dell"};

            foreach (var computerType in computerType1)
            {
                if (make.Contains(computerType))
                {
                    Console.WriteLine(make);
                }
            }return false;
        }

}
}
