using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; } // Price per product using decimal (Microsoft, 2021).

        public Product(int id, string name, decimal quantity, decimal price) // Constructor
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

    public static class ProductExtentionMethods // Extension methods for Product class (Geeksforgeeks, 2019).
    {
        public static decimal TotalValue(this List<Product> products)
        {
            decimal totalValue = 0;
            foreach (Product product in products)
            {
                totalValue += product.Quantity * product.Price;
            }
            return totalValue;
        } // Calculates the total value of all products in the inventory
        public static List<Product> FilterByLowStock(this List<Product> products, decimal threshold)
        {
            threshold = 10;
            return products.Where(p => p.Quantity < threshold).ToList();
        } // Filters products with stock below a certain threshold
    }

    public static class ProductQueries
    {
        public static IEnumerable<dynamic> SelectProductNamesAndPrices(this List<Product> products)
        {
            return products.Select(p => new { p.Name, p.Price });
        } // Selects product names and prices as dynamic objects using LINQ (Microsoft, 2024).
    }
}


/*Reference List:
Geeksforgeeks, 2019. Extension Method in C#. [online] Available at: <https://www.geeksforgeeks.org/c-sharp/extension-method-in-c-sharp/> [Accessed 08 August 2025].
Microsoft, 2021. Floating-point numeric types (C# reference). [online] Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types> [Accessed 08 August 2025].
Microsoft, 2024. Intorduction to LINQ Questies in C#. [online] Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries> [Accessed 08 August 2025].
*/