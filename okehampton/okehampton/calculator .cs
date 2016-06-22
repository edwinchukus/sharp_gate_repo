using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okehampton
{
   public class Calculator
   {
       private int _x = 4;
       private int _y = 3;

       public Calculator()
       {
           this._x = _x;
           this._y = _y;

       }
       public int Add()
       {
           int j = _x + _y;
           return j;
       }

       public int Divide()
       {
           int j = -_x/_y;
           return j;
       } 
    }
}
