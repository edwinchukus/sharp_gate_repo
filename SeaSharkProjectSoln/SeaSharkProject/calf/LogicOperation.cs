using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaSharkProject.calf
{
    public class LogicOperation
    {
        private readonly double _x;
        private readonly double _y;


        public LogicOperation(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public double Add()
        {
            double answer = _x + _y;
            return answer;
        }

        public double Divide()
        {
            double answer = _x / _y;
            return answer;
        }

    }
}
