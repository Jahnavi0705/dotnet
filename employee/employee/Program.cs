using System;

namespace employee
{
    class employee
    {
        int employeeid;
        string name, gender, designation,location;
        double sal;

        public void getemployeeinfo()
        {
            Console.WriteLine("Enter employee Id: ");
            employeeid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter employee Gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter employee dsignation: ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter employee Location: ");
            location = Console.ReadLine();
            Console.WriteLine("Enter employee salary: ");
            sal = Convert.ToDouble(Console.ReadLine());

        }

        public void display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Employee details are:");
            Console.WriteLine("Employee Name: "+name);
            Console.WriteLine("Employee Gender: "+gender);
            Console.WriteLine("Employee Designation: "+designation);
            Console.WriteLine("Employee Location: "+location);
            Console.WriteLine("Employee Salary: "+sal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee []emp = new employee[2];

            for(int i=0; i<emp.Length;i++)
            {
                employee emp1 = new employee();
                emp1.getemployeeinfo();
                emp[i] = emp1;
            }
            for(int i=0; i<emp.Length;i++)
            {
                emp[i].display();

            }

        }
    }
}
