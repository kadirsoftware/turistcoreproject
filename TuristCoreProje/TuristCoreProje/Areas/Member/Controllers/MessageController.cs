using Microsoft.AspNetCore.Mvc;

namespace TuristCoreProje.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
