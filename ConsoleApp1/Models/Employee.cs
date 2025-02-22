using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public int?  Age { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; } = DateTime.UtcNow;
        public virtual Department Workfor { get; set; }
        public int DeptId { get; set; }
    }
}
