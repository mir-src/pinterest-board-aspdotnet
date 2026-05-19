using pinterest_board_aspdotnet.Models;

namespace pinterest_board_aspdotnet.Services
{
    public interface IBoardService
    {
        List<Board> GetAllBoards();
        void AddBoard(Board board); 
        void RemoveBoard(int id);
        void RenameBoard(int id, string name, string description);
    }
}
