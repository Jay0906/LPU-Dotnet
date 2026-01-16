/*
Create two async methods:
One waits 1 second
Another waits 2 seconds
Call them one after the other using await.
*/
using System;
using System.Threading.Tasks;
namespace AsychPrac;

public class Prac4
{
    public static async Task method1()
    {
        await Task.Delay(1000);
        System.Console.WriteLine("Task 1 Completed");
    }

    public static async Task method2()
    {
        await Task.Delay(2000);
        System.Console.WriteLine("Task 2 Completed");
    }
}
