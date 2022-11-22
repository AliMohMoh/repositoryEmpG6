using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Entities
{   
    public class PersonalData 
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Display(Name = "ImgUrl")]
        public string ImgUrl { get; set; }
        [Display(Name = "EmployeeId")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
