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
        public void RemoveBoard(int id)
        {
            _boards.RemoveAll(b => b.Id == id);
        }
        public void RenameBoard(int id, string name)
        {
            var item = _boards.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.Name = name;
            }
        }
    }
}
