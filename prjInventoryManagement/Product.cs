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
        public decimal Price { get; set; }

        public Product(int id, string name, decimal quantity, decimal price)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

    public static class ProductExtentionMethods
    {
        public static decimal TotalValue(this List<Product> products)
        {
            decimal totalValue = 0;
            foreach (Product product in products)
            {
                totalValue += product.Quantity * product.Price;
            }
            return totalValue;
        }
        public static List<Product> FilterByLowStock(this List<Product> products, decimal threshold)
        {
            threshold = 10;
            return products.Where(p => p.Quantity < threshold).ToList();
        }
    }

    public static class ProductQueries
    {
        public static IEnumerable<dynamic> SelectProductNamesAndPrices(this List<Product> products)
        {
            return products.Select(p => new { p.Name, p.Price });
        }
    }
}
