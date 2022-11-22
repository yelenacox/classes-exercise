using System;

namespace Classes

{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string title;
        public DateTime startDate;

        public Employee(string _firstName, string _lastName, string _title, DateTime _dateTime)
        {
            firstName = _firstName;
            lastName = _lastName;
            title = _title;
            startDate = _dateTime;
        }

    }

}