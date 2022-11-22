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
    public class JobController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public JobController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.Jobs.GetAllAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int Id)
        {
            if(Id>0)
            return View(await _unitOfWork.Jobs.GetByIdAsync(Id));

            return View(new Job());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit(Job model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                   await _unitOfWork.Jobs.Update(model);
                    TempData["success"] = "Job Edit successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var entity= await _unitOfWork.Jobs.AddAsync(model);
                    if (entity.Id > 0) {
                        TempData["success"] = "Job created successfully";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }            
           return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if(await _unitOfWork.Jobs.Delete(id))
            {
                return Json(new { success = true, message = "Job Delete successfully" });
            }
            return Json(new { success = false, message = "Can not Delete Job" });
        }
    }
}
