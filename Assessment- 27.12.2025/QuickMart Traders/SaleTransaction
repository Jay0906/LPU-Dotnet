using System;
using QuickMartTraders;

public class Program
{
    static SaleTransaction? LastTransaction;
    static bool HasLastTransaction = false;

    public static void Main()
    {
        bool next = true;

        while (next)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            int op = int.Parse(Console.ReadLine()!);

            if (op == 4)
            {
                next = false;
            }
            else if (op == 1)
            {
                SaleTransaction t = new SaleTransaction();

                Console.Write("Enter Invoice No: ");
                t.InvoiceNo = Console.ReadLine()!;

                Console.Write("Enter Customer Name: ");
                t.CustomerName = Console.ReadLine()!;

                Console.Write("Enter Item Name: ");
                t.ItemName = Console.ReadLine()!;

                Console.Write("Enter Quantity: ");
                t.Quantity = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Purchase Amount (total): ");
                t.PurchaseAmount = double.Parse(Console.ReadLine()!);

                Console.Write("Enter Selling Amount (total): ");
                t.SellingAmount = double.Parse(Console.ReadLine()!);

                LastTransaction = t;
                HasLastTransaction = true;

                Console.WriteLine("\nTransaction saved successfully.");
                Console.WriteLine("Status: " + t.ProfitOrLossStatus());
                Console.WriteLine($"Profit/Loss Amount: {t.ProfirOrLossAmount():F2}");
                Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent():F2}");
                Console.WriteLine("------------------------------------------------------");
            }
            else if (op == 2)
            {
                if (!HasLastTransaction)
                {
                    Console.WriteLine("No transaction available. Please create a new transaction first.");
                }
                else
                {
                    Console.WriteLine("\n-------------- Last Transaction --------------");
                    Console.WriteLine("InvoiceNo: " + LastTransaction!.InvoiceNo);
                    Console.WriteLine("Customer: " + LastTransaction.CustomerName);
                    Console.WriteLine("Item: " + LastTransaction.ItemName);
                    Console.WriteLine("Quantity: " + LastTransaction.Quantity);
                    Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
                    Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
                    Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus());
                    Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfirOrLossAmount():F2}");
                    Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent():F2}");
                    Console.WriteLine("--------------------------------------------");
                }
                Console.WriteLine("------------------------------------------------------");
            }
            else if (op == 3)
            {
                if (!HasLastTransaction)
                {
                    Console.WriteLine("No transaction available. Please create a new transaction first.");
                }
                else
                {
                    Console.WriteLine("Status: " + LastTransaction!.ProfitOrLossStatus());
                    Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfirOrLossAmount():F2}");
                    Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent():F2}");
                }
                Console.WriteLine("------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }

        Console.WriteLine("Thank you. Application closed normally.");
    }
}
