using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Entities
{
    
    public class Employee
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [MaxLength(200)]
        [Display(Name = "Name"), Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "HireDate")]
        public DateTime HireDate { get; set; } 
        [Display(Name = "Salary")]
        public double Salary { get; set; }
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        [Display(Name ="Department")]
        public int DepartmentId { get; set; }
        [Display(Name = "Job")]
        public int JobId { get; set; }
        [Display(Name = "City")]
        public int CityId { get; set; }

        public City City { get; set; }
        public Department Department { get; set; }
        public Job Job { get; set; }

        public PersonalData PersonalData { get; set; }
        public ICollection<EmpRole> EmpRoles { get; set; }

    }
}
