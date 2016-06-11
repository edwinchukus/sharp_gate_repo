using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.two_dim_arrays
{
    public class ShoppingMall
    {
        private object[,] _userDetails;

        public ShoppingMall()
        {
            _userDetails = new object[5,2];
            _userDetails[0, 0] = "22222@gmail.com";
            _userDetails[0, 1] = true;
            _userDetails[1, 0] = 15;
            _userDetails[1, 1] = 10000d;
            _userDetails[2, 0] = 15.26;
            _userDetails[2, 1] = 16f;
//            int[,] itemQuntity = new int[10,2];
        }



        public bool ValidateUserDetails(string details)
        {
            string email = (string)_userDetails[0,0];
            bool isHeRegistered = (bool)_userDetails[0, 1];
            if (email.Contains(details))
            {
                return true;
            }
            return false;
        }




    }
}
