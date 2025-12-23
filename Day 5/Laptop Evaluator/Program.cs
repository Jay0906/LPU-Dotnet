using System;
using System.Runtime.CompilerServices;
namespace LaptopEvaluator;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. Desktop");
        Console.WriteLine("2. Laptop");
        Console.Write("Choose the Option: ");

        int ch=int.Parse(Console.ReadLine()!);

        if (ch == 1)
        {
            Desktop d=new Desktop();

            Console.Write("Enter the Processor: ");
            d.processor=Console.ReadLine()!;

            Console.Write("Enter the RAM Size: ");
            d.ramsize=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Hard-Disk Size: ");
            d.HarddiskSize=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Graphic-Card Size: ");
            d.GraphicCard=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Moniter Size: ");
            d.MoniterSize=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Power-Supply Volt: ");
            d.PowerSupplyVolt=int.Parse(Console.ReadLine()!);

            Console.Write("Desktop Price: "+d.DesktopPriceCalculation());
        }else if (ch == 2)
        {
            Laptop l=new Laptop();

            Console.Write("Enter the Processor: ");
            l.processor=Console.ReadLine()!;

            Console.Write("Enter the RAM Size: ");
            l.ramsize=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Hard-Disk Size: ");
            l.HarddiskSize=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Graphic-Card Size: ");
            l.GraphicCard=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Battery-Volt Size: ");
            l.BatteryVolt=int.Parse(Console.ReadLine()!);

            Console.Write("Enter the Display Size: ");
            l.DisplaySize=int.Parse(Console.ReadLine()!);

            Console.Write("Laptop Price: "+l.LaptopPriceCalculation());
        }
    }
}
