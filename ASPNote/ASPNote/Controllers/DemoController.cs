using Microsoft.AspNetCore.Mvc;

namespace ASPNote.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()    //Index Action method
        {
            return View();
        }
    }
}
