using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdPlayProject.arrays
{
    public class Products
    {
        private readonly string[] _products = new string[20];
        private readonly double[] _prices = new double[20];
        private int _productIndex;
        public Products()
        {
            // Initial Products in the DB
            _products[0] = "iPhone 5s";
            _products[1] = "Samsung Galaxy Note II";
            _products[2] = "Nokia 3310";
            _products[3] = "iPhone 6 plus";
            _products[4] = "HTC Mobile 22";
            _products[5] = "Iphone 6";
            // Initial Prices
            _prices[0] = 52.52;
            _prices[1] = 122.22;
            _prices[2] = 582.02;
            _prices[3] = 142.25;
            _prices[4] = 233.59;
            _prices[5] = 802.14;

        }

        public void GetItemPrice(string productName)
        {
            foreach (var product in _products)
            {
                if (product.Contains(productName))
                {
                    _productIndex = Array.IndexOf(_products, product);
                    Console.WriteLine("The product name is {0} at index {1}", product, _productIndex);
                    break;
                }
            }
            Console.WriteLine("The price is $ {0}",_prices[_productIndex]);
        }

        public void GetAllProducts()
        {
            for (int i = 0; i < _products.Length; i++)
            {
                _productIndex = Array.IndexOf(_products, _products[i]);
                Console.WriteLine("Product name is {0} which was stored at location {1}", _products[i], _productIndex);
            }
        }

        public string AddProduct(string newProductName)
        {
            foreach (var product in _products)
            {
                if (string.IsNullOrEmpty(product))
                {
                    _productIndex = Array.IndexOf(_products, product);
                    _products[_productIndex] = newProductName;
                    break;
                }
            }
            return "Successfully added to the Database";
        }
    }
    

        
    
}
