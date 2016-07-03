using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Revision3
{
    public class loops
    {
        public bool FindProduct(string ProductName)
        {
            IList<string> itemNames = new List<string>()
            {
                "spring water",
                "bread",
                "nokia phone ",
                "honey",
                "coke",
                "red wine"
            };
            bool result = false;
            foreach (var itemName in itemNames)
            {
                if (ProductName.Contains(itemName))
                {
                    result = true;
                    break;
                }
                return result;
            }


        }
    }
}

