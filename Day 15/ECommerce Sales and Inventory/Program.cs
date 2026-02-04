using System;
namespace ECommerceSalesAndInventory
{
    public class Program
    {
        public static void Main()
        {
                    // ---------- READ PRODUCTS ----------
        int n = int.Parse(Console.ReadLine()!);
        Dictionary<int, IProduct> products = new Dictionary<int, IProduct>();

        for (int i = 0; i < n; i++)
        {
            var parts = Console.ReadLine()!.Split(' ');
            int id = int.Parse(parts[0]);
            string name = parts[1];
            decimal price = decimal.Parse(parts[2]);

            products[id] = new Product(id, name, price);
        }

        // ---------- READ CATEGORIES ----------
        int m = int.Parse(Console.ReadLine()!);
        Dictionary<int, ICategory> categories = new Dictionary<int, ICategory>();

        for (int i = 0; i < m; i++)
        {
            var parts = Console.ReadLine()!.Split(' ');
            int id = int.Parse(parts[0]);
            string name = parts[1];

            categories[id] = new Category(id, name);
        }

        // ---------- COMPANY ----------
        Company company = new Company(1, "E-Commerce");

        foreach (var cat in categories.Values)
            company.AddCategory(cat);

        // ---------- READ MAPPING ----------
        int k = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < k; i++)
        {
            var parts = Console.ReadLine()!.Split(',');
            int categoryId = int.Parse(parts[0]);
            int productId = int.Parse(parts[1]);

            categories[categoryId].AddProduct(products[productId]);
        }

        // ---------- OUTPUT ----------
        Console.WriteLine("Top category:" + company.GetTopCategoryNameByProductCount());

        Console.WriteLine("Common products:");
        foreach (var p in company.GetProductBelongingToMultipleCategories())
            Console.WriteLine(p.Name);

        var top = company.GetTopCategoryBySumOfProductPrices();
        Console.WriteLine($"Most valuable category:{top.name} {top.total}");

        foreach (var c in company.GetCategoriesWithSumOfProductPrices())
            Console.WriteLine($"{c.catName} {c.sumofPrices}");
        }
    }
}
