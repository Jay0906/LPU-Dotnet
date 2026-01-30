using System;
namespace BankChatBot
{
    public class Program
    {
        public static void Main()
        {
            int n=int.Parse(Console.ReadLine()!);
            IBankAccountOperation bank=new BankAccountOperation();

            for(int i = 0; i < n; i++)
            {
                string message=Console.ReadLine();
                decimal result=bank.ProcessOperation(message);
                Console.WriteLine(result);
            }
        }
    }
}
