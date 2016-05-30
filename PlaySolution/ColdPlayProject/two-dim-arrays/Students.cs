using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.two_dim_arrays
{
    public class Students
    {
        private int _okonsAge;

        public void GetStudent()
        {
           object[] okons = GetOkonsDetails();
            _okonsAge = (int)okons[1];
            var myAge = _okonsAge;
        }



        public object[] GetOkonsDetails()
        {
            object[] userDetails = new object[10];
            userDetails[0] = "Okon Johnson"; 
            userDetails[1] = 29;
            userDetails[2] = 25000.25;
            userDetails[3] = false;
            return userDetails;
        }

    }
}
