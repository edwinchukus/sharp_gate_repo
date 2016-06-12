using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping
{
   public class ShoppingMail
   {
       private string[,] _usersDetails;
       public ShoppingMail()
       {
           
           _usersDetails[0, 0] = "122shey@hotmail.com";
           _usersDetails[0, 1] = "12345";
            _usersDetails[0, 2] = "122casi@hotmail.com";
            _usersDetails[1, 0] = "12345";
            _usersDetails[1, 1] = "122deji@hotmail.com";
            _usersDetails[1, 2] = "12345";
            int[,] itemQuantity = new int[2, 2];

            public void showUsersDetails()
           {
               foreach (var usersDetails in _usersDetails)
               {
                   Console.WriteLine(usersDetails);

            }
            

    }

       }
    }
}
