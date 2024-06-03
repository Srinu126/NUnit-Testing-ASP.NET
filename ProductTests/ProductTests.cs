namespace ProductTests;
using NUnit.Framework;

public class ProductTests
{
    [Test]
        public void ValidProductID()
        {
            int productID = 1000;
            Product product = new Product(productID, "Pixel 7", 1000, 100);
            Assert.That(product.ProductID, Is.InRange(6, 60000));
        }
    [Test]
        public void InvalidProductID_BelowMinimum()
        {
            int productId = 5;
            Product product = new Product(productId, "Pixel 8", 1500, 100);
            Assert.That(product.ProductID, Is.Not.InRange(6, 60000));
        }
    [Test]
            public void Valid_ProductID_SAMSUNG()
            { 
                Product product = new Product(4500, "SAMSUNG", 1000, 1500);
                int expected = 4500;
                int actual = product.ProductID;
                Assert.That(expected, Is.EqualTo(actual));
            }

    [Test]
        public void InvalidProductID_AboveMaximum()
        {
            int productId = 60001;
            Product product = new Product(productId, "Pixel 8Pro", 2000, 100);
            Assert.That(product.ProductID, Is.Not.InRange(6, 60000));
        }
    [Test]
            public void ValidProductName_SAMSUNG()
            {
                string productName="SAMSUNG";
                Product product = new Product(123, productName, 1000, 1500);
                string expected = productName;
                string actual = product.ProductName;
 
                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
    [Test]
        public void ValidPrice()
        {
            int price = 1000;
            Product product = new Product(134, "Pixel 7", price, 100);
            Assert.That(product.Price, Is.InRange(6, 6000));
        }
    [Test]
        public void InvalidPrice_BelowMinimum()
        {
            int price = 5;
            Product product = new Product(234, "Pixel 8", price, 100);
            Assert.That(product.Price, Is.Not.InRange(6, 6000));
        }

    [Test]
        public void InvalidPrice_AboveMaximum()
        {
            int price = 6008;
            Product product = new Product(474, "Pixel 8Pro", price, 100);
            Assert.That(product.Price, Is.Not.InRange(6, 6000));
        }
    [Test]
        public void ValidStock()
        {
            int stock = 1000;
            Product product = new Product(134, "Pixel 7", 1000, stock);
            Assert.That(product.Stock, Is.InRange(6, 600000));
        }
    [Test]
        public void InvalidStock_BelowMinimum()
        {
            int stock = 5;
            Product product = new Product(234, "Pixel 8", 2000, stock);
            Assert.That(product.Stock, Is.Not.InRange(6, 600000));
        }

    [Test]
        public void InvalidStock_AboveMaximum()
        {
            int stock = 600008;
            Product product = new Product(474, "Pixel 8Pro", 3000, stock);
            Assert.That(product.Stock, Is.Not.InRange(6, 600000));
        }
    [Test]
            public void ValidIncreaseStock()
            {
                int quantity = 150;
                Product product = new Product(135, "Pixel 7", 1000, 1000);
                int expectedStock = quantity+product.Stock;
                product.IncreaseStock(quantity);
                int actualStock = product.Stock;
                Assert.That(expectedStock, Is.EqualTo(actualStock));
            }
    [Test]
        public void InvalidIncreaseStock_NegativeQuantity()
        {
            Product product = new Product(12345, "Pixel 7", 1000, 100);
            int initialStock = product.Stock;
            int amount = -10;
            product.IncreaseStock(amount);
            Assert.That(product.Stock, Is.EqualTo(initialStock));
        }
    [Test]
        public void InvalidIncreaseStock_MaximumLimit()
        {
            Product product = new Product(12345, "Pixel 8Pro", 1500, 600000);
            int initialStock = product.Stock;
            int amountToIncrease = 1;
            product.IncreaseStock(amountToIncrease);
            Assert.That(product.Stock, Is.EqualTo(initialStock));
        }
    [Test]
        public void ValidDecreaseStock()
        {
            Product product = new Product(12345, "Samsung", 1000, 100);
            int initialStock = product.Stock;
            int amountToDecrease = 25;
            product.DecreaseStock(amountToDecrease);
            Assert.That(product.Stock, Is.EqualTo(initialStock - amountToDecrease));
        }

    [Test]
        public void InvalidDecreaseStock_NegativeAmount()
        {
            Product product = new Product(12345, "IPhone", 2500, 100);
            int initialStock = product.Stock;
            int invalidAmount = -10;
            product.DecreaseStock(invalidAmount);
            Assert.That(product.Stock, Is.EqualTo(initialStock));
        }

    [Test]
        public void InvalidDecreaseStock_ExceedingStock()
        {
            Product product = new Product(12345, "Samsung", 1000, 10);
            int amountToDecrease = 20;
            product.DecreaseStock(amountToDecrease);
            Assert.That(product.Stock, Is.EqualTo(6));
        }
    [Test]
            public void ValidProductName()
            {
                string productName="Pixel 6A";
                Product product = new Product(123, productName, 1000, 1500);
                string expected = productName;
                string actual = product.ProductName;
 
                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
}