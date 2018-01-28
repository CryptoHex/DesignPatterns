using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager softwareManager = new Manager("John", "Software");
            Manager frontendManager = new Manager("Erik", "FrondEnd");
            Manager backendManager = new Manager("Pesho", "BackEnd");
            Firm firm = new Firm(softwareManager);

            frontendManager.Add(new Employee("George", "Bootstrap specialist"));
            frontendManager.Add(new Employee("Sasho", "The HTML guy"));

            backendManager.Add(new Employee("Tom", "Database Expert"));
            backendManager.Add(new Employee("Arya", "MVC Expert"));

            softwareManager.Add(frontendManager);
            softwareManager.Add(backendManager);

            firm.Print();

        }
    }
}
