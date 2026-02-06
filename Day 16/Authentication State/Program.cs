using System;
namespace AuthenticationState
{
    public class Program
    {
        public static void Main()
        {

            System.Console.Write("Enter no. of Locations: ");
            int n=int.Parse(Console.ReadLine()!);
            List<string> Locations=new List<string>();

            for(int i = 0; i < n; i++)
            {
                Locations.Add(Console.ReadLine()!);
            }
            ApplicationAuthState auth=new ApplicationAuthState(Locations);
            
            
            List<User> userss=new List<User>();
            System.Console.Write("Enter no. of users: ");
            int m=int.Parse(Console.ReadLine()!);

            for(int i = 0; i < m; i++)
            {
                string[] users=Console.ReadLine()!.Split(",");
                userss.Add(new User(int.Parse(users[0]),users[1],users[2],users[3]));
            }

            System.Console.Write("Enter no. of Operations [Operation:Index] : ");
            int k = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < k; i++)
            {
                // Format: Operation:UserIndex
                string[] commandParts = Console.ReadLine()!.Split(':');

                string operation = commandParts[0];
                int userIndex = int.Parse(commandParts[1]);

                User currentUser = userss[userIndex];

                string result = "";

                if (operation == "Register")
                {
                    result = auth.Register(currentUser);
                }
                else if (operation == "Login")
                {
                    result = auth.Login(currentUser);
                }
                else if (operation == "Logout")
                {
                    result = auth.Logout(currentUser);
                }

                Console.WriteLine(result);
            }
        }
    }
}
