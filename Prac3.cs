/*
Write a program that prints:
Start
(wait 3 seconds)
End
*/

using System;
using System.Threading.Tasks;

namespace AsychPrac
{
    public class Prac3
    {
        public static async Task method()
        {
            System.Console.WriteLine("Start");
            await Task.Delay(3000);
            System.Console.WriteLine("End");
        }
    }
}