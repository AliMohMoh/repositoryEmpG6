using EmployeeG6.Models.Data;
using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Services.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IRepository<City> Cities { get; private set; }
        public IRepository<Department> Departments { get; private set; }
        public IRepository<Job> Jobs { get; private set; }
        public IRepository<Role> Roles { get; private set; }
        public IRepository<EmpRole> EmpRoles { get; private set; }
        public IRepository<PersonalData> PersonalDatas { get; private set; }
        public IEmployeeService Employees { get; private set; }
        public IToolService Tools { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            Cities = new Repository<City>(_context);
            Departments = new Repository<Department>(_context);
            Jobs = new Repository<Job>(_context);
            Roles = new Repository<Role>(_context);
            EmpRoles = new Repository<EmpRole>(_context);
            Employees = new EmployeeService(_context);
            PersonalDatas = new Repository<PersonalData>(_context);
            Tools = new ToolService(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
