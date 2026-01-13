using System;
namespace PhoneCallSubscription
{
    public class Program
    {
        public static void Main()
        {
            PhoneCall phonecall=new PhoneCall();
            
            phonecall.MakePhoneCall(true);
            System.Console.WriteLine(phonecall.Message);

            phonecall.MakePhoneCall(false);
            System.Console.WriteLine(phonecall.Message);
        }
    }
}
