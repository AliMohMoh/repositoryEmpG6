using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Entities
{
    public class Role 
    {
        [Display(Name = "Id"), Required(ErrorMessage = "Required")]
        public int Id { get; set; }
        [MaxLength(100)]
        [Display(Name = "Name"), Required(ErrorMessage = "Required")]
        public string Name { get; set; }


        public ICollection<EmpRole> EmpRoles { get; set; }
    }
}
