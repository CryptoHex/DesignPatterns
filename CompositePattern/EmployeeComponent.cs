using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public abstract class EmployeeComponent
    {

        public virtual void Add(EmployeeComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(EmployeeComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }

    }
}
