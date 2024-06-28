using Microsoft.EntityFrameworkCore;
using testapi.Models;

namespace testapi.Data
{
public interface iGamesDbContext
{
          DbSet<Game> Games { get; set; }
            int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
  
}

}
