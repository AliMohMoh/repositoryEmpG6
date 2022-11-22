using EmployeeG6.Models.Entities;
using EmployeeG6.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Services.Interfaces
{
    public interface IToolService : IRepository<City>
    {
        Task<ICollection<NameId>> GetCityId_Name();
        Task<ICollection<NameId>> GetJobId_Name();
        Task<ICollection<NameId>> GetDepartmentId_Name();
        Task<ICollection<NameId>> GetRoleId_Name();
    }
}
