using Microsoft.AspNetCore.Mvc;
using studentbackedpractice.Models;

public class CourseRegistrationController: Controller
{
    AppDbContext db;

    public CourseRegistrationController(AppDbContext db1)
    {
        db=db1;
    }

    public async Task<IActionResult> ShowCourses()
    {
        var res=db.Registrations.ToList();
        return View(res);
    }

    [HttpGet]
    public async Task<IActionResult> AddCourse()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> AddCourse(CourseRegistration obj)
    {
        db.Registrations.Add(obj);
        db.SaveChanges();
        return RedirectToAction("ShowCourses");
    }

    public async Task<IActionResult>Delete(int id)
    {
        var res=db.Registrations.Find(id);

        db.Registrations.Remove(res);
        db.SaveChanges();
        return RedirectToAction("ShowCourses");
    }


}