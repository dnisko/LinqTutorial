using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part26
{
    public class Employee
    {
        public int ID { get; set;}
        public string Name { get; set;}

        public override bool Equals(object obj)
        {
            return this.ID == ((Employee)obj).ID &&
                   this.Name == ((Employee)obj).Name;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Name.GetHashCode();
        }
    }
}
