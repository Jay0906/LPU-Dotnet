using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace CarManagement
{
    public class Program
    {
        public static void Main()
        {
            System.Console.Write("Enter no. of cars: ");
            int n=int.Parse(Console.ReadLine()!);
            List<Car> carList=new List<Car>();

            for(int i = 0; i < n; i++)
            {
                string[] car=Console.ReadLine()!.Split(" ");
                carList.Add(new Car(car[0],car[1],int.Parse(car[2])));
            }

            Tasks task=new Tasks(carList);

            Car exp=task.MostExpensiveCar();
            System.Console.WriteLine($"Most Expensive Car: {exp.Brand} - {exp.Model}");

            Car cheap=task.CheapestCar();
            System.Console.WriteLine($"Cheapest Car: {cheap.Brand} - {cheap.Model}");

            System.Console.WriteLine($"Avg Price of Cars: {task.AveragePriceofCars()}");

            foreach(var item in task.MostExpensiveModelForEachBrand())
            {
                System.Console.WriteLine($"{item.Key} - {item.Value.Model} - {item.Value.Price}");   
            }
        }
    }
}
