using System;
using System.ComponentModel;
using System.Security.AccessControl;
namespace CakeWorld;

public class Program
{
    public static void Main()
    {
        Cake cake=new Cake();

        try
        {
            Console.Write("Enter the Flavour: ");
            cake.Flavour=Console.ReadLine()!;

            Console.Write("Enter the Quantity: ");
            cake.QuantityInKG=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Price: ");
            cake.PricePerKG=int.Parse(Console.ReadLine()!);

            if (cake.CakeOrder())
            {
                Console.WriteLine("Cake Order Successfull");
                Console.WriteLine("Total Price after Discount: "+cake.CalculatePrice());
            }
        }
        
        catch(InvalidFlavourException e)
        {
            Console.WriteLine(e.Message);
        }
        
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    
    }
}
