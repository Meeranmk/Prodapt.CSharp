namespace Prodapt.CSharp.Day4
{
    internal class Employee
    {
        int empId;
        string empName;
        string city;
        int age;

        public Employee()
        {
            empId = 1;
            empName = "virat";
            city = "chennai";
        }

        public Employee(int empId, string empName, string city, int age)
        {
            this.empId = empId;
            this.empName = empName;
            this.city = city;
            this.age = age;
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine($"Emp id:{emp.empId}\tEmployee name:{emp.empName}\t Employee city:{emp.city}\t Age: {emp.age}");
        }
    }
}
