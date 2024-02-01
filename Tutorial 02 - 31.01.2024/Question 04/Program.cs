using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
        class Product
        {
            public string ProductName;
            public double Price;

            public Product(string productName, double price)
            {
                ProductName = productName;
                Price = price;
            }
        }

        static void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Product Name: {product.ProductName}");
            Console.WriteLine($"Price: ${product.Price}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Fiction Book", 12.99);
            Product product3 = new Product("Cookie", 2.99);

            DisplayProductDetails(product1);
            DisplayProductDetails(product2);
            DisplayProductDetails(product3);

            Console.ReadLine();

        }
    }
}
