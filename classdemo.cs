using System;

public class Employee
{
    int empId;
    string eName;
    double salary;

    public void getData(int id, string name, double sal)
    {
        empId = id;
        eName = name;
        salary = sal;
    }

    //high salary of emp
    public double getsalary()
    {
        return salary;
    }

    public void showData()
    {
        Console.WriteLine("Emp ID: " + empId);//display emp id
        Console.WriteLine("Emp Name: " + eName);
        Console.WriteLine("Emp Salary: " + salary);//display emp salary
        Console.WriteLine();
    }
    //internal class
    internal class ClassDemo1
    {
        public static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            emp1.getData(111, "qwer", 2000000);

            Employee emp2 = new Employee();
            emp2.getData(112, "adsc", 245000);

         
            if (emp1.getsalary() > emp2.getsalary())
            {
                Console.WriteLine("Employee with Highest Salary:");
                emp1.showData();
            }
            else
            {
                Console.WriteLine("Employee with Highest Salary:");
                emp2.showData();
            }
        }
    }
}
