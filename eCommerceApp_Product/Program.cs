using eCommerceApp_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp_Product
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product(1, "banana", 1, 500);
            Console.WriteLine("Enter the count:");
            var count = Convert.ToInt32(Console.ReadLine());
            product.DecreaseStock(count);
            product.IncreaseStock(count);

        }
    }
}
