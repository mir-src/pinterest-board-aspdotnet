using Microsoft.AspNetCore.Mvc;
using pinterest_board_aspdotnet.Services;

namespace pinterest_board_aspdotnet.Controllers
{
    public class BoardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
