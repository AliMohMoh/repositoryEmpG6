using EmployeeG6.Models.Entities;
using EmployeeG6.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Services.Interfaces
{
    public interface IEmployeeService : IRepository<Employee>
    {
        Task<ICollection<NameId>> GetId_NameAsync();
    }
}
