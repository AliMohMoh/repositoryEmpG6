using EmployeeG6.Models.Data;
using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Services.Interfaces;
using EmployeeG6.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Services.Services
{
    public class ToolService : Repository<City>, IToolService
    {
        private readonly AppDbContext _dbContext;

        public ToolService(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<NameId>> GetCityId_Name()
        {
            return await _context.Cities.Select(s => new NameId() {Id= s.Id,Name=s.Name}).ToListAsync();
        }
        public async Task<ICollection<NameId>> GetJobId_Name()
        {
            return await _context.Jobs.Select(s => new NameId() {Id= s.Id,Name=s.Name}).ToListAsync();
        }
        public async Task<ICollection<NameId>> GetDepartmentId_Name()
        {
            return await _context.Departments.Select(s => new NameId() {Id= s.Id,Name=s.Name}).ToListAsync();
        }
        public async Task<ICollection<NameId>> GetRoleId_Name()
        {
            return await _context.AppRoles.Select(s => new NameId() {Id= s.Id,Name=s.Name}).ToListAsync();
        }
    }
}
