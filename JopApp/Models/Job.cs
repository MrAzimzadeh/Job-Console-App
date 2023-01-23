using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopApp.Models
{
    public class Job : Base
    {
        public string Name { get; set; }
        public DateTime DeadLine { get; set; }
        public decimal Salary { get; set; }
        public string Phone { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
