using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace M1MockPrac
{
    public class Jewellery
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public int Price { get; set; }

        public Jewellery(string Id,string Type,string Material,int Price)
        {
            this.Id=Id;
            this.Type=Type;
            this.Material=Material;
            this.Price=Price;
        }
    }

    public class JewelleryUtility
    {
        Jewellery jew;

        public JewelleryUtility(Jewellery jew)
        {
            this.jew=jew;
        }

        public void GetJewellery()
        {
            System.Console.WriteLine($"Details: {jew.Id} {jew.Type} {jew.Price}");
        }

        public void UpdateJewellery()
        {
            System.Console.WriteLine($"Updated Price: {jew.Price}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            string[] input=Console.ReadLine()!.Split(" ");
            Jewellery jew=new Jewellery(
                input[0],
                input[1],
                "Gold",
                int.Parse(input[2])
            );

            JewelleryUtility jews=new JewelleryUtility(jew);
            bool flag=true;

            while (flag)
            {
                System.Console.WriteLine("1. Display Details");
                System.Console.WriteLine("2. Update Price");
                System.Console.WriteLine("3. Exit");
                System.Console.Write("Enter your choice: ");
                int n=int.Parse(Console.ReadLine()!);

                if (n == 1)
                {
                    jews.GetJewellery();
                }
                else if (n == 2)
                {
                    int UpPrice=int.Parse(Console.ReadLine()!);
                    jew.Price=UpPrice;
                    jews.UpdateJewellery();    
                }
                else if (n == 3)
                {
                    flag=false;
                    System.Console.WriteLine("Thank You");
                }
            }
        }
    }
}
