using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Poop", DateTime.Parse("9/30/2022"));

            // Create three employees
            Employee emp1 = new Employee("Taco", "Tuesday", "Bitch", DateTime.Parse("10-31-2022"));
            Employee emp2 = new Employee("Artie", "Moose", "Accountant", DateTime.Parse("11/1/2022"));
            Employee emp3 = new Employee("Shadow", "Demon", "Exterminator", DateTime.Parse("10/1/2022"));

            // Assign the employees to the company
            myCompany.Employees.Add(emp1);
            myCompany.Employees.Add(emp2);
            myCompany.Employees.Add(emp3);

            /*
Iterate the company's employee list and generate the
simple report shown above
*/
            myCompany.ListEmployees();
        }
    }
}