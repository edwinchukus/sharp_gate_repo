using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision3.first_Revision
{
     public class switchStatement
    {
         public void DecideOnBrowserName( string BrowserName)
         {
             switch (BrowserName)
             {

                case "firefox":
                case "Ghost":
                    Console.WriteLine(" case running on the{0}  browser", BrowserName);
                    break;
                case "chrome":
                     Console.WriteLine("case running on the{0}browser",BrowserName);
                    break;
                case "safari":
                     Console.WriteLine(" case running on the{0}browser",BrowserName);
                    break;
                case "internet explorer":
                     Console.WriteLine("case runnin on the {0}browser", BrowserName);
                    break;
                default:
                     Console.WriteLine("there is no broswer as {} BrowserName");
                    break;

             }
         }
    }
}
