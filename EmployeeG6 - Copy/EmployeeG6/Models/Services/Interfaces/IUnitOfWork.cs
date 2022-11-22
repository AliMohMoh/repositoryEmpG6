using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Services.Interfaces
{
     public interface IUnitOfWork : IDisposable
    {
        IRepository<City> Cities { get; }
        IRepository<Department> Departments { get; }
        IRepository<Job> Jobs { get; }
        IRepository<Role> Roles { get; }
        IRepository<EmpRole> EmpRoles { get; }
        IRepository<PersonalData> PersonalDatas { get; }
        IEmployeeService Employees { get; }
        IToolService Tools { get; }

        int Complete();
    }
}
