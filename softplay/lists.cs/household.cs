using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lists.cs
{
   public class household
   {
       private List _list;
       public household()
       {
          List<string>items=new List<string>();
          items.Add("pot");
            items.Add("spoon");
            items.Add("knife");
            items.Insert(1,"Mango");
        }
    }
}
