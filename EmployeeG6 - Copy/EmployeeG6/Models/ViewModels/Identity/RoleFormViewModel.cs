using System.ComponentModel.DataAnnotations;

namespace EmployeeG6.Models.ViewModels.Identity
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}