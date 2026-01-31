using System;
using Microsoft.VisualBasic;
namespace BikeRentalShop
{
    public class Program
    {
        public static void Main()
        {
            bool flag=true;

            BikeUtility  bike=new BikeUtility();
            while(flag){
            System.Console.WriteLine("1. Add Bike Details");
            System.Console.WriteLine("2. Group Bikes By Brand");
            System.Console.WriteLine("3. Exit");

            System.Console.Write("Enter your choice: ");
            int choice=int.Parse(Console.ReadLine()!);
            if (choice == 1)
            {
                System.Console.Write("Enter Model: ");
                string model=Console.ReadLine()!;
                
                System.Console.Write("Enter Brand: ");
                string brand=Console.ReadLine()!;
                
                System.Console.Write("Enter Price Per Day: ");
                int price=int.Parse(Console.ReadLine()!);

                bike.AddDetails(model,brand,price);

                System.Console.WriteLine("Bike Details Added Successfully");
            }
            else if (choice == 2)
            {
               foreach(var item in bike.GroupBikesByBrand())
                {
                    System.Console.Write($"{item.Key} - ");
                    foreach(var items in item.Value)
                        {
                            System.Console.Write($"{items.Model}");
                        }
                    System.Console.WriteLine();
                } 
            }
            else if (choice == 3)
            {
                flag=false;
            }
        }
            System.Console.WriteLine("Program Exited Successfully");
        }
    }
}
