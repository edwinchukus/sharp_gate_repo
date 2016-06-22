using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewProject.FirstReview
{
    public class SwitchStatement
    {
 
        public void DecideOnBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                case "Ghost":
                    Console.WriteLine("Test running on the {0} browser", browserName); 
                    break;
                case "Chrome":
                    Console.WriteLine("Test running on the {0} browser ", browserName);
                    break;
                case "Safari":
                    Console.WriteLine("Test running on the {0} browser ", browserName);
                    break;
                case "Internet Explorer":
                    Console.WriteLine("Test running on the {0} browser ", browserName);
                    break;
                default:
                    Console.WriteLine("There is no such browser as {0} ", browserName);
                    break;
            }
        }

    }
}
