using System;
namespace StudentRecordManagementSystem
{
    public class Program
    {
        public static Dictionary<int,Student> studentDetails=new Dictionary<int, Student>();
        
        public static void Main()
        {
            Student student=new Student();
            student.Id="101";
            student.Name="Ambi";
            student.Course="CSE";
            student.Marks=98;

            studentDetails.Add(1,student);

            Student studentt=new Student();
            studentt.Id="102";
            studentt.Name="Jay";
            studentt.Course="CSE";
            studentt.Marks=100;

            studentDetails.Add(2,studentt);

            bool flag=true;
            while (flag)
            {
                System.Console.WriteLine("1. Get Student Details");
                System.Console.WriteLine("2. Update Marks");
                System.Console.WriteLine("3. Exit");
                System.Console.Write("Enter your choice: ");
                int n=int.Parse(Console.ReadLine()!);

                StudentUtility st=new StudentUtility();
                if (n == 1)
                {
                    foreach(var item in st.GetStudentDetails("101"))
                    {
                        System.Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
                else if (n == 2)
                {
                    foreach(var item in st.UpdateStudentMarks("102", 87))
                    {
                        System.Console.WriteLine($"{item.Key} - {item.Value.Name} - {item.Value.Marks}");
                    }    
                }
                else if (n == 3)
                {
                    flag=false;
                    System.Console.WriteLine("Program Exited.");
                }
            }
        }
    }
}
