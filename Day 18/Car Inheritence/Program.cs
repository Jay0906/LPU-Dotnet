using System;
using System.Security.Principal;
namespace CarInheritence
{
    public class Program
    {
        public static void Main()
        {
            System.Console.Write("Enter Type: ");
            int type=int.Parse(Console.ReadLine()!);

            System.Console.Write("Enter Mileage: ");
            int mileage=int.Parse(Console.ReadLine()!);

            Car car=null;

            if (type == 0)
            {
                car=new WagonR(mileage);
                System.Console.Write("A WagonR is ");
            }
            else if (type == 1)
            {
                car=new HondaCity(mileage);
                System.Console.Write("A Honda City is ");    
            }
            else if (type == 2)
            {
                car=new InnovaCrysta(mileage);
                System.Console.Write("A Innova Crysta is ");
            }
            

            System.Console.Write($"{(car.getIsSedan() ? "Sedan" : "Not Sedan")}, is a {car.getSeats()} Seater, and {car.getMileage()}");
        }
    }
}
