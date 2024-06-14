using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp_Product
{
    public class Product
    {
        private int _productID;
        private decimal _price;
        private int _stock;
        public int ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                if (value < 1 || value > 10000)
                    Console.WriteLine("ProductID must be between 1 and 10000.");
                _productID = value;
            }
        }
        public string? ProductName { get; set; }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 1 || value > 5000)
                    Console.WriteLine("Price must be between $1 and $5000.");
                _price = value;
            }
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 1 || value > 100000)
                    Console.WriteLine("Stock must be between 1 and 100000.");
                _stock = value;
            }
        }

        //Product Constructor
        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }


        // Methods to Increase the stock and decrease the stock
        public void IncreaseStock(int amt)
        {
            if (amt < 0)
            {
                throw new ArgumentException("Amount to increase cannot be negative (should =>0).");
            }
            Stock += amt;
        }


        // Method to decrease stock
        public void DecreaseStock(int num)
        {
            if (num < 0)
                Console.WriteLine("Amount cannot be negative(should >= 0)");
            if (num > Stock)
                Console.WriteLine("Amount required greater than stock");
            Stock -= num;
        }
    }
}
