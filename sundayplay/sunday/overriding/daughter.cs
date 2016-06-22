using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunday.overriding
{
     public class daughter:father
    {
         public override void MakingACall()
         {
             Console.WriteLine("i made a call with daddy's phone");
         }

         public override void showMeMyPhone()
         {
             base.showMeMyPhone();
         }

         oid showmeMyPhone()
         {
             
         }
    }
}
