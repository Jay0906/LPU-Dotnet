using System;
using System.Security.Cryptography;
namespace UserAuthentication
{
    public class Program
    {
        public static void Main()
        {
            Authentication at=new Authentication();
            try{
                if (at.ValidatePassword("Ambi", "Azbycxdw@1", "Azbycxdw@2") != null)
                {
                    System.Console.WriteLine("Registered Successfully");
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
