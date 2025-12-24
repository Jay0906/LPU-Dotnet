using System;
using System.Globalization;
using System.Runtime.InteropServices;
namespace CandyCraze;

public class Program
{
    public Candy CalculateDiscountPrice(Candy candy)
    {
        candy.TotalPrice=candy.Quantity*candy.PricePerPiece;

        if (candy.Flavour == "Strawberry")
        {
            candy.Discount=15;
        }else if (candy.Flavour == "Lemon")
        {
            candy.Discount=10;
        }else if (candy.Flavour == "Mint")
        {
            candy.Discount=5;
        }

        double Discount=candy.TotalPrice-(candy.TotalPrice*candy.Discount/100);
        candy.TotalPrice=Discount;
        return candy;

    } 

    static void Main()
    {
        Program p=new Program();
        Candy candy=new Candy();

        Console.Write("Enter Flavour: ");
        candy.Flavour=Console.ReadLine()!;

        Console.Write("Enter Quantity: ");
        candy.Quantity=int.Parse(Console.ReadLine()!);

        Console.Write("Enter Price: ");
        candy.PricePerPiece=int.Parse(Console.ReadLine()!);

        if(candy.ValidateCandyFlavour()){

            candy=p.CalculateDiscountPrice(candy);

            Console.WriteLine("Total Price: "+candy.Quantity*candy.PricePerPiece);

            Console.Write("Discounted Price: "+candy.TotalPrice);
        }
        else
        {
            Console.Write("Invalid Input");
        }

    }
}
