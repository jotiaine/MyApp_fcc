using Microsoft.AspNetCore.Mvc;
using MyApp_fcc.Models;

namespace MyApp_fcc.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name= "keyboard"};
            return View(item);
        }
    }
}
