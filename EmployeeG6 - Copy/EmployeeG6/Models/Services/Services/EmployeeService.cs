using EmployeeG6.Models.Data;
using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Services.Interfaces;
using EmployeeG6.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Models.Services.Services
{
    public class EmployeeService : Repository<Employee>, IEmployeeService
    {
        private readonly AppDbContext _dbContext;

        public EmployeeService(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<NameId>> GetId_NameAsync()
        {
            return await _context.Employees.Select(s => new NameId() { Id = s.Id, Name = s.Name }).ToListAsync();
        }
    }
}
