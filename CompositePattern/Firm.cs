using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Firm
    {
        private readonly EmployeeComponent _employees;

        public Firm(EmployeeComponent employees)
        {
            _employees = employees;
        }

        public void Print()
        {
            _employees.Print();
        }
    }
}
