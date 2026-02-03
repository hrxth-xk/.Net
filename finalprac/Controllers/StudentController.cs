using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalprac.Models;
namespace finalprac.Controllers;

public class StudentController : Controller
{
    AppDbContext db;
    public StudentController(AppDbContext db1)
    {
        db=db1;
    }

    public async Task<IActionResult> ShowStudents()
    {
        var res=db.Students.ToList();
        return View(res);
    }

    [HttpGet]
    public async Task<IActionResult> AddStudents()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddStudents(Student obj)
    {
        db.Students.Add(obj);
        db.SaveChanges();
        return RedirectToAction("ShowStudents");
    }

    public async Task<IActionResult>DeleteStudents(int id)
    {
        var res=db.Students.Find(id);

        db.Students.Remove(res);
        db.SaveChanges();
        return RedirectToAction("ShowStudents");
    }
}


