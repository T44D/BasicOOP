using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee1 = new Employees("10001", "Taufan", "Aprialdo", "taufanaprialdo@gmail.com", 10000000);
            Employees employee2 = new Employees("10002", "Morgan", "James", "morganjames@gmail.com", 70000000);
            Manager manager1 = new Manager("10003", "Cindy", "Elisa", "cindyelisa@gmail.com", 12000000, 5000000);

            employee1.ShowData();
            Console.WriteLine();
            employee2.ShowData();
            Console.WriteLine();
            manager1.ShowData();
        }
    }
}
