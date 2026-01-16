using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;

namespace AsychPrac
{
    public class Program
    {
        static async Task Main()
        {
            // await Prac3.method();
            // await Prac4.method1();
            // await Prac4.method2();
            //Console.WriteLine(await Prac5.method(2,4));
            //await Prac6.method();
            // Task t1=Prac7.DownloadFileAsych();
            // Task t2=Prac7.LogActivityAsych();
            // await Task.WhenAll(t1,t2);
            // System.Console.WriteLine("All Tasks Completed");
            //await Prac8.method1();
            // try
            // {
            //     await Prac9.method();
            // }
            // catch(Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            Task t1=Prac10.method();
            System.Console.WriteLine("Doing some Other things");
            await t1;
            System.Console.WriteLine("All Tasks Done");
        }
    }
}
