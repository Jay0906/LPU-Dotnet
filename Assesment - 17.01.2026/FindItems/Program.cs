using System;
namespace FindItems
{
    public class Program
    {
        public static void Main()
        {
            itemsApp items=new itemsApp();

            System.Console.WriteLine("Enter Sold Count: ");
            long sc=int.Parse(Console.ReadLine()!);

            SortedDictionary<string,long> res=items.FinditemDetails(sc);
            System.Console.Write("Item Details based on Sold Count: ");
            foreach(var item in res)
            {
                System.Console.WriteLine($"\t{item.Key} - {item.Value}");
            }

            List<string> MinMax=items.FindMinandMaxSoldItems();
            System.Console.WriteLine($"Min: {MinMax[0]}");
            System.Console.WriteLine($"Max: {MinMax[1]}");

            System.Console.WriteLine("Items Sorted : ");
            Dictionary<string,long> Sort=items.SortbyCount();
            foreach(var item in Sort)
            {
                System.Console.WriteLine($"\t{item.Key} - {item.Value}");
            }
        }
    }
}
