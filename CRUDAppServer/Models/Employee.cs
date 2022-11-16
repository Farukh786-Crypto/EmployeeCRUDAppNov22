using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppServer.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int empId { get; set; }

        public string empName { get; set; }

        public string empEmail { get; set; }

        public string empPassword { get; set; }
    }
}
