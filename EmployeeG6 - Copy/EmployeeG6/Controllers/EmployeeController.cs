using EmployeeG6.Models.Entities;
using EmployeeG6.Models.Helper;
using EmployeeG6.Models.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeG6.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hosting;

        public EmployeeController(IUnitOfWork unitOfWork, IWebHostEnvironment hosting)
        {
            _unitOfWork = unitOfWork;
            _hosting = hosting;
        }
        //-----------------------Employee -----------------------------------------
        #region 
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.Employees.GetAllAsync());
        }
        public async Task<IActionResult> Details(int Id)
        {
            return View(await _unitOfWork.Employees.FindAsync(s => s.Id == Id, new[] { "City", "Department", "Job", "PersonalData", "EmpRoles" }, false));
        }

        public async Task<IActionResult> CreateOrEdit(int Id)
        {
            ViewBag.Departments = await _unitOfWork.Tools.GetDepartmentId_Name();
            ViewBag.Jobs = await _unitOfWork.Tools.GetJobId_Name();
            ViewBag.Cities = await _unitOfWork.Tools.GetCityId_Name();
            if (Id > 0)
                return View(await _unitOfWork.Employees.GetByIdAsync(Id));

            return View(new Employee() {HireDate=DateTime.Now });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit(Employee model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    await _unitOfWork.Employees.Update(model);
                    TempData["success"] = "Job Edit successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var entity = await _unitOfWork.Employees.AddAsync(model);
                    if (entity.Id > 0)
                    {
                        TempData["success"] = "Job created successfully";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            ViewBag.Departments = await _unitOfWork.Tools.GetDepartmentId_Name();
            ViewBag.Jobs = await _unitOfWork.Tools.GetJobId_Name();
            ViewBag.Cities = await _unitOfWork.Tools.GetCityId_Name();
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await _unitOfWork.Employees.Delete(id))
            {
                return Json(new { success = true, message = "Empo Delete successfully" });
            }
            return Json(new { success = false, message = "Can not Delete Job" });
        }

        #endregion


        //-----------------------PersonalData -----------------------------------------
        #region        
        
        public async Task<IActionResult> CreateOrEditPersonalData(int Id,int EmployeeId)
        {
            if (Id > 0)
                return View(await _unitOfWork.PersonalDatas.GetByIdAsync(Id));

            return View(new PersonalData() { EmployeeId = EmployeeId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEditPersonalData(PersonalData model)
        {
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files.FirstOrDefault();
                string pathUpload = Path.Combine(_hosting.WebRootPath, "uploads");
                model.ImgUrl= UploadFileHelper.UploadFile(file, pathUpload, model.ImgUrl);
            }
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    await _unitOfWork.PersonalDatas.Update(model);
                    TempData["success"] = "PersonalData Edit successfully";
                    return RedirectToAction(nameof(Details),new {Id=model.EmployeeId});
                }
                else
                {
                    var entity = await _unitOfWork.PersonalDatas.AddAsync(model);
                    if (entity.Id > 0)
                    {
                        TempData["success"] = "PersonalData Edit successfully";
                        return RedirectToAction(nameof(Details), new { Id = model.EmployeeId });
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> DeletePersonalData(int id)
        {
            if (await _unitOfWork.PersonalDatas.Delete(id))
            {
                return Json(new { success = true, message = "PersonalData Delete successfully" });
            }
            return Json(new { success = false, message = "Can not Delete PersonalData" });
        }

        #endregion
    }
}
