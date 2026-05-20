using pinterest_board_aspdotnet.Models;

namespace pinterest_board_aspdotnet.Services
{
    public class BoardService : IBoardService
    {
        private readonly AppDbContext _context;
        public BoardService(AppDbContext context)
        {
            _context = context;
        }
        public List<Board> GetAllBoards()
        {
            return _context.Boards.ToList(); 
        }
        public void AddBoard(Board board)
        {
            _context.Boards.Add(board);
            _context.SaveChanges();
        }
        public void RemoveBoard(int id)
        {
            var item = _context.Boards.FirstOrDefault(b => b.Id == id);
            if (item != null)
            {
                _context.Boards.Remove(item);
                _context.SaveChanges();
            }
        }
        public void RenameBoard(int id, string name, string description)
        {
            var item = _context.Boards.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.Name = name;
                item.Description = description;
                _context.SaveChanges();
            }
        }
    }
}
