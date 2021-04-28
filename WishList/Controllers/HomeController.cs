using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Index();
        }

        public IActionResult Error()
        {
            return Error();
        }
    }
}
