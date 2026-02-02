using Microsoft.AspNetCore.Mvc;
using Myfirstapp.Models;

namespace Myfirstapp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "KeyBoard" };
            return View(item);
        }
    }
}