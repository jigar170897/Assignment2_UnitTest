using eCommerceApp_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp_ProductTest
{
    public class ProductTest
    {
        public class ProductTest_
        {
            private Product _product { get; set; }
            [SetUp]
            public void Setup()
            {
                _product = new Product(101, "Spring water", 3, 1000);
            }

            // product ID validate
            [Test]
            public void Test_ProductID_MinVal()
            {
                var product = new Product(1, "Spring water", 2.5m, 1000);
                Assert.That(product.ProductID, Is.EqualTo(1));
            }

            [Test]
            public void Test_ProductID_MaxVal()
            {
                var product = new Product(10000, "Spring water", 2.5m, 1000);
                Assert.That(product.ProductID, Is.EqualTo(10000));
            }

            [Test]
            public void Test_ProductID_OutOfRange()
            {
                var product = new Product(1005, "Spring water", 2.5m, 1000);
                Assert.That(product.Stock, Is.EqualTo(1000));
            }

            //negative value
            [Test]
            public void IncreaseStock_IncreaseByNegative_ThrowsException()
            {
                var product = new Product(1, "Test Product Name", 11, 5);
                Assert.Throws<ArgumentException>(() => product.IncreaseStock(-1));
            }

            [Test]
            public void Test_ProductName_Empty()
            {
                var product = new Product(1, "", 2.5m, 1000);
                Assert.That(product.ProductName, Is.EqualTo(""));
            }


            // Test_ Price Attribute
            [Test]
            public void Test_Price_MinVal()
            {
                var product = new Product(3, "Spring water", 1.00m, 1000);
                Assert.That(product.Price, Is.EqualTo(1.00m));
            }

            [Test]
            public void Test_Price_MaxVal()
            {
                var product = new Product(1, "Spring water", 5000.00m, 1000);
                Assert.That(product.Price, Is.EqualTo(5000.00m));
            }

            [Test]
            public void Test_Price_OutOfRange()
            {
                var product = new Product(1, "Spring water", 5000.00m, 6000);
                Assert.That(product.Stock, Is.EqualTo(6000));
            }

            // Test_ Stock Attribute
            [Test]
            public void Test_Stock_MinVal()
            {
                var product = new Product(1, "Spring water", 2.5m, 1);
                Assert.That(product.Stock, Is.EqualTo(1));
            }

            [Test]
            public void Test_Stock_MaxVal()
            {
                var product = new Product(1, "Spring water", 2.5m, 100000);
                Assert.That(product.Stock, Is.EqualTo(100000));
            }

            [Test]
            public void Test_Stock_OutOfRange()
            {
                var product = new Product(1, "Spring water", 2.5m, 100001);
                Assert.That(product.Stock, Is.EqualTo(100001));

            }



            // Test_ DecreaseStock 
            [Test]
            public void Test_DecreaseStock_Valid()
            {
                var product = new Product(1, "Spring water", 2.5m, 5);
                product.DecreaseStock(1);
                Assert.That(product.Stock, Is.EqualTo(4));
            }

            // test Stock attribute
            [Test]
            public void Test_DecreaseStock_ValidMinValue()
            {
                var product = new Product(1, "Test Product Name", 11, 1);
                Assert.That(product.Stock, Is.EqualTo(1));
            }


            [Test]
            public void Test_DecreaseStock_OverStock()
            {
                var product = new Product(1, "Spring water", 200000, 5);
                product.IncreaseStock(10);
                Assert.That(product.Stock, Is.EqualTo(15));
            }
            // Test_ IncreaseStock 

            [Test]
            public void Test_IncreaseStock_Valid()
            {
                var product = new Product(1, "Spring water", 2.5m, 5);
                product.IncreaseStock(5);
                Assert.That(product.Stock, Is.EqualTo(10));
            }

            [Test]
            public void IncreaseStock_IncreaseByZero()
            {
                var product = new Product(1, "Test Product Name", 11, 5);
                product.IncreaseStock(0);
                Assert.That(product.Stock, Is.EqualTo(5));
            }


            [Test]
            public void Test_IncreaseStock_ZeroNum()
            {
                var product = new Product(1, "Spring water", 2.5m, 5);
                product.IncreaseStock(0);
                Assert.That(product.Stock, Is.EqualTo(5));
            }
        }
    }
}
