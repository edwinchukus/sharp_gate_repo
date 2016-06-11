using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace student
{
   public class person
    {
       public int Add(int x, int y)
       {
           int c = x + y;
           return c;
       }
    }
}
