using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Employees
    {
        public string Nik { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public Employees() {}

        public Employees(string nik, string firstName, string lastName, string email, int salary)
        {
            Nik = nik;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Salary = salary;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void RaiseSalary(float multiplier)
        {
            Salary = Convert.ToInt32(Salary + (Salary * multiplier));
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"NIK: {Nik}");
            Console.WriteLine($"Full Name: {GetFullName()}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
