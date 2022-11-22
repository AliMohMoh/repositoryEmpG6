using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeG6.Models.Data;
using EmployeeG6.Models.Entities;

namespace EmployeeG6.Controllers
{
    public class EmpRolesController : Controller
    {
        private readonly AppDbContext _context;

        public EmpRolesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EmpRoles
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.EmpRoles.Include(e => e.Employee).Include(e => e.Role);
            return View(await appDbContext.ToListAsync());
        }

        // GET: EmpRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empRole = await _context.EmpRoles
                .Include(e => e.Employee)
                .Include(e => e.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empRole == null)
            {
                return NotFound();
            }

            return View(empRole);
        }

        // GET: EmpRoles/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name");
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name");
            return View();
        }

        // POST: EmpRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeId,RoleId")] EmpRole empRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", empRole.EmployeeId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name", empRole.RoleId);
            return View(empRole);
        }

        // GET: EmpRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empRole = await _context.EmpRoles.FindAsync(id);
            if (empRole == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", empRole.EmployeeId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name", empRole.RoleId);
            return View(empRole);
        }

        // POST: EmpRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeId,RoleId")] EmpRole empRole)
        {
            if (id != empRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpRoleExists(empRole.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", empRole.EmployeeId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name", empRole.RoleId);
            return View(empRole);
        }

        // GET: EmpRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empRole = await _context.EmpRoles
                .Include(e => e.Employee)
                .Include(e => e.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empRole == null)
            {
                return NotFound();
            }

            return View(empRole);
        }

        // POST: EmpRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empRole = await _context.EmpRoles.FindAsync(id);
            _context.EmpRoles.Remove(empRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpRoleExists(int id)
        {
            return _context.EmpRoles.Any(e => e.Id == id);
        }
    }
}
