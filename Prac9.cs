/*
Create an async method that throws an exception after 2 seconds.
Handle the exception in Main
*/

using System;
using System.Threading.Tasks;
namespace AsychPrac;

public class Prac9
{
    public static async Task method()
    {
        await Task.Delay(2000);
        throw new Exception("Something went wrong");
    }
}
