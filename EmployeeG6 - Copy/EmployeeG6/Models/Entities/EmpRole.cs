using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Entities
{
    public class EmpRole 
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        [Display(Name = "Role")]
        public int RoleId { get; set; }

        public Employee Employee { get; set; }
        public Role Role { get; set; }
    }
}
