using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string _name, DateTime _date)
        {
            name = _name;
            CreatedOn = _date;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach (var i in Employees)
            {
                Console.WriteLine($"{i.firstName} {i.lastName} works for {name} as {i.title} since {i.startDate}.");
            }
        }
    }
}