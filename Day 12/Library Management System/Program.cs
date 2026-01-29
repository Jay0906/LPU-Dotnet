using System;
namespace LibraryManagementSystemm
{
    public class Program
    {
        public static void Main()
        {
            int n=int.Parse(Console.ReadLine()!);
            ILibrarySystem lib=new LibrarySystem();

            for(int i = 0; i < n; i++)
            {
                var input=Console.ReadLine().Split(" ");
                Book b=new Book
                {
                    Id=int.Parse(input[0]),
                    Title=input[1],
                    Author=input[2],
                    Category=input[3],
                    Price=int.Parse(input[4])
                };
                int qty=int.Parse(input[5]);
                lib.AddBook(b,qty);
            }

            Console.WriteLine("Book Info:");
            foreach (var b in lib.BookInfo())
            Console.WriteLine($"Book Name: {b.Item1}, Quantity: {b.Item2}, Price: {b.Item3}");

            Console.WriteLine("Category Total Price:");
            foreach (var c in lib.CategoryTotalPrice())
            Console.WriteLine($"Category: {c.Item1}, Total Price: {c.Item2}");

            Console.WriteLine("Category And Author With Count:");
            foreach (var ca in lib.CategoryAndAuthorWithCount())
            Console.WriteLine($"Category: {ca.Item1}, Author: {ca.Item2}, Count: {ca.Item3}");

            Console.WriteLine($"Total Price: {lib.CalculateTotal()}");
        }
    }
}
