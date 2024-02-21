using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    public class Product
    {
        private int productId;
        private string productName;
        private double price;
        private int quantityInStock;

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public void AddProduct(int quantityToAdd)
        {
            if (quantityToAdd > 0)
            {
                quantityInStock += quantityToAdd;
                Console.WriteLine($"{quantityToAdd} {productName}(s) added successfully. New Stock Quantity: {quantityInStock}");
            }
            else
            {
                Console.WriteLine("Invalid quantity to add!");
            }
        }

        public void BuyProduct(int quantityToBuy)
        {
            if (quantityToBuy > 0 && quantityToBuy <= quantityInStock)
            {
                Console.WriteLine($"{quantityToBuy} {productName}(s) bought successfully. Price: ${price * quantityToBuy}");
                quantityInStock -= quantityToBuy;
            }
            else
            {
                Console.WriteLine($"Invalid quantity to buy or insufficient stock.");
            }
        }

        public int ProductId
        {
            get { return productId; }
        }

        public string ProductName
        {
            get { return productName; }
        }

        public double Price
        {
            get { return price; }
        }

        public int QuantityInStock
        {
            get { return quantityInStock; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product(101, "Laptop", 800, 10);

            Console.WriteLine("Product Details: ");
            Console.WriteLine($"Product ID: {laptop.ProductId}");
            Console.WriteLine($"Product Name: {laptop.ProductName}");
            Console.WriteLine($"Product Price: {laptop.Price}");
            Console.WriteLine($"Product Stock: {laptop.QuantityInStock}");

            // laptop.ProductId = 199;
            // Since the productId property is read-only, it cannot be modified.
            // If you try to modify it, it will result in a compilation error.

            Console.ReadLine();
        }
    }
}
