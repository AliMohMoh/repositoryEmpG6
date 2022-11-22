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
    public class CityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.Cities.GetAllAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int Id)
        {
            if(Id>0)
            return View(await _unitOfWork.Cities.GetByIdAsync(Id));

            return View(new City());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit(City model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                   await _unitOfWork.Cities.Update(model);
                    TempData["success"] = "City Edit successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var entity= await _unitOfWork.Cities.AddAsync(model);
                    if (entity.Id > 0) {
                        TempData["success"] = "City created successfully";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }            
           return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if(await _unitOfWork.Cities.Delete(id))
            {
                return Json(new { success = true, message = "City Delete successfully" });
            }
            return Json(new { success = false, message = "Can not Delete City" });
        }
    }
}
