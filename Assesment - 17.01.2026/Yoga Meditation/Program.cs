using System;
namespace YogaMeditation
{
    public class YogaMeditation
    {
        public static void Main()
        {
            YogaCalc yc=new YogaCalc();
            yc.AddYogaMember(121,23,67,70,"Weight Gain");
            yc.AddYogaMember(122,35,90,67,"Weight Loss");
            yc.AddYogaMember(123,27,56,65,"Weight Gain");
            yc.AddYogaMember(124,32,80,60,"Weight Loss");
            yc.AddYogaMember(125,19,100,62,"Weight Loss");

            System.Console.Write("Enter MemberID for BMI: ");
            int memid=int.Parse(Console.ReadLine()!);
            System.Console.WriteLine(yc.CalculateBMI(memid));

            System.Console.Write("Enter MemberID for Fee: ");
            System.Console.WriteLine(yc.CalculateYogaFee(memid));
        }
    }
}
