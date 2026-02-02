using Microsoft.AspNetCore.Mvc;
using weeklyprj.Models;

namespace weeklyprj.Controllers
{
    public class EmployeeController : Controller
    {
        AppDbContext db;
        public EmployeeController(AppDbContext db1)
        {
            db=db1;
        }

        public IActionResult ShowEmployee()
        {
            var res=db.Employees.ToList();
            return View(res);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee obj)
        {
            db.Employees.Add(obj);
            db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }

        public IActionResult DeleteEmp(int id)
        {
            var res=db.Employees.Find(id);

            db.Employees.Remove(res);
            db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }
    }
}