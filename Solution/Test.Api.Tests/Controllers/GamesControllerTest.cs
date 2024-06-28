using testapi.Data;
using testapi.Models;
using testapi.Controllers;
using Moq;
using Moq.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace GamesControllers.Tests
{
    public class GamesControllerTests
    {
        private readonly GamesController _controller;
public GamesControllerTests()
{
    var fakedata = new List<Game>
    {
        new  Game
        {
               id = -1,
               teamOneName="test city 1",
               teamTwoName="test city 2",
               winner =0  
            },
            new Game
             {
               id = -2,
               teamOneName="test city 3",
               teamTwoName="test city 4",
               winner =0  
            },
            new Game
             {
               id = -3,
               teamOneName="test city 5",
               teamTwoName="test city 6",
               winner =0  
            }
    }.AsQueryable();
    var _context =new Mock<iGamesDbContext>();
    _context.Setup(db => db.Games).ReturnsDbSet(fakedata);

    _controller = new GamesController(_context.Object);
}
[Fact]

public void get_returns_dummy_data()
{
    var expected = new List<Game>
    {
        new  Game
        {
               id = -1,
               teamOneName="test city 1",
               teamTwoName="test city 2",
               winner =0  
            },
            new Game
             {
               id = -2,
               teamOneName="test city 3",
               teamTwoName="test city 4",
               winner =0  
            },
            new Game
             {
               id = -3,
               teamOneName="test city 5",
               teamTwoName="test city 6",
               winner =0  
            }
    }.AsQueryable();

    var result = _controller.GetGames();

    Assert.Equivalent(expected, result);

}

    }
}
