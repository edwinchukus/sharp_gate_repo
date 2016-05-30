using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ColdPlayProject.one_dim_arrays
{
    public class Library
    {
        /* 
         * Write a code that will be able to store new books in the library catlog
         * - User should be able to view all books from the catlog
         * - User should able to search for a book in the catlog
         * - User should be capable of finding price of each book
         */
         private readonly string[] _bookNames = new string[10];
         private readonly double[] _bookPrices = new double[10];

        public Library()
        {
            // Initialising all the books
            _bookNames[0] = "Arrow of God";
            _bookNames[1] = "Modern Biology";
            _bookNames[2] = "Things Fall Apart";
            _bookNames[3] = "The Gods are not to blame";
            _bookNames[4] = "Ababio Chemistry";
            //Initialising the prices of the books
            _bookPrices[0] = 1200.52;
            _bookPrices[1] = 1000d;
            _bookPrices[2] = 652.06;
            _bookPrices[3] = 524d;
            _bookPrices[4] = 320.00;
        }


        public void AddBookToCartlog(string newBookName)
        {
            foreach (var aBookName in _bookNames)
            {
                int index = Array.IndexOf(_bookNames, aBookName);
                if (_bookNames[index] == null)
                {
                    _bookNames[index] = newBookName;
                    break;
                }
            }
            Console.WriteLine("Successfully added {0} to the Database!", newBookName);
        }

        public void ViewAllBooks()
        {
            for (int i = 0; i < _bookNames.Length; i++)
            {
                int index = Array.IndexOf(_bookNames, _bookNames[i]);
                if (_bookNames[index] != null )
                {
                    Console.WriteLine("Book name is {0}", _bookNames[i]);
                }
            }
        }

        public void FindBookAndPrice(string newBookName)
        {
            foreach (var aBookName in _bookNames)
            {
                if (string.IsNullOrEmpty(aBookName))
                {
                    continue;
                }else if (aBookName.Contains(newBookName))
                {
                    int index = Array.IndexOf(_bookNames, aBookName);
                    Array.Sort(_bookNames);
                    Array.Sort(_bookPrices);
                    Array.Reverse(_bookNames);
                    Console.WriteLine("The full book name is {0} with price {1}", aBookName, _bookPrices[index]);
                    break;
                }
            }
        }


    }
}
