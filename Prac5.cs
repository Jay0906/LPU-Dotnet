/*
Create an async method that returns an integer after 1 second.
Print the returned value in Main.
*/

using System;
using System.Threading.Tasks;
namespace AsychPrac;

public class Prac5
{
    public static async Task<int> method(int a,int b)
    {
        await Task.Delay(1000);
        return a+b;
    }
}
