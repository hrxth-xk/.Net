using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using prj2.Models;
public class StudentController : Controller
{
    AppDbContext db;
    public StudentController(AppDbContext db1)
    {
        db=db1;
    }

    public IActionResult ShowStudent()
    {
        var res=db.students.ToList();
        return View(res);
    }

    [HttpGet]
    public IActionResult AddStudent()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddStudent(Student obj)
    {
        db.students.Add(obj);
        db.SaveChanges();
        return RedirectToAction("ShowStudent");
    }

    public IActionResult DeleteStudent(int id)
    {
        var res=db.students.Find(id);
        db.students.Remove(res);
        db.SaveChanges();
        return RedirectToAction("ShowStudent");
    }
}
