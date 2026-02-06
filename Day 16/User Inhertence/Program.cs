using System;
using System.ComponentModel;
namespace UserInheritence
{
    public class Program
    {
        public static void Main()
        {
            System.Console.Write("Enter Admin Details [Name,Gender,Age] : ");
            string[] admin=Console.ReadLine()!.Split(",");
            Admin ad=new Admin(admin[0],(Gender)Enum.Parse(typeof(Gender), admin[1]),int.Parse(admin[2]));

            System.Console.WriteLine($"Type of User {ad.GetName()} is {ad.GetType()}");
            System.Console.WriteLine($"Age of User {ad.GetName()} is {ad.GetAge()}");
            System.Console.WriteLine($"Gender of User {ad.GetName()} is {ad.GetGender()}");

            System.Console.Write("Enter Moderator Details [Name,Gender,Age] : ");
            string[] mod=Console.ReadLine()!.Split(",");
            Moderator md=new Moderator(mod[0],(Gender)Enum.Parse(typeof(Gender), mod[1]),int.Parse(mod[2]));

            System.Console.WriteLine($"Type of User {md.GetName()} is {md.GetType()}");
            System.Console.WriteLine($"Age of User {md.GetName()} is {md.GetAge()}");
            System.Console.WriteLine($"Gender of User {md.GetName()} is {md.GetGender()}");
        }
    }
}
