using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Manager : EmployeeComponent
    {
        private string name;
        private string position;
        List<EmployeeComponent> _components = new List<EmployeeComponent>();

        public Manager(string name, string position)
        {
            this.name = name;
            this.position = position;
        }

        public override void Add(EmployeeComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(EmployeeComponent component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"{this.name} is a {this.position} Manager");
            Console.WriteLine("-------------");
            foreach(var empComponent in _components)
            {
                Console.Write("-");
                empComponent.Print();
            }
            Console.WriteLine();
        }
    }
}
