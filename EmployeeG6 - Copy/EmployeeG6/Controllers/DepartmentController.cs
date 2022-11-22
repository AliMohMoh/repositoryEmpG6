using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.Departments.GetAllAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int Id)
        {
            if(Id>0)
            return View(await _unitOfWork.Departments.GetByIdAsync(Id));

            return View(new Department());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit(Department model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                   await _unitOfWork.Departments.Update(model);
                    TempData["success"] = "Department Edit successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var entity= await _unitOfWork.Departments.AddAsync(model);
                    if (entity.Id > 0) {
                        TempData["success"] = "Department created successfully";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }            
           return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if(await _unitOfWork.Departments.Delete(id))
            {
                return Json(new { success = true, message = "Department Delete successfully" });
            }
            return Json(new { success = false, message = "Can not Delete Department" });
        }
    }
}
