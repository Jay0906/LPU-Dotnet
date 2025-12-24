using System;
using System.Globalization;
namespace LibraryManagementSystem;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the Title: ");
        string Title=Console.ReadLine()!;

        Console.Write("Enter the Author: ");
        string Author=Console.ReadLine()!;

        Console.Write("Enter no. of Pages: ");
        int NumPages=int.Parse(Console.ReadLine()!);

        Console.Write("Enter Due Date: ");
        DateTime DueDate=DateTime.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Enter Return Date: ");
        DateTime ReturnDate= DateTime.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Enter the days to read: ");
        int NumOfDays=int.Parse(Console.ReadLine()!);

        Console.Write("Enter the Daily latefee rate:");
        int Latefee=int.Parse(Console.ReadLine()!);

        Book book=new Book(Title,Author,NumPages,DueDate,ReturnDate);

        Console.WriteLine("Average Days read per Day: "+book.AveragePagesReadPerDay(NumOfDays));

        Console.WriteLine("Late Fee: "+book.CalculateLateFee(Latefee));
    }
}
