using System;
namespace CalculateNumbers
{
    public class Program
    {
        public static void Main()
        {
            Number num=new Number();
            System.Console.Write("Enter the no. of Marks you wish to Add: ");
            int n=int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Enter the Marks you want to add: ");
            while (n > 0)
            {
                num.AddNumbers(int.Parse(Console.ReadLine()!));
                n--;
            }

            System.Console.Write("GPA Scored: ");
            double gpa=Math.Round(num.GetGPAScored(),2);
            if(gpa>0)
            {
            System.Console.WriteLine(gpa);
            }
            else
            {
                System.Console.WriteLine("No Numbers Available");
            }

            System.Console.Write("Grade: ");
            char grade=num.GetGradeScored(gpa);
            if (grade!='\0')
            {
                System.Console.WriteLine(num.GetGradeScored(gpa));
            }
            else
            {
                System.Console.WriteLine("Invalid GPA");
            }
        }
    }
}
