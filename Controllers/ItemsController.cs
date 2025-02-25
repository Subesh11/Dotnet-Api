using Microsoft.AspNetCore.Mvc;
using MyApps.Models;

namespace MyApps.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var Item = new Item() { Name = "KeyBoard" };
            return View(Item);
        }
        public IActionResult Test(int id)
        {
            return Content("id=" + id);

        }
    }
}
