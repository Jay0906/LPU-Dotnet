using System;
using System.Collections.Generic;
namespace E_commerceInventorySystem;
class Program
{
    static void Main()
    {
        // TODO:
        // Create a sample inventory with at least 5 products

        // TODO:
        // Demonstrate:
        // - Adding products with validation
        // - Finding products by brand (for electronics)
        // - Applying discounts
        // - Calculating total value before/after discount
        // - Handling a mixed collection of different product types
        // Create repository
        var repository = new ProductRepository<ElectronicProduct>();

        // Create products
        var laptop = new ElectronicProduct
        {
            Id = 1,
            Name = "Laptop",
            Price = 800,
            Brand = "Dell",
            WarrantyMonths = 24
        };

        var headphones = new ElectronicProduct
        {
            Id = 2,
            Name = "Headphones",
            Price = 100,
            Brand = "Sony",
            WarrantyMonths = 12
        };

        var monitor = new ElectronicProduct
        {
            Id = 3,
            Name = "Monitor",
            Price = 300,
            Brand = "LG",
            WarrantyMonths = 18
        };

        // Add products with validation
        try
        {
            repository.AddProduct(laptop);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Laptop Error: {ex.Message}");
        }

        try
        {
            repository.AddProduct(headphones);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Headphones Error: {ex.Message}");
        }

        try
        {
            repository.AddProduct(monitor);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Monitor Error: {ex.Message}");
        }


        // Find expensive products (>500)
        Console.WriteLine("---- Expensive Products ----");
        var expensiveProducts = repository.FindProducts(p => p.Price > 500);

        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Find products by brand
        Console.WriteLine("\n---- Sony Products ----");
        var sonyProducts = repository.FindProducts(p => p.Brand == "Sony");

        foreach (var product in sonyProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Calculate total inventory value
        decimal totalValue = repository.CalculateTotalValue();
        Console.WriteLine($"\nTotal Inventory Value: {totalValue}");

        // Use InventoryManager
        var manager = new InventoryManager();

        Console.WriteLine("\n---- Processing Products ----");
        manager.ProcessProducts(new List<ElectronicProduct>
        {
            laptop,
            headphones,
            monitor
        });

        // Update prices (Increase by 10%)
        Console.WriteLine("\n---- Updating Prices (10% Increase) ----");

        var productList = new List<ElectronicProduct>
        {
            laptop,
            headphones,
            monitor
        };

        manager.UpdatePrices(productList, p => p.Price * 1.10m);

        // Print updated prices
        Console.WriteLine("\n---- Updated Prices ----");
        foreach (var product in productList)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        Console.WriteLine("\nProgram Finished.");
    }
}

