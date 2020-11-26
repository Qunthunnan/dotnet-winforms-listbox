using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLists.Models
{
    class Employee
    {
        private static long lastId = 0;
        public long Id { get; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {
            this.Id = ++lastId;
        }
        public override string ToString()
        {
            return $"Employee: Id={Id}, Name={Name}, Salary={Salary}";
        }
    }
}
