using System;
namespace ProductInventoryManagement
{
    public class Program
    {
        public static void Main()
        {
            System.Console.Write("Enter No. of Lines: ");
            int n=int.Parse(Console.ReadLine()!);
            Inventory invent=new Inventory();

            for(int i = 0; i < n; i++)
            {
                var input=Console.ReadLine().Split(" ");
                Product prod=new Product
                {
                    Name=input[0],
                    Category=input[1],
                    Stock=int.Parse(input[2]),
                    Price=int.Parse(input[3])
                };
                invent.AddProduct(prod);
            }

            string[] query=Console.ReadLine().Split(" ");
            string categorytosearch=query[0];
            string nametoSearch=query[1];
            string nametoRemove=query[2];


            System.Console.WriteLine("All Products By Category: ");
            foreach(var item in invent.GetProductByCategory(categorytosearch))
            {
                Console.WriteLine($"Product Name: {item.Name}");    
            }
            

 // Search products by name
        Console.WriteLine(nametoSearch + ":");
        var searchedProducts = invent.SearchProductsByName(nametoSearch);
        foreach (var p in searchedProducts)
        {
            Console.WriteLine($"Product Name: {p.Name} Category:{p.Category}");
        }

        // Total value
        Console.WriteLine($"Total Value: ${invent.CalculateTotalValue()}");

        // Category count
        var categoryCount = invent.GetProductsByCategoryWithCount();
        foreach (var item in categoryCount)
        {
            Console.WriteLine($"{item.Item1}:{item.Item2}");
        }

        // All products by category with price
        var allByCategory = invent.GetAllProductByCategory();
        foreach (var group in allByCategory)
        {
            Console.WriteLine(group.Item1 + ":");
            foreach (var p in group.Item2)
            {
                Console.WriteLine($"Product Name: {p.Name} Price:{p.Price}");
            }
        }

        // Remove product
        var productToRemove = invent
            .SearchProductsByName(nametoRemove)
            .FirstOrDefault(p => p.Name.Equals(nametoRemove, StringComparison.OrdinalIgnoreCase));

        if (productToRemove != null)
        {
            invent.RemoveProduct(productToRemove);
        }

        // New total value
        Console.WriteLine($"New Total Value: ${invent.CalculateTotalValue()}");
        }
    }
}
