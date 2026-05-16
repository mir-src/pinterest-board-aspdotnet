using Microsoft.AspNetCore.Mvc;
using pinterest_board_aspdotnet.Services;

namespace pinterest_board_aspdotnet.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardService _boardService;
        public BoardsController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        public IActionResult Index()
        {
            var posts = _boardService.GetAllBoards();
            return View(posts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
