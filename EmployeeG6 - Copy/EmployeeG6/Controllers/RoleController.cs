using EmployeeG6.Models.Data;
using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Controllers
{
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.Roles.GetAllAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int Id)
        {
            if(Id>0)
            return View(await _unitOfWork.Roles.GetByIdAsync(Id));

            return View(new Role());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit(Role model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                   await _unitOfWork.Roles.Update(model);
                    TempData["success"] = "Role Edit successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var entity= await _unitOfWork.Roles.AddAsync(model);
                    if (entity.Id > 0) {
                        TempData["success"] = "Role created successfully";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }            
           return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if(await _unitOfWork.Roles.Delete(id))
            {
                return Json(new { success = true, message = "Role Delete successfully" });
            }
            return Json(new { success = false, message = "Can not Delete Role" });
        }
    }
}
