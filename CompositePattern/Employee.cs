using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Employee : EmployeeComponent
    {
        private string name;
        private string position;

        public Employee(string name, string position)
        {
            this.name = name;
            this.position = position;
        }

        public override void Print()
        {
            Console.WriteLine($"{this.name} is a {this.position}");
        }
    }
}
