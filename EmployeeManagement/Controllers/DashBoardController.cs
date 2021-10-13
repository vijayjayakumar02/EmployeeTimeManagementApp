using BussinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly EntryBL entryBL;

        public DashBoardController(EntryBL entryBL)
        {
            this.entryBL = entryBL;
        }
        
        
        public IActionResult Index(string id)
        {
            if (id != null)
            {
                var entries = entryBL.GetEntry(id);
                return View(entries);
            }
            return View();
        }

        [Authorize(Roles ="Admin")]
        public IActionResult AdminDashboard()
        {
            DateTime date = new DateTime(2021, 10, 13);

            var employeeEntry = entryBL.GetEmployeeEntry(date);

            ViewBag.Count = entryBL.EmployeesCount();

            return View(employeeEntry);
        }
    }
}
