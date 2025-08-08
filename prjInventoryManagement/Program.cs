using System.Security.Cryptography.X509Certificates;

namespace prjInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
                {
                    new Product(1, "Laptop", 5, 1200.00m),
                    new Product(2, "Mouse", 25, 15.50m),
                    new Product(3, "Keyboard", 8, 45.00m),
                    new Product(4, "Monitor", 3, 300.00m)
                }; // Initialises a list of products with sample data

            var namesAndPrices = products.SelectProductNamesAndPrices();
            Console.WriteLine("Product Names and Prices:");
            foreach (var item in namesAndPrices)
            {
                Console.WriteLine($"- {item.Name}: R{item.Price}");
            } // Displays product names and prices using LINQ

            var lowStockProducts = products.FilterByLowStock(10);
            Console.WriteLine("\nProducts with Low Stock:");
            foreach (var product in lowStockProducts)
            {
                Console.WriteLine($"- {product.Name} (Quantity: {product.Quantity})");
            } // Displays products with stock below a certain threshold using extension method

            decimal totalValue = products.TotalValue();
            Console.WriteLine($"\nTotal Inventory Value: R{totalValue}"); // Calculates and displays the total value of all products in the inventory
        }
    }
}