using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Lesson27
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? TerminationDate {  get; set; }
        
        public double Salary { get; set; }
        public string Comments { get; set; }

    }
}
