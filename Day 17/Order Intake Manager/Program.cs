using System;
namespace OrderIntakeManager
{
    public class Program
    {
        public static Stack<Order> orderList=new Stack<Order>();
        public static void Main()
        {
            Order order=new Order();
            
            System.Console.Write("Enter OrderId: ");
            int ordId=int.Parse(Console.ReadLine()!);

            System.Console.Write("Enter Customer Name: ");
            string name=Console.ReadLine()!;

            System.Console.Write("Enter Item: ");
            string item=Console.ReadLine()!;

            order.AddOrderDetails(ordId,name,item);
            Console.WriteLine(order.GetOrderDetails());
            order.RemoveOrderDetails();
        }
    }
}
