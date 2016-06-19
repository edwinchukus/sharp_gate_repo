using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace inhritance.inheritance
{
  public  class Mercidi
    {
        protected int _truckAge;
        protected string _truckName;
        protected bool _isTrckNew;
      protected double _sellingPrices;

      public string _truckname { get { return _truckName; } set { _truckName = value; } }
      public double _sellingPrice { get { return _sellingPrices; } set { _sellingPrices = value; } }
    }
}
