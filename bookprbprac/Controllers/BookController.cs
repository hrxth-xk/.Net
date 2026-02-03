using Microsoft.AspNetCore.Mvc;
using bookprbprac.Models;
using bookprbprac.Exceptions;

namespace bookprbprac.Controllers
{
    public class BookController: Controller
    {
        AppDbContext db;
        public BookController(AppDbContext db1)
        {
            db=db1;
        }

        public async Task<ActionResult> AvailableBooks()
        {
            var res=db.Books.ToList();

            return View(res);
        }
        [HttpGet]
        public async Task<ActionResult> AddBook()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddBook(Book obj)
        {
            if (obj.AvailableCopies > 10)
            {
                throw new BookAvailabilityException("Available copies cannot exceed 10");
            }
            db.Books.Add(obj);
            db.SaveChanges();
            return RedirectToAction("AvailableBooks");
        }

        public async Task<ActionResult>DeleteBook(int id)
        {
            var res=db.Books.Find(id);
            db.Books.Remove(res);
            db.SaveChanges();
            return RedirectToAction("AvailableBooks");
        }
    }
}