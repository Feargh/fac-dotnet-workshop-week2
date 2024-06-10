using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testapi.Data;
using testapi.Models;

namespace testapi.Controllers;

[ApiController]
[Route("[controller]")]

public class GamesController : ControllerBase
{


    
    private readonly ILogger<GamesController> _logger;
    private readonly GamesDbContext _context;

    public GamesController(GamesDbContext context, ILogger<GamesController> logger)
    {
         _context = context;
        _logger = logger;
        if (!_context.Games.Any())
            {
                _context.Games.AddRange(new List<Game>
                {
                    new Game{
               id = 1,
               teamOneName="London",
               teamTwoName="Cardif",
               winner =1  
            },
             new Game{
               id = 2,
               teamOneName="Leeds",
               teamTwoName="London",
               winner =2  
            },
             new Game{
               id = 3,
               teamOneName="London",
               teamTwoName="Manchester",
               winner =1  
            },
                });
                _context.SaveChanges();
            }
    }

    [HttpGet(Name = "GetGames")]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
    {
            return await _context.Games.ToListAsync();
    }
    
         [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        //         [HttpPost]
        // public IEnumerable<Game>  AddEmployee([FromBody] Game game)
        // {
        //     games.Add(game);
        //     return games;
        // }
}
