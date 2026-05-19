using Microsoft.EntityFrameworkCore;
using pinterest_board_aspdotnet.Models;

public class AppDbContext : DbContext
{
    public DbSet<Board> Boards {get; set;}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}