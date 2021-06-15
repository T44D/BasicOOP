using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Manager : Employees
    {
        public int Allowance { get; set; }

        public Manager() {}

        public Manager(string nik, string firstName, string lastName, string email, int salary, int allowance)
        {
            Nik = nik;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Salary = salary;
            Allowance = allowance;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Allowance {Allowance}");
        }
    }
}
