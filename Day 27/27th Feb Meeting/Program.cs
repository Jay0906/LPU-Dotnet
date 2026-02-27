using System;
using System.Linq;
namespace _27thMeeting
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> empList=new List<Employee>()
            {
            new Employee{ EmpID=1001, FirstName="Malcolm", LastName="Darualla", Title="Manager", DOB=new DateOnly(1984,11,16), DOJ=new DateOnly(2011,6,8), City="Mumbai"},
            new Employee{ EmpID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=new DateOnly(1984,8,20), DOJ=new DateOnly(2012,7,7), City="Mumbai"},
            new Employee{ EmpID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=new DateOnly(1987,11,14), DOJ=new DateOnly(2015,4,12), City="Pune"},
            new Employee{ EmpID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=new DateOnly(1990,6,3), DOJ=new DateOnly(2016,2,2), City="Pune"},
            new Employee{ EmpID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=new DateOnly(1991,3,8), DOJ=new DateOnly(2016,2,2), City="Mumbai"},
            new Employee{ EmpID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=new DateOnly(1989,11,7), DOJ=new DateOnly(2014,8,8), City="Chennai"},
            new Employee{ EmpID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=new DateOnly(1989,12,2), DOJ=new DateOnly(2015,6,1), City="Mumbai"},
            new Employee{ EmpID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=new DateOnly(1993,11,11), DOJ=new DateOnly(2014,6,11), City="Chennai"},
            new Employee{ EmpID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=new DateOnly(1992,8,12), DOJ=new DateOnly(2014,12,3), City="Chennai"},
            new Employee{ EmpID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=new DateOnly(1991,4,12), DOJ=new DateOnly(2016,2,1), City="Pune"}  
            };


            System.Console.WriteLine("All Employees: ");
            var AllEmp=empList;
            foreach(var item in AllEmp)
            {
                System.Console.WriteLine($"\t{item.EmpID}  -  {item.FirstName}  -  {item.LastName}  -  {item.Title}  -  {item.DOB}  -  {item.DOJ}  -  {item.City}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("Employees not from Mumbai: ");
            var NotMumbai=empList.Where(n=>n.City!="Mumbai");
             foreach(var item in NotMumbai)
            {
                System.Console.WriteLine($"\t{item.EmpID}   -   {item.FirstName}   -   {item.LastName}   -   {item.City}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("Employee who are Asst.Manager: ");
            var AsstManager=empList.Where(n=>n.Title=="AsstManager");
            foreach(var item in AsstManager)
            {
                System.Console.WriteLine($"\t{item.EmpID}   -   {item.FirstName}   -   {item.LastName}   -   {item.Title}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("Employees whose LastName Starts with 'S': ");
            var EmpS=empList.Where(n=>n.LastName.StartsWith("S"));
            foreach(var item in EmpS)
            {
                System.Console.WriteLine($"\t{item.EmpID}   -   {item.FirstName}   -   {item.LastName}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("All Employees who have joined before 1/1/2015: ");
            var empdate=empList.Where(n=>n.DOJ<new DateOnly(2015,1,1));
            foreach(var item in empdate)
            {
                System.Console.WriteLine($"\t{item.EmpID} - {item.FirstName}   -   {item.LastName}   -   {item.DOJ}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("Employees whose DOB is after 1/1/1990: ");
            var empDOB=empList.Where(n=>n.DOB>new DateOnly(1990,1,1));
            foreach(var item in empDOB)
            {
                System.Console.WriteLine($"\t{item.EmpID}  -  {item.FirstName}  -  {item.LastName}  -  {item.DOB}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("Employees whose Designation is Consultant and Associate");
            var emp_cons_assos=empList.Where(n=>n.Title=="Manager" || n.Title=="Consultant");
            foreach(var item in emp_cons_assos)
            {
                System.Console.WriteLine($"\t{item.EmpID}  -  {item.FirstName}  -  {item.LastName}  -  {item.Title}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.Write("Total no. of Employees: ");
            var emp_count=empList.Count();
            System.Console.WriteLine($"{emp_count}\n");

            System.Console.WriteLine("----------------------------------------");

            System.Console.WriteLine("Employees from Chennai: ");
            var chennai=empList.Where(n=>n.City=="Chennai");
             foreach(var item in chennai)
            {
                System.Console.WriteLine($"\t{item.EmpID}   -   {item.FirstName}   -   {item.LastName}   -   {item.City}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.Write("Highest Employee ID: ");
            var emp_high=empList.FirstOrDefault(n=>n.EmpID==1001);
            System.Console.WriteLine($"{emp_high.EmpID}  -  {emp_high.FirstName}  -  {emp_high.LastName}");
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("All Employees who have joined after 1/1/2015: ");
            var emp_date_after=empList.Where(n=>n.DOJ>new DateOnly(2015,1,1));
            foreach(var item in emp_date_after)
            {
                System.Console.WriteLine($"\t{item.EmpID} - {item.FirstName}   -   {item.LastName}   -   {item.DOJ}");
            }
            System.Console.WriteLine("----------------------------------------");


            System.Console.Write("Employees whose Designation is Consultant and Associate");
            var emp_not_assosiate=empList.Where(n=>n.Title!="Assosiate").Count();
            System.Console.WriteLine($"{emp_not_assosiate}\n");
            System.Console.WriteLine("----------------------------------------");


            System.Console.WriteLine("Total no. of Employees based on City: ");
            var emp_count_city=empList.Where(n=>n.Title=="Manager" || n.Title=="Consultant");
            foreach(var item in emp_cons_assos)
            {
                System.Console.WriteLine($"\t{item.EmpID}  -  {item.FirstName}  -  {item.LastName}  -  {item.Title}");
            }
            System.Console.WriteLine("----------------------------------------");
        }
    }
}
