using pinterest_board_aspdotnet.Models;

namespace pinterest_board_aspdotnet.Services
{
    public class BoardService : IBoardService
    {
        private static List<Board> _boards = new List<Board>(); 

        public List<Board> GetAllBoards()
        {
            return _boards;
        }
        public void AddBoard(Board board)
        {
            _boards.Add(board);
        }
    }
}
