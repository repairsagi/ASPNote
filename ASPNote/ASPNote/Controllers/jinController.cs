using Microsoft.AspNetCore.Mvc;

namespace ASPNote
{
    public class jinController : Controller
    {
        public IActionResult Index()
        {
            return Content("jin page");
        }
    }
}
