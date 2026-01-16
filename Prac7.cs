/*
Create two async methods:
DownloadFileAsync() → waits 4 seconds
LogActivityAsync() → waits 2 seconds
Start both without awaiting immediately, then wait for both using Task.WhenAll.
*/

using System;
using System.Threading.Tasks;

namespace AsychPrac;

public class Prac7
{
    public static async Task DownloadFileAsych()
    {
        await Task.Delay(4000);
        System.Console.WriteLine("File Downloaded");
    }
    public static async Task LogActivityAsych()
    {
        await Task.Delay(2000);
        System.Console.WriteLine("Log Activated");
    }
}
