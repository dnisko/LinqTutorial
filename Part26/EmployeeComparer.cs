using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part26
{
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.ID == y.ID && x.Name == y.Name;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
        }
    }
}
