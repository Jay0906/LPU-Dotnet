using System;
namespace EmployeeInheritence
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the no. of Lines: ");
            int n=int.Parse(Console.ReadLine()!);
            
            Console.Write("Enter Finance Employee Details: ");
            for(int i = 0; i < n; i++)
            {
                string[] finEmployee=Console.ReadLine()!.Split(" ");
                FinanceEmployee financeEmployee=new FinanceEmployee(finEmployee[0],finEmployee[1]);

                Console.WriteLine($"Department: {financeEmployee.GetDepartment()} - Name: {financeEmployee.GetName()} - Location: {financeEmployee.GetLocation()}");
                Console.WriteLine(financeEmployee.GetStatus()? $"{financeEmployee.GetName()} is on Vacation" : $"{financeEmployee.GetName()} is not on Vacation");                

                Console.WriteLine("Switching");
                financeEmployee.SwitchStatus();
                Console.WriteLine(financeEmployee.GetStatus()? $"{financeEmployee.GetName()} is on Vacation" : $"{financeEmployee.GetName()} is not on Vacation");
            }

            Console.Write("Enter Marketing Employee Details: ");
            for(int i = 0; i < n; i++)
            {
                string[] MarkEmployee=Console.ReadLine()!.Split(" ");
                MarketingEmployee marketingEmployee=new MarketingEmployee(MarkEmployee[0],MarkEmployee[1]);

                Console.WriteLine($"Department: {marketingEmployee.GetDepartment()} - Name: {marketingEmployee.GetName()} - Location: {marketingEmployee.GetLocation()}");
                Console.WriteLine(marketingEmployee.GetStatus()? $"{marketingEmployee.GetName()} is on Vacation" : $"{marketingEmployee.GetName()} is not on Vacation");                

                Console.WriteLine("Switching");
                marketingEmployee.SwitchStatus();
                Console.WriteLine(marketingEmployee.GetStatus()? $"{marketingEmployee.GetName()} is on Vacation" : $"{marketingEmployee.GetName()} is not on Vacation");
            }

        }
    }
}
