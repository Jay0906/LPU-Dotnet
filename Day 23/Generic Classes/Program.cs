using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
namespace GenericClassPrac
{
    public class Program
    {
        public static void Main()
        {

            // Prac1<int> gen=new Prac1<int>();
            // gen.SetValue(20);
            // gen.GetValue();
            
            //----------------------------------------------------

            // Prac2<int,string> gen=new Prac2<int,string>(1,"One");
            // Prac2<string,bool> gen1=new Prac2<string, bool>("Two",true);
            // gen.Print();        
            // gen1.Print();
            // 

            //----------------------------------------------------

            // MyStack<int> stack=new MyStack<int>(5);
            // stack.push(10);
            // stack.push(20);
            // stack.push(30);
            // System.Console.WriteLine(stack.pop());
            // System.Console.WriteLine(stack.peek());
            
            //----------------------------------------------------

            // Prac4<int> prac=new Prac4<int>();
            // int x=5,y=10;
            // prac.Swap(ref x,ref y);
            // System.Console.WriteLine($"X:{x} , Y:{y}");

            //----------------------------------------------------

            // Prac5 prac=new Prac5();
            // prac.Print<int>(10);
            // prac.Print<string>("Ambi");

            //----------------------------------------------------

            Prac6 prac=new Prac6();
            System.Console.WriteLine(prac.FindMax<int>(5,10));
        }
    }
}
