/*
Write a program where:
One async method starts first
Another method runs in between
Finally, the first method finishes
(Use different delays to show execution order clearly.)
*/

using System;
using System.Threading.Tasks;
namespace AsychPrac;

public class Prac8
{
    public static async Task method1()
    {
        System.Console.WriteLine("Task Started");
        Task firsttask= Task.Delay(5000);
        await method2();
        await firsttask;
        System.Console.WriteLine("All Tasks Completed");
        
    }
    public static async Task method2()
    {
        await Task.Delay(3000);
        System.Console.WriteLine("Running in between");
    }
}
