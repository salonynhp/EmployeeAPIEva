using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    //3.Create a Models: (DTOs) EmployeeMaster.cs
    public class EmployeeMaster
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
