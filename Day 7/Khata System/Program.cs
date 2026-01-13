using System;
namespace KhataSystem
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string,int> record=new Dictionary<string, int>
            {
                    { "Milk", 100 },
                    { "Tea", 50 },
                    { "Coffee", 100 },
                    { "Sugar", 50 },
                    { "Salt", 200 }

            };
            Khata khata=new Khata(record);

            System.Console.WriteLine($"Total Amount: {khata.getTotal()}");
            System.Console.WriteLine($"Repeated Amount Count : {khata.repeatedCounts()}");
        }
    }
}
