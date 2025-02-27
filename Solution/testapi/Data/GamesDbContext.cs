using Microsoft.EntityFrameworkCore;
using testapi.Models;

namespace testapi.Data
{
    public class GamesDbContext : DbContext, iGamesDbContext
    {
        public GamesDbContext(DbContextOptions<GamesDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
