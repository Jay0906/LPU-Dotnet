using System;
using System.Security.Cryptography;
namespace CabFare;

public class Program
{
    public static void Main()
    {
        CabDetails cab=new CabDetails();

        Console.Write("Enter the bookingID: ");
        cab.BookingID=Console.ReadLine()!;

        Console.Write("Enter the Cab Type: ");
        cab.CabType=Console.ReadLine()!;

        Console.Write("Enter the distance in KM: ");
        cab.Distance=int.Parse(Console.ReadLine()!);

        Console.Write("Enter the waiting time in minutes: ");
        cab.WaitingTime=int.Parse(Console.ReadLine()!);

        if(cab.ValidateBookingID()){
            Console.WriteLine($"The Fare amount is: {cab.CalculateFareAmount():F2}");
        }
        else
        {
            Console.Write("Invalid Input");
        }
    }
}
